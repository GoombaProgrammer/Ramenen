Public Class Update
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MDIParent1.TopMost = False
        Dim makebackup = MsgBox("Updating Ramenen will remove your data, do you want to make a backup before updating?", MsgBoxStyle.YesNo, "Ramenen Updater")
        MDIParent1.TopMost = True
        Try
            If makebackup = MsgBoxResult.Yes Then
                IO.Directory.Move("C:\VirtualSystem\Ramenen", "C:\VirtualSystem\Ramenen.old")
            Else
                IO.Directory.Delete("C:\VirtualSystem\Ramenen")
            End If
        Catch
        End Try
        Process.Start("https://www.taart.site/ramenen/Ramenen.exe?vr=" & New Random().Next(1, 99999999))
        Application.Exit()
    End Sub

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = New Net.WebClient().DownloadString("https://www.taart.site/ramenen/rnotes.txt")
    End Sub
End Class