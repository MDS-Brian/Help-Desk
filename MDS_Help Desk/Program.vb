Imports System.Windows.Forms

Friend Module Program

    <STAThread>
    Friend Sub Main()
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MenuMain())
    End Sub

End Module
