Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.startup, AudioPlayMode.Background)
    End Sub

    Private Sub startupTimer_Tick(sender As Object, e As EventArgs) Handles startupTimer.Tick
        MDIParent1.Show()
        Me.Close()
    End Sub
End Class
