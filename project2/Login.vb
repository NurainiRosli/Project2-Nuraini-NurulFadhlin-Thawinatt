Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            MessageBox.Show("Login Sucessfully!")
            BookHome.Show()
            Hide()

        ElseIf txtUsername.Text = "boss" And txtPassword.Text = "boss" Then
            MessageBox.Show("Login Sucessfully!")
            BookHome.Show()
            Hide()

        ElseIf txtUsername.Text = "customer" And txtPassword.Text = "customer" Then
            MessageBox.Show("Login Sucessfully!")
            CustomerHome.Show()
            Hide()
        Else
            MessageBox.Show("Login Failed!")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

End Class