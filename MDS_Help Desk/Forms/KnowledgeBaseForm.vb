Imports Microsoft.Data.SqlClient

''' <summary>
''' Search, view, add and edit knowledge base entries
''' (frm-SearchKnowledgeBase and frm-AddToKnowledgeBase in Access).
''' </summary>
Public Class KnowledgeBaseForm

    Private Const Caption As String = "Knowledge Base"

    Private _loading As Boolean
    Private _dirty As Boolean
    ''' <summary>The entry shown below the list; RecordNo is Nothing for a new one.</summary>
    Private _current As KnowledgeEntry

    Private Sub KnowledgeBaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not LoadProcesses() Then
            BeginInvoke(Sub() Close())
            Return
        End If
        For Each c In New Control() {cboEntryProcess, txtError, txtWorkaround}
            AddHandler c.TextChanged, AddressOf Entry_Changed
        Next
        AddHandler dtpEntered.ValueChanged, AddressOf Entry_Changed
        RunSearch()
        txtKeyword.Focus()
    End Sub

    Private Function LoadProcesses() As Boolean
        Try
            Dim processes = KnowledgeBase.Processes()
            Dim keep = SelectedText(cboSearchProcess)
            Bind(cboSearchProcess, WithAnyRow(processes.Copy()))
            If keep IsNot Nothing Then cboSearchProcess.SelectedValue = keep Else cboSearchProcess.SelectedIndex = 0
            Dim typed = cboEntryProcess.Text
            Bind(cboEntryProcess, processes)
            cboEntryProcess.Text = typed
            Return True
        Catch ex As SqlException
            MessageBox.Show("Could not load the knowledge base from SQL Server." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Entry_Changed(sender As Object, e As EventArgs)
        If Not _loading AndAlso _current IsNot Nothing Then _dirty = True
    End Sub

#Region "Search"

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        RunSearch()
    End Sub

    Private Sub cmdNewSearch_Click(sender As Object, e As EventArgs) Handles cmdNewSearch.Click
        cboSearchProcess.SelectedIndex = 0
        txtKeyword.Clear()
        RunSearch()
        txtKeyword.Focus()
    End Sub

    Private Sub RunSearch(Optional selectRecord As Integer? = Nothing)
        Try
            Cursor = Cursors.WaitCursor
            _loading = True
            dgvResults.DataSource = KnowledgeBase.Search(SelectedText(cboSearchProcess), NullIfBlank(txtKeyword.Text))
            FormatGrid()
        Catch ex As SqlException
            MessageBox.Show("The search did not run." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            _loading = False
            Cursor = Cursors.Default
        End Try

        SelectRow(selectRecord)
    End Sub

    ''' <summary>Selects the row for a record without loading it (clears the selection for Nothing).</summary>
    Private Sub SelectRow(recordNo As Integer?)
        _loading = True
        dgvResults.ClearSelection()
        If recordNo.HasValue Then
            For Each row As DataGridViewRow In dgvResults.Rows
                If CInt(row.Cells("RecordNo").Value) = recordNo.Value Then
                    dgvResults.CurrentCell = row.Cells("RecordNo")
                    row.Selected = True
                    Exit For
                End If
            Next
        End If
        _loading = False
    End Sub

    Private Sub FormatGrid()
        With dgvResults.Columns
            .Item("RecordNo").HeaderText = "Record No"
            .Item("RecordNo").Width = 80
            .Item("Process").Width = 200
            .Item("Entered").HeaderText = "Date"
            .Item("Entered").Width = 90
            .Item("Entered").DefaultCellStyle.Format = "d"
            .Item("Error").HeaderText = "Problem or Error"
            .Item("Error").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Item("Workaround").Visible = False
        End With
    End Sub

    Private Sub dgvResults_SelectionChanged(sender As Object, e As EventArgs) Handles dgvResults.SelectionChanged
        If _loading OrElse dgvResults.CurrentRow Is Nothing OrElse Not dgvResults.CurrentRow.Selected Then Return
        Dim recordNo = CInt(dgvResults.CurrentRow.Cells("RecordNo").Value)
        If _current IsNot Nothing AndAlso Nullable.Equals(_current.RecordNo, recordNo) Then Return
        If Not ConfirmDiscard() Then
            BeginInvoke(Sub() SelectRow(_current?.RecordNo))
            Return
        End If
        ShowEntry(recordNo)
    End Sub

