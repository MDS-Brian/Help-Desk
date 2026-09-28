''' <summary>
''' Base class for the help desk windows: gives every form the application icon (app.ico).
''' New forms should inherit AppForm instead of Form (change the Inherits line in the
''' form's .Designer.vb file).
''' </summary>
Public Class AppForm
    Inherits Form

    Private Shared ReadOnly _icon As New Lazy(Of Icon)(AddressOf LoadIcon)

    ''' <summary>The application icon, loaded once from the embedded app.ico.</summary>
    Public Shared ReadOnly Property AppIcon As Icon
        Get
            Return _icon.Value
        End Get
    End Property

    Private Shared Function LoadIcon() As Icon
        Using stream = GetType(AppForm).Assembly.GetManifestResourceStream("MDS_Help_Desk.app.ico")
            Return If(stream Is Nothing, Nothing, New Icon(stream))
        End Using
    End Function

    Protected Overrides Sub OnLoad(e As EventArgs)
        ' Not in the designer: it would try to load the icon while you are editing the form.
        If Not DesignMode AndAlso AppIcon IsNot Nothing Then Icon = AppIcon
        MyBase.OnLoad(e)
    End Sub

End Class
