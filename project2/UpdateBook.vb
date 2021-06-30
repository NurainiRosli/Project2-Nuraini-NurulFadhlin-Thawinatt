Public Class UpdateBook
    Public idBook As Integer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strCode As String = txtCode.Text
        Dim strName As String = txtName.Text
        Dim strQuantity As String = txtQuantity.Text
        Dim strType As String = txtType.Text

        Dim strSql = "UPDATE book SET itemCode = '" & strCode & "', nameB = '" & strName & "',
        quantity = '" & strQuantity & "', type = '" & strType & "' WHERE idbook = " & idBook
        Dim UpdateMySQL As New VBMySQL
        Try
            UpdateMySQL.Insert_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process save data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Boss.ReadDataFromDB()
            btnCancel_Click(sender, e)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtCode.Clear()
        txtName.Clear()
        txtQuantity.Clear()
        txtType.Clear()
        Me.Hide()
        Book.Show()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim DeleteMySQL As New VBMySQL
        Dim strSql As String = "DELETE FROM book WHERE idbook = " & idBook
        Try
            DeleteMySQL.Delete_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process delete data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Boss.ReadDataFromDB()
            btnCancel_Click(sender, e)
        End Try

    End Sub


End Class