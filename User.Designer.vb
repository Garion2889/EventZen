<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label3 = New Label()
        Panel1 = New Panel()
        viewregeventpanel = New Panel()
        Label1 = New Label()
        exitBtn = New Button()
        regtable = New DataGridView()
        Button1 = New Button()
        registerevent = New Button()
        Button3 = New Button()
        UserEventTableView = New DataGridView()
        eventCode = New DataGridViewTextBoxColumn()
        eventName = New DataGridViewTextBoxColumn()
        eventDate = New DataGridViewTextBoxColumn()
        eventLocation = New DataGridViewTextBoxColumn()
        eventDesc = New DataGridViewTextBoxColumn()
        availability = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        viewregeventpanel.SuspendLayout()
        CType(regtable, ComponentModel.ISupportInitialize).BeginInit()
        CType(UserEventTableView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label3.Location = New Point(438, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(336, 86)
        Label3.TabIndex = 2
        Label3.Text = "EventZen"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(viewregeventpanel)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(registerevent)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(UserEventTableView)
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1244, 661)
        Panel1.TabIndex = 3
        ' 
        ' viewregeventpanel
        ' 
        viewregeventpanel.Controls.Add(Label1)
        viewregeventpanel.Controls.Add(exitBtn)
        viewregeventpanel.Controls.Add(regtable)
        viewregeventpanel.Location = New Point(204, 120)
        viewregeventpanel.Name = "viewregeventpanel"
        viewregeventpanel.Size = New Size(862, 332)
        viewregeventpanel.TabIndex = 13
        viewregeventpanel.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(375, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 15)
        Label1.TabIndex = 12
        Label1.Text = "Registered Events"
        ' 
        ' exitBtn
        ' 
        exitBtn.Location = New Point(750, 294)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(75, 23)
        exitBtn.TabIndex = 11
        exitBtn.Text = "Exit"
        exitBtn.UseVisualStyleBackColor = True
        ' 
        ' regtable
        ' 
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        regtable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        regtable.BackgroundColor = Color.White
        regtable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        regtable.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, Column7, DataGridViewTextBoxColumn6})
        regtable.Location = New Point(40, 51)
        regtable.Margin = New Padding(3, 2, 3, 2)
        regtable.Name = "regtable"
        regtable.ReadOnly = True
        regtable.RowHeadersWidth = 51
        regtable.Size = New Size(785, 238)
        regtable.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(955, 589)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 23)
        Button1.TabIndex = 12
        Button1.Text = "View Event Registered"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' registerevent
        ' 
        registerevent.Location = New Point(863, 589)
        registerevent.Name = "registerevent"
        registerevent.Size = New Size(75, 23)
        registerevent.TabIndex = 11
        registerevent.Text = "Register"
        registerevent.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1091, 664)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 44)
        Button3.TabIndex = 10
        Button3.Text = "Register"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' UserEventTableView
        ' 
        UserEventTableView.BackgroundColor = Color.White
        UserEventTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        UserEventTableView.Columns.AddRange(New DataGridViewColumn() {eventCode, eventName, eventDate, eventLocation, eventDesc, availability})
        UserEventTableView.Location = New Point(146, 151)
        UserEventTableView.Margin = New Padding(3, 2, 3, 2)
        UserEventTableView.Name = "UserEventTableView"
        UserEventTableView.RowHeadersWidth = 51
        UserEventTableView.Size = New Size(952, 433)
        UserEventTableView.TabIndex = 3
        ' 
        ' eventCode
        ' 
        eventCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        eventCode.HeaderText = "Code"
        eventCode.MinimumWidth = 6
        eventCode.Name = "eventCode"
        eventCode.ReadOnly = True
        ' 
        ' eventName
        ' 
        eventName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        eventName.HeaderText = "Event"
        eventName.MinimumWidth = 6
        eventName.Name = "eventName"
        eventName.ReadOnly = True
        ' 
        ' eventDate
        ' 
        eventDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        eventDate.HeaderText = "Date"
        eventDate.MinimumWidth = 6
        eventDate.Name = "eventDate"
        eventDate.ReadOnly = True
        ' 
        ' eventLocation
        ' 
        eventLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        eventLocation.HeaderText = "Location"
        eventLocation.MinimumWidth = 6
        eventLocation.Name = "eventLocation"
        eventLocation.ReadOnly = True
        ' 
        ' eventDesc
        ' 
        eventDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        eventDesc.HeaderText = "Description"
        eventDesc.MinimumWidth = 6
        eventDesc.Name = "eventDesc"
        eventDesc.ReadOnly = True
        ' 
        ' availability
        ' 
        availability.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        availability.HeaderText = "Availability"
        availability.Name = "availability"
        availability.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewTextBoxColumn1.HeaderText = "Registered ID"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 101
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewTextBoxColumn2.HeaderText = "UID"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 51
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn3.HeaderText = "Username"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewTextBoxColumn4.HeaderText = "Event Code"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        DataGridViewTextBoxColumn4.Width = 92
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewTextBoxColumn5.HeaderText = "Event"
        DataGridViewTextBoxColumn5.MinimumWidth = 6
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.ReadOnly = True
        DataGridViewTextBoxColumn5.Width = 129
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Event Date"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn6.HeaderText = "Date Registered"
        DataGridViewTextBoxColumn6.MinimumWidth = 6
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.ReadOnly = True
        ' 
        ' User
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(247), CByte(244))
        ClientSize = New Size(1244, 661)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "User"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        viewregeventpanel.ResumeLayout(False)
        viewregeventpanel.PerformLayout()
        CType(regtable, ComponentModel.ISupportInitialize).EndInit()
        CType(UserEventTableView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserEventTableView As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents registerevent As Button
    Friend WithEvents viewregeventpanel As Panel
    Friend WithEvents regtable As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents exitBtn As Button
    Friend WithEvents eventCode As DataGridViewTextBoxColumn
    Friend WithEvents eventName As DataGridViewTextBoxColumn
    Friend WithEvents eventDate As DataGridViewTextBoxColumn
    Friend WithEvents eventLocation As DataGridViewTextBoxColumn
    Friend WithEvents eventDesc As DataGridViewTextBoxColumn
    Friend WithEvents availability As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
