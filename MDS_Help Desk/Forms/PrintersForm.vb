Imports Microsoft.Data.SqlClient

''' <summary>
''' Printer inventory (frmMDS_IT_Printers in Access), kept in dbo.MDS_IT_Printers.
''' </summary>
Public Class PrintersForm

    Private Const Caption As String = "Printers"

    ''' <summary>Locations offered in Access, plus any others already in the table.</summary>
    Private Shared ReadOnly StandardLocations As String() = {
        "Douglas A", "Douglas B", "Douglas C", "Douglas D", "Douglas E", "Douglas F",
        "Green Tree Main", "Green Tree East", "Phoenix 1", "Office", "Mill", "IT"}

    Private _loading As Boolean
    Private _dirty As Boolean
    Private _isNew As Boolean
    Private _current As String

    Private Sub PrintersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loading = True
        Try
            Dim types = ItAdmin.PrinterTypes()
            Dim locations = ItAdmin.PrinterLocations()
            Bind(cboFilterType, WithAnyRow(types.Copy()))
            Bind(cboFilterLocation, WithAnyRow(locations.Copy()))
            cboFilterType.SelectedIndex = 0
            cboFilterLocation.SelectedIndex = 0
            FillItems(cboType, {"Laser", "Label", "Copier"}, types)
            FillItems(cboLocation, StandardLocations, locations)
        Catch ex As SqlException
            MessageBox.Show("Could not load the printer lists from SQL Server." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            BeginInvoke(Sub() Close())
            Return
        Finally
            _loading = False
        End Try
        EditorChanges.Track(grpPrinter, Sub() If Not _loading AndAlso _current IsNot Nothing Then _dirty = True)
        RefreshList()
    End Sub

    Private Shared Sub FillItems(cbo As ComboBox, fixedItems As IEnumerable(Of String), lookup As DataTable)
        Dim items As New List(Of String)(fixedItems)
        For Each r As DataRow In lookup.Rows
            Dim v = r("Display").ToString().Trim()
            If v.Length > 0 AndAlso Not items.Contains(v, StringComparer.OrdinalIgnoreCase) Then items.Add(v)
        Next
        cbo.Items.Clear()
        cbo.Items.AddRange(items.ToArray())
    End Sub

#Region "List"

    Private Sub RefreshList()
        Try
            Cursor = Cursors.WaitCursor
            dgvPrinters.DataSource = ItAdmin.Printers(SelectedText(cboFilterType), SelectedText(cboFilterLocation))
            dgvPrinters.Columns("Notes").HeaderText = "Has Notes"
            lblCount.Text = $"{dgvPrinters.Rows.Count} printer(s)"
        Catch ex As SqlException
            MessageBox.Show("Could not load the printers." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
        If Not String.IsNullOrEmpty(_current) Then EditorChanges.SelectRow(dgvPrinters, "Printer", _current)
    End Sub

    Private Sub Filter_Changed(sender As Object, e As EventArgs) Handles cboFilterType.SelectionChangeCommitted, cboFilterLocation.SelectionChangeCommitted
        RefreshList()
    End Sub

    Private Sub cmdClearFilter_Click(sender As Object, e As EventArgs) Handles cmdClearFilter.Click
        cboFilterType.SelectedIndex = 0
        cboFilterLocation.SelectedIndex = 0
        RefreshList()
    End Sub

    Private Sub dgvPrinters_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrinters.CellDoubleClick
        If e.RowIndex >= 0 Then OpenPrinter(dgvPrinters.Rows(e.RowIndex).Cells("Printer").Value.ToString())
    End Sub

    Private Sub dgvPrinters_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPrinters.KeyDown
        If e.KeyCode = Keys.Enter AndAlso dgvPrinters.CurrentRow IsNot Nothing Then
            e.Handled = True
            OpenPrinter(dgvPrinters.CurrentRow.Cells("Printer").Value.ToString())
        End If
    End Sub

#End Region

#Region "Editor"

    Private Sub OpenPrinter(printerId As String)
        If Not ConfirmDiscard() Then Return
        Dim p As PrinterRecord
        Try
            p = ItAdmin.LoadPrinter(printerId)
        Catch ex As SqlException
            MessageBox.Show("Could not load the printer." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        If p Is Nothing Then Return
        Fill(p, isNew:=False)
    End Sub

    Private Sub Fill(p As PrinterRecord, isNew As Boolean)
        _loading = True
        _isNew = isNew
        _current = If(p.PrinterID, "")
        txtPrinter.Text = p.PrinterID
        txtPrinter.ReadOnly = Not isNew
        txtModel.Text = p.ModelNo
        txtMaker.Text = p.Manufacturer
        EditorChanges.SetText(cboType, p.Type)
        txtIP.Text = p.IpAddress
        txtConnected.Text = p.ConnectedTo
        EditorChanges.SetText(cboLocation, p.Location)
        txtNotes.Text = p.Notes
        grpPrinter.Text = If(isNew, "New printer", $"Printer {p.PrinterID}")
        grpPrinter.Enabled = True
        cmdSave.Enabled = True
        cmdDelete.Enabled = Not isNew
        _loading = False
        _dirty = False
    End Sub

    Private Sub ClearEditor()
        _loading = True
        _current = Nothing
        _isNew = False
        For Each ctl As Control In grpPrinter.Controls
            If TypeOf ctl Is TextBox OrElse TypeOf ctl Is ComboBox Then ctl.Text = ""
        Next
        grpPrinter.Text = "Printer"
        grpPrinter.Enabled = False
        cmdSave.Enabled = False
        cmdDelete.Enabled = False
        _loading = False
        _dirty = False
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        If Not ConfirmDiscard() Then Return
        Fill(New PrinterRecord(), isNew:=True)
        txtPrinter.Focus()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim p As New PrinterRecord With {
            .PrinterID = NullIfBlank(txtPrinter.Text)?.ToUpperInvariant(),
            .ModelNo = NullIfBlank(txtModel.Text),
            .Manufacturer = NullIfBlank(txtMaker.Text),
            .Type = NullIfBlank(cboType.Text),
            .IpAddress = NullIfBlank(txtIP.Text),
            .ConnectedTo = NullIfBlank(txtConnected.Text),
            .Location = NullIfBlank(cboLocation.Text),
            .Notes = NullIfBlank(txtNotes.Text)
        }
        If p.PrinterID Is Nothing Then
            MessageBox.Show("Enter the printer ID.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPrinter.Focus()
            Return
        End If

        Try
            Cursor = Cursors.WaitCursor
            If _isNew AndAlso ItAdmin.LoadPrinter(p.PrinterID) IsNot Nothing Then
                MessageBox.Show($"Printer {p.PrinterID} already exists. Open it from the list to change it.",
                                Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            ItAdmin.SavePrinter(p, _isNew)
        Catch ex As SqlException
            MessageBox.Show("The printer was not saved." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            Cursor = Cursors.Default
        End Try

        Fill(p, isNew:=False)
        RefreshList()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If String.IsNullOrEmpty(_current) OrElse _isNew Then Return
        If MessageBox.Show($"Delete printer {_current}? This cannot be undone.", Caption,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then Return
        Try
            ItAdmin.DeletePrinter(_current)
        Catch ex As SqlException
            MessageBox.Show("The printer was not deleted." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        ClearEditor()
        RefreshList()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim data = TryCast(dgvPrinters.DataSource, DataTable)
        If data Is Nothing Then Return
        Dim filters As New List(Of String)
        If SelectedText(cboFilterType) IsNot Nothing Then filters.Add("Type " & cboFilterType.Text)
        If SelectedText(cboFilterLocation) IsNot Nothing Then filters.Add("Location " & cboFilterLocation.Text)
        ReportPreview.Show(Me, InventoryReports.Printers(data, If(filters.Count = 0, "All printers", String.Join(" · ", filters))))
    End Sub

#End Region

#Region "Close"

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub PrintersForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmDiscard() Then e.Cancel = True
    End Sub

    Private Function ConfirmDiscard() As Boolean
        If Not _dirty Then Return True
        If MessageBox.Show("The printer has changes that were not saved. Discard them?", Caption,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            _dirty = False
            Return True
        End If
        Return False
    End Function

#End Region

End Class
