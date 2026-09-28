Option Strict Off

''' <summary>
''' Opens an Outlook draft for the user to review and send. Late-bound so no Office
''' interop assemblies are needed, and it works from a 64-bit process with 32-bit Office.
''' </summary>
Public Module OutlookMail

    Private Const olMailItem As Integer = 0

    Public Sub ShowDraft(toAddress As String, cc As String, subject As String, body As String, Optional attachmentPath As String = Nothing)
        Dim outlookType = Type.GetTypeFromProgID("Outlook.Application")
        If outlookType Is Nothing Then
            Throw New InvalidOperationException("Microsoft Outlook is not installed on this computer.")
        End If
        Dim outlook As Object = Activator.CreateInstance(outlookType)
        Dim mail As Object = outlook.CreateItem(olMailItem)
        mail.To = toAddress
        mail.CC = If(cc, "")
        mail.Subject = subject
        mail.Body = body
        If Not String.IsNullOrEmpty(attachmentPath) AndAlso IO.File.Exists(attachmentPath) Then
            mail.Attachments.Add(attachmentPath)
        End If
        mail.Display()
    End Sub

End Module
