Public Class Update
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://www.taart.site/ramenen/Ramenen.exe")
        Application.Exit()
    End Sub

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = New Net.WebClient().DownloadString("https://www.taart.site/ramenen/rnotes.txt")
    End Sub
End Class