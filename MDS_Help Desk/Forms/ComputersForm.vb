Imports Microsoft.Data.SqlClient

''' <summary>
''' Computer inventory (frmMDS_IT_Computers in Access), kept in dbo.MDS_HelpDesk_Computers.
''' </summary>
Public Class ComputersForm

    Private Const Caption As String = "Computers"

    Private _loading As Boolean
    Private _dirty As Boolean
    Private _isNew As Boolean
    Private _current As String

    Private Sub ComputersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loading = True
        Try
            Bind(cboFilterType, WithAnyRow(ItAdmin.ComputerTypes()))
            Bind(cboFilterWhse, WithAnyRow(ItAdmin.ComputerWarehouses()))
            cboFilterType.SelectedIndex = 0
            cboFilterWhse.SelectedIndex = 0
            FillItems(cboType, {"Work Station", "Pack Station", "Ship Station", "Handheld"}, ItAdmin.ComputerTypes())
            FillItems(cboWindows, {"7", "10", "11", "Mobile", "Android"}, Nothing)
            FillItems(cboWarehouse, Array.Empty(Of String)(), Lookups.Category("Whse"), ItAdmin.ComputerWarehouses())
            FillItems(cboSentinel, {"", "Y", "N"}, Nothing)
            FillItems(cboVpn, {"", "Y", "N"}, Nothing)
        Catch ex As SqlException
            MessageBox.Show("Could not load the computer lists from SQL Server." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            BeginInvoke(Sub() Close())
            Return
        Finally
            _loading = False
        End Try
        EditorChanges.Track(grpComputer, Sub() If Not _loading AndAlso _current IsNot Nothing Then _dirty = True)
        RefreshList()
    End Sub

    ''' <summary>Fills an editable combo with fixed choices plus any values found in lookup tables.</summary>
    Private Shared Sub FillItems(cbo As ComboBox, fixedItems As IEnumerable(Of String), ParamArray lookups() As DataTable)
        Dim items As New List(Of String)(fixedItems)
        For Each t In lookups
            If t Is Nothing Then Continue For
            For Each r As DataRow In t.Rows
                Dim v = r("Display").ToString().Trim()
                If v.Length > 0 AndAlso Not items.Contains(v, StringComparer.OrdinalIgnoreCase) Then items.Add(v)
            Next
        Next
        cbo.Items.Clear()
        cbo.Items.AddRange(items.ToArray())
    End Sub

