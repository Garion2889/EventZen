<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Button1 = New Button()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        usernamelogin = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        passwordlogin = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Button1.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(282, 400)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 37)
        Button1.TabIndex = 11
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label1.Location = New Point(22, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 30)
        Label1.TabIndex = 8
        Label1.Text = "Login"
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
        PictureBox2.TabIndex = 7
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
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' usernamelogin
        ' 
        usernamelogin.BackColor = Color.FromArgb(CByte(248), CByte(245), CByte(246))
        usernamelogin.BorderStyle = BorderStyle.FixedSingle
        usernamelogin.Location = New Point(30, 215)
        usernamelogin.Margin = New Padding(3, 2, 3, 2)
        usernamelogin.Name = "usernamelogin"
        usernamelogin.Size = New Size(271, 23)
        usernamelogin.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label2.Location = New Point(30, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 17)
        Label2.TabIndex = 13
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label3.Location = New Point(30, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 17)
        Label3.TabIndex = 15
        Label3.Text = "Password"
        ' 
        ' passwordlogin
        ' 
        passwordlogin.BackColor = Color.FromArgb(CByte(248), CByte(245), CByte(246))
        passwordlogin.BorderStyle = BorderStyle.FixedSingle
        passwordlogin.Location = New Point(30, 264)
        passwordlogin.Margin = New Padding(3, 2, 3, 2)
        passwordlogin.Name = "passwordlogin"
        passwordlogin.PasswordChar = "*"c
        passwordlogin.Size = New Size(271, 23)
        passwordlogin.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(24, 425)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 16
        Label4.Text = "New Here?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(95, 426)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 17)
        Label5.TabIndex = 17
        Label5.Text = "Register"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 447)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(passwordlogin)
        Controls.Add(Label2)
        Controls.Add(usernamelogin)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EventZen"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents usernamelogin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents passwordlogin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
