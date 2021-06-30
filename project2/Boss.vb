Public Class Boss
    Private Sub Boss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadDataFromDB()
    End Sub

    Public Sub ReadDataFromDB()
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMySQL
        Try
            retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM owner")
            If retrieveTable.CreateDataReader.HasRows = False Then
                MessageBox.Show("Data Not Found!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim row As DataRow
            dgvBoss.Rows.Clear()
            Dim Bil As Integer
            Bil = 1
            For Each row In retrieveTable.Rows
                dgvBoss.Rows.Add(Bil, row("idowner"), row("nameowner"), row("position"), row("phoneNum"), row("gender"), row("dateInCharge"))
                Bil = Bil + 1
            Next
            retrieveTable = Nothing
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvBoss_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBoss.CellContentClick
        Dim strIdboss As String
        If e.RowIndex < 0 Then Exit Sub
        strIdboss = dgvBoss.Item(1, e.RowIndex).Value.ToString()
        UpdateBoss.idBoss = CInt(strIdboss)
        Dim Result As New ArrayList
        Dim retrieveRow As New VBMySQL
        Dim strSql As String = "SELECT * FROM owner WHERE idowner = " & strIdboss
        Try
            Result = retrieveRow.Retrieve_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        For Each row As Dictionary(Of String, Object) In Result
            With UpdateBoss
                .txtName.Text = row("nameowner").ToString()
                .txtPosition.Text = row("position").ToString()
                .txtphoneNum.Text = row("phoneNum").ToString()
                .txtGender.Text = row("gender").ToString()
                .txtdateInCharge.Text = row("dateInCharge").ToString()
            End With
        Next
        Me.Hide()
        UpdateBoss.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strName As String = txtName.Text
        Dim strPosition As String = txtPosition.Text
        Dim strphoneNum As String = txtphoneNum.Text
        Dim strGender As String = txtGender.Text
        Dim strdateInCharge As String = txtdateInCharge.Text
        Dim strSql = "INSERT INTO owner VALUES (null, '" & strName & "', '" & strPosition & "', '" & strphoneNum & "', '" & strGender & "', '" & strdateInCharge & "')"
        Dim CreateMySQL As New VBMySQL
        Try
            CreateMySQL.Insert_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Process read data failed!" & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.ReadDataFromDB()
            btnCancel_Click(sender, e)
        End Try

        Me.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtName.Clear()
        txtPosition.Clear()
        txtphoneNum.Clear()
        txtGender.Clear()
        txtdateInCharge.Clear()
        Me.Hide()
        'Me.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtName.Show()
        txtPosition.Clear()
        txtphoneNum.Clear()
        txtGender.Clear()
        txtdateInCharge.Clear()
        Me.Hide()
        UpdateBoss.Show()
    End Sub


End Class