Imports Ookii
Imports IWshRuntimeLibrary

Public Class Form1
#Region "Process suspend/resume"
    <Flags()>
    Public Enum ThreadAccess As Integer
        TERMINATE = (&H1)
        SUSPEND_RESUME = (&H2)
        GET_CONTEXT = (&H8)
        SET_CONTEXT = (&H10)
        SET_INFORMATION = (&H20)
        QUERY_INFORMATION = (&H40)
        SET_THREAD_TOKEN = (&H80)
        IMPERSONATE = (&H100)
        DIRECT_IMPERSONATION = (&H200)
    End Enum

    Private Declare Function OpenThread Lib "kernel32.dll" (ByVal dwDesiredAccess As ThreadAccess, ByVal bInheritHandle As Boolean, ByVal dwThreadId As UInteger) As IntPtr
    Private Declare Function SuspendThread Lib "kernel32.dll" (ByVal hThread As IntPtr) As UInteger
    Private Declare Function ResumeThread Lib "kernel32.dll" (ByVal hThread As IntPtr) As UInteger
    Private Declare Function CloseHandle Lib "kernel32.dll" (ByVal hHandle As IntPtr) As Boolean

    Private Sub SuspendProcess(ByVal process As System.Diagnostics.Process)
        For Each t As ProcessThread In process.Threads
            Dim th As IntPtr

            th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
            If th <> IntPtr.Zero Then
                SuspendThread(th)
                CloseHandle(th)
            End If
        Next
    End Sub

    Private Sub ResumeProcess(ByVal process As System.Diagnostics.Process)
        For Each t As ProcessThread In process.Threads
            Dim th As IntPtr

            th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
            If th <> IntPtr.Zero Then
                ResumeThread(th)
                CloseHandle(th)
            End If
        Next
    End Sub
#End Region
    Dim BlockedPrcs As New List(Of Process)
    Dim AllowedPrcs As New List(Of Process)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiManager.Start()
        ProcessWatcher.Enabled = My.Settings.StartAtRun
        cb_runatstartup.Checked = My.Settings.StartAtStartup
        cb_enableatrun.Checked = My.Settings.StartAtRun
        If My.Settings.StartAtRun = True Then
            NotifyIcon.ShowBalloonTip(100, "ProcBlock", "Initializing..." & vbCrLf & "Services started automatically", ToolTipIcon.Info)
        Else
            NotifyIcon.ShowBalloonTip(100, "ProcBlock", "Initializing...", ToolTipIcon.Info)
        End If
        If My.Settings.StartAndMinimizeAtStartup Then
            SendToTrayToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub UiManager_Tick(sender As Object, e As EventArgs) Handles UiManager.Tick
        ToolStripStatusPrcsRnng.Text = "Running: " & Process.GetProcesses.Count
        ToolStripStatusDatabaseCount.Text = "Database: " & My.Settings.PrcsDatabase.Count
        ToolStripStatusBlocked.Text = "Blocked: " & BlockedPrcs.Count
        ToolStripStatusAllowedprcs.Text = "Allowed: " & AllowedPrcs.Count
        If ProcessWatcher.Enabled = True Then
            ToolStripStatusWorkMode.Text = "Active"
            ToolStripStatusWorkMode.Image = My.Resources.switch_on_icon
        Else
            ToolStripStatusWorkMode.Text = "Inctive"
            ToolStripStatusWorkMode.Image = My.Resources.switch_off_icon
        End If
    End Sub

    Private Sub LinkChangepsw_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkChangepsw.LinkClicked
        If My.Settings.password = "" Then
            Dim IBD As New Dialogs.InputDialog With {.Content = "Note: Password is case sensitive.", .MainInstruction = "No password is associated with this user, please write one", .UsePasswordMasking = True, .WindowTitle = "ProcBlock"}
            My.Computer.Audio.Play(My.Resources.Audio_Question, AudioPlayMode.Background) : If IBD.ShowDialog <> DialogResult.Cancel Then
                If IBD.Input.Replace(" ", "") = "" Then
                    MessageBox.Show(Me, "Password cannot be empty or filled with spaces", "ProcBlock", MessageBoxButtons.OK, MessageBoxIcon.Warning) : My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
                Else
                    My.Settings.password = IBD.Input
                End If
            End If
        Else
            Dim IBD2 As New Dialogs.InputDialog With {.Content = "Note: Password is case sensitive.", .MainInstruction = "Enter current password.", .UsePasswordMasking = True, .WindowTitle = "ProcBlock"}
            My.Computer.Audio.Play(My.Resources.Audio_Question, AudioPlayMode.Background) : If IBD2.ShowDialog <> DialogResult.Cancel Then
                If IBD2.Input <> My.Settings.password Then
                    MessageBox.Show(Me, "Password doesn't match with current password.", "ProcBlock", MessageBoxButtons.OK, MessageBoxIcon.Warning) : My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
                Else
                    Dim IBD3 As New Dialogs.InputDialog With {.Content = "Note: Password is case sensitive.", .MainInstruction = "Password matched, input new one", .UsePasswordMasking = True, .WindowTitle = "ProcBlock"}
                    My.Computer.Audio.Play(My.Resources.Audio_Question, AudioPlayMode.Background) : If IBD3.ShowDialog <> DialogResult.Cancel Then
                        If IBD3.Input.Replace(" ", "") = "" Then
                            MessageBox.Show(Me, "Password cannot be empty or filled with spaces", "ProcBlock", MessageBoxButtons.OK, MessageBoxIcon.Warning) : My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
                        Else
                            My.Settings.password = IBD3.Input : My.Computer.Audio.Play(My.Resources.AudioOff, AudioPlayMode.Background)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TurnOnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnOnToolStripMenuItem.Click
        If My.Settings.password = "" Then
            Dim ErrorDialog As New Dialogs.TaskDialog With {.AllowDialogCancellation = True, .CenterParent = True, .Content = "You didn't set a password , set one", .MainIcon = Dialogs.TaskDialogIcon.Error, .WindowTitle = "ProcBlock", .MainInstruction = "Do you want to set one now?"}
            Dim YesBTN As New Dialogs.TaskDialogButton With {.Text = "Yes"}
            Dim NoBTN As New Dialogs.TaskDialogButton With {.Text = "No"}
            ErrorDialog.Buttons.Add(YesBTN)
            ErrorDialog.Buttons.Add(NoBTN)
            If ErrorDialog.ShowDialog Is YesBTN Then : My.Computer.Audio.Play(My.Resources.Audio_Question, AudioPlayMode.Background)
                LinkChangepsw_LinkClicked(Nothing, New LinkLabelLinkClickedEventArgs(New LinkLabel.Link(0, 1), MouseButtons.Left))
            End If
        Else
            ProcessWatcher.Start()
            My.Computer.Audio.Play(My.Resources.AudioOn, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub TurnOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnOffToolStripMenuItem.Click
        If My.Settings.password <> "" Then
            Dim IBD As New Dialogs.InputDialog With {.Content = "The password you added at first application run.", .MainInstruction = "Input your password to disable ProcBlock", .UsePasswordMasking = True, .WindowTitle = "ProcBlock"}
            My.Computer.Audio.Play(My.Resources.Audio_Question, AudioPlayMode.Background) : If IBD.ShowDialog <> DialogResult.Cancel Then
                If IBD.Input = My.Settings.password Then
                    ProcessWatcher.Stop()
                    My.Computer.Audio.Play(My.Resources.AudioOff, AudioPlayMode.Background)
                Else
                    My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
                End If
            Else
                My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
            End If
        Else
            ProcessWatcher.Stop()
            My.Computer.Audio.Play(My.Resources.AudioOff, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If ProcessWatcher.Enabled = True Then
            If My.Settings.password <> "" Then
                Dim IBD As New Dialogs.InputDialog With {.Content = "The password you added at first application run.", .MainInstruction = "Input your password to close ProcBlock", .UsePasswordMasking = True, .WindowTitle = "ProcBlock"}
                My.Computer.Audio.Play(My.Resources.Audio_Question, AudioPlayMode.Background) : If IBD.ShowDialog <> DialogResult.Cancel Then
                    If IBD.Input = My.Settings.password Then
                        UiManager.Stop()
                        ProcessWatcher.Stop()
                        My.Computer.Audio.Play(My.Resources.AudioOff, AudioPlayMode.WaitToComplete)
                        Me.Close()
                    Else
                        My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
                    End If
                Else
                    My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
                End If
            Else
                UiManager.Stop()
                ProcessWatcher.Stop()
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub AddProccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProccessToolStripMenuItem.Click
        My.Forms.PrcsManager.Show()
    End Sub
    Dim p() As Process
    Private Sub ProcessWatcher_Tick(sender As Object, e As EventArgs) Handles ProcessWatcher.Tick
        For Each prcs In My.Settings.PrcsDatabase
            p = Process.GetProcessesByName(prcs)
            If p.Count > 0 AndAlso AllowedPrcs.Contains(p(0)) = False Then
                For Each _prcs In p
                    If Hold = False Then
                        SuspendProcess(_prcs)
                    End If
                Next
                If Hold = False Then
                    CheckToAllow(p(0))
                End If
            End If
        Next
    End Sub
    Private Hold As Boolean = False
    Private Sub CheckToAllow(process As Process)
        Hold = True
        Dim IBPsw As New Dialogs.InputDialog With {.MainInstruction = "Enter password to gain access to the app", .Content = "Process is: " & process.MainWindowTitle & "(" & process.ProcessName & ")" & vbCrLf & "Note: Entering the wrong password will kill the process", .WindowTitle = "ProcBlock"}
        My.Computer.Audio.Play(My.Resources.Audio_Question, AudioPlayMode.Background) : If IBPsw.ShowDialog <> DialogResult.Cancel Then
            If My.Settings.password = IBPsw.Input Then
                ResumeProcess(process)
                My.Computer.Audio.Play(My.Resources.AudioOn, AudioPlayMode.Background)
                AllowedPrcs.Add(process)
                Hold = True
            Else
                Try
                    process.Kill()
                    My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
                Catch ex As Exception
                    My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
                    NotifyIcon.ShowBalloonTip(100, "ProcBlock", "Error stopping " & process.ProcessName, ToolTipIcon.Info)
                End Try
                Hold = False
            End If
        Else
            My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
            process.Kill()
            Hold = False
        End If
    End Sub

    Private Sub cb_runatstartup_CheckedChanged(sender As Object, e As EventArgs) Handles cb_runatstartup.CheckedChanged
        If cb_runatstartup.Checked Then
            CreateShortCut(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "ProcBlock.lnk"), "ProcBlock")
        Else
            IO.File.Delete(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "ProcBlock.lnk"))
            My.Settings.StartAtStartup = False
        End If
    End Sub

    Private Sub cb_enableatrun_CheckedChanged(sender As Object, e As EventArgs) Handles cb_enableatrun.CheckedChanged
        My.Settings.StartAtRun = cb_enableatrun.Checked
    End Sub

    Private Sub cb_startminimizeatrun_CheckedChanged(sender As Object, e As EventArgs) Handles cb_startminimizeatrun.CheckedChanged
        My.Settings.StartAndMinimizeAtStartup = cb_startminimizeatrun.Checked
    End Sub

    Private Sub CreateShortCut(ByVal FileName As String, ByVal Title As String)
        Try
            Dim WshShell As New WshShell
            ' short cut files have a .lnk extension
            Dim shortCut As IWshRuntimeLibrary.IWshShortcut = WshShell.CreateShortcut(FileName)
            ' set the shortcut properties
            With shortCut
                .TargetPath = Application.ExecutablePath
                .WindowStyle = 1I
                .Description = Title
                .WorkingDirectory = Application.StartupPath
                ' the next line gets the first Icon from the executing program
                .IconLocation = Application.ExecutablePath & ", 0"
                .Arguments = String.Empty
                .Save() ' save the shortcut file
            End With
            My.Settings.StartAtStartup = True
        Catch ex As System.Exception
            MessageBox.Show("Could not create the shortcut" & Environment.NewLine & ex.Message, "ProcBlock", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Settings.StartAtStartup = False
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ProcessWatcher.Enabled = True Then
            If My.Settings.password <> "" Then
                Dim IBD As New Dialogs.InputDialog With {.Content = "The password you added at first application run.", .MainInstruction = "Input your password to close ProcBlock", .UsePasswordMasking = True, .WindowTitle = "ProcBlock"}
                My.Computer.Audio.Play(My.Resources.Audio_Question, AudioPlayMode.Background) : If IBD.ShowDialog <> DialogResult.Cancel Then
                    If IBD.Input = My.Settings.password Then
                        UiManager.Stop()
                        ProcessWatcher.Stop()
                        My.Computer.Audio.Play(My.Resources.AudioOff, AudioPlayMode.WaitToComplete)
                        e.Cancel = False
                    Else
                        My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
                        e.Cancel = True
                    End If
                Else
                    My.Computer.Audio.Play(My.Resources.Audio_CriticalError, AudioPlayMode.Background)
                    e.Cancel = True
                End If
            Else
                e.Cancel = False
                UiManager.Stop()
                ProcessWatcher.Stop()
            End If
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub SendToTrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendToTrayToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        ExitToolStripMenuItem.PerformClick()
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Me.Show()
    End Sub
End Class
