Imports Microsoft.Data.SqlClient

''' <summary>
''' Cadence handheld unit IDs (frmHelpDesk_Unit_ID in Access): list, filter by warehouse,
''' click a column heading to sort.
''' </summary>
Public Class UnitIdsForm

    Private Sub UnitIdsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Bind(cboWarehouse, WithAnyRow(ItAdmin.Warehouses()))
            cboWarehouse.SelectedIndex = 0
        Catch ex As SqlException
            MessageBox.Show("Could not load the warehouses from SQL Server." & vbCrLf & vbCrLf & ex.Message,
                            Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            BeginInvoke(Sub() Close())
            Return
        End Try
        RefreshList()
    End Sub

    Private Sub cboWarehouse_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboWarehouse.SelectionChangeCommitted
        RefreshList()
    End Sub

    Private Sub RefreshList()
        Try
            dgvUnits.DataSource = ItAdmin.UnitIds(SelectedText(cboWarehouse))
            dgvUnits.Columns("Assigned To").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            lblCount.Text = $"{dgvUnits.Rows.Count} unit(s)"
        Catch ex As SqlException
            MessageBox.Show("Could not load the unit IDs." & vbCrLf & vbCrLf & ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

End Class