#End Region

#Region "Entry"

    Private Sub ShowEntry(recordNo As Integer)
        Dim entry As KnowledgeEntry
        Try
            entry = KnowledgeBase.Load(recordNo)
        Catch ex As SqlException
            MessageBox.Show("Could not load the entry." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        If entry Is Nothing Then Return
        FillEntry(entry)
    End Sub

    Private Sub FillEntry(entry As KnowledgeEntry)
        _loading = True
        _current = entry
        txtRecordNo.Text = If(entry.RecordNo.HasValue, entry.RecordNo.Value.ToString(), "(new)")
        dtpEntered.Value = If(entry.Entered, Date.Today)
        cboEntryProcess.SelectedIndex = -1
        cboEntryProcess.Text = If(entry.Process, "")
        txtError.Text = entry.ErrorText
        txtWorkaround.Text = entry.Workaround
        grpEntry.Text = If(entry.RecordNo.HasValue, $"Entry {entry.RecordNo}", "New entry")
        grpEntry.Enabled = True
        cmdSave.Enabled = True
        cmdPrint.Enabled = entry.RecordNo.HasValue
        _loading = False
        _dirty = False
    End Sub

    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click
        If Not ConfirmDiscard() Then Return
        _loading = True
        dgvResults.ClearSelection()
        _loading = False
        ' Start the new entry with the process being searched, if any.
        FillEntry(New KnowledgeEntry With {.Process = SelectedText(cboSearchProcess), .Entered = Date.Today})
        cboEntryProcess.Focus()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If _current Is Nothing Then Return
        Dim entry As New KnowledgeEntry With {
            .RecordNo = _current.RecordNo,
            .Process = NullIfBlank(cboEntryProcess.Text),
            .ErrorText = NullIfBlank(txtError.Text),
            .Workaround = NullIfBlank(txtWorkaround.Text),
            .Entered = dtpEntered.Value.Date
        }
        If entry.Process Is Nothing Then
            MessageBox.Show("Enter or select the process.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboEntryProcess.Focus()
            Return
        End If
        If entry.ErrorText Is Nothing Then
            MessageBox.Show("Describe the problem or error.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtError.Focus()
            Return
        End If

        Try
            Cursor = Cursors.WaitCursor
            If entry.RecordNo.HasValue Then
                KnowledgeBase.Update(entry)
            Else
                entry.RecordNo = KnowledgeBase.Insert(entry)
            End If
        Catch ex As SqlException
            MessageBox.Show("The entry was not saved." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            Cursor = Cursors.Default
        End Try

        FillEntry(entry)
        LoadProcesses()
        RunSearch(entry.RecordNo)
        MessageBox.Show($"Entry {entry.RecordNo} was saved.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If _current Is Nothing OrElse Not _current.RecordNo.HasValue Then Return
        If _dirty AndAlso MessageBox.Show("This entry has changes that were not saved. The printout shows the saved version. Print anyway?",
                                          Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            Dim saved = KnowledgeBase.Load(_current.RecordNo.Value)
            If saved IsNot Nothing Then ReportPreview.Show(Me, HelpDeskReports.KnowledgeBaseEntry(saved))
        Catch ex As SqlException
            MessageBox.Show("Could not load the entry." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Close"

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub KnowledgeBaseForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmDiscard() Then e.Cancel = True
    End Sub

    Private Function ConfirmDiscard() As Boolean
        If Not _dirty OrElse _current Is Nothing Then Return True
        If MessageBox.Show("This entry has changes that were not saved. Discard them?", Caption,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            _dirty = False
            Return True
        End If
        Return False
    End Function

#End Region

End Class