#Region "List"

    Private Sub RefreshList()
        Try
            Cursor = Cursors.WaitCursor
            dgvComputers.DataSource = ItAdmin.Computers(SelectedText(cboFilterType), SelectedText(cboFilterWhse))
            dgvComputers.Columns("Packstation").DefaultCellStyle.Format = "d"
            dgvComputers.Columns("Notes").HeaderText = "Has Notes"
            lblCount.Text = $"{dgvComputers.Rows.Count} computer(s)"
        Catch ex As SqlException
            MessageBox.Show("Could not load the computers." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
        If _current IsNot Nothing Then EditorChanges.SelectRow(dgvComputers, "Computer", _current)
    End Sub

    Private Sub Filter_Changed(sender As Object, e As EventArgs) Handles cboFilterType.SelectionChangeCommitted, cboFilterWhse.SelectionChangeCommitted
        RefreshList()
    End Sub

    Private Sub cmdClearFilter_Click(sender As Object, e As EventArgs) Handles cmdClearFilter.Click
        cboFilterType.SelectedIndex = 0
        cboFilterWhse.SelectedIndex = 0
        RefreshList()
    End Sub

    Private Sub dgvComputers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComputers.CellDoubleClick
        If e.RowIndex >= 0 Then OpenComputer(dgvComputers.Rows(e.RowIndex).Cells("Computer").Value.ToString())
    End Sub

    Private Sub dgvComputers_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvComputers.KeyDown
        If e.KeyCode = Keys.Enter AndAlso dgvComputers.CurrentRow IsNot Nothing Then
            e.Handled = True
            OpenComputer(dgvComputers.CurrentRow.Cells("Computer").Value.ToString())
        End If
    End Sub

#End Region

#Region "Editor"

    Private Sub OpenComputer(computer As String)
        If Not ConfirmDiscard() Then Return
        Dim c As ComputerRecord
        Try
            c = ItAdmin.LoadComputer(computer)
        Catch ex As SqlException
            MessageBox.Show("Could not load the computer." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        If c Is Nothing Then Return
        Fill(c, isNew:=False)
    End Sub

    Private Sub Fill(c As ComputerRecord, isNew As Boolean)
        _loading = True
        _isNew = isNew
        _current = c.Computer
        txtComputer.Text = c.Computer
        txtComputer.ReadOnly = Not isNew
        txtUser.Text = c.UserName
        txtCml.Text = c.CmlWin
        EditorChanges.SetText(cboWindows, c.WinVersion)
        txtOffice.Text = c.OfficeVersion
        dtpPackstation.Checked = c.PackstationVersion.HasValue
        If c.PackstationVersion.HasValue Then dtpPackstation.Value = c.PackstationVersion.Value
        EditorChanges.SetText(cboType, c.Type)
        EditorChanges.SetText(cboSentinel, c.Sentinel)
        txtIP.Text = c.IpAddress
        EditorChanges.SetText(cboWarehouse, c.Warehouse)
        txtModel.Text = c.ModelNbr
        EditorChanges.SetText(cboVpn, c.Vpn)
        txtUps.Text = c.WritebackUps
        txtUsps.Text = c.WritebackUsps
        txtFedex.Text = c.WritebackFedex
        txtNotes.Text = c.Notes
        grpComputer.Text = If(isNew, "New computer", $"Computer {c.Computer}")
        grpComputer.Enabled = True
        cmdSave.Enabled = True
        cmdDelete.Enabled = Not isNew
        _loading = False
        _dirty = False
    End Sub

    Private Sub ClearEditor()
        _loading = True
        _current = Nothing
        _isNew = False
        For Each ctl As Control In grpComputer.Controls
            If TypeOf ctl Is TextBox OrElse TypeOf ctl Is ComboBox Then ctl.Text = ""
        Next
        dtpPackstation.Checked = False
        grpComputer.Text = "Computer"
        grpComputer.Enabled = False
        cmdSave.Enabled = False
        cmdDelete.Enabled = False
        _loading = False
        _dirty = False
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        If Not ConfirmDiscard() Then Return
        Fill(New ComputerRecord(), isNew:=True)
        _current = ""
        txtComputer.Focus()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim c As New ComputerRecord With {
            .Computer = NullIfBlank(txtComputer.Text)?.ToUpperInvariant(),
            .UserName = NullIfBlank(txtUser.Text),
            .CmlWin = NullIfBlank(txtCml.Text),
            .WinVersion = NullIfBlank(cboWindows.Text),
            .OfficeVersion = NullIfBlank(txtOffice.Text),
            .PackstationVersion = If(dtpPackstation.Checked, dtpPackstation.Value.Date, CType(Nothing, Date?)),
            .Type = NullIfBlank(cboType.Text),
            .Sentinel = NullIfBlank(cboSentinel.Text),
            .IpAddress = NullIfBlank(txtIP.Text),
            .Warehouse = NullIfBlank(cboWarehouse.Text),
            .ModelNbr = NullIfBlank(txtModel.Text),
            .Vpn = NullIfBlank(cboVpn.Text),
            .WritebackUps = NullIfBlank(txtUps.Text),
            .WritebackUsps = NullIfBlank(txtUsps.Text),
            .WritebackFedex = NullIfBlank(txtFedex.Text),
            .Notes = NullIfBlank(txtNotes.Text)
        }
        If c.Computer Is Nothing Then
            MessageBox.Show("Enter the computer number.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtComputer.Focus()
            Return
        End If

        Try
            Cursor = Cursors.WaitCursor
            If _isNew AndAlso ItAdmin.LoadComputer(c.Computer) IsNot Nothing Then
                MessageBox.Show($"Computer {c.Computer} already exists. Open it from the list to change it.",
                                Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            ItAdmin.SaveComputer(c, _isNew)
        Catch ex As SqlException
            MessageBox.Show("The computer was not saved." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            Cursor = Cursors.Default
        End Try

        Fill(c, isNew:=False)
        RefreshList()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If String.IsNullOrEmpty(_current) OrElse _isNew Then
            MessageBox.Show("You must first select a computer to delete", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If MessageBox.Show($"Delete computer {_current}? This cannot be undone.", Caption,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then Return
        Try
            ItAdmin.DeleteComputer(_current)
        Catch ex As SqlException
            MessageBox.Show("The computer was not deleted." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        ClearEditor()
        RefreshList()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim data = TryCast(dgvComputers.DataSource, DataTable)
        If data Is Nothing Then Return
        Dim filters As New List(Of String)
        If SelectedText(cboFilterType) IsNot Nothing Then filters.Add("Type " & cboFilterType.Text)
        If SelectedText(cboFilterWhse) IsNot Nothing Then filters.Add("Location " & cboFilterWhse.Text)
        ReportPreview.Show(Me, InventoryReports.Computers(data, If(filters.Count = 0, "All computers", String.Join(" · ", filters))))
    End Sub

#End Region

#Region "Close"

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub ComputersForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmDiscard() Then e.Cancel = True
    End Sub

    Private Function ConfirmDiscard() As Boolean
        If Not _dirty Then Return True
        If MessageBox.Show("The computer has changes that were not saved. Discard them?", Caption,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            _dirty = False
            Return True
        End If
        Return False
    End Function

#End Region

End Class
