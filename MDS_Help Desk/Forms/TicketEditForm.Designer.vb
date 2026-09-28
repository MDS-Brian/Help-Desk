<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicketEditForm
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
        grpStatus = New GroupBox()
        optOpen = New RadioButton()
        optClosed = New RadioButton()
        optAll = New RadioButton()
        grpAssigned = New GroupBox()
        optAnyAssigned = New RadioButton()
        optAssigned = New RadioButton()
        optNotAssigned = New RadioButton()
        lblQuickFind = New Label()
        txtQuickFind = New TextBox()
        cmdSearch = New Button()
        lblCount = New Label()
        lblFilterAccount = New Label()
        cboFilterAccount = New BorderedComboBox()
        lblFilterUser = New Label()
        cboFilterUser = New BorderedComboBox()
        lblFilterPriority = New Label()
        cboFilterPriority = New BorderedComboBox()
        cmdClearFilter = New Button()
        dgvTickets = New DataGridView()
        grpTicket = New GroupBox()
        lblTicketNo = New Label()
        txtTicketNo = New TextBox()
        lblAccount = New Label()
        cboAccount = New BorderedComboBox()
        lblRequestBy = New Label()
        cboRequestBy = New BorderedComboBox()
        lblAddContact = New Label()
        cboAddContact = New BorderedComboBox()
        lblCadenceID = New Label()
        txtCadenceID = New TextBox()
        cmdCadenceStatus = New Button()
        lblOrderNbr = New Label()
        txtOrderNbr = New TextBox()
        lblPC_Nbr = New Label()
        txtPC_Nbr = New TextBox()
        lblStatus = New Label()
        cboStatus = New BorderedComboBox()
        lblPriority = New Label()
        cboPriority = New BorderedComboBox()
        lblSoftware = New Label()
        cboSoftware = New BorderedComboBox()
        lblAssignedTo = New Label()
        cboAssignedTo = New BorderedComboBox()
        lblTier = New Label()
        cboTier = New BorderedComboBox()
        lblResolution = New Label()
        cboResolution = New BorderedComboBox()
        lblRequestDate = New Label()
        dtpRequestDate = New DateTimePicker()
        lblNeedBy = New Label()
        dtpNeedBy = New DateTimePicker()
        lblCloseDate = New Label()
        txtCloseDate = New TextBox()
        lblAutoClose = New Label()
        dtpAutoClose = New DateTimePicker()
        lblNotes = New Label()
        txtNotes = New TextBox()
        lblDescription = New Label()
        txtDescription = New TextBox()
        chkNotifyUpdates = New CheckBox()
        chkNotifyClose = New CheckBox()
        cmdQuickPrint = New Button()
        cmdUpdateTicket = New Button()
        cmdCloseTicket = New Button()
        cmdReset = New Button()
        cmdClose = New Button()
        lblAttachment = New Label()
        cmdOpenAttachment = New Button()
        grpStatus.SuspendLayout()
        grpAssigned.SuspendLayout()
        CType(dgvTickets, ComponentModel.ISupportInitialize).BeginInit()
        grpTicket.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpStatus
        ' 
        grpStatus.Controls.Add(optOpen)
        grpStatus.Controls.Add(optClosed)
        grpStatus.Controls.Add(optAll)
        grpStatus.Location = New Point(12, 6)
        grpStatus.Name = "grpStatus"
        grpStatus.Size = New Size(250, 54)
        grpStatus.TabIndex = 0
        grpStatus.TabStop = False
        grpStatus.Text = "Status"
        ' 
        ' optOpen
        ' 
        optOpen.AutoSize = True
        optOpen.Checked = True
        optOpen.Location = New Point(12, 22)
        optOpen.Name = "optOpen"
        optOpen.Size = New Size(60, 22)
        optOpen.TabIndex = 0
        optOpen.TabStop = True
        optOpen.Text = "Open"
        optOpen.UseVisualStyleBackColor = True
        ' 
        ' optClosed
        ' 
        optClosed.AutoSize = True
        optClosed.Location = New Point(90, 22)
        optClosed.Name = "optClosed"
        optClosed.Size = New Size(68, 22)
        optClosed.TabIndex = 1
        optClosed.Text = "Closed"
        optClosed.UseVisualStyleBackColor = True
        ' 
        ' optAll
        ' 
        optAll.AutoSize = True
        optAll.Location = New Point(175, 22)
        optAll.Name = "optAll"
        optAll.Size = New Size(43, 22)
        optAll.TabIndex = 2
        optAll.Text = "All"
        optAll.UseVisualStyleBackColor = True
        ' 
        ' grpAssigned
        ' 
        grpAssigned.Controls.Add(optAnyAssigned)
        grpAssigned.Controls.Add(optAssigned)
        grpAssigned.Controls.Add(optNotAssigned)
        grpAssigned.Location = New Point(272, 6)
        grpAssigned.Name = "grpAssigned"
        grpAssigned.Size = New Size(330, 54)
        grpAssigned.TabIndex = 1
        grpAssigned.TabStop = False
        grpAssigned.Text = "Assignment"
        ' 
        ' optAnyAssigned
        ' 
        optAnyAssigned.AutoSize = True
        optAnyAssigned.Checked = True
        optAnyAssigned.Location = New Point(12, 22)
        optAnyAssigned.Name = "optAnyAssigned"
        optAnyAssigned.Size = New Size(50, 22)
        optAnyAssigned.TabIndex = 0
        optAnyAssigned.TabStop = True
        optAnyAssigned.Text = "Any"
        optAnyAssigned.UseVisualStyleBackColor = True
        ' 
        ' optAssigned
        ' 
        optAssigned.AutoSize = True
        optAssigned.Location = New Point(80, 22)
        optAssigned.Name = "optAssigned"
        optAssigned.Size = New Size(82, 22)
        optAssigned.TabIndex = 1
        optAssigned.Text = "Assigned"
        optAssigned.UseVisualStyleBackColor = True
        ' 
        ' optNotAssigned
        ' 
        optNotAssigned.AutoSize = True
        optNotAssigned.Location = New Point(185, 22)
        optNotAssigned.Name = "optNotAssigned"
        optNotAssigned.Size = New Size(108, 22)
        optNotAssigned.TabIndex = 2
        optNotAssigned.Text = "Not Assigned"
        optNotAssigned.UseVisualStyleBackColor = True
        ' 
        ' lblQuickFind
        ' 
        lblQuickFind.Location = New Point(620, 24)
        lblQuickFind.Name = "lblQuickFind"
        lblQuickFind.Size = New Size(70, 23)
        lblQuickFind.TabIndex = 2
        lblQuickFind.Text = "Ticket No"
        lblQuickFind.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtQuickFind
        ' 
        txtQuickFind.Location = New Point(695, 22)
        txtQuickFind.MaxLength = 10
        txtQuickFind.Name = "txtQuickFind"
        txtQuickFind.Size = New Size(90, 25)
        txtQuickFind.TabIndex = 3
        ' 
        ' cmdSearch
        ' 
        cmdSearch.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdSearch.FlatAppearance.BorderColor = Color.Black
        cmdSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdSearch.FlatStyle = FlatStyle.Flat
        cmdSearch.Font = New Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdSearch.Location = New Point(795, 17)
        cmdSearch.Name = "cmdSearch"
        cmdSearch.Size = New Size(110, 36)
        cmdSearch.TabIndex = 4
        cmdSearch.Text = "Search"
        cmdSearch.UseVisualStyleBackColor = False
        ' 
        ' lblCount
        ' 
        lblCount.Font = New Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCount.Location = New Point(920, 24)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(248, 23)
        lblCount.TabIndex = 5
        lblCount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblFilterAccount
        ' 
        lblFilterAccount.Location = New Point(12, 68)
        lblFilterAccount.Name = "lblFilterAccount"
        lblFilterAccount.Size = New Size(65, 23)
        lblFilterAccount.TabIndex = 6
        lblFilterAccount.Text = "Account"
        lblFilterAccount.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboFilterAccount
        ' 
        cboFilterAccount.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterAccount.Location = New Point(80, 66)
        cboFilterAccount.Name = "cboFilterAccount"
        cboFilterAccount.Size = New Size(270, 26)
        cboFilterAccount.TabIndex = 7
        ' 
        ' lblFilterUser
        ' 
        lblFilterUser.Location = New Point(365, 68)
        lblFilterUser.Name = "lblFilterUser"
        lblFilterUser.Size = New Size(95, 23)
        lblFilterUser.TabIndex = 8
        lblFilterUser.Text = "Requested By"
        lblFilterUser.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboFilterUser
        ' 
        cboFilterUser.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterUser.Location = New Point(462, 66)
        cboFilterUser.Name = "cboFilterUser"
        cboFilterUser.Size = New Size(200, 26)
        cboFilterUser.TabIndex = 9
        ' 
        ' lblFilterPriority
        ' 
        lblFilterPriority.Location = New Point(677, 68)
        lblFilterPriority.Name = "lblFilterPriority"
        lblFilterPriority.Size = New Size(55, 23)
        lblFilterPriority.TabIndex = 10
        lblFilterPriority.Text = "Priority"
        lblFilterPriority.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboFilterPriority
        ' 
        cboFilterPriority.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterPriority.Location = New Point(735, 66)
        cboFilterPriority.Name = "cboFilterPriority"
        cboFilterPriority.Size = New Size(170, 26)
        cboFilterPriority.TabIndex = 11
        ' 
        ' cmdClearFilter
        ' 
        cmdClearFilter.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdClearFilter.FlatAppearance.BorderColor = Color.Black
        cmdClearFilter.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdClearFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdClearFilter.FlatStyle = FlatStyle.Flat
        cmdClearFilter.Font = New Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdClearFilter.Location = New Point(920, 61)
        cmdClearFilter.Name = "cmdClearFilter"
        cmdClearFilter.Size = New Size(130, 36)
        cmdClearFilter.TabIndex = 12
        cmdClearFilter.Text = "Clear Filters"
        cmdClearFilter.UseVisualStyleBackColor = False
        ' 
        ' dgvTickets
        ' 
        dgvTickets.AllowUserToAddRows = False
        dgvTickets.AllowUserToDeleteRows = False
        dgvTickets.AllowUserToResizeRows = False
        dgvTickets.BackgroundColor = Color.White
        dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTickets.Location = New Point(12, 104)
        dgvTickets.MultiSelect = False
        dgvTickets.Name = "dgvTickets"
        dgvTickets.ReadOnly = True
        dgvTickets.RowHeadersVisible = False
        dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTickets.Size = New Size(1156, 290)
        dgvTickets.TabIndex = 13
        ' 
        ' grpTicket
        ' 
        grpTicket.Controls.Add(lblTicketNo)
        grpTicket.Controls.Add(txtTicketNo)
        grpTicket.Controls.Add(lblAccount)
        grpTicket.Controls.Add(cboAccount)
        grpTicket.Controls.Add(lblRequestBy)
        grpTicket.Controls.Add(cboRequestBy)
        grpTicket.Controls.Add(lblAddContact)
        grpTicket.Controls.Add(cboAddContact)
        grpTicket.Controls.Add(lblCadenceID)
        grpTicket.Controls.Add(txtCadenceID)
        grpTicket.Controls.Add(cmdCadenceStatus)
        grpTicket.Controls.Add(lblOrderNbr)
        grpTicket.Controls.Add(txtOrderNbr)
        grpTicket.Controls.Add(lblPC_Nbr)
        grpTicket.Controls.Add(txtPC_Nbr)
        grpTicket.Controls.Add(lblStatus)
        grpTicket.Controls.Add(cboStatus)
        grpTicket.Controls.Add(lblPriority)
        grpTicket.Controls.Add(cboPriority)
        grpTicket.Controls.Add(lblSoftware)
        grpTicket.Controls.Add(cboSoftware)
        grpTicket.Controls.Add(lblAssignedTo)
        grpTicket.Controls.Add(cboAssignedTo)
        grpTicket.Controls.Add(lblTier)
        grpTicket.Controls.Add(cboTier)
        grpTicket.Controls.Add(lblResolution)
        grpTicket.Controls.Add(cboResolution)
        grpTicket.Controls.Add(lblRequestDate)
        grpTicket.Controls.Add(dtpRequestDate)
        grpTicket.Controls.Add(lblNeedBy)
        grpTicket.Controls.Add(dtpNeedBy)
        grpTicket.Controls.Add(lblCloseDate)
        grpTicket.Controls.Add(txtCloseDate)
        grpTicket.Controls.Add(lblAutoClose)
        grpTicket.Controls.Add(dtpAutoClose)
        grpTicket.Controls.Add(lblNotes)
        grpTicket.Controls.Add(txtNotes)
        grpTicket.Controls.Add(lblDescription)
        grpTicket.Controls.Add(txtDescription)
        grpTicket.Controls.Add(lblAttachment)
        grpTicket.Controls.Add(cmdOpenAttachment)
        grpTicket.Enabled = False
        grpTicket.Location = New Point(12, 402)
        grpTicket.Name = "grpTicket"
        grpTicket.Size = New Size(1156, 356)
        grpTicket.TabIndex = 14
        grpTicket.TabStop = False
        grpTicket.Text = "Ticket (double-click a ticket above to open it)"
        ' 
        ' lblTicketNo
        ' 
        lblTicketNo.Location = New Point(12, 26)
        lblTicketNo.Name = "lblTicketNo"
        lblTicketNo.Size = New Size(110, 23)
        lblTicketNo.TabIndex = 0
        lblTicketNo.Text = "Current Ticket"
        lblTicketNo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtTicketNo
        ' 
        txtTicketNo.BorderStyle = BorderStyle.FixedSingle
        txtTicketNo.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtTicketNo.Location = New Point(125, 24)
        txtTicketNo.Name = "txtTicketNo"
        txtTicketNo.ReadOnly = True
        txtTicketNo.Size = New Size(100, 22)
        txtTicketNo.TabIndex = 1
        txtTicketNo.TabStop = False
        ' 
        ' lblAccount
        ' 
        lblAccount.Location = New Point(12, 58)
        lblAccount.Name = "lblAccount"
        lblAccount.Size = New Size(110, 23)
        lblAccount.TabIndex = 2
        lblAccount.Text = "Account No"
        lblAccount.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboAccount
        ' 
        cboAccount.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboAccount.AutoCompleteSource = AutoCompleteSource.ListItems
        cboAccount.Font = New Font("Microsoft Sans Serif", 9.75F)
        cboAccount.Location = New Point(125, 56)
        cboAccount.Name = "cboAccount"
        cboAccount.Size = New Size(245, 24)
        cboAccount.TabIndex = 3
        ' 
        ' lblRequestBy
        ' 
        lblRequestBy.Location = New Point(12, 90)
        lblRequestBy.Name = "lblRequestBy"
        lblRequestBy.Size = New Size(110, 23)
        lblRequestBy.TabIndex = 4
        lblRequestBy.Text = "Requested By"
        lblRequestBy.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboRequestBy
        ' 
        cboRequestBy.DropDownStyle = ComboBoxStyle.DropDownList
        cboRequestBy.Font = New Font("Microsoft Sans Serif", 9.75F)
        cboRequestBy.Location = New Point(125, 88)
        cboRequestBy.Name = "cboRequestBy"
        cboRequestBy.Size = New Size(245, 24)
        cboRequestBy.TabIndex = 5
        ' 
        ' lblAddContact
        ' 
        lblAddContact.Location = New Point(12, 122)
        lblAddContact.Name = "lblAddContact"
        lblAddContact.Size = New Size(110, 23)
        lblAddContact.TabIndex = 6
        lblAddContact.Text = "Add'l Contact"
        lblAddContact.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboAddContact
        ' 
        cboAddContact.DropDownStyle = ComboBoxStyle.DropDownList
        cboAddContact.Font = New Font("Microsoft Sans Serif", 9.75F)
        cboAddContact.Location = New Point(125, 120)
        cboAddContact.Name = "cboAddContact"
        cboAddContact.Size = New Size(245, 24)
        cboAddContact.TabIndex = 7
        ' 
        ' lblCadenceID
        ' 
        lblCadenceID.Location = New Point(12, 154)
        lblCadenceID.Name = "lblCadenceID"
        lblCadenceID.Size = New Size(110, 23)
        lblCadenceID.TabIndex = 8
        lblCadenceID.Text = "Cadence ID"
        lblCadenceID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCadenceID
        ' 
        txtCadenceID.CharacterCasing = CharacterCasing.Upper
        txtCadenceID.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtCadenceID.Location = New Point(125, 152)
        txtCadenceID.MaxLength = 15
        txtCadenceID.Name = "txtCadenceID"
        txtCadenceID.Size = New Size(150, 22)
        txtCadenceID.TabIndex = 9
        ' 
        ' cmdCadenceStatus
        ' 
        cmdCadenceStatus.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdCadenceStatus.FlatAppearance.BorderColor = Color.Black
        cmdCadenceStatus.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdCadenceStatus.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdCadenceStatus.FlatStyle = FlatStyle.Flat
        cmdCadenceStatus.Location = New Point(282, 150)
        cmdCadenceStatus.Name = "cmdCadenceStatus"
        cmdCadenceStatus.Size = New Size(88, 30)
        cmdCadenceStatus.TabIndex = 10
        cmdCadenceStatus.Text = "Status"
        cmdCadenceStatus.UseVisualStyleBackColor = False
        ' 
        ' lblOrderNbr
        ' 
        lblOrderNbr.Location = New Point(12, 186)
        lblOrderNbr.Name = "lblOrderNbr"
        lblOrderNbr.Size = New Size(110, 23)
        lblOrderNbr.TabIndex = 11
        lblOrderNbr.Text = "Order Nbr"
        lblOrderNbr.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtOrderNbr
        ' 
        txtOrderNbr.Location = New Point(125, 184)
        txtOrderNbr.MaxLength = 25
        txtOrderNbr.Name = "txtOrderNbr"
        txtOrderNbr.Size = New Size(245, 25)
        txtOrderNbr.TabIndex = 12
        ' 
        ' lblPC_Nbr
        ' 
        lblPC_Nbr.Location = New Point(12, 218)
        lblPC_Nbr.Name = "lblPC_Nbr"
        lblPC_Nbr.Size = New Size(110, 23)
        lblPC_Nbr.TabIndex = 13
        lblPC_Nbr.Text = "PC Nbr"
        lblPC_Nbr.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtPC_Nbr
        ' 
        txtPC_Nbr.Location = New Point(125, 216)
        txtPC_Nbr.MaxLength = 10
        txtPC_Nbr.Name = "txtPC_Nbr"
        txtPC_Nbr.Size = New Size(245, 25)
        txtPC_Nbr.TabIndex = 14
        ' 
        ' lblAttachment
        ' 
        lblAttachment.Location = New Point(390, 218)
        lblAttachment.Name = "lblAttachment"
        lblAttachment.Size = New Size(95, 23)
        lblAttachment.TabIndex = 39
        lblAttachment.Text = "Attachment"
        lblAttachment.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmdOpenAttachment
        ' 
        cmdOpenAttachment.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdOpenAttachment.Enabled = False
        cmdOpenAttachment.FlatAppearance.BorderColor = Color.Black
        cmdOpenAttachment.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdOpenAttachment.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdOpenAttachment.FlatStyle = FlatStyle.Flat
        cmdOpenAttachment.Location = New Point(488, 214)
        cmdOpenAttachment.Name = "cmdOpenAttachment"
        cmdOpenAttachment.Size = New Size(230, 30)
        cmdOpenAttachment.TabIndex = 40
        cmdOpenAttachment.Text = "Open Attachment"
        cmdOpenAttachment.UseVisualStyleBackColor = False
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(390, 26)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(95, 23)
        lblStatus.TabIndex = 15
        lblStatus.Text = "Status"
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Location = New Point(488, 24)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(230, 26)
        cboStatus.TabIndex = 16
        ' 
        ' lblPriority
        ' 
        lblPriority.Location = New Point(390, 58)
        lblPriority.Name = "lblPriority"
        lblPriority.Size = New Size(95, 23)
        lblPriority.TabIndex = 17
        lblPriority.Text = "Priority"
        lblPriority.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboPriority
        ' 
        cboPriority.DropDownStyle = ComboBoxStyle.DropDownList
        cboPriority.Location = New Point(488, 56)
        cboPriority.Name = "cboPriority"
        cboPriority.Size = New Size(230, 26)
        cboPriority.TabIndex = 18
        ' 
        ' lblSoftware
        ' 
        lblSoftware.Location = New Point(390, 90)
        lblSoftware.Name = "lblSoftware"
        lblSoftware.Size = New Size(95, 23)
        lblSoftware.TabIndex = 19
        lblSoftware.Text = "Software"
        lblSoftware.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboSoftware
        ' 
        cboSoftware.DropDownStyle = ComboBoxStyle.DropDownList
        cboSoftware.Location = New Point(488, 88)
        cboSoftware.Name = "cboSoftware"
        cboSoftware.Size = New Size(230, 26)
        cboSoftware.TabIndex = 20
        ' 
        ' lblAssignedTo
        ' 
        lblAssignedTo.Location = New Point(390, 122)
        lblAssignedTo.Name = "lblAssignedTo"
        lblAssignedTo.Size = New Size(95, 23)
        lblAssignedTo.TabIndex = 21
        lblAssignedTo.Text = "Assigned To"
        lblAssignedTo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboAssignedTo
        ' 
        cboAssignedTo.DropDownStyle = ComboBoxStyle.DropDownList
        cboAssignedTo.Location = New Point(488, 120)
        cboAssignedTo.Name = "cboAssignedTo"
        cboAssignedTo.Size = New Size(230, 26)
        cboAssignedTo.TabIndex = 22
        ' 
        ' lblTier
        ' 
        lblTier.Location = New Point(390, 154)
        lblTier.Name = "lblTier"
        lblTier.Size = New Size(95, 23)
        lblTier.TabIndex = 23
        lblTier.Text = "Tier Level"
        lblTier.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboTier
        ' 
        cboTier.DropDownStyle = ComboBoxStyle.DropDownList
        cboTier.Location = New Point(488, 152)
        cboTier.Name = "cboTier"
        cboTier.Size = New Size(230, 26)
        cboTier.TabIndex = 24
        ' 
        ' lblResolution
        ' 
        lblResolution.Location = New Point(390, 186)
        lblResolution.Name = "lblResolution"
        lblResolution.Size = New Size(95, 23)
        lblResolution.TabIndex = 25
        lblResolution.Text = "Resolution"
        lblResolution.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboResolution
        ' 
        cboResolution.DropDownStyle = ComboBoxStyle.DropDownList
        cboResolution.Location = New Point(488, 184)
        cboResolution.Name = "cboResolution"
        cboResolution.Size = New Size(230, 26)
        cboResolution.TabIndex = 26
        ' 
        ' lblRequestDate
        ' 
        lblRequestDate.Location = New Point(735, 26)
        lblRequestDate.Name = "lblRequestDate"
        lblRequestDate.Size = New Size(115, 23)
        lblRequestDate.TabIndex = 27
        lblRequestDate.Text = "Request Date"
        lblRequestDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpRequestDate
        ' 
        dtpRequestDate.CustomFormat = "MM/dd/yyyy  h:mm tt"
        dtpRequestDate.Format = DateTimePickerFormat.Custom
        dtpRequestDate.Location = New Point(853, 24)
        dtpRequestDate.Name = "dtpRequestDate"
        dtpRequestDate.Size = New Size(290, 25)
        dtpRequestDate.TabIndex = 28
        ' 
        ' lblNeedBy
        ' 
        lblNeedBy.Location = New Point(735, 58)
        lblNeedBy.Name = "lblNeedBy"
        lblNeedBy.Size = New Size(115, 23)
        lblNeedBy.TabIndex = 29
        lblNeedBy.Text = "Needed By Date"
        lblNeedBy.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpNeedBy
        ' 
        dtpNeedBy.CustomFormat = "MM/dd/yyyy  h:mm tt"
        dtpNeedBy.Format = DateTimePickerFormat.Custom
        dtpNeedBy.Location = New Point(853, 56)
        dtpNeedBy.Name = "dtpNeedBy"
        dtpNeedBy.ShowCheckBox = True
        dtpNeedBy.Size = New Size(290, 25)
        dtpNeedBy.TabIndex = 30
        ' 
        ' lblCloseDate
        ' 
        lblCloseDate.Location = New Point(735, 90)
        lblCloseDate.Name = "lblCloseDate"
        lblCloseDate.Size = New Size(115, 23)
        lblCloseDate.TabIndex = 31
        lblCloseDate.Text = "Close Date"
        lblCloseDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCloseDate
        ' 
        txtCloseDate.Location = New Point(853, 88)
        txtCloseDate.Name = "txtCloseDate"
        txtCloseDate.ReadOnly = True
        txtCloseDate.Size = New Size(290, 25)
        txtCloseDate.TabIndex = 32
        txtCloseDate.TabStop = False
        ' 
        ' lblAutoClose
        ' 
        lblAutoClose.Location = New Point(735, 122)
        lblAutoClose.Name = "lblAutoClose"
        lblAutoClose.Size = New Size(115, 23)
        lblAutoClose.TabIndex = 33
        lblAutoClose.Text = "Auto Close Date"
        lblAutoClose.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpAutoClose
        ' 
        dtpAutoClose.Format = DateTimePickerFormat.Short
        dtpAutoClose.Location = New Point(853, 120)
        dtpAutoClose.Name = "dtpAutoClose"
        dtpAutoClose.ShowCheckBox = True
        dtpAutoClose.Size = New Size(290, 25)
        dtpAutoClose.TabIndex = 34
        ' 
        ' lblNotes
        ' 
        lblNotes.Location = New Point(735, 154)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(115, 23)
        lblNotes.TabIndex = 35
        lblNotes.Text = "Notes"
        lblNotes.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNotes
        ' 
        txtNotes.AcceptsReturn = True
        txtNotes.Location = New Point(853, 152)
        txtNotes.MaxLength = 1000
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.ScrollBars = ScrollBars.Vertical
        txtNotes.Size = New Size(290, 194)
        txtNotes.TabIndex = 36
        ' 
        ' lblDescription
        ' 
        lblDescription.Location = New Point(12, 254)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(110, 23)
        lblDescription.TabIndex = 37
        lblDescription.Text = "Description"
        lblDescription.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtDescription
        ' 
        txtDescription.AcceptsReturn = True
        txtDescription.Location = New Point(125, 252)
        txtDescription.MaxLength = 1024
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ScrollBars = ScrollBars.Vertical
        txtDescription.Size = New Size(593, 94)
        txtDescription.TabIndex = 38
        ' 
        ' chkNotifyUpdates
        ' 
        chkNotifyUpdates.AutoSize = True
        chkNotifyUpdates.Location = New Point(14, 778)
        chkNotifyUpdates.Name = "chkNotifyUpdates"
        chkNotifyUpdates.Size = New Size(119, 22)
        chkNotifyUpdates.TabIndex = 15
        chkNotifyUpdates.Text = "Notify Updates"
        chkNotifyUpdates.UseVisualStyleBackColor = True
        ' 
        ' chkNotifyClose
        ' 
        chkNotifyClose.AutoSize = True
        chkNotifyClose.Checked = True
        chkNotifyClose.CheckState = CheckState.Checked
        chkNotifyClose.Location = New Point(160, 778)
        chkNotifyClose.Name = "chkNotifyClose"
        chkNotifyClose.Size = New Size(102, 22)
        chkNotifyClose.TabIndex = 16
        chkNotifyClose.Text = "Notify Close"
        chkNotifyClose.UseVisualStyleBackColor = True
        ' 
        ' cmdQuickPrint
        ' 
        cmdQuickPrint.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdQuickPrint.FlatAppearance.BorderColor = Color.Black
        cmdQuickPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdQuickPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdQuickPrint.FlatStyle = FlatStyle.Flat
        cmdQuickPrint.Font = New Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdQuickPrint.Location = New Point(408, 768)
        cmdQuickPrint.Name = "cmdQuickPrint"
        cmdQuickPrint.Size = New Size(144, 40)
        cmdQuickPrint.TabIndex = 21
        cmdQuickPrint.Text = "Quick Print"
        cmdQuickPrint.UseVisualStyleBackColor = False
        ' 
        ' cmdUpdateTicket
        ' 
        cmdUpdateTicket.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdUpdateTicket.Enabled = False
        cmdUpdateTicket.FlatAppearance.BorderColor = Color.Black
        cmdUpdateTicket.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdUpdateTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdUpdateTicket.FlatStyle = FlatStyle.Flat
        cmdUpdateTicket.Font = New Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdUpdateTicket.Location = New Point(560, 768)
        cmdUpdateTicket.Name = "cmdUpdateTicket"
        cmdUpdateTicket.Size = New Size(144, 40)
        cmdUpdateTicket.TabIndex = 17
        cmdUpdateTicket.Text = "Update Ticket"
        cmdUpdateTicket.UseVisualStyleBackColor = False
        ' 
        ' cmdCloseTicket
        ' 
        cmdCloseTicket.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdCloseTicket.Enabled = False
        cmdCloseTicket.FlatAppearance.BorderColor = Color.Black
        cmdCloseTicket.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(250), CByte(140), CByte(60))
        cmdCloseTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(250), CByte(140), CByte(60))
        cmdCloseTicket.FlatStyle = FlatStyle.Flat
        cmdCloseTicket.Font = New Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdCloseTicket.Location = New Point(712, 768)
        cmdCloseTicket.Name = "cmdCloseTicket"
        cmdCloseTicket.Size = New Size(144, 40)
        cmdCloseTicket.TabIndex = 18
        cmdCloseTicket.Text = "Close Ticket"
        cmdCloseTicket.UseVisualStyleBackColor = False
        ' 
        ' cmdReset
        ' 
        cmdReset.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdReset.FlatAppearance.BorderColor = Color.Black
        cmdReset.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdReset.FlatStyle = FlatStyle.Flat
        cmdReset.Font = New Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdReset.Location = New Point(864, 768)
        cmdReset.Name = "cmdReset"
        cmdReset.Size = New Size(144, 40)
        cmdReset.TabIndex = 19
        cmdReset.Text = "Reset"
        cmdReset.UseVisualStyleBackColor = False
        ' 
        ' cmdClose
        ' 
        cmdClose.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cmdClose.FlatAppearance.BorderColor = Color.Black
        cmdClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(189), CByte(215), CByte(238))
        cmdClose.FlatStyle = FlatStyle.Flat
        cmdClose.Font = New Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdClose.Location = New Point(1016, 768)
        cmdClose.Name = "cmdClose"
        cmdClose.Size = New Size(144, 40)
        cmdClose.TabIndex = 20
        cmdClose.Text = "Close"
        cmdClose.UseVisualStyleBackColor = False
        ' 
        ' TicketEditForm
        ' 
        AcceptButton = cmdSearch
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(142), CByte(187), CByte(245))
        ClientSize = New Size(1180, 820)
        Controls.Add(grpStatus)
        Controls.Add(grpAssigned)
        Controls.Add(lblQuickFind)
        Controls.Add(txtQuickFind)
        Controls.Add(cmdSearch)
        Controls.Add(lblCount)
        Controls.Add(lblFilterAccount)
        Controls.Add(cboFilterAccount)
        Controls.Add(lblFilterUser)
        Controls.Add(cboFilterUser)
        Controls.Add(lblFilterPriority)
        Controls.Add(cboFilterPriority)
        Controls.Add(cmdClearFilter)
        Controls.Add(dgvTickets)
        Controls.Add(grpTicket)
        Controls.Add(chkNotifyUpdates)
        Controls.Add(chkNotifyClose)
        Controls.Add(cmdQuickPrint)
        Controls.Add(cmdUpdateTicket)
        Controls.Add(cmdCloseTicket)
        Controls.Add(cmdReset)
        Controls.Add(cmdClose)
        Font = New Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "TicketEditForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Edit Help Desk Tickets"
        grpStatus.ResumeLayout(False)
        grpStatus.PerformLayout()
        grpAssigned.ResumeLayout(False)
        grpAssigned.PerformLayout()
        CType(dgvTickets, ComponentModel.ISupportInitialize).EndInit()
        grpTicket.ResumeLayout(False)
        grpTicket.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents grpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents optOpen As System.Windows.Forms.RadioButton
    Friend WithEvents optClosed As System.Windows.Forms.RadioButton
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents grpAssigned As System.Windows.Forms.GroupBox
    Friend WithEvents optAnyAssigned As System.Windows.Forms.RadioButton
    Friend WithEvents optAssigned As System.Windows.Forms.RadioButton
    Friend WithEvents optNotAssigned As System.Windows.Forms.RadioButton
    Friend WithEvents lblQuickFind As System.Windows.Forms.Label
    Friend WithEvents txtQuickFind As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents lblFilterAccount As System.Windows.Forms.Label
    Friend WithEvents cboFilterAccount As BorderedComboBox
    Friend WithEvents lblFilterUser As System.Windows.Forms.Label
    Friend WithEvents cboFilterUser As BorderedComboBox
    Friend WithEvents lblFilterPriority As System.Windows.Forms.Label
    Friend WithEvents cboFilterPriority As BorderedComboBox
    Friend WithEvents cmdClearFilter As System.Windows.Forms.Button
    Friend WithEvents dgvTickets As System.Windows.Forms.DataGridView
    Friend WithEvents grpTicket As System.Windows.Forms.GroupBox
    Friend WithEvents lblTicketNo As System.Windows.Forms.Label
    Friend WithEvents txtTicketNo As System.Windows.Forms.TextBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents cboAccount As BorderedComboBox
    Friend WithEvents lblRequestBy As System.Windows.Forms.Label
    Friend WithEvents cboRequestBy As BorderedComboBox
    Friend WithEvents lblAddContact As System.Windows.Forms.Label
    Friend WithEvents cboAddContact As BorderedComboBox
    Friend WithEvents lblCadenceID As System.Windows.Forms.Label
    Friend WithEvents txtCadenceID As System.Windows.Forms.TextBox
    Friend WithEvents cmdCadenceStatus As System.Windows.Forms.Button
    Friend WithEvents lblOrderNbr As System.Windows.Forms.Label
    Friend WithEvents txtOrderNbr As System.Windows.Forms.TextBox
    Friend WithEvents lblPC_Nbr As System.Windows.Forms.Label
    Friend WithEvents txtPC_Nbr As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As BorderedComboBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents cboPriority As BorderedComboBox
    Friend WithEvents lblSoftware As System.Windows.Forms.Label
    Friend WithEvents cboSoftware As BorderedComboBox
    Friend WithEvents lblAssignedTo As System.Windows.Forms.Label
    Friend WithEvents cboAssignedTo As BorderedComboBox
    Friend WithEvents lblTier As System.Windows.Forms.Label
    Friend WithEvents cboTier As BorderedComboBox
    Friend WithEvents lblResolution As System.Windows.Forms.Label
    Friend WithEvents cboResolution As BorderedComboBox
    Friend WithEvents lblRequestDate As System.Windows.Forms.Label
    Friend WithEvents dtpRequestDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNeedBy As System.Windows.Forms.Label
    Friend WithEvents dtpNeedBy As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCloseDate As System.Windows.Forms.Label
    Friend WithEvents txtCloseDate As System.Windows.Forms.TextBox
    Friend WithEvents lblAutoClose As System.Windows.Forms.Label
    Friend WithEvents dtpAutoClose As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents chkNotifyUpdates As System.Windows.Forms.CheckBox
    Friend WithEvents chkNotifyClose As System.Windows.Forms.CheckBox
    Friend WithEvents cmdQuickPrint As System.Windows.Forms.Button
    Friend WithEvents cmdUpdateTicket As System.Windows.Forms.Button
    Friend WithEvents cmdCloseTicket As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lblAttachment As System.Windows.Forms.Label
    Friend WithEvents cmdOpenAttachment As System.Windows.Forms.Button
End Class
