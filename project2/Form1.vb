Public Class Form1
    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        Dim Login As New Login()

        Login.Show()
        Me.Hide()

    End Sub

    Private Sub BtnBoss_Click(sender As Object, e As EventArgs) Handles BtnBoss.Click
        Dim Login As New Login()

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCus_Click(sender As Object, e As EventArgs) Handles BtnCus.Click
        Dim Login As New Login()

        Login.Show()
        Me.Hide()
    End Sub
End Class
