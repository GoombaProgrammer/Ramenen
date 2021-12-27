Imports System.IO

Public Class Notepad
    Public fullName As String = ""
    Public dir As String = "System"
    Dim amountPressed = 0
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        amountPressed += 1
        If amountPressed = 5 Then
            MDIParent1.closeToDebug = 1
        End If
        ListBox1.Show()
        ListBox1.Items.Clear()
        Dim di As New DirectoryInfo("C:\VirtualSystem\Ramenen\Groups\" & dir)
        Dim fiArr As DirectoryInfo() = di.GetDirectories()

        Dim di2 As New DirectoryInfo(di.FullName)
        Dim fiArr2 As FileInfo() = di2.GetFiles()
            Dim fri2 As FileInfo
            For Each fri2 In fiArr2
                ListBox1.Items.Add(fri2.Name)

        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not ListBox1.SelectedIndex = -1 Then
            Dim streader As New StreamReader("C:\VirtualSystem\Ramenen\Groups\" & dir & "\" & ListBox1.SelectedItem.ToString)
            RichTextBox1.Text = streader.ReadToEnd()
            streader.Close()
            ListBox1.Hide()
        End If
    End Sub

    Public Sub open(ByVal fullpath As String)
        fullName = fullpath
        Dim streader As New StreamReader(fullpath)
        RichTextBox1.Text = streader.ReadToEnd()
        streader.Close()
        ListBox1.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MDIParent1.TopMost = False
        Dim newFileName = InputBox("Enter the group and file name. For example: groupname\foo.bar")
        If Not newFileName.Contains("\") Then
            MsgBox("Invalid opcode.")
        Else
            If IO.Directory.Exists("C:\VirtualSystem\Ramenen\Groups\" & newFileName.Split("\")(0)) Then
                IO.File.WriteAllText("C:\VirtualSystem\Ramenen\Groups\" & newFileName.Split("\")(0) & "\" & newFileName.Split("\")(1), RichTextBox1.Text)
            Else
                MsgBox("Invalid dicode.")
            End If
        End If
        MDIParent1.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IO.File.WriteAllText(fullName, RichTextBox1.Text)
    End Sub

    Private Sub Notepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class