<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnAdmin = New System.Windows.Forms.Button()
        Me.BtnBoss = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAdmin
        '
        Me.BtnAdmin.BackColor = System.Drawing.Color.MistyRose
        Me.BtnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmin.Location = New System.Drawing.Point(51, 185)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.Size = New System.Drawing.Size(87, 35)
        Me.BtnAdmin.TabIndex = 0
        Me.BtnAdmin.Text = "Admin"
        Me.BtnAdmin.UseVisualStyleBackColor = False
        '
        'BtnBoss
        '
        Me.BtnBoss.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnBoss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBoss.Location = New System.Drawing.Point(169, 185)
        Me.BtnBoss.Name = "BtnBoss"
        Me.BtnBoss.Size = New System.Drawing.Size(87, 35)
        Me.BtnBoss.TabIndex = 1
        Me.BtnBoss.Text = "Boss"
        Me.BtnBoss.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "     Welcome to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nifanatt Book Store"
        '
        'BtnCus
        '
        Me.BtnCus.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCus.Location = New System.Drawing.Point(289, 185)
        Me.BtnCus.Name = "BtnCus"
        Me.BtnCus.Size = New System.Drawing.Size(87, 35)
        Me.BtnCus.TabIndex = 3
        Me.BtnCus.Text = "Customer"
        Me.BtnCus.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(438, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBoss)
        Me.Controls.Add(Me.BtnAdmin)
        Me.Name = "Form1"
        Me.Text = "Nifanatt Book Store System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAdmin As Button
    Friend WithEvents BtnBoss As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCus As Button
End Class
