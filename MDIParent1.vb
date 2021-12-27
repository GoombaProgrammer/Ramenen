Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms

Public Class MDIParent1
    Dim dontaskclose = False
    Dim unwanted As Integer = 0
    Dim version As String = 0.1
    Dim potentialvirus As Integer = 0
    Dim virus As Integer = 0
    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Shared Function GetPrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Shared Function WritePrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Boolean
    End Function


    Public Shared Function ReadINI(ByVal File As String, ByVal Section As String, ByVal Key As String) As String
        Dim sb As New StringBuilder(500)
        GetPrivateProfileString(Section, Key, "", sb, sb.Capacity, File)
        Return sb.ToString
    End Function

    Public Shared Sub WriteINI(ByVal File As String, ByVal Section As String, ByVal Key As String, ByVal Value As String)
        WritePrivateProfileString(Section, Key, Value, File)
    End Sub

    Public closeToDebug As Integer = 0
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        Dim ChildForm As New Form With {
            .MdiParent = Me
        }
        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub
    Private Sub Closings(ByVal sender As Object, ByVal e As EventArgs) Handles Me.FormClosing
        If Not dontaskclose Then
            Dim ays = MsgBox("This will end your Ramenen session.", MsgBoxStyle.YesNo, "End Ramenen")
            If ays = MsgBoxResult.No Then
                Dim newme = New MDIParent1
                For Each ChildForm As Form In Me.MdiChildren
                    ChildForm.MdiParent = newme
                Next
                newme.Show()
                dontaskclose = True
                Me.Close()
            End If
        End If
    End Sub
    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog With {
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments,
            .Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        }
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
        If closeToDebug = 1 Then
            MessageBox.Show("You are now in debug mode!")
            Me.ShowInTaskbar = True
            Me.TopMost = False
            Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
            closeToDebug = 0
        End If
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim settings = MsgBox("Do you want me to hide in the taskbar?", MsgBoxStyle.YesNo, "Settings")
        If settings = MsgBoxResult.Yes Then
            Me.ShowInTaskbar = False
        Else
            Me.ShowInTaskbar = True
        End If
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not IO.Directory.Exists("C:\VirtualSystem\Ramenen") Then
            IO.Directory.CreateDirectory("C:\VirtualSystem\Ramenen")
            IO.Directory.CreateDirectory("C:\VirtualSystem\Ramenen\System")
            IO.Directory.CreateDirectory("C:\VirtualSystem\Ramenen\Groups")
            IO.Directory.CreateDirectory("C:\VirtualSystem\Ramenen\Groups\Programs")
            IO.Directory.CreateDirectory("C:\VirtualSystem\Ramenen\Groups\System")
            IO.File.WriteAllText("C:\VirtualSystem\Ramenen\Groups\System\status.ras", "1")
            IO.File.Create("C:\VirtualSystem\Ramenen\Groups\System\ramenen.ini").Close()
            WriteINI("C:\VirtualSystem\Ramenen\Groups\System\ramenen.ini", "Colors", "StripColor", "LightGray")
            IO.File.Create("C:\VirtualSystem\Ramenen\Groups\System\firewall.ini").Close()
            WriteINI("C:\VirtualSystem\Ramenen\Groups\System\firewall.ini", "Block", "UnknownExtensions", "True")
            WriteINI("C:\VirtualSystem\Ramenen\Groups\System\firewall.ini", "Protection", "AllowAllFileNames", "False")
            WriteINI("C:\VirtualSystem\Ramenen\Groups\System\firewall.ini", "Protection", "CheckSystemDir", "True")
            WriteINI("C:\VirtualSystem\Ramenen\Groups\System\ramenen.ini", "Colors", "GroupsColor", "White")
            IO.File.WriteAllBytes("C:\VirtualSystem\Ramenen\Groups\Programs\colors.rex", My.Resources.colors)
            IO.File.WriteAllBytes("C:\VirtualSystem\Ramenen\Groups\Programs\tgo.rex", My.Resources.tgo)
            IO.File.WriteAllBytes("C:\VirtualSystem\Ramenen\Groups\Programs\drawingpad.rex", My.Resources.drawingpad)
            IO.File.Create("C:\VirtualSystem\Ramenen\System\progman.rpf").Close()
            IO.File.WriteAllText("C:\VirtualSystem\Ramenen\System\progman.rpf", "RMN::StartProgramManager(WithByte(x20));")
            IO.File.Create("C:\VirtualSystem\Ramenen\System\RMN.rpr").Close()
            IO.File.WriteAllText("C:\VirtualSystem\Ramenen\System\RMN.rpr", "define StartProgramManager(new Byte(0)) = startXmlPlusPlus(<xmlpp><programs=mdiparent1 second=second>)")
        End If
        MenuStrip.BackColor = Color.FromName(ReadINI("C:\VirtualSystem\Ramenen\Groups\System\ramenen.ini", "Colors", "StripColor"))
        ListBox1.BackColor = Color.FromName(ReadINI("C:\VirtualSystem\Ramenen\Groups\System\ramenen.ini", "Colors", "GroupsColor"))
        If File.ReadAllText("C:\VirtualSystem\Ramenen\Groups\System\status.ras") = "2" Then
            IO.Directory.Delete("C:\VirtualSystem\Ramenen", True)
            Application.Exit()
        ElseIf File.ReadAllText("C:\VirtualSystem\Ramenen\Groups\System\status.ras") = "1" Then
        ElseIf File.ReadAllText("C:\VirtualSystem\Ramenen\Groups\System\status.ras") = "0" Then
            MsgBox("debug msgbox")
        Else
            Application.Exit()
        End If
        UpdateGroups()
        If Not version = New Net.WebClient().DownloadString("https://www.taart.site/ramenen/ver.txt") Then
            Dim updatedialog As New Update
            updatedialog.MdiParent = Me
            updatedialog.Show()
        End If
    End Sub

    Private Sub CreateFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateFolderToolStripMenuItem.Click
        Me.TopMost = False
        Dim fName = InputBox("Group name:", "Enter a name for the group.")
        IO.Directory.CreateDirectory("C:\VirtualSystem\Ramenen\Groups\" + fName.Replace("..", ""))
        UpdateGroups()
        Me.TopMost = True
    End Sub

    Sub UpdateGroups()
        IO.Directory.CreateDirectory("C:\VirtualSystem\Ramenen\Groups")
        ListBox1.Items.Clear()
        Dim di As New DirectoryInfo("C:\VirtualSystem\Ramenen\Groups\")
        Dim fiArr As DirectoryInfo() = di.GetDirectories()
        Dim fri As DirectoryInfo
        For Each fri In fiArr
            ListBox1.Items.Add(fri.Name)
        Next
    End Sub
    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If Not ListBox1.SelectedIndex = -1 Then
            Dim newChild = New cder
            Dim di As New DirectoryInfo("C:\VirtualSystem\Ramenen\Groups\" + ListBox1.SelectedItem)
            Dim fiArr As FileInfo() = di.GetFiles()
            Dim fri As FileInfo
            For Each fri In fiArr
                newChild.ListBox1.Items.Add(ListBox1.SelectedItem.Split("\")(0) & "\" & fri.Name)
            Next
            newChild.MdiParent = Me
            newChild.Show()
        End If
    End Sub
    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click
        Me.TopMost = False
        Dim newFileName = InputBox("Enter the group And file name. For example: groupname\foo.bar")
        If Not newFileName.Contains("\") Then
            MsgBox("Invalid opcode.")
        Else
            If IO.Directory.Exists("C:\VirtualSystem\Ramenen\Groups\" & newFileName.Split("\")(0)) Then
                IO.File.Create("C:\VirtualSystem\Ramenen\Groups\" & newFileName.Split("\")(0) & "\" & newFileName.Split("\")(1)).Close()
            Else
                MsgBox("Invalid dicode.")
            End If
        End If
        Me.TopMost = True
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        ListBox1.Visible = ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub AntiVirusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntiVirusToolStripMenuItem.Click
        Me.TopMost = False
        Dim answer = MsgBox("Do you want to edit the Ramenen Firewall/Anti-Virus configuration?", MsgBoxStyle.YesNo, "Ramenen Firewall")
        Me.TopMost = False
        If answer = MsgBoxResult.Yes Then
            Dim notepad As New Notepad
            notepad.MdiParent = Me
            notepad.open("C:\VirtualSystem\Ramenen\Groups\System\firewall.ini")
            notepad.dir = "System"
            notepad.Show()
        End If
    End Sub

    Private Sub ScanForVirussesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanForVirussesToolStripMenuItem.Click
        GetFiles("C:\VirtualSystem\Ramenen")
        MsgBox("Complete. Virusses found: " & virus + potentialvirus + unwanted & " where " & potentialvirus + unwanted & " may not be virusses.")

        unwanted = 0

        potentialvirus = 0
        virus = 0
    End Sub


    Public Sub GetFiles(ByVal strpath As String)

        Try

            Dim str As String() = IO.Directory.GetFiles(strpath, "*.*", IO.SearchOption.TopDirectoryOnly)
            'Get Current Directory files
            For Each s As String In str
                If ReadINI("C:\VirtualSystem\Ramenen\Groups\System\firewall.ini", "Protection", "AllowAllFileNames") = "False" Then
                    If s.EndsWith("porn") Then
                        unwanted += 1
                    End If
                    If s.Contains("naked") Then
                        unwanted += 1
                    End If
                    If s.Contains("sexy") Then
                        unwanted += 1
                    End If
                End If
                If s.Contains("poopy") Then
                    unwanted += 1
                End If
                If s.Contains("fuck") Then
                    unwanted += 1
                End If
                Dim checkInsie As New StreamReader(s)
                Dim inside = checkInsie.ReadToEnd
                checkInsie.Close()
                If inside.Contains("porn") Or inside.Contains("nakedg") Then
                    unwanted += 1
                End If
                If inside.Contains("System32") Or inside.Contains("SysWOW64") Then
                    potentialvirus += 1
                End If
                If inside.ToLower.Contains("virus") Then
                    potentialvirus += 1
                End If
                If inside.ToLower.Contains("X5O!P%@AP[4\PZX54(P^)7CC)7}$EICAR-STANDARD-ANTIVIRUS-TEST-FILE!$H+H*") Then
                    virus += 1
                End If
                If s.EndsWith(".txt.rex") Then
                    potentialvirus += 1
                End If
                If s.EndsWith(".txt.com") Then
                    potentialvirus += 1
                End If

            Next
            'Loop  over sub-directories
            For Each strDirectory As String In IO.Directory.GetDirectories(strpath, "*.*", IO.SearchOption.TopDirectoryOnly)


                Me.GetFiles(strDirectory)


            Next

        Catch ex As UnauthorizedAccessException
            'Access Denied exception

        Catch ex1 As Exception
            'Other exceptions

        End Try

    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        Try
            Me.TopMost = False
            Dim oldName = InputBox("Enter the file name and group you want to move (ex. Programs\tgo.rex)")
            Me.TopMost = True
            Me.TopMost = False
            Dim newName = InputBox("Enter the new file name and group (ex. Programs\tgo_backup.rex)")
            Me.TopMost = True
            IO.File.Move("C:\VirtualSystem\Ramenen\Groups\" & oldName, "C:\VirtualSystem\Ramenen\Groups\" & newName)
            Dim newme As New MDIParent1
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.MdiParent = newme
            Next
            newme.Show()
            dontaskclose = True
            Me.Close()
        Catch
            Dim newOops As New Oops
            newOops.setReason("Fatal error during move! Does the file / group exist?")
            newOops.MdiParent = Me
            newOops.Show()
        End Try
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub
End Class