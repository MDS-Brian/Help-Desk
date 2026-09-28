Imports System.IO
Imports System.Text.Json

''' <summary>
''' Settings loaded from appsettings.json next to the executable.
''' </summary>
Public NotInheritable Class AppConfig

    Private Shared _root As JsonElement
    Private Shared _loaded As Boolean

    Private Sub New()
    End Sub

    Private Shared ReadOnly Property Root As JsonElement
        Get
            If Not _loaded Then
                Dim path = IO.Path.Combine(AppContext.BaseDirectory, "appsettings.json")
                If Not File.Exists(path) Then
                    Throw New FileNotFoundException("The configuration file appsettings.json was not found.", path)
                End If
                Using doc = JsonDocument.Parse(File.ReadAllText(path))
                    _root = doc.RootElement.Clone()
                End Using
                _loaded = True
            End If
            Return _root
        End Get
    End Property

    Private Shared Function GetValue(section As String, key As String) As String
        Dim sec As JsonElement
        Dim val As JsonElement
        If Root.TryGetProperty(section, sec) AndAlso sec.TryGetProperty(key, val) Then
            Return val.GetString()
        End If
        Throw New InvalidOperationException($"Setting {section}:{key} is missing from appsettings.json.")
    End Function

    Public Shared Function ConnectionString(name As String) As String
        Return GetValue("ConnectionStrings", name)
    End Function

    Public Shared ReadOnly Property SupportEmail As String
        Get
            Return GetValue("Email", "SupportAddress")
        End Get
    End Property

    Public Shared ReadOnly Property EmailDomain As String
        Get
            Return GetValue("Email", "Domain")
        End Get
    End Property

    Public Shared ReadOnly Property DatabaseMailProfile As String
        Get
            Return GetValue("Email", "DatabaseMailProfile")
        End Get
    End Property

    ''' <summary>Share that ticket attachments are copied to (one sub-folder per ticket).</summary>
    Public Shared ReadOnly Property AttachmentsFolder As String
        Get
            Return GetValue("Attachments", "Folder")
        End Get
    End Property

    Public Shared ReadOnly Property AttachmentMaxBytes As Long
        Get
            Dim sec As JsonElement
            Dim val As JsonElement
            If Root.TryGetProperty("Attachments", sec) AndAlso sec.TryGetProperty("MaxSizeMB", val) Then
                Return val.GetInt64() * 1024L * 1024L
            End If
            Return 25L * 1024L * 1024L
        End Get
    End Property

    Public Shared ReadOnly Property AccountsDatabasePath As String
        Get
            Dim val As JsonElement
            If Root.TryGetProperty("AccountsDatabasePath", val) Then Return val.GetString()
            Return Nothing
        End Get
    End Property

End Class
