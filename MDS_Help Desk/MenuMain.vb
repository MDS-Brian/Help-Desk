Public Class MenuMain

    Private Sub cmdAddTicket_Click(sender As Object, e As EventArgs) Handles cmdAddTicket.Click
        Using f As New TicketNewForm()
            f.ShowDialog(Me)
        End Using
    End Sub

    Private Sub cmdOpenTickets_Click(sender As Object, e As EventArgs) Handles cmdOpenTickets.Click
        Using f As New TicketEditForm()
            f.ShowDialog(Me)
        End Using
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Using f As New PrintTicketsForm()
            f.ShowDialog(Me)
        End Using
    End Sub

    Private Sub Command7_Click(sender As Object, e As EventArgs) Handles Command7.Click

    End Sub

    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        Dim path = AppConfig.AccountsDatabasePath
        If String.IsNullOrWhiteSpace(path) OrElse Not IO.File.Exists(path) Then
            MessageBox.Show($"The Accounts database was not found:{vbCrLf}{path}", "Help Desk",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Process.Start(New ProcessStartInfo(path) With {.UseShellExecute = True, .WindowStyle = ProcessWindowStyle.Maximized})
        Me.Close()
    End Sub

    Private Sub cmdKnowlege_Click(sender As Object, e As EventArgs) Handles cmdKnowlege.Click
        Using f As New KnowledgeBaseForm()
            f.ShowDialog(Me)
        End Using
    End Sub

    Private Sub cmdUtilites_Click(sender As Object, e As EventArgs) Handles cmdUtilites.Click
        NotConverted("Utilities")
    End Sub

    Private Sub cmdAdmin_Click(sender As Object, e As EventArgs) Handles cmdAdmin.Click
        Using f As New ItAdminForm()
            f.ShowDialog(Me)
        End Using
    End Sub

    Private Sub Command12_Click(sender As Object, e As EventArgs) Handles Command12.Click

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub NotConverted(feature As String)
        MessageBox.Show($"{feature} has not been converted from Access yet.", "Help Desk",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
