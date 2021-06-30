Public Class BookHome
    Private Sub BossToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BossToolStripMenuItem.Click
        Boss.ShowDialog()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Staff.ShowDialog()
    End Sub


    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        Me.Close()
        CustomerHome.ShowDialog()

    End Sub

    Private Sub BookHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to Exit?", "Nifanatt Book Store System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = vbYes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Abt.ShowDialog()
    End Sub
End Class