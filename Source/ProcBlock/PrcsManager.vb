Public Class PrcsManager
    Private Sub PrcsManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each prcs In My.Settings.PrcsDatabase
            ListPrcs.Items.Add(prcs)
        Next
    End Sub
    Private Sub DBAdd_Click(sender As Object, e As EventArgs) Handles DBAdd.Click
        My.Forms.ProcessPickervb.ShowDialog()
        If My.Forms.ProcessPickervb.DialogResult = DialogResult.OK Then
            If My.Forms.ProcessPickervb.SelectedProcessIsProcess Then
                My.Settings.PrcsDatabase.Add(My.Forms.ProcessPickervb.SelectedProcess.ProcessName)
                ListPrcs.Items.Add(My.Forms.ProcessPickervb.SelectedProcess.ProcessName)
            Else
                My.Settings.PrcsDatabase.Add(My.Forms.ProcessPickervb.SelectedProcess)
                ListPrcs.Items.Add(My.Forms.ProcessPickervb.SelectedProcess)
            End If
        End If
    End Sub

    Private Sub DBRemove_Click(sender As Object, e As EventArgs) Handles DBRemove.Click
        If ListPrcs.SelectedIndex = -1 Then
            MessageBox.Show(Me, "Please select a process first.", "Process picker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim SelectedIndex = ListPrcs.SelectedIndex
            ListPrcs.ClearSelected()
            My.Settings.PrcsDatabase.Remove(ListPrcs.Items.Item(SelectedIndex))
            ListPrcs.Items.Remove(ListPrcs.Items.Item(SelectedIndex))
        End If
    End Sub

    Private Sub DBClear_Click(sender As Object, e As EventArgs) Handles DBClear.Click
        Dim result = MessageBox.Show(Me, "Are you sure you want to clear database ?", "ProcBlock", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            My.Settings.PrcsDatabase.Clear()
            ListPrcs.Items.Clear()
        ElseIf result = DialogResult.No Or result = DialogResult.Cancel Then

        End If
    End Sub
End Class