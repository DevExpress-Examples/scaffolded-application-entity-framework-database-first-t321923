Imports DevExpress.Xpf.Core
Imports DevExpress.Internal

Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.

    Private Sub Application_Startup(sender As Object, e As StartupEventArgs)
        ApplicationThemeHelper.UpdateApplicationThemeName()
        DbEngineDetector.PatchConnectionStringsAndConfigureEntityFrameworkDefaultConnectionFactory()
    End Sub

    Protected Overrides Sub OnExit(ByVal e As ExitEventArgs)
        ApplicationThemeHelper.SaveApplicationThemeName()
    End Sub
End Class
