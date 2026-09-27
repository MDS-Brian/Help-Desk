''' <summary>
''' The help desk user matching the Windows login (Module1.CheckUser in Access).
''' </summary>
Public NotInheritable Class CurrentUser

    Private Shared _checked As Boolean

    Public Shared Property Login As String
    Public Shared Property UserID As Integer?
    Public Shared Property UserName As String
    Public Shared Property UserRole As String

    Private Sub New()
    End Sub

    Public Shared Sub Check()
        If _checked Then Return
        Login = Environment.UserName
        Dim dt = Db.Query(Db.MDS,
            "SELECT TOP 1 ID, UserName, UserRole FROM dbo.MDS_HelpDesk_Users WHERE LoginName = @login",
            Db.P("@login", Login))
        If dt.Rows.Count > 0 Then
            UserID = CInt(dt.Rows(0)("ID"))
            UserName = dt.Rows(0)("UserName").ToString().Trim()
            UserRole = dt.Rows(0)("UserRole").ToString().Trim()
        End If
        _checked = True
    End Sub

End Class
