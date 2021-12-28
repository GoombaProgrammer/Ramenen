Imports System.Reflection
Imports System.Linq
Imports System.Text
Imports System.Runtime.InteropServices

Public Class cder
    Dim myProcess As Process = New Process()
    Dim MyHandle As IntPtr
    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Shared Function GetPrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    End Function
    Private Declare Function SetParent Lib "user32" (ByVal hWndChild As Long, ByVal hWndNewParent As Long) As Long
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Long
    Public Shared Function ReadINI(ByVal File As String, ByVal Section As String, ByVal Key As String) As String
        Dim sb As New StringBuilder(500)
        GetPrivateProfileString(Section, Key, "", sb, sb.Capacity, File)
        Return sb.ToString
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex >= 0 Then
            If ListBox1.SelectedItem.ToString.ToLower().EndsWith(".txt") Then
                Dim notepad As New Notepad
                notepad.MdiParent = MDIParent1
                notepad.open("C:\VirtualSystem\Ramenen\Groups\" + ListBox1.SelectedItem.ToString)
                notepad.dir = ListBox1.SelectedItem.split("\")(0)
                notepad.Show()

            ElseIf ListBox1.SelectedItem.ToString.ToLower().EndsWith(".doc") Then
                Dim notepad As New Notepad
                notepad.MdiParent = MDIParent1
                notepad.open("C:\VirtualSystem\Ramenen\Groups\" + ListBox1.SelectedItem.ToString)
                notepad.dir = ListBox1.SelectedItem.split("\")(0)
                notepad.Show()
            ElseIf ListBox1.SelectedItem.ToString.ToLower().EndsWith(".png") Or ListBox1.SelectedItem.ToString.ToLower().EndsWith(".jpg") Then
                Dim notepad As New Oops
                notepad.MdiParent = MDIParent1
                notepad.setReason("Photo viewer coming soon.")
                notepad.Show()
            ElseIf ListBox1.SelectedItem.ToString.ToLower().EndsWith(".ini") Then
                Dim notepad As New Notepad
                notepad.MdiParent = MDIParent1
                notepad.open("C:\VirtualSystem\Ramenen\Groups\" + ListBox1.SelectedItem.ToString)
                notepad.dir = ListBox1.SelectedItem.split("\")(0)
                notepad.Show()
            ElseIf ListBox1.SelectedItem.ToString.ToLower().EndsWith(".ras") Or ListBox1.SelectedItem.ToString.ToLower().EndsWith(".dll") Then
                Dim notepad As New Oops
                notepad.MdiParent = MDIParent1
                notepad.setReason("You can not open system files")
                notepad.Show()
            ElseIf ListBox1.SelectedItem.ToString.ToLower().EndsWith(".com") Or ListBox1.SelectedItem.ToString.ToLower().EndsWith(".rex") Then
                Try
                    Dim child As New Form()
                    Dim t = New AssemblyName()
                    Dim asm As Assembly = Assembly.LoadFrom("C:\VirtualSystem\Ramenen\Groups\" & ListBox1.SelectedItem.ToString)
                    Dim Type As Type = asm.GetType(GetAssemblyNamespace(asm) & ".RamenenDefault", True, True)
                    Dim childform = Activator.CreateInstance(Type)
                    child = childform
                    child.MdiParent = MDIParent1
                    child.Show()
                Catch ex As Exception
                    Dim notepad As New Oops
                    notepad.MdiParent = MDIParent1
                    notepad.setReason("The executable is corrupt or invalid")
                    notepad.Show()
                End Try
            Else
                If ReadINI("C:\VirtualSystem\Ramenen\Groups\System\firewall.ini", "Block", "UnknownExtensions") = "False" Then
                    Dim notepad As New Notepad
                    notepad.MdiParent = MDIParent1
                    notepad.open("C:\VirtualSystem\Ramenen\Groups\" + ListBox1.SelectedItem.ToString)
                    notepad.dir = ListBox1.SelectedItem.split("\")(0)
                    notepad.Show()
                Else
                    Dim notepad As New Oops
                    notepad.MdiParent = MDIParent1
                    notepad.setReason("The file is unknown and has been blocked for security")
                    notepad.Show()
                End If
            End If
        End If
    End Sub

    Public Function GetAssemblyNamespace(ByVal asm As Assembly) As String
        Dim ns As String = ""

        For Each tp As Type In asm.GetModules.First().GetTypes()
            If If(ns.Length = 0, True, tp.[Namespace].Length < ns.Length) Then ns = tp.[Namespace]
        Next

        Return ns
    End Function
End Class