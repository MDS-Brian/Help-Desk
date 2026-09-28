Imports System.IO

''' <summary>
''' Ticket attachments: the file is copied to AppConfig.AttachmentsFolder\&lt;ticket no&gt;\ and the
''' full path is stored in dbo.MDS_HelpDesk.FileName (one attachment per ticket).
''' </summary>
Public Module Attachments

    Private Const MaxPathLength As Integer = 255   ' size of MDS_HelpDesk.FileName

    ''' <summary>Returns a message if the file cannot be attached, otherwise Nothing.</summary>
    Public Function CheckFile(path As String) As String
        Dim info As New FileInfo(path)
        If Not info.Exists Then Return "The file was not found."
        If info.Length > AppConfig.AttachmentMaxBytes Then
            Return $"The file is {info.Length / 1024 / 1024:N1} MB; attachments can be up to {AppConfig.AttachmentMaxBytes \ 1024 \ 1024} MB."
        End If
        Return Nothing
    End Function

    ''' <summary>Copies the file into the ticket's folder, never overwriting, and returns the new path.</summary>
    Public Function CopyToShare(ticketId As Integer, sourcePath As String) As String
        Dim folder = Path.Combine(AppConfig.AttachmentsFolder, ticketId.ToString())
        Directory.CreateDirectory(folder)

        Dim name = Path.GetFileName(sourcePath)
        Dim dest = Path.Combine(folder, name)
        Dim n = 2
        While File.Exists(dest)
            dest = Path.Combine(folder, $"{Path.GetFileNameWithoutExtension(name)} ({n}){Path.GetExtension(name)}")
            n += 1
        End While
        If dest.Length > MaxPathLength Then
            Throw New PathTooLongException($"The attachment path would be longer than {MaxPathLength} characters. Rename the file to something shorter and try again.")
        End If

        File.Copy(sourcePath, dest)
        Return dest
    End Function

    ''' <summary>Opens an attachment with its default program.</summary>
    Public Sub Open(path As String)
        If Not File.Exists(path) Then Throw New FileNotFoundException($"The attachment was not found:{vbCrLf}{path}", path)
        Process.Start(New ProcessStartInfo(path) With {.UseShellExecute = True})
    End Sub

    ''' <summary>"name.pdf (1.2 MB)" for showing a chosen file.</summary>
    Public Function Describe(path As String) As String
        Dim info As New FileInfo(path)
        Dim size = If(info.Length < 1024 * 1024, $"{Math.Max(1, info.Length \ 1024)} KB", $"{info.Length / 1024 / 1024:N1} MB")
        Return $"{info.Name} ({size})"
    End Function

End Module
