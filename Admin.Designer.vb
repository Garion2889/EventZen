<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        eventPage = New TabPage()
        modifypanel = New Panel()
        Label17 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        updateavailtxt = New TextBox()
        updatedesctxt = New RichTextBox()
        updatelocationtxt = New TextBox()
        updatedatetxt = New TextBox()
        updateeventtxt = New TextBox()
        modifycancelBtn = New Button()
        modifyclearBtn = New Button()
        modifyeventbtn = New Button()
        addeventpanel = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        addavailtxt = New TextBox()
        adddesctxt = New RichTextBox()
        addlocationtxt = New TextBox()
        adddatetxt = New TextBox()
        addeventtxt = New TextBox()
        canceladdBtn = New Button()
        clearBtn = New Button()
        addeventBtn = New Button()
        loadeventBtn = New Button()
        dlteventBtn = New Button()
        modifyeventpanelBtn = New Button()
        addeventpanelBtn = New Button()
        Button3 = New Button()
        admineventview = New DataGridView()
        eventcode = New DataGridViewTextBoxColumn()
        eventName = New DataGridViewTextBoxColumn()
        eventDate = New DataGridViewTextBoxColumn()
        eventLocation = New DataGridViewTextBoxColumn()
        eventDesc = New DataGridViewTextBoxColumn()
        availability = New DataGridViewTextBoxColumn()
        Panel5 = New Panel()
        Label7 = New Label()
        labelSeats = New Label()
        Panel4 = New Panel()
        Label5 = New Label()
        registerquantity = New Label()
        Panel3 = New Panel()
        Label2 = New Label()
        eventquantity = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        managePage = New TabPage()
        regRefreshBtn = New Button()
        regtable = New DataGridView()
        Label4 = New Label()
        Panel6 = New Panel()
        panelSidebar = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Column6 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        eventPage.SuspendLayout()
        modifypanel.SuspendLayout()
        addeventpanel.SuspendLayout()
        CType(admineventview, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        managePage.SuspendLayout()
        CType(regtable, ComponentModel.ISupportInitialize).BeginInit()
        panelSidebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TabControl1)
        Panel1.Controls.Add(panelSidebar)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1244, 661)
        Panel1.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.Controls.Add(eventPage)
        TabControl1.Controls.Add(managePage)
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.Location = New Point(316, 0)
        TabControl1.Margin = New Padding(0)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(0, 0)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(928, 661)
        TabControl1.TabIndex = 0
        TabControl1.TabStop = False
        ' 
        ' eventPage
        ' 
        eventPage.Controls.Add(modifypanel)
        eventPage.Controls.Add(addeventpanel)
        eventPage.Controls.Add(loadeventBtn)
        eventPage.Controls.Add(dlteventBtn)
        eventPage.Controls.Add(modifyeventpanelBtn)
        eventPage.Controls.Add(addeventpanelBtn)
        eventPage.Controls.Add(Button3)
        eventPage.Controls.Add(admineventview)
        eventPage.Controls.Add(Panel5)
        eventPage.Controls.Add(Panel4)
        eventPage.Controls.Add(Panel3)
        eventPage.Controls.Add(Label3)
        eventPage.Controls.Add(Panel2)
        eventPage.Location = New Point(4, 5)
        eventPage.Margin = New Padding(3, 2, 3, 2)
        eventPage.Name = "eventPage"
        eventPage.Padding = New Padding(3, 2, 3, 2)
        eventPage.Size = New Size(920, 652)
        eventPage.TabIndex = 0
        eventPage.Text = "eventpage"
        eventPage.UseVisualStyleBackColor = True
        ' 
        ' modifypanel
        ' 
        modifypanel.Controls.Add(Label17)
        modifypanel.Controls.Add(Label12)
        modifypanel.Controls.Add(Label13)
        modifypanel.Controls.Add(Label14)
        modifypanel.Controls.Add(Label15)
        modifypanel.Controls.Add(Label16)
        modifypanel.Controls.Add(updateavailtxt)
        modifypanel.Controls.Add(updatedesctxt)
        modifypanel.Controls.Add(updatelocationtxt)
        modifypanel.Controls.Add(updatedatetxt)
        modifypanel.Controls.Add(updateeventtxt)
        modifypanel.Controls.Add(modifycancelBtn)
        modifypanel.Controls.Add(modifyclearBtn)
        modifypanel.Controls.Add(modifyeventbtn)
        modifypanel.Location = New Point(78, 234)
        modifypanel.Name = "modifypanel"
        modifypanel.Size = New Size(498, 268)
        modifypanel.TabIndex = 15
        modifypanel.Visible = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(220, 11)
        Label17.Name = "Label17"
        Label17.Size = New Size(77, 15)
        Label17.TabIndex = 13
        Label17.Text = "Modify Event"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(30, 203)
        Label12.Name = "Label12"
        Label12.Size = New Size(65, 15)
        Label12.TabIndex = 12
        Label12.Text = "Availability"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(30, 130)
        Label13.Name = "Label13"
        Label13.Size = New Size(67, 15)
        Label13.TabIndex = 11
        Label13.Text = "Description"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(30, 101)
        Label14.Name = "Label14"
        Label14.Size = New Size(53, 15)
        Label14.TabIndex = 10
        Label14.Text = "Location"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(30, 72)
        Label15.Name = "Label15"
        Label15.Size = New Size(31, 15)
        Label15.TabIndex = 9
        Label15.Text = "Date"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(30, 43)
        Label16.Name = "Label16"
        Label16.Size = New Size(36, 15)
        Label16.TabIndex = 8
        Label16.Text = "Event"
        ' 
        ' updateavailtxt
        ' 
        updateavailtxt.Location = New Point(116, 200)
        updateavailtxt.Name = "updateavailtxt"
        updateavailtxt.Size = New Size(100, 23)
        updateavailtxt.TabIndex = 7
        ' 
        ' updatedesctxt
        ' 
        updatedesctxt.Location = New Point(116, 127)
        updatedesctxt.Name = "updatedesctxt"
        updatedesctxt.Size = New Size(318, 67)
        updatedesctxt.TabIndex = 6
        updatedesctxt.Text = ""
        ' 
        ' updatelocationtxt
        ' 
        updatelocationtxt.Location = New Point(116, 98)
        updatelocationtxt.Name = "updatelocationtxt"
        updatelocationtxt.Size = New Size(318, 23)
        updatelocationtxt.TabIndex = 5
        ' 
        ' updatedatetxt
        ' 
        updatedatetxt.Location = New Point(116, 69)
        updatedatetxt.Name = "updatedatetxt"
        updatedatetxt.Size = New Size(318, 23)
        updatedatetxt.TabIndex = 4
        ' 
        ' updateeventtxt
        ' 
        updateeventtxt.Location = New Point(116, 40)
        updateeventtxt.Name = "updateeventtxt"
        updateeventtxt.Size = New Size(318, 23)
        updateeventtxt.TabIndex = 3
        ' 
        ' modifycancelBtn
        ' 
        modifycancelBtn.Location = New Point(359, 233)
        modifycancelBtn.Name = "modifycancelBtn"
        modifycancelBtn.Size = New Size(75, 23)
        modifycancelBtn.TabIndex = 2
        modifycancelBtn.Text = "Cancel"
        modifycancelBtn.UseVisualStyleBackColor = True
        ' 
        ' modifyclearBtn
        ' 
        modifyclearBtn.Location = New Point(278, 233)
        modifyclearBtn.Name = "modifyclearBtn"
        modifyclearBtn.Size = New Size(75, 23)
        modifyclearBtn.TabIndex = 1
        modifyclearBtn.Text = "Clear"
        modifyclearBtn.UseVisualStyleBackColor = True
        ' 
        ' modifyeventbtn
        ' 
        modifyeventbtn.Location = New Point(197, 233)
        modifyeventbtn.Name = "modifyeventbtn"
        modifyeventbtn.Size = New Size(75, 23)
        modifyeventbtn.TabIndex = 0
        modifyeventbtn.Text = "Modify"
        modifyeventbtn.UseVisualStyleBackColor = True
        ' 
        ' addeventpanel
        ' 
        addeventpanel.Controls.Add(Label11)
        addeventpanel.Controls.Add(Label10)
        addeventpanel.Controls.Add(Label9)
        addeventpanel.Controls.Add(Label8)
        addeventpanel.Controls.Add(Label6)
        addeventpanel.Controls.Add(addavailtxt)
        addeventpanel.Controls.Add(adddesctxt)
        addeventpanel.Controls.Add(addlocationtxt)
        addeventpanel.Controls.Add(adddatetxt)
        addeventpanel.Controls.Add(addeventtxt)
        addeventpanel.Controls.Add(canceladdBtn)
        addeventpanel.Controls.Add(clearBtn)
        addeventpanel.Controls.Add(addeventBtn)
        addeventpanel.Location = New Point(81, 234)
        addeventpanel.Name = "addeventpanel"
        addeventpanel.Size = New Size(498, 268)
        addeventpanel.TabIndex = 14
        addeventpanel.Visible = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(30, 203)
        Label11.Name = "Label11"
        Label11.Size = New Size(65, 15)
        Label11.TabIndex = 12
        Label11.Text = "Availability"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(30, 130)
        Label10.Name = "Label10"
        Label10.Size = New Size(67, 15)
        Label10.TabIndex = 11
        Label10.Text = "Description"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(30, 101)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 15)
        Label9.TabIndex = 10
        Label9.Text = "Location"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(30, 72)
        Label8.Name = "Label8"
        Label8.Size = New Size(31, 15)
        Label8.TabIndex = 9
        Label8.Text = "Date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(30, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 8
        Label6.Text = "Event"
        ' 
        ' addavailtxt
        ' 
        addavailtxt.Location = New Point(116, 200)
        addavailtxt.Name = "addavailtxt"
        addavailtxt.Size = New Size(100, 23)
        addavailtxt.TabIndex = 7
        ' 
        ' adddesctxt
        ' 
        adddesctxt.Location = New Point(116, 127)
        adddesctxt.Name = "adddesctxt"
        adddesctxt.Size = New Size(318, 67)
        adddesctxt.TabIndex = 6
        adddesctxt.Text = ""
        ' 
        ' addlocationtxt
        ' 
        addlocationtxt.Location = New Point(116, 98)
        addlocationtxt.Name = "addlocationtxt"
        addlocationtxt.Size = New Size(318, 23)
        addlocationtxt.TabIndex = 5
        ' 
        ' adddatetxt
        ' 
        adddatetxt.Location = New Point(116, 69)
        adddatetxt.Name = "adddatetxt"
        adddatetxt.Size = New Size(318, 23)
        adddatetxt.TabIndex = 4
        ' 
        ' addeventtxt
        ' 
        addeventtxt.Location = New Point(116, 40)
        addeventtxt.Name = "addeventtxt"
        addeventtxt.Size = New Size(318, 23)
        addeventtxt.TabIndex = 3
        ' 
        ' canceladdBtn
        ' 
        canceladdBtn.Location = New Point(359, 233)
        canceladdBtn.Name = "canceladdBtn"
        canceladdBtn.Size = New Size(75, 23)
        canceladdBtn.TabIndex = 2
        canceladdBtn.Text = "Cancel"
        canceladdBtn.UseVisualStyleBackColor = True
        ' 
        ' clearBtn
        ' 
        clearBtn.Location = New Point(278, 233)
        clearBtn.Name = "clearBtn"
        clearBtn.Size = New Size(75, 23)
        clearBtn.TabIndex = 1
        clearBtn.Text = "Clear"
        clearBtn.UseVisualStyleBackColor = True
        ' 
        ' addeventBtn
        ' 
        addeventBtn.Location = New Point(197, 233)
        addeventBtn.Name = "addeventBtn"
        addeventBtn.Size = New Size(75, 23)
        addeventBtn.TabIndex = 0
        addeventBtn.Text = "Add"
        addeventBtn.UseVisualStyleBackColor = True
        ' 
        ' loadeventBtn
        ' 
        loadeventBtn.Location = New Point(832, 621)
        loadeventBtn.Name = "loadeventBtn"
        loadeventBtn.Size = New Size(75, 23)
        loadeventBtn.TabIndex = 13
        loadeventBtn.Text = "Refresh"
        loadeventBtn.UseVisualStyleBackColor = True
        ' 
        ' dlteventBtn
        ' 
        dlteventBtn.Location = New Point(751, 621)
        dlteventBtn.Name = "dlteventBtn"
        dlteventBtn.Size = New Size(75, 23)
        dlteventBtn.TabIndex = 12
        dlteventBtn.Text = "Delete"
        dlteventBtn.UseVisualStyleBackColor = True
        ' 
        ' modifyeventpanelBtn
        ' 
        modifyeventpanelBtn.Location = New Point(670, 621)
        modifyeventpanelBtn.Name = "modifyeventpanelBtn"
        modifyeventpanelBtn.Size = New Size(75, 23)
        modifyeventpanelBtn.TabIndex = 11
        modifyeventpanelBtn.Text = "Modify"
        modifyeventpanelBtn.UseVisualStyleBackColor = True
        ' 
        ' addeventpanelBtn
        ' 
        addeventpanelBtn.Location = New Point(589, 621)
        addeventpanelBtn.Name = "addeventpanelBtn"
        addeventpanelBtn.Size = New Size(75, 23)
        addeventpanelBtn.TabIndex = 10
        addeventpanelBtn.Text = "Add"
        addeventpanelBtn.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(822, 692)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(88, 34)
        Button3.TabIndex = 9
        Button3.Text = "Save"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' admineventview
        ' 
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        admineventview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        admineventview.BackgroundColor = Color.White
        admineventview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        admineventview.Columns.AddRange(New DataGridViewColumn() {eventcode, eventName, eventDate, eventLocation, eventDesc, availability})
        admineventview.Location = New Point(17, 250)
        admineventview.Margin = New Padding(3, 2, 3, 2)
        admineventview.Name = "admineventview"
        admineventview.ReadOnly = True
        admineventview.RowHeadersWidth = 51
        admineventview.Size = New Size(889, 362)
        admineventview.TabIndex = 8
        ' 
        ' eventcode
        ' 
        eventcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        eventcode.HeaderText = "Code"
        eventcode.MinimumWidth = 6
        eventcode.Name = "eventcode"
        eventcode.ReadOnly = True
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
        availability.HeaderText = "Availability"
        availability.Name = "availability"
        availability.ReadOnly = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Label7)
        Panel5.Controls.Add(labelSeats)
        Panel5.Location = New Point(622, 101)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(284, 131)
        Panel5.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(18, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(156, 22)
        Label7.TabIndex = 0
        Label7.Text = "AVAILABLE SEATS"
        ' 
        ' labelSeats
        ' 
        labelSeats.AutoSize = True
        labelSeats.Font = New Font("Microsoft YaHei UI", 66F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelSeats.Location = New Point(35, 13)
        labelSeats.Name = "labelSeats"
        labelSeats.Size = New Size(212, 117)
        labelSeats.TabIndex = 1
        labelSeats.Text = "100"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(registerquantity)
        Panel4.Location = New Point(319, 101)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(284, 131)
        Panel4.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(18, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 22)
        Label5.TabIndex = 0
        Label5.Text = "REGISTERED"
        ' 
        ' registerquantity
        ' 
        registerquantity.AutoSize = True
        registerquantity.Font = New Font("Microsoft YaHei UI", 66F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        registerquantity.Location = New Point(67, 13)
        registerquantity.Name = "registerquantity"
        registerquantity.Size = New Size(158, 117)
        registerquantity.TabIndex = 1
        registerquantity.Text = "24"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(eventquantity)
        Panel3.Location = New Point(17, 101)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(284, 131)
        Panel3.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 22)
        Label2.TabIndex = 0
        Label2.Text = "EVENTS"
        ' 
        ' eventquantity
        ' 
        eventquantity.AutoSize = True
        eventquantity.Font = New Font("Microsoft YaHei UI", 66F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        eventquantity.Location = New Point(64, 13)
        eventquantity.Name = "eventquantity"
        eventquantity.Size = New Size(158, 117)
        eventquantity.TabIndex = 1
        eventquantity.Text = "10"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label3.Location = New Point(54, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 42)
        Label3.TabIndex = 4
        Label3.Text = "Events"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(45, 26)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(4, 44)
        Panel2.TabIndex = 0
        ' 
        ' managePage
        ' 
        managePage.Controls.Add(regRefreshBtn)
        managePage.Controls.Add(regtable)
        managePage.Controls.Add(Label4)
        managePage.Controls.Add(Panel6)
        managePage.Location = New Point(4, 5)
        managePage.Margin = New Padding(3, 2, 3, 2)
        managePage.Name = "managePage"
        managePage.Padding = New Padding(3, 2, 3, 2)
        managePage.Size = New Size(920, 652)
        managePage.TabIndex = 1
        managePage.Text = "TabPage2"
        managePage.UseVisualStyleBackColor = True
        ' 
        ' regRefreshBtn
        ' 
        regRefreshBtn.Location = New Point(15, 591)
        regRefreshBtn.Name = "regRefreshBtn"
        regRefreshBtn.Size = New Size(75, 23)
        regRefreshBtn.TabIndex = 10
        regRefreshBtn.Text = "Refresh"
        regRefreshBtn.UseVisualStyleBackColor = True
        ' 
        ' regtable
        ' 
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        regtable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        regtable.BackgroundColor = Color.White
        regtable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        regtable.Columns.AddRange(New DataGridViewColumn() {Column6, DataGridViewTextBoxColumn1, Column1, Column2, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3})
        regtable.Location = New Point(15, 170)
        regtable.Margin = New Padding(3, 2, 3, 2)
        regtable.Name = "regtable"
        regtable.ReadOnly = True
        regtable.RowHeadersWidth = 51
        regtable.Size = New Size(893, 400)
        regtable.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label4.Location = New Point(54, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(291, 42)
        Label4.TabIndex = 6
        Label4.Text = "Registered Users"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Black
        Panel6.Location = New Point(45, 26)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(4, 44)
        Panel6.TabIndex = 5
        ' 
        ' panelSidebar
        ' 
        panelSidebar.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        panelSidebar.Controls.Add(Button2)
        panelSidebar.Controls.Add(Button1)
        panelSidebar.Controls.Add(Label1)
        panelSidebar.Dock = DockStyle.Left
        panelSidebar.Location = New Point(0, 0)
        panelSidebar.Margin = New Padding(3, 2, 3, 2)
        panelSidebar.Name = "panelSidebar"
        panelSidebar.Size = New Size(313, 661)
        panelSidebar.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Image = My.Resources.Resources.users__1_
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(-2, 312)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(319, 82)
        Button2.TabIndex = 2
        Button2.Text = "Participants"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.calendar__1_
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(-2, 228)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(319, 82)
        Button1.TabIndex = 1
        Button1.Text = "Events"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(10, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 42)
        Label1.TabIndex = 0
        Label1.Text = "EventZen"
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Column6.HeaderText = "Registered ID"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 101
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewTextBoxColumn1.HeaderText = "UID"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 51
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Username"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Column2.HeaderText = "Event Code"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 92
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn2.HeaderText = "Event"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn3.HeaderText = "Date Registered"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(247), CByte(244))
        ClientSize = New Size(1244, 661)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        eventPage.ResumeLayout(False)
        eventPage.PerformLayout()
        modifypanel.ResumeLayout(False)
        modifypanel.PerformLayout()
        addeventpanel.ResumeLayout(False)
        addeventpanel.PerformLayout()
        CType(admineventview, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        managePage.ResumeLayout(False)
        managePage.PerformLayout()
        CType(regtable, ComponentModel.ISupportInitialize).EndInit()
        panelSidebar.ResumeLayout(False)
        panelSidebar.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents eventPage As TabPage
    Friend WithEvents managePage As TabPage
    Friend WithEvents panelSidebar As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents eventquantity As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents registerquantity As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents labelSeats As Label
    Friend WithEvents admineventview As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents regtable As DataGridView
    Friend WithEvents loadeventBtn As Button
    Friend WithEvents dlteventBtn As Button
    Friend WithEvents modifyeventpanelBtn As Button
    Friend WithEvents addeventpanelBtn As Button
    Friend WithEvents addeventpanel As Panel
    Friend WithEvents canceladdBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents addeventBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents addavailtxt As TextBox
    Friend WithEvents adddesctxt As RichTextBox
    Friend WithEvents addlocationtxt As TextBox
    Friend WithEvents adddatetxt As TextBox
    Friend WithEvents addeventtxt As TextBox
    Friend WithEvents modifypanel As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents updateavailtxt As TextBox
    Friend WithEvents updatedesctxt As RichTextBox
    Friend WithEvents updatelocationtxt As TextBox
    Friend WithEvents updatedatetxt As TextBox
    Friend WithEvents updateeventtxt As TextBox
    Friend WithEvents modifycancelBtn As Button
    Friend WithEvents modifyclearBtn As Button
    Friend WithEvents modifyeventbtn As Button
    Friend WithEvents eventcode As DataGridViewTextBoxColumn
    Friend WithEvents eventName As DataGridViewTextBoxColumn
    Friend WithEvents eventDate As DataGridViewTextBoxColumn
    Friend WithEvents eventLocation As DataGridViewTextBoxColumn
    Friend WithEvents eventDesc As DataGridViewTextBoxColumn
    Friend WithEvents availability As DataGridViewTextBoxColumn
    Friend WithEvents Label17 As Label
    Friend WithEvents regRefreshBtn As Button
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
