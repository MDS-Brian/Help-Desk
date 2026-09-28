<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicketNewForm
    Inherits AppForm
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
        lblTitle = New Label()
        grpType = New GroupBox()
        optGeneral = New RadioButton()
        optNewAccount = New RadioButton()
        optNewUser = New RadioButton()
        lblUserID = New Label()
        cboUserID = New BorderedComboBox()
        lblAccount = New Label()
        cboAccount = New BorderedComboBox()
        lblSoftware = New Label()
        cboSoftware = New BorderedComboBox()
        lblPriority = New Label()
        cboPriority = New BorderedComboBox()
        lblDateNeeded = New Label()
        dtpDateNeeded = New DateTimePicker()
        lblRequestedBy = New Label()
        cboRequestedBy = New BorderedComboBox()
        lblAddContact = New Label()
        cboAddContact = New BorderedComboBox()
        lblCadenceID = New Label()
        cboCadenceID = New BorderedComboBox()
        lblOrderNbr = New Label()
        txtOrderNbr = New TextBox()
        lblPC_Nbr = New Label()
        txtPC_Nbr = New TextBox()
        pnlNewAccount = New Panel()
        lblNewAccountNo = New Label()
        txtNewAccountNo = New TextBox()
        lblLaunchDate = New Label()
        dtpLaunchDate = New DateTimePicker()
        pnlNewUser = New Panel()
        lblNewUserName = New Label()
        txtNewUserName = New TextBox()
        lblNewUserSocial = New Label()
        txtNewUserSocial = New TextBox()
        lblNewUserPhone = New Label()
        txtNewUserPhone = New MaskedTextBox()
        lblDescription = New Label()
        txtDescription = New TextBox()
        cmdSubmit = New Button()
        cmdReset = New Button()
        cmdClose = New Button()
        lblAttachment = New Label()
        txtAttachment = New TextBox()
        cmdBrowse = New Button()
        cmdRemoveAttachment = New Button()
        grpType.SuspendLayout()
        pnlNewAccount.SuspendLayout()
        pnlNewUser.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblTitle.Location = New Point(16, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(231, 27)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Request For I.T. Support"
        ' 
        ' grpType
        ' 
        grpType.Controls.Add(optGeneral)
        grpType.Controls.Add(optNewAccount)
        grpType.Controls.Add(optNewUser)
        grpType.Font = New Font("Calibri", 9F)
        grpType.Location = New Point(20, 50)
        grpType.Name = "grpType"
        grpType.Size = New Size(620, 52)
        grpType.TabIndex = 1
        grpType.TabStop = False
        grpType.Text = "Help Desk Type"
        ' 
        ' optGeneral
        ' 
        optGeneral.AutoSize = True
        optGeneral.Checked = True
        optGeneral.Location = New Point(15, 22)
        optGeneral.Name = "optGeneral"
        optGeneral.Size = New Size(104, 18)
        optGeneral.TabIndex = 0
        optGeneral.TabStop = True
        optGeneral.Text = "General Ticket"
        optGeneral.UseVisualStyleBackColor = True
        ' 
        ' optNewAccount
        ' 
        optNewAccount.AutoSize = True
        optNewAccount.Location = New Point(180, 22)
        optNewAccount.Name = "optNewAccount"
        optNewAccount.Size = New Size(94, 18)
        optNewAccount.TabIndex = 1
        optNewAccount.Text = "New Account"
        optNewAccount.UseVisualStyleBackColor = True
        ' 
        ' optNewUser
        ' 
        optNewUser.AutoSize = True
        optNewUser.Location = New Point(345, 22)
        optNewUser.Name = "optNewUser"
        optNewUser.Size = New Size(77, 18)
        optNewUser.TabIndex = 2
        optNewUser.Text = "New User"
        optNewUser.UseVisualStyleBackColor = True
        ' 
        ' lblUserID
        ' 
        lblUserID.Font = New Font("Calibri", 9F)
        lblUserID.Location = New Point(20, 120)
        lblUserID.Name = "lblUserID"
        lblUserID.Size = New Size(110, 20)
        lblUserID.TabIndex = 2
        lblUserID.Text = "User ID"
        lblUserID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboUserID
        ' 
        cboUserID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboUserID.AutoCompleteSource = AutoCompleteSource.ListItems
        cboUserID.BackColor = Color.White
        cboUserID.DrawMode = DrawMode.OwnerDrawFixed
        cboUserID.Font = New Font("Calibri", 9F)
        cboUserID.Location = New Point(135, 120)
        cboUserID.Name = "cboUserID"
        cboUserID.Size = New Size(240, 23)
        cboUserID.TabIndex = 3
        ' 
        ' lblAccount
        ' 
        lblAccount.Font = New Font("Calibri", 9F)
        lblAccount.Location = New Point(20, 145)
        lblAccount.Name = "lblAccount"
        lblAccount.Size = New Size(110, 20)
        lblAccount.TabIndex = 4
        lblAccount.Text = "Account"
        lblAccount.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboAccount
        ' 
        cboAccount.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboAccount.AutoCompleteSource = AutoCompleteSource.ListItems
        cboAccount.DrawMode = DrawMode.OwnerDrawFixed
        cboAccount.Font = New Font("Calibri", 9F)
        cboAccount.Location = New Point(135, 145)
        cboAccount.Name = "cboAccount"
        cboAccount.Size = New Size(240, 23)
        cboAccount.TabIndex = 5
        ' 
        ' lblSoftware
        ' 
        lblSoftware.Font = New Font("Calibri", 9F)
        lblSoftware.Location = New Point(20, 170)
        lblSoftware.Name = "lblSoftware"
        lblSoftware.Size = New Size(110, 20)
        lblSoftware.TabIndex = 6
        lblSoftware.Text = "Software"
        lblSoftware.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboSoftware
        ' 
        cboSoftware.DrawMode = DrawMode.OwnerDrawFixed
        cboSoftware.DropDownStyle = ComboBoxStyle.DropDownList
        cboSoftware.FlatStyle = FlatStyle.Flat
        cboSoftware.Font = New Font("Calibri", 9F)
        cboSoftware.Location = New Point(135, 170)
        cboSoftware.Name = "cboSoftware"
        cboSoftware.Size = New Size(240, 23)
        cboSoftware.TabIndex = 7
        ' 
        ' lblPriority
        ' 
        lblPriority.Font = New Font("Calibri", 9F)
        lblPriority.Location = New Point(20, 196)
        lblPriority.Name = "lblPriority"
        lblPriority.Size = New Size(110, 20)
        lblPriority.TabIndex = 8
        lblPriority.Text = "Priority"
        lblPriority.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboPriority
        ' 
        cboPriority.DrawMode = DrawMode.OwnerDrawFixed
        cboPriority.DropDownStyle = ComboBoxStyle.DropDownList
        cboPriority.FlatStyle = FlatStyle.Flat
        cboPriority.Font = New Font("Calibri", 9F)
        cboPriority.Location = New Point(135, 196)
        cboPriority.Name = "cboPriority"
        cboPriority.Size = New Size(240, 23)
        cboPriority.TabIndex = 9
        ' 
        ' lblDateNeeded
        ' 
        lblDateNeeded.Font = New Font("Calibri", 9F)
        lblDateNeeded.Location = New Point(20, 223)
        lblDateNeeded.Name = "lblDateNeeded"
        lblDateNeeded.Size = New Size(110, 20)
        lblDateNeeded.TabIndex = 10
        lblDateNeeded.Text = "Date Needed"
        lblDateNeeded.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpDateNeeded
        ' 
        dtpDateNeeded.Checked = False
        dtpDateNeeded.CustomFormat = "MM/dd/yyyy  h:mm tt"
        dtpDateNeeded.Font = New Font("Calibri", 9F)
        dtpDateNeeded.Format = DateTimePickerFormat.Custom
        dtpDateNeeded.Location = New Point(135, 223)
        dtpDateNeeded.Name = "dtpDateNeeded"
        dtpDateNeeded.ShowCheckBox = True
        dtpDateNeeded.Size = New Size(240, 22)
        dtpDateNeeded.TabIndex = 11
        ' 
        ' lblRequestedBy
        ' 
        lblRequestedBy.Font = New Font("Calibri", 9F)
        lblRequestedBy.Location = New Point(20, 250)
        lblRequestedBy.Name = "lblRequestedBy"
        lblRequestedBy.Size = New Size(110, 20)
        lblRequestedBy.TabIndex = 12
        lblRequestedBy.Text = "Requested By"
        lblRequestedBy.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboRequestedBy
        ' 
        cboRequestedBy.DrawMode = DrawMode.OwnerDrawFixed
        cboRequestedBy.DropDownStyle = ComboBoxStyle.DropDownList
        cboRequestedBy.FlatStyle = FlatStyle.Flat
        cboRequestedBy.Font = New Font("Calibri", 9F)
        cboRequestedBy.Location = New Point(135, 250)
        cboRequestedBy.Name = "cboRequestedBy"
        cboRequestedBy.Size = New Size(240, 23)
        cboRequestedBy.TabIndex = 13
        ' 
        ' lblAddContact
        ' 
        lblAddContact.Font = New Font("Calibri", 9F)
        lblAddContact.Location = New Point(20, 277)
        lblAddContact.Name = "lblAddContact"
        lblAddContact.Size = New Size(110, 20)
        lblAddContact.TabIndex = 14
        lblAddContact.Text = "Add'l Contact"
        lblAddContact.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboAddContact
        ' 
        cboAddContact.DrawMode = DrawMode.OwnerDrawFixed
        cboAddContact.DropDownStyle = ComboBoxStyle.DropDownList
        cboAddContact.FlatStyle = FlatStyle.Flat
        cboAddContact.Font = New Font("Calibri", 9F)
        cboAddContact.Location = New Point(135, 277)
        cboAddContact.Name = "cboAddContact"
        cboAddContact.Size = New Size(240, 23)
        cboAddContact.TabIndex = 15
        ' 
        ' lblCadenceID
        ' 
        lblCadenceID.Font = New Font("Calibri", 9F)
        lblCadenceID.Location = New Point(20, 304)
        lblCadenceID.Name = "lblCadenceID"
        lblCadenceID.Size = New Size(110, 20)
        lblCadenceID.TabIndex = 16
        lblCadenceID.Text = "Cadence ID"
        lblCadenceID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboCadenceID
        ' 
        cboCadenceID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboCadenceID.AutoCompleteSource = AutoCompleteSource.ListItems
        cboCadenceID.DrawMode = DrawMode.OwnerDrawFixed
        cboCadenceID.Font = New Font("Calibri", 9F)
        cboCadenceID.Location = New Point(135, 304)
        cboCadenceID.MaxLength = 15
        cboCadenceID.Name = "cboCadenceID"
        cboCadenceID.Size = New Size(240, 23)
        cboCadenceID.TabIndex = 17
        ' 
        ' lblOrderNbr
        ' 
        lblOrderNbr.Font = New Font("Calibri", 9F)
        lblOrderNbr.Location = New Point(20, 331)
        lblOrderNbr.Name = "lblOrderNbr"
        lblOrderNbr.Size = New Size(110, 20)
        lblOrderNbr.TabIndex = 18
        lblOrderNbr.Text = "Order Number"
        lblOrderNbr.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtOrderNbr
        ' 
        txtOrderNbr.BorderStyle = BorderStyle.FixedSingle
        txtOrderNbr.Font = New Font("Calibri", 9F)
        txtOrderNbr.Location = New Point(135, 331)
        txtOrderNbr.MaxLength = 25
        txtOrderNbr.Name = "txtOrderNbr"
        txtOrderNbr.Size = New Size(240, 22)
        txtOrderNbr.TabIndex = 19
        ' 
        ' lblPC_Nbr
        ' 
        lblPC_Nbr.Font = New Font("Calibri", 9F)
        lblPC_Nbr.Location = New Point(20, 358)
        lblPC_Nbr.Name = "lblPC_Nbr"
        lblPC_Nbr.Size = New Size(110, 20)
        lblPC_Nbr.TabIndex = 20
        lblPC_Nbr.Text = "Computer No"
        lblPC_Nbr.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtPC_Nbr
        ' 
        txtPC_Nbr.BorderStyle = BorderStyle.FixedSingle
        txtPC_Nbr.Font = New Font("Calibri", 9F)
        txtPC_Nbr.Location = New Point(135, 358)
        txtPC_Nbr.MaxLength = 10
        txtPC_Nbr.Name = "txtPC_Nbr"
        txtPC_Nbr.Size = New Size(240, 22)
        txtPC_Nbr.TabIndex = 21
        ' 
        ' pnlNewAccount
        ' 
        pnlNewAccount.Controls.Add(lblNewAccountNo)
        pnlNewAccount.Controls.Add(txtNewAccountNo)
        pnlNewAccount.Controls.Add(lblLaunchDate)
        pnlNewAccount.Controls.Add(dtpLaunchDate)
        pnlNewAccount.Font = New Font("Calibri", 9F)
        pnlNewAccount.Location = New Point(390, 172)
        pnlNewAccount.Name = "pnlNewAccount"
        pnlNewAccount.Size = New Size(250, 61)
        pnlNewAccount.TabIndex = 22
        pnlNewAccount.Visible = False
        ' 
        ' lblNewAccountNo
        ' 
        lblNewAccountNo.Location = New Point(0, 0)
        lblNewAccountNo.Name = "lblNewAccountNo"
        lblNewAccountNo.Size = New Size(105, 23)
        lblNewAccountNo.TabIndex = 0
        lblNewAccountNo.Text = "New Account No"
        lblNewAccountNo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNewAccountNo
        ' 
        txtNewAccountNo.Location = New Point(110, 0)
        txtNewAccountNo.MaxLength = 10
        txtNewAccountNo.Name = "txtNewAccountNo"
        txtNewAccountNo.Size = New Size(140, 22)
        txtNewAccountNo.TabIndex = 1
        ' 
        ' lblLaunchDate
        ' 
        lblLaunchDate.Location = New Point(0, 32)
        lblLaunchDate.Name = "lblLaunchDate"
        lblLaunchDate.Size = New Size(105, 23)
        lblLaunchDate.TabIndex = 2
        lblLaunchDate.Text = "Exp Launch Date"
        lblLaunchDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpLaunchDate
        ' 
        dtpLaunchDate.Checked = False
        dtpLaunchDate.Format = DateTimePickerFormat.Short
        dtpLaunchDate.Location = New Point(110, 32)
        dtpLaunchDate.Name = "dtpLaunchDate"
        dtpLaunchDate.ShowCheckBox = True
        dtpLaunchDate.Size = New Size(140, 22)
        dtpLaunchDate.TabIndex = 3
        ' 
        ' pnlNewUser
        ' 
        pnlNewUser.Controls.Add(lblNewUserName)
        pnlNewUser.Controls.Add(txtNewUserName)
        pnlNewUser.Controls.Add(lblNewUserSocial)
        pnlNewUser.Controls.Add(txtNewUserSocial)
        pnlNewUser.Controls.Add(lblNewUserPhone)
        pnlNewUser.Controls.Add(txtNewUserPhone)
        pnlNewUser.Font = New Font("Calibri", 9F)
        pnlNewUser.Location = New Point(390, 167)
        pnlNewUser.Name = "pnlNewUser"
        pnlNewUser.Size = New Size(250, 93)
        pnlNewUser.TabIndex = 23
        pnlNewUser.Visible = False
        ' 
        ' lblNewUserName
        ' 
        lblNewUserName.Location = New Point(0, 0)
        lblNewUserName.Name = "lblNewUserName"
        lblNewUserName.Size = New Size(105, 23)
        lblNewUserName.TabIndex = 0
        lblNewUserName.Text = "User Name"
        lblNewUserName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNewUserName
        ' 
        txtNewUserName.Location = New Point(110, 2)
        txtNewUserName.Name = "txtNewUserName"
        txtNewUserName.Size = New Size(140, 22)
        txtNewUserName.TabIndex = 1
        ' 
        ' lblNewUserSocial
        ' 
        lblNewUserSocial.Location = New Point(0, 32)
        lblNewUserSocial.Name = "lblNewUserSocial"
        lblNewUserSocial.Size = New Size(105, 23)
        lblNewUserSocial.TabIndex = 2
        lblNewUserSocial.Text = "Last 4 of SS#"
        lblNewUserSocial.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNewUserSocial
        ' 
        txtNewUserSocial.Location = New Point(110, 32)
        txtNewUserSocial.MaxLength = 4
        txtNewUserSocial.Name = "txtNewUserSocial"
        txtNewUserSocial.Size = New Size(140, 22)
        txtNewUserSocial.TabIndex = 3
        ' 
        ' lblNewUserPhone
        ' 
        lblNewUserPhone.Location = New Point(0, 64)
        lblNewUserPhone.Name = "lblNewUserPhone"
        lblNewUserPhone.Size = New Size(105, 23)
        lblNewUserPhone.TabIndex = 4
        lblNewUserPhone.Text = "Telephone"
        lblNewUserPhone.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNewUserPhone
        ' 
        txtNewUserPhone.Location = New Point(110, 64)
        txtNewUserPhone.Mask = "(999) 000-0000"
        txtNewUserPhone.Name = "txtNewUserPhone"
        txtNewUserPhone.Size = New Size(140, 22)
        txtNewUserPhone.TabIndex = 5
        txtNewUserPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        ' 
        ' lblDescription
        ' 
        lblDescription.Font = New Font("Calibri", 9F)
        lblDescription.Location = New Point(20, 386)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(110, 23)
        lblDescription.TabIndex = 24
        lblDescription.Text = "Description"
        lblDescription.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtDescription
        ' 
        txtDescription.AcceptsReturn = True
        txtDescription.BorderStyle = BorderStyle.FixedSingle
        txtDescription.Font = New Font("Calibri", 9F)
        txtDescription.Location = New Point(135, 386)
        txtDescription.MaxLength = 1024
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ScrollBars = ScrollBars.Vertical
        txtDescription.Size = New Size(505, 110)
        txtDescription.TabIndex = 25
        '
        ' lblAttachment
        '
        lblAttachment.Font = New Font("Calibri", 9F)
        lblAttachment.Location = New Point(20, 506)
        lblAttachment.Name = "lblAttachment"
        lblAttachment.Size = New Size(110, 23)
        lblAttachment.TabIndex = 26
        lblAttachment.Text = "Attachment"
        lblAttachment.TextAlign = ContentAlignment.MiddleLeft
        '
        ' txtAttachment
        '
        txtAttachment.BorderStyle = BorderStyle.FixedSingle
        txtAttachment.Font = New Font("Calibri", 9F)
        txtAttachment.Location = New Point(135, 507)
        txtAttachment.Name = "txtAttachment"
        txtAttachment.ReadOnly = True
        txtAttachment.Size = New Size(321, 22)
        txtAttachment.TabIndex = 27
        txtAttachment.TabStop = False
        '
        ' cmdBrowse
        '
        cmdBrowse.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdBrowse.FlatAppearance.BorderColor = Color.Black
        cmdBrowse.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdBrowse.FlatStyle = FlatStyle.Flat
        cmdBrowse.Font = New Font("Calibri", 9F, FontStyle.Bold)
        cmdBrowse.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        cmdBrowse.Location = New Point(462, 505)
        cmdBrowse.Name = "cmdBrowse"
        cmdBrowse.Size = New Size(86, 26)
        cmdBrowse.TabIndex = 28
        cmdBrowse.Text = "Browse…"
        cmdBrowse.UseVisualStyleBackColor = False
        '
        ' cmdRemoveAttachment
        '
        cmdRemoveAttachment.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdRemoveAttachment.Enabled = False
        cmdRemoveAttachment.FlatAppearance.BorderColor = Color.Black
        cmdRemoveAttachment.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdRemoveAttachment.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdRemoveAttachment.FlatStyle = FlatStyle.Flat
        cmdRemoveAttachment.Font = New Font("Calibri", 9F, FontStyle.Bold)
        cmdRemoveAttachment.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        cmdRemoveAttachment.Location = New Point(554, 505)
        cmdRemoveAttachment.Name = "cmdRemoveAttachment"
        cmdRemoveAttachment.Size = New Size(86, 26)
        cmdRemoveAttachment.TabIndex = 29
        cmdRemoveAttachment.Text = "Remove"
        cmdRemoveAttachment.UseVisualStyleBackColor = False
        '
        ' cmdSubmit
        ' 
        cmdSubmit.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdSubmit.FlatAppearance.BorderColor = Color.Black
        cmdSubmit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdSubmit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdSubmit.FlatStyle = FlatStyle.Flat
        cmdSubmit.Font = New Font("Calibri", 9F, FontStyle.Bold)
        cmdSubmit.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        cmdSubmit.Location = New Point(135, 548)
        cmdSubmit.Name = "cmdSubmit"
        cmdSubmit.Size = New Size(144, 40)
        cmdSubmit.TabIndex = 30
        cmdSubmit.Text = "Submit"
        cmdSubmit.UseVisualStyleBackColor = False
        ' 
        ' cmdReset
        ' 
        cmdReset.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdReset.FlatAppearance.BorderColor = Color.Black
        cmdReset.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdReset.FlatStyle = FlatStyle.Flat
        cmdReset.Font = New Font("Calibri", 9F, FontStyle.Bold)
        cmdReset.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        cmdReset.Location = New Point(315, 548)
        cmdReset.Name = "cmdReset"
        cmdReset.Size = New Size(144, 40)
        cmdReset.TabIndex = 31
        cmdReset.Text = "Reset"
        cmdReset.UseVisualStyleBackColor = False
        ' 
        ' cmdClose
        ' 
        cmdClose.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdClose.DialogResult = DialogResult.Cancel
        cmdClose.FlatAppearance.BorderColor = Color.Black
        cmdClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdClose.FlatStyle = FlatStyle.Flat
        cmdClose.Font = New Font("Calibri", 9F, FontStyle.Bold)
        cmdClose.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        cmdClose.Location = New Point(496, 548)
        cmdClose.Name = "cmdClose"
        cmdClose.Size = New Size(144, 40)
        cmdClose.TabIndex = 32
        cmdClose.Text = "Close"
        cmdClose.UseVisualStyleBackColor = False
        ' 
        ' TicketNewForm
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(142), CByte(187), CByte(245))
        CancelButton = cmdClose
        ClientSize = New Size(660, 623)
        Controls.Add(lblTitle)
        Controls.Add(grpType)
        Controls.Add(lblUserID)
        Controls.Add(cboUserID)
        Controls.Add(lblAccount)
        Controls.Add(cboAccount)
        Controls.Add(lblSoftware)
        Controls.Add(cboSoftware)
        Controls.Add(lblPriority)
        Controls.Add(cboPriority)
        Controls.Add(lblDateNeeded)
        Controls.Add(dtpDateNeeded)
        Controls.Add(lblRequestedBy)
        Controls.Add(cboRequestedBy)
        Controls.Add(lblAddContact)
        Controls.Add(cboAddContact)
        Controls.Add(lblCadenceID)
        Controls.Add(cboCadenceID)
        Controls.Add(lblOrderNbr)
        Controls.Add(txtOrderNbr)
        Controls.Add(lblPC_Nbr)
        Controls.Add(txtPC_Nbr)
        Controls.Add(pnlNewAccount)
        Controls.Add(pnlNewUser)
        Controls.Add(lblDescription)
        Controls.Add(txtDescription)
        Controls.Add(lblAttachment)
        Controls.Add(txtAttachment)
        Controls.Add(cmdBrowse)
        Controls.Add(cmdRemoveAttachment)
        Controls.Add(cmdSubmit)
        Controls.Add(cmdReset)
        Controls.Add(cmdClose)
        Font = New Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "TicketNewForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Add Help Desk Ticket"
        grpType.ResumeLayout(False)
        grpType.PerformLayout()
        pnlNewAccount.ResumeLayout(False)
        pnlNewAccount.PerformLayout()
        pnlNewUser.ResumeLayout(False)
        pnlNewUser.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents optGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents optNewAccount As System.Windows.Forms.RadioButton
    Friend WithEvents optNewUser As System.Windows.Forms.RadioButton
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents cboUserID As BorderedComboBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents cboAccount As BorderedComboBox
    Friend WithEvents lblSoftware As System.Windows.Forms.Label
    Friend WithEvents cboSoftware As BorderedComboBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents cboPriority As BorderedComboBox
    Friend WithEvents lblDateNeeded As System.Windows.Forms.Label
    Friend WithEvents dtpDateNeeded As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRequestedBy As System.Windows.Forms.Label
    Friend WithEvents cboRequestedBy As BorderedComboBox
    Friend WithEvents lblAddContact As System.Windows.Forms.Label
    Friend WithEvents cboAddContact As BorderedComboBox
    Friend WithEvents lblCadenceID As System.Windows.Forms.Label
    Friend WithEvents cboCadenceID As BorderedComboBox
    Friend WithEvents lblOrderNbr As System.Windows.Forms.Label
    Friend WithEvents txtOrderNbr As System.Windows.Forms.TextBox
    Friend WithEvents lblPC_Nbr As System.Windows.Forms.Label
    Friend WithEvents txtPC_Nbr As System.Windows.Forms.TextBox
    Friend WithEvents pnlNewAccount As System.Windows.Forms.Panel
    Friend WithEvents lblNewAccountNo As System.Windows.Forms.Label
    Friend WithEvents txtNewAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents lblLaunchDate As System.Windows.Forms.Label
    Friend WithEvents dtpLaunchDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlNewUser As System.Windows.Forms.Panel
    Friend WithEvents lblNewUserName As System.Windows.Forms.Label
    Friend WithEvents txtNewUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblNewUserSocial As System.Windows.Forms.Label
    Friend WithEvents txtNewUserSocial As System.Windows.Forms.TextBox
    Friend WithEvents lblNewUserPhone As System.Windows.Forms.Label
    Friend WithEvents txtNewUserPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lblAttachment As System.Windows.Forms.Label
    Friend WithEvents txtAttachment As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents cmdRemoveAttachment As System.Windows.Forms.Button
End Class
