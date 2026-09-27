Imports Microsoft.Data.SqlClient

''' <summary>
''' The list of Cadence IDs in dbo.MDS_HelpDesk_OrdersInComp (frmHelpDesk_OrdersInComp in Access):
''' add IDs (paste a column of them), remove selected ones, or clear the table.
''' </summary>
Public Class OrdersInCompForm

    Private Const Caption As String = "Orders In COMP"

    Private Sub OrdersInCompForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshList()
    End Sub

    Private Sub RefreshList()
        Try
            dgvOrders.DataSource = ItAdmin.OrdersInComp()
            dgvOrders.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            lblCount.Text = $"{dgvOrders.Rows.Count} order(s)"
        Catch ex As SqlException
            MessageBox.Show("Could not load the list." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim ids = txtAdd.Text.Split({vbCr, vbLf, ",", vbTab, " "}, StringSplitOptions.RemoveEmptyEntries).
                              Select(Function(s) s.Trim().ToUpperInvariant()).
                              Where(Function(s) s.Length > 0).
                              Distinct().ToList()
        If ids.Count = 0 Then
            MessageBox.Show("Type or paste Cadence IDs in the box, one per line.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAdd.Focus()
            Return
        End If
        Dim tooLong = ids.FirstOrDefault(Function(s) s.Length > 100)
        If tooLong IsNot Nothing Then
            MessageBox.Show($"'{tooLong.Substring(0, 30)}…' is too long to be a Cadence ID.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim added = ItAdmin.AddOrdersInComp(ids)
            txtAdd.Clear()
            RefreshList()
            Dim skipped = ids.Count - added
            MessageBox.Show($"{added} added" & If(skipped > 0, $", {skipped} already in the list.", "."), Caption,
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As SqlException
            MessageBox.Show("The IDs were not added." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        Dim ids = dgvOrders.SelectedRows.Cast(Of DataGridViewRow)().Select(Function(r) r.Cells(0).Value.ToString()).ToList()
        If ids.Count = 0 Then Return
        If MessageBox.Show($"Remove {ids.Count} Cadence ID(s) from the list?", Caption,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            For Each id In ids
                ItAdmin.RemoveOrderInComp(id)
            Next
        Catch ex As SqlException
            MessageBox.Show("Not all IDs were removed." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        RefreshList()
    End Sub

    Private Sub cmdClearTable_Click(sender As Object, e As EventArgs) Handles cmdClearTable.Click
        If dgvOrders.Rows.Count = 0 Then Return
        If MessageBox.Show($"Remove all {dgvOrders.Rows.Count} Cadence IDs from the list?", Caption,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then Return
        Try
            ItAdmin.ClearOrdersInComp()
        Catch ex As SqlException
            MessageBox.Show("The table was not cleared." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        RefreshList()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

End Class
