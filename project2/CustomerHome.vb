Public Class CustomerHome
    Private Sub CustomerDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerDataToolStripMenuItem.Click
        CustomerData.ShowDialog()
    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        Book.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Abt.ShowDialog()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        BookList.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to Exit?", "Nifanatt Book Store System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = vbYes) Then
            Application.Exit()
        End If
    End Sub
End Class