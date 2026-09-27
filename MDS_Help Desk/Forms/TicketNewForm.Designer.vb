<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicketNewForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.optGeneral = New System.Windows.Forms.RadioButton()
        Me.optNewAccount = New System.Windows.Forms.RadioButton()
        Me.optNewUser = New System.Windows.Forms.RadioButton()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.cboUserID = New System.Windows.Forms.ComboBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.cboAccount = New System.Windows.Forms.ComboBox()
        Me.lblSoftware = New System.Windows.Forms.Label()
        Me.cboSoftware = New System.Windows.Forms.ComboBox()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.cboPriority = New System.Windows.Forms.ComboBox()
        Me.lblDateNeeded = New System.Windows.Forms.Label()
        Me.dtpDateNeeded = New System.Windows.Forms.DateTimePicker()
        Me.lblRequestedBy = New System.Windows.Forms.Label()
        Me.cboRequestedBy = New System.Windows.Forms.ComboBox()
        Me.lblAddContact = New System.Windows.Forms.Label()
        Me.cboAddContact = New System.Windows.Forms.ComboBox()
        Me.lblCadenceID = New System.Windows.Forms.Label()
        Me.cboCadenceID = New System.Windows.Forms.ComboBox()
        Me.lblOrderNbr = New System.Windows.Forms.Label()
        Me.txtOrderNbr = New System.Windows.Forms.TextBox()
        Me.lblPC_Nbr = New System.Windows.Forms.Label()
        Me.txtPC_Nbr = New System.Windows.Forms.TextBox()
        Me.pnlNewAccount = New System.Windows.Forms.Panel()
        Me.lblNewAccountNo = New System.Windows.Forms.Label()
        Me.txtNewAccountNo = New System.Windows.Forms.TextBox()
        Me.lblLaunchDate = New System.Windows.Forms.Label()
        Me.dtpLaunchDate = New System.Windows.Forms.DateTimePicker()
        Me.pnlNewUser = New System.Windows.Forms.Panel()
        Me.lblNewUserName = New System.Windows.Forms.Label()
        Me.txtNewUserName = New System.Windows.Forms.TextBox()
        Me.lblNewUserSocial = New System.Windows.Forms.Label()
        Me.txtNewUserSocial = New System.Windows.Forms.TextBox()
        Me.lblNewUserPhone = New System.Windows.Forms.Label()
        Me.txtNewUserPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpType.SuspendLayout()
        Me.pnlNewAccount.SuspendLayout()
        Me.pnlNewUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.lblTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(240, 27)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Request For I.T. Support"
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.optGeneral)
        Me.grpType.Controls.Add(Me.optNewAccount)
        Me.grpType.Controls.Add(Me.optNewUser)
        Me.grpType.Location = New System.Drawing.Point(20, 50)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(620, 52)
        Me.grpType.TabIndex = 1
        Me.grpType.TabStop = False
        Me.grpType.Text = "Help Desk Type"
        '
        'optGeneral
        '
        Me.optGeneral.AutoSize = True
        Me.optGeneral.Checked = True
        Me.optGeneral.Location = New System.Drawing.Point(15, 22)
        Me.optGeneral.Name = "optGeneral"
        Me.optGeneral.Size = New System.Drawing.Size(110, 22)
        Me.optGeneral.TabIndex = 0
        Me.optGeneral.TabStop = True
        Me.optGeneral.Text = "General Ticket"
        Me.optGeneral.UseVisualStyleBackColor = True
        '
        'optNewAccount
        '
        Me.optNewAccount.AutoSize = True
        Me.optNewAccount.Location = New System.Drawing.Point(180, 22)
        Me.optNewAccount.Name = "optNewAccount"
        Me.optNewAccount.Size = New System.Drawing.Size(105, 22)
        Me.optNewAccount.TabIndex = 1
        Me.optNewAccount.Text = "New Account"
        Me.optNewAccount.UseVisualStyleBackColor = True
        '
        'optNewUser
        '
        Me.optNewUser.AutoSize = True
        Me.optNewUser.Location = New System.Drawing.Point(345, 22)
        Me.optNewUser.Name = "optNewUser"
        Me.optNewUser.Size = New System.Drawing.Size(85, 22)
        Me.optNewUser.TabIndex = 2
        Me.optNewUser.Text = "New User"
        Me.optNewUser.UseVisualStyleBackColor = True
        '
        'lblUserID
        '
        Me.lblUserID.Location = New System.Drawing.Point(20, 120)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(110, 23)
        Me.lblUserID.TabIndex = 2
        Me.lblUserID.Text = "User ID"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboUserID
        '
        Me.cboUserID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboUserID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUserID.Location = New System.Drawing.Point(135, 120)
        Me.cboUserID.Name = "cboUserID"
        Me.cboUserID.Size = New System.Drawing.Size(505, 26)
        Me.cboUserID.TabIndex = 3
        '
        'lblAccount
        '
        Me.lblAccount.Location = New System.Drawing.Point(20, 152)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(110, 23)
        Me.lblAccount.TabIndex = 4
        Me.lblAccount.Text = "Account"
        Me.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAccount
        '
        Me.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccount.Location = New System.Drawing.Point(135, 152)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(505, 26)
        Me.cboAccount.TabIndex = 5
        '
        'lblSoftware
        '
        Me.lblSoftware.Location = New System.Drawing.Point(20, 184)
        Me.lblSoftware.Name = "lblSoftware"
        Me.lblSoftware.Size = New System.Drawing.Size(110, 23)
        Me.lblSoftware.TabIndex = 6
        Me.lblSoftware.Text = "Software"
        Me.lblSoftware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSoftware
        '
        Me.cboSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSoftware.Location = New System.Drawing.Point(135, 184)
        Me.cboSoftware.Name = "cboSoftware"
        Me.cboSoftware.Size = New System.Drawing.Size(240, 26)
        Me.cboSoftware.TabIndex = 7
        '
        'lblPriority
        '
        Me.lblPriority.Location = New System.Drawing.Point(20, 216)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(110, 23)
        Me.lblPriority.TabIndex = 8
        Me.lblPriority.Text = "Priority"
        Me.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPriority
        '
        Me.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPriority.Location = New System.Drawing.Point(135, 216)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Size = New System.Drawing.Size(240, 26)
        Me.cboPriority.TabIndex = 9
        '
        'lblDateNeeded
        '
        Me.lblDateNeeded.Location = New System.Drawing.Point(20, 248)
        Me.lblDateNeeded.Name = "lblDateNeeded"
        Me.lblDateNeeded.Size = New System.Drawing.Size(110, 23)
        Me.lblDateNeeded.TabIndex = 10
        Me.lblDateNeeded.Text = "Date Needed"
        Me.lblDateNeeded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDateNeeded
        '
        Me.dtpDateNeeded.CustomFormat = "MM/dd/yyyy  h:mm tt"
        Me.dtpDateNeeded.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateNeeded.Location = New System.Drawing.Point(135, 248)
        Me.dtpDateNeeded.Name = "dtpDateNeeded"
        Me.dtpDateNeeded.ShowCheckBox = True
        Me.dtpDateNeeded.Checked = False
        Me.dtpDateNeeded.Size = New System.Drawing.Size(240, 26)
        Me.dtpDateNeeded.TabIndex = 11
        '
        'lblRequestedBy
        '
        Me.lblRequestedBy.Location = New System.Drawing.Point(20, 280)
        Me.lblRequestedBy.Name = "lblRequestedBy"
        Me.lblRequestedBy.Size = New System.Drawing.Size(110, 23)
        Me.lblRequestedBy.TabIndex = 12
        Me.lblRequestedBy.Text = "Requested By"
        Me.lblRequestedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboRequestedBy
        '
        Me.cboRequestedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRequestedBy.Location = New System.Drawing.Point(135, 280)
        Me.cboRequestedBy.Name = "cboRequestedBy"
        Me.cboRequestedBy.Size = New System.Drawing.Size(240, 26)
        Me.cboRequestedBy.TabIndex = 13
        '
        'lblAddContact
        '
        Me.lblAddContact.Location = New System.Drawing.Point(20, 312)
        Me.lblAddContact.Name = "lblAddContact"
        Me.lblAddContact.Size = New System.Drawing.Size(110, 23)
        Me.lblAddContact.TabIndex = 14
        Me.lblAddContact.Text = "Add'l Contact"
        Me.lblAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAddContact
        '
        Me.cboAddContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddContact.Location = New System.Drawing.Point(135, 312)
        Me.cboAddContact.Name = "cboAddContact"
        Me.cboAddContact.Size = New System.Drawing.Size(240, 26)
        Me.cboAddContact.TabIndex = 15
        '
        'lblCadenceID
        '
        Me.lblCadenceID.Location = New System.Drawing.Point(20, 344)
        Me.lblCadenceID.Name = "lblCadenceID"
        Me.lblCadenceID.Size = New System.Drawing.Size(110, 23)
        Me.lblCadenceID.TabIndex = 16
        Me.lblCadenceID.Text = "Cadence ID"
        Me.lblCadenceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboCadenceID
        '
        Me.cboCadenceID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCadenceID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCadenceID.Location = New System.Drawing.Point(135, 344)
        Me.cboCadenceID.MaxLength = 15
        Me.cboCadenceID.Name = "cboCadenceID"
        Me.cboCadenceID.Size = New System.Drawing.Size(240, 26)
        Me.cboCadenceID.TabIndex = 17
        '
        'lblOrderNbr
        '
        Me.lblOrderNbr.Location = New System.Drawing.Point(20, 376)
        Me.lblOrderNbr.Name = "lblOrderNbr"
        Me.lblOrderNbr.Size = New System.Drawing.Size(110, 23)
        Me.lblOrderNbr.TabIndex = 18
        Me.lblOrderNbr.Text = "Order Number"
        Me.lblOrderNbr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOrderNbr
        '
        Me.txtOrderNbr.Location = New System.Drawing.Point(135, 376)
        Me.txtOrderNbr.MaxLength = 25
        Me.txtOrderNbr.Name = "txtOrderNbr"
        Me.txtOrderNbr.Size = New System.Drawing.Size(240, 26)
        Me.txtOrderNbr.TabIndex = 19
        '
        'lblPC_Nbr
        '
        Me.lblPC_Nbr.Location = New System.Drawing.Point(20, 408)
        Me.lblPC_Nbr.Name = "lblPC_Nbr"
        Me.lblPC_Nbr.Size = New System.Drawing.Size(110, 23)
        Me.lblPC_Nbr.TabIndex = 20
        Me.lblPC_Nbr.Text = "Computer No"
        Me.lblPC_Nbr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPC_Nbr
        '
        Me.txtPC_Nbr.Location = New System.Drawing.Point(135, 408)
        Me.txtPC_Nbr.MaxLength = 10
        Me.txtPC_Nbr.Name = "txtPC_Nbr"
        Me.txtPC_Nbr.Size = New System.Drawing.Size(240, 26)
        Me.txtPC_Nbr.TabIndex = 21
        '
        'pnlNewAccount
        '
        Me.pnlNewAccount.Controls.Add(Me.lblNewAccountNo)
        Me.pnlNewAccount.Controls.Add(Me.txtNewAccountNo)
        Me.pnlNewAccount.Controls.Add(Me.lblLaunchDate)
        Me.pnlNewAccount.Controls.Add(Me.dtpLaunchDate)
        Me.pnlNewAccount.Location = New System.Drawing.Point(390, 184)
        Me.pnlNewAccount.Name = "pnlNewAccount"
        Me.pnlNewAccount.Size = New System.Drawing.Size(250, 64)
        Me.pnlNewAccount.TabIndex = 22
        Me.pnlNewAccount.Visible = False
        '
        'lblNewAccountNo
        '
        Me.lblNewAccountNo.Location = New System.Drawing.Point(0, 0)
        Me.lblNewAccountNo.Name = "lblNewAccountNo"
        Me.lblNewAccountNo.Size = New System.Drawing.Size(105, 23)
        Me.lblNewAccountNo.TabIndex = 0
        Me.lblNewAccountNo.Text = "New Account No"
        Me.lblNewAccountNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNewAccountNo
        '
        Me.txtNewAccountNo.Location = New System.Drawing.Point(110, 0)
        Me.txtNewAccountNo.MaxLength = 10
        Me.txtNewAccountNo.Name = "txtNewAccountNo"
        Me.txtNewAccountNo.Size = New System.Drawing.Size(140, 26)
        Me.txtNewAccountNo.TabIndex = 1
        '
        'lblLaunchDate
        '
        Me.lblLaunchDate.Location = New System.Drawing.Point(0, 32)
        Me.lblLaunchDate.Name = "lblLaunchDate"
        Me.lblLaunchDate.Size = New System.Drawing.Size(105, 23)
        Me.lblLaunchDate.TabIndex = 2
        Me.lblLaunchDate.Text = "Exp Launch Date"
        Me.lblLaunchDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpLaunchDate
        '
        Me.dtpLaunchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpLaunchDate.Location = New System.Drawing.Point(110, 32)
        Me.dtpLaunchDate.Name = "dtpLaunchDate"
        Me.dtpLaunchDate.ShowCheckBox = True
        Me.dtpLaunchDate.Checked = False
        Me.dtpLaunchDate.Size = New System.Drawing.Size(140, 26)
        Me.dtpLaunchDate.TabIndex = 3
        '
        'pnlNewUser
        '
        Me.pnlNewUser.Controls.Add(Me.lblNewUserName)
        Me.pnlNewUser.Controls.Add(Me.txtNewUserName)
        Me.pnlNewUser.Controls.Add(Me.lblNewUserSocial)
        Me.pnlNewUser.Controls.Add(Me.txtNewUserSocial)
        Me.pnlNewUser.Controls.Add(Me.lblNewUserPhone)
        Me.pnlNewUser.Controls.Add(Me.txtNewUserPhone)
        Me.pnlNewUser.Location = New System.Drawing.Point(390, 184)
        Me.pnlNewUser.Name = "pnlNewUser"
        Me.pnlNewUser.Size = New System.Drawing.Size(250, 96)
        Me.pnlNewUser.TabIndex = 23
        Me.pnlNewUser.Visible = False
        '
        'lblNewUserName
        '
        Me.lblNewUserName.Location = New System.Drawing.Point(0, 0)
        Me.lblNewUserName.Name = "lblNewUserName"
        Me.lblNewUserName.Size = New System.Drawing.Size(105, 23)
        Me.lblNewUserName.TabIndex = 0
        Me.lblNewUserName.Text = "User Name"
        Me.lblNewUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNewUserName
        '
        Me.txtNewUserName.Location = New System.Drawing.Point(110, 0)
        Me.txtNewUserName.Name = "txtNewUserName"
        Me.txtNewUserName.Size = New System.Drawing.Size(140, 26)
        Me.txtNewUserName.TabIndex = 1
        '
        'lblNewUserSocial
        '
        Me.lblNewUserSocial.Location = New System.Drawing.Point(0, 32)
        Me.lblNewUserSocial.Name = "lblNewUserSocial"
        Me.lblNewUserSocial.Size = New System.Drawing.Size(105, 23)
        Me.lblNewUserSocial.TabIndex = 2
        Me.lblNewUserSocial.Text = "Last 4 of SS#"
        Me.lblNewUserSocial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNewUserSocial
        '
        Me.txtNewUserSocial.Location = New System.Drawing.Point(110, 32)
        Me.txtNewUserSocial.MaxLength = 4
        Me.txtNewUserSocial.Name = "txtNewUserSocial"
        Me.txtNewUserSocial.Size = New System.Drawing.Size(140, 26)
        Me.txtNewUserSocial.TabIndex = 3
        '
        'lblNewUserPhone
        '
        Me.lblNewUserPhone.Location = New System.Drawing.Point(0, 64)
        Me.lblNewUserPhone.Name = "lblNewUserPhone"
        Me.lblNewUserPhone.Size = New System.Drawing.Size(105, 23)
        Me.lblNewUserPhone.TabIndex = 4
        Me.lblNewUserPhone.Text = "Telephone"
        Me.lblNewUserPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNewUserPhone
        '
        Me.txtNewUserPhone.Location = New System.Drawing.Point(110, 64)
        Me.txtNewUserPhone.Mask = "(999) 000-0000"
        Me.txtNewUserPhone.Name = "txtNewUserPhone"
        Me.txtNewUserPhone.Size = New System.Drawing.Size(140, 26)
        Me.txtNewUserPhone.TabIndex = 5
        Me.txtNewUserPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(20, 444)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(110, 23)
        Me.lblDescription.TabIndex = 24
        Me.lblDescription.Text = "Description"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.AcceptsReturn = True
        Me.txtDescription.Location = New System.Drawing.Point(135, 444)
        Me.txtDescription.MaxLength = 1024
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(505, 110)
        Me.txtDescription.TabIndex = 25
        '
        'cmdSubmit
        '
        Me.cmdSubmit.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSubmit.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmit.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.cmdSubmit.Location = New System.Drawing.Point(135, 572)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(144, 40)
        Me.cmdSubmit.TabIndex = 26
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = False
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReset.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.cmdReset.Location = New System.Drawing.Point(315, 572)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(144, 40)
        Me.cmdReset.TabIndex = 27
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.cmdClose.Location = New System.Drawing.Point(496, 572)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(144, 40)
        Me.cmdClose.TabIndex = 28
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'TicketNewForm
        '
        Me.AcceptButton = Nothing
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(660, 630)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.cboUserID)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.cboAccount)
        Me.Controls.Add(Me.lblSoftware)
        Me.Controls.Add(Me.cboSoftware)
        Me.Controls.Add(Me.lblPriority)
        Me.Controls.Add(Me.cboPriority)
        Me.Controls.Add(Me.lblDateNeeded)
        Me.Controls.Add(Me.dtpDateNeeded)
        Me.Controls.Add(Me.lblRequestedBy)
        Me.Controls.Add(Me.cboRequestedBy)
        Me.Controls.Add(Me.lblAddContact)
        Me.Controls.Add(Me.cboAddContact)
        Me.Controls.Add(Me.lblCadenceID)
        Me.Controls.Add(Me.cboCadenceID)
        Me.Controls.Add(Me.lblOrderNbr)
        Me.Controls.Add(Me.txtOrderNbr)
        Me.Controls.Add(Me.lblPC_Nbr)
        Me.Controls.Add(Me.txtPC_Nbr)
        Me.Controls.Add(Me.pnlNewAccount)
        Me.Controls.Add(Me.pnlNewUser)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdClose)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TicketNewForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Help Desk Ticket"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.pnlNewAccount.ResumeLayout(False)
        Me.pnlNewAccount.PerformLayout()
        Me.pnlNewUser.ResumeLayout(False)
        Me.pnlNewUser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents optGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents optNewAccount As System.Windows.Forms.RadioButton
    Friend WithEvents optNewUser As System.Windows.Forms.RadioButton
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents cboUserID As System.Windows.Forms.ComboBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents cboAccount As System.Windows.Forms.ComboBox
    Friend WithEvents lblSoftware As System.Windows.Forms.Label
    Friend WithEvents cboSoftware As System.Windows.Forms.ComboBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents cboPriority As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateNeeded As System.Windows.Forms.Label
    Friend WithEvents dtpDateNeeded As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRequestedBy As System.Windows.Forms.Label
    Friend WithEvents cboRequestedBy As System.Windows.Forms.ComboBox
    Friend WithEvents lblAddContact As System.Windows.Forms.Label
    Friend WithEvents cboAddContact As System.Windows.Forms.ComboBox
    Friend WithEvents lblCadenceID As System.Windows.Forms.Label
    Friend WithEvents cboCadenceID As System.Windows.Forms.ComboBox
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
End Class
