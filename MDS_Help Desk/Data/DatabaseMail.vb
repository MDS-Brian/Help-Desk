''' <summary>
''' Sends email through SQL Server Database Mail (msdb.dbo.sp_send_dbmail), as the Access
''' Edit Tickets form did. The Windows user needs the DatabaseMailUserRole in msdb.
''' </summary>
Public Module DatabaseMail

    Public Sub Send(recipients As String, copyRecipients As String, subject As String, body As String)
        Using cn = Db.Open(Db.MDS),
              cmd = Db.NewCommand(cn,
                "EXEC msdb.dbo.sp_send_dbmail
                    @profile_name = @profile, @recipients = @to, @copy_recipients = @cc,
                    @from_address = @from, @reply_to = @from, @subject = @subject, @body = @body",
                Db.P("@profile", AppConfig.DatabaseMailProfile),
                Db.P("@to", recipients),
                Db.P("@cc", copyRecipients),
                Db.P("@from", AppConfig.SupportEmail),
                Db.P("@subject", subject),
                Db.P("@body", body))
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Module
