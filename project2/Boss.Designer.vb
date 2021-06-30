<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boss
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtdateInCharge = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtphoneNum = New System.Windows.Forms.TextBox()
        Me.lblphoneNum = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvBoss = New System.Windows.Forms.DataGridView()
        Me.idboss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameboss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phoneNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateInCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelPATIENT = New System.Windows.Forms.Label()
        CType(Me.dgvBoss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdateInCharge
        '
        Me.txtdateInCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtdateInCharge.Location = New System.Drawing.Point(575, 226)
        Me.txtdateInCharge.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdateInCharge.Name = "txtdateInCharge"
        Me.txtdateInCharge.Size = New System.Drawing.Size(124, 24)
        Me.txtdateInCharge.TabIndex = 195
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtPosition.Location = New System.Drawing.Point(194, 228)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(167, 24)
        Me.txtPosition.TabIndex = 196
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtID.Location = New System.Drawing.Point(194, 131)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(101, 24)
        Me.txtID.TabIndex = 206
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.MistyRose
        Me.lblID.Font = New System.Drawing.Font("Meiryo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(114, 132)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(76, 24)
        Me.lblID.TabIndex = 205
        Me.lblID.Text = "Boss ID"
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtGender.Location = New System.Drawing.Point(575, 178)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(124, 24)
        Me.txtGender.TabIndex = 204
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtName.Location = New System.Drawing.Point(194, 178)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(167, 24)
        Me.txtName.TabIndex = 194
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.MistyRose
        Me.lblDate.Font = New System.Drawing.Font("Meiryo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(442, 228)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(129, 23)
        Me.lblDate.TabIndex = 193
        Me.lblDate.Text = "Date In Charge"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.MistyRose
        Me.lblPosition.Font = New System.Drawing.Font("Meiryo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(116, 228)
        Me.lblPosition.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(74, 23)
        Me.lblPosition.TabIndex = 192
        Me.lblPosition.Text = "Position"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.MistyRose
        Me.lblName.Font = New System.Drawing.Font("Meiryo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(135, 178)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 23)
        Me.lblName.TabIndex = 191
        Me.lblName.Text = "Name"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.MistyRose
        Me.lblGender.Font = New System.Drawing.Font("Meiryo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(504, 178)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(67, 23)
        Me.lblGender.TabIndex = 203
        Me.lblGender.Text = "Gender"
        '
        'txtphoneNum
        '
        Me.txtphoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtphoneNum.Location = New System.Drawing.Point(575, 132)
        Me.txtphoneNum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtphoneNum.Name = "txtphoneNum"
        Me.txtphoneNum.Size = New System.Drawing.Size(167, 24)
        Me.txtphoneNum.TabIndex = 202
        '
        'lblphoneNum
        '
        Me.lblphoneNum.AutoSize = True
        Me.lblphoneNum.BackColor = System.Drawing.Color.MistyRose
        Me.lblphoneNum.Font = New System.Drawing.Font("Meiryo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphoneNum.Location = New System.Drawing.Point(480, 131)
        Me.lblphoneNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblphoneNum.Name = "lblphoneNum"
        Me.lblphoneNum.Size = New System.Drawing.Size(91, 23)
        Me.lblphoneNum.TabIndex = 201
        Me.lblphoneNum.Text = "Phone No."
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SandyBrown
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Transparent
        Me.btnCancel.Location = New System.Drawing.Point(547, 539)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 40)
        Me.btnCancel.TabIndex = 200
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.SandyBrown
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Transparent
        Me.btnUpdate.Location = New System.Drawing.Point(394, 539)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(87, 40)
        Me.btnUpdate.TabIndex = 199
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SandyBrown
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Transparent
        Me.btnAdd.Location = New System.Drawing.Point(227, 539)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 40)
        Me.btnAdd.TabIndex = 198
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'dgvBoss
        '
        Me.dgvBoss.AllowUserToAddRows = False
        Me.dgvBoss.BackgroundColor = System.Drawing.Color.Wheat
        Me.dgvBoss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBoss.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idboss, Me.bil, Me.nameboss, Me.position, Me.phoneNum, Me.gender, Me.dateInCharge})
        Me.dgvBoss.Location = New System.Drawing.Point(47, 334)
        Me.dgvBoss.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvBoss.Name = "dgvBoss"
        Me.dgvBoss.RowHeadersWidth = 51
        Me.dgvBoss.RowTemplate.Height = 24
        Me.dgvBoss.Size = New System.Drawing.Size(804, 155)
        Me.dgvBoss.TabIndex = 197
        '
        'idboss
        '
        Me.idboss.HeaderText = "idboss"
        Me.idboss.MinimumWidth = 6
        Me.idboss.Name = "idboss"
        Me.idboss.Visible = False
        Me.idboss.Width = 125
        '
        'bil
        '
        Me.bil.HeaderText = "Bil"
        Me.bil.MinimumWidth = 6
        Me.bil.Name = "bil"
        Me.bil.Width = 125
        '
        'nameboss
        '
        Me.nameboss.HeaderText = "Name"
        Me.nameboss.MinimumWidth = 6
        Me.nameboss.Name = "nameboss"
        Me.nameboss.Width = 125
        '
        'position
        '
        Me.position.HeaderText = "Position"
        Me.position.MinimumWidth = 6
        Me.position.Name = "position"
        Me.position.Width = 125
        '
        'phoneNum
        '
        Me.phoneNum.HeaderText = "Phone No."
        Me.phoneNum.MinimumWidth = 6
        Me.phoneNum.Name = "phoneNum"
        Me.phoneNum.Width = 125
        '
        'gender
        '
        Me.gender.HeaderText = "Gender"
        Me.gender.MinimumWidth = 6
        Me.gender.Name = "gender"
        Me.gender.Width = 125
        '
        'dateInCharge
        '
        Me.dateInCharge.HeaderText = "Date In Charge"
        Me.dateInCharge.MinimumWidth = 6
        Me.dateInCharge.Name = "dateInCharge"
        Me.dateInCharge.Width = 125
        '
        'LabelPATIENT
        '
        Me.LabelPATIENT.AutoSize = True
        Me.LabelPATIENT.BackColor = System.Drawing.Color.Wheat
        Me.LabelPATIENT.Font = New System.Drawing.Font("Segoe Print", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPATIENT.ForeColor = System.Drawing.Color.Black
        Me.LabelPATIENT.Location = New System.Drawing.Point(316, 20)
        Me.LabelPATIENT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPATIENT.Name = "LabelPATIENT"
        Me.LabelPATIENT.Size = New System.Drawing.Size(255, 51)
        Me.LabelPATIENT.TabIndex = 190
        Me.LabelPATIENT.Text = "BOSS  DETAILS"
        '
        'Boss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.project2.My.Resources.Resources.boook__2_
        Me.ClientSize = New System.Drawing.Size(888, 620)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtdateInCharge)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtphoneNum)
        Me.Controls.Add(Me.lblphoneNum)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvBoss)
        Me.Controls.Add(Me.LabelPATIENT)
        Me.Name = "Boss"
        Me.Text = "Boss"
        CType(Me.dgvBoss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtdateInCharge As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtphoneNum As TextBox
    Friend WithEvents lblphoneNum As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvBoss As DataGridView
    Friend WithEvents idboss As DataGridViewTextBoxColumn
    Friend WithEvents bil As DataGridViewTextBoxColumn
    Friend WithEvents nameboss As DataGridViewTextBoxColumn
    Friend WithEvents position As DataGridViewTextBoxColumn
    Friend WithEvents phoneNum As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents dateInCharge As DataGridViewTextBoxColumn
    Friend WithEvents LabelPATIENT As Label
End Class
