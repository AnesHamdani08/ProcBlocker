Public Class ProcessPickervb
    Public SelectedProcess As Object 'Process or String
    Public SelectedProcessIsProcess As Boolean = True
    Public PrcsList As Process()
    Public Overloads Property DialogResult As DialogResult
    Private AppClosing As Boolean = False
    Private Sub ProcessPickervb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListPrcssPicker.Items.Clear()
        PrcsList = Process.GetProcesses
        For Each prcs In PrcsList
            If prcs IsNot Nothing Then
                ListPrcssPicker.Items.Add(prcs.ProcessName & "(" & prcs.MainWindowTitle & ")")
            End If
        Next
    End Sub
    Private Sub DBAddpicker_Click(sender As Object, e As EventArgs) Handles DBAddpicker.Click
        If ListPrcssPicker.SelectedIndex = -1 Then
            MessageBox.Show(Me, "Please select a process first.", "Process picker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            SelectedProcess = PrcsList(ListPrcssPicker.SelectedIndex)
            SelectedProcessIsProcess = True
            DialogResult = System.Windows.Forms.DialogResult.OK
            AppClosing = True
            Me.Close()
        End If
    End Sub

    Private Sub DB_Add_Browse_Click(sender As Object, e As EventArgs) Handles DB_Add_Browse.Click
        If OpenFileDialog.ShowDialog <> System.Windows.Forms.DialogResult.Cancel Then
            SelectedProcess = IO.Path.GetFileNameWithoutExtension(OpenFileDialog.FileName)
            SelectedProcessIsProcess = False
            DialogResult = System.Windows.Forms.DialogResult.OK
            AppClosing = True
            Me.Close()
        End If
    End Sub

    Private Sub ProcessPickervb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If AppClosing = False Then
            DialogResult = System.Windows.Forms.DialogResult.Cancel
        End If
        AppClosing = False
    End Sub
End Class