<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        passwordtxt = New TextBox()
        Label2 = New Label()
        usernametxt = New TextBox()
        registerBtn = New Button()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        conpasstxt = New TextBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(144, 426)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 17)
        Label5.TabIndex = 27
        Label5.Text = "Login"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(24, 425)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 15)
        Label4.TabIndex = 26
        Label4.Text = "Already a Member?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label3.Location = New Point(30, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 17)
        Label3.TabIndex = 25
        Label3.Text = "Password"
        ' 
        ' passwordtxt
        ' 
        passwordtxt.BackColor = Color.FromArgb(CByte(248), CByte(245), CByte(246))
        passwordtxt.BorderStyle = BorderStyle.FixedSingle
        passwordtxt.Location = New Point(30, 259)
        passwordtxt.Margin = New Padding(3, 2, 3, 2)
        passwordtxt.Name = "passwordtxt"
        passwordtxt.PasswordChar = "*"c
        passwordtxt.Size = New Size(271, 23)
        passwordtxt.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label2.Location = New Point(30, 188)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 17)
        Label2.TabIndex = 23
        Label2.Text = "Username"
        ' 
        ' usernametxt
        ' 
        usernametxt.BackColor = Color.FromArgb(CByte(248), CByte(245), CByte(246))
        usernametxt.BorderStyle = BorderStyle.FixedSingle
        usernametxt.Location = New Point(30, 210)
        usernametxt.Margin = New Padding(3, 2, 3, 2)
        usernametxt.Name = "usernametxt"
        usernametxt.Size = New Size(271, 23)
        usernametxt.TabIndex = 22
        ' 
        ' registerBtn
        ' 
        registerBtn.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        registerBtn.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        registerBtn.ForeColor = Color.Transparent
        registerBtn.Location = New Point(282, 400)
        registerBtn.Margin = New Padding(3, 2, 3, 2)
        registerBtn.Name = "registerBtn"
        registerBtn.Size = New Size(129, 37)
        registerBtn.TabIndex = 21
        registerBtn.Text = "Register"
        registerBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label1.Location = New Point(22, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 30)
        Label1.TabIndex = 20
        Label1.Text = "Register"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.TopBg
        PictureBox2.Location = New Point(-8, -2)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(516, 426)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 19
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.BottomBg
        PictureBox1.Location = New Point(-8, 332)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(516, 157)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label6.Location = New Point(30, 295)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 17)
        Label6.TabIndex = 29
        Label6.Text = "Confirm Password"
        ' 
        ' conpasstxt
        ' 
        conpasstxt.BackColor = Color.FromArgb(CByte(248), CByte(245), CByte(246))
        conpasstxt.BorderStyle = BorderStyle.FixedSingle
        conpasstxt.Location = New Point(30, 316)
        conpasstxt.Margin = New Padding(3, 2, 3, 2)
        conpasstxt.Name = "conpasstxt"
        conpasstxt.PasswordChar = "*"c
        conpasstxt.Size = New Size(271, 23)
        conpasstxt.TabIndex = 28
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 447)
        Controls.Add(Label6)
        Controls.Add(conpasstxt)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(passwordtxt)
        Controls.Add(Label2)
        Controls.Add(usernametxt)
        Controls.Add(registerBtn)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents registerBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents conpasstxt As TextBox
End Class
