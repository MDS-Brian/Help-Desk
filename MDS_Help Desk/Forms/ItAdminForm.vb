''' <summary>
''' IT Admin menu (frmHelpDesk_Utilities in Access). The WMS tools on the right are listed
''' but not converted yet.
''' </summary>
Public Class ItAdminForm

    Private Sub cmdComputers_Click(sender As Object, e As EventArgs) Handles cmdComputers.Click
        Open(New ComputersForm())
    End Sub

    Private Sub cmdPrinters_Click(sender As Object, e As EventArgs) Handles cmdPrinters.Click
        Open(New PrintersForm())
    End Sub

    Private Sub cmdCategories_Click(sender As Object, e As EventArgs) Handles cmdCategories.Click
        Open(New CategoriesForm())
    End Sub

    Private Sub cmdUnitID_Click(sender As Object, e As EventArgs) Handles cmdUnitID.Click
        Open(New UnitIdsForm())
    End Sub

    Private Sub cmdOrdersInComp_Click(sender As Object, e As EventArgs) Handles cmdOrdersInComp.Click
        Open(New OrdersInCompForm())
    End Sub

    Private Sub WmsTool_Click(sender As Object, e As EventArgs) Handles cmdSkuUpper.Click, cmdPrel.Click, cmdQuickLaunch.Click,
                                                                       cmdResetCdi.Click, cmdGuid.Click, cmdFtp.Click,
                                                                       cmdShopify.Click, cmdAssignSkus.Click, cmdWebImport.Click
        MessageBox.Show($"{DirectCast(sender, Button).Text} has not been converted from Access yet.", "IT Admin",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub Open(f As Form)
        Using f
            f.ShowDialog(Me)
        End Using
    End Sub

End Class
