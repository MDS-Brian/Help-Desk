<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicketEditForm
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
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.optOpen = New System.Windows.Forms.RadioButton()
        Me.optClosed = New System.Windows.Forms.RadioButton()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.grpAssigned = New System.Windows.Forms.GroupBox()
        Me.optAnyAssigned = New System.Windows.Forms.RadioButton()
        Me.optAssigned = New System.Windows.Forms.RadioButton()
        Me.optNotAssigned = New System.Windows.Forms.RadioButton()
        Me.lblQuickFind = New System.Windows.Forms.Label()
        Me.txtQuickFind = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblFilterAccount = New System.Windows.Forms.Label()
        Me.cboFilterAccount = New System.Windows.Forms.ComboBox()
        Me.lblFilterUser = New System.Windows.Forms.Label()
        Me.cboFilterUser = New System.Windows.Forms.ComboBox()
        Me.lblFilterPriority = New System.Windows.Forms.Label()
        Me.cboFilterPriority = New System.Windows.Forms.ComboBox()
        Me.cmdClearFilter = New System.Windows.Forms.Button()
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.grpTicket = New System.Windows.Forms.GroupBox()
        Me.lblTicketNo = New System.Windows.Forms.Label()
        Me.txtTicketNo = New System.Windows.Forms.TextBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.cboAccount = New System.Windows.Forms.ComboBox()
        Me.lblRequestBy = New System.Windows.Forms.Label()
        Me.cboRequestBy = New System.Windows.Forms.ComboBox()
        Me.lblAddContact = New System.Windows.Forms.Label()
        Me.cboAddContact = New System.Windows.Forms.ComboBox()
        Me.lblCadenceID = New System.Windows.Forms.Label()
        Me.txtCadenceID = New System.Windows.Forms.TextBox()
        Me.cmdCadenceStatus = New System.Windows.Forms.Button()
        Me.lblOrderNbr = New System.Windows.Forms.Label()
        Me.txtOrderNbr = New System.Windows.Forms.TextBox()
        Me.lblPC_Nbr = New System.Windows.Forms.Label()
        Me.txtPC_Nbr = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.cboPriority = New System.Windows.Forms.ComboBox()
        Me.lblSoftware = New System.Windows.Forms.Label()
        Me.cboSoftware = New System.Windows.Forms.ComboBox()
        Me.lblAssignedTo = New System.Windows.Forms.Label()
        Me.cboAssignedTo = New System.Windows.Forms.ComboBox()
        Me.lblTier = New System.Windows.Forms.Label()
        Me.cboTier = New System.Windows.Forms.ComboBox()
        Me.lblResolution = New System.Windows.Forms.Label()
        Me.cboResolution = New System.Windows.Forms.ComboBox()
        Me.lblRequestDate = New System.Windows.Forms.Label()
        Me.dtpRequestDate = New System.Windows.Forms.DateTimePicker()
        Me.lblNeedBy = New System.Windows.Forms.Label()
        Me.dtpNeedBy = New System.Windows.Forms.DateTimePicker()
        Me.lblCloseDate = New System.Windows.Forms.Label()
        Me.txtCloseDate = New System.Windows.Forms.TextBox()
        Me.lblAutoClose = New System.Windows.Forms.Label()
        Me.dtpAutoClose = New System.Windows.Forms.DateTimePicker()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.chkNotifyUpdates = New System.Windows.Forms.CheckBox()
        Me.chkNotifyClose = New System.Windows.Forms.CheckBox()
        Me.cmdQuickPrint = New System.Windows.Forms.Button()
        Me.cmdUpdateTicket = New System.Windows.Forms.Button()
        Me.cmdCloseTicket = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpStatus.SuspendLayout()
        Me.grpAssigned.SuspendLayout()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTicket.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.optOpen)
        Me.grpStatus.Controls.Add(Me.optClosed)
        Me.grpStatus.Controls.Add(Me.optAll)
        Me.grpStatus.Location = New System.Drawing.Point(12, 6)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(250, 54)
        Me.grpStatus.TabIndex = 0
        Me.grpStatus.TabStop = False
        Me.grpStatus.Text = "Status"
        '
        'optOpen
        '
        Me.optOpen.AutoSize = True
        Me.optOpen.Checked = True
        Me.optOpen.Location = New System.Drawing.Point(12, 22)
        Me.optOpen.Name = "optOpen"
        Me.optOpen.TabIndex = 0
        Me.optOpen.TabStop = True
        Me.optOpen.Text = "Open"
        Me.optOpen.UseVisualStyleBackColor = True
        '
        'optClosed
        '
        Me.optClosed.AutoSize = True
        Me.optClosed.Location = New System.Drawing.Point(90, 22)
        Me.optClosed.Name = "optClosed"
        Me.optClosed.TabIndex = 1
        Me.optClosed.Text = "Closed"
        Me.optClosed.UseVisualStyleBackColor = True
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.Location = New System.Drawing.Point(175, 22)
        Me.optAll.Name = "optAll"
        Me.optAll.TabIndex = 2
        Me.optAll.Text = "All"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'grpAssigned
        '
        Me.grpAssigned.Controls.Add(Me.optAnyAssigned)
        Me.grpAssigned.Controls.Add(Me.optAssigned)
        Me.grpAssigned.Controls.Add(Me.optNotAssigned)
        Me.grpAssigned.Location = New System.Drawing.Point(272, 6)
        Me.grpAssigned.Name = "grpAssigned"
        Me.grpAssigned.Size = New System.Drawing.Size(330, 54)
        Me.grpAssigned.TabIndex = 1
        Me.grpAssigned.TabStop = False
        Me.grpAssigned.Text = "Assignment"
        '
        'optAnyAssigned
        '
        Me.optAnyAssigned.AutoSize = True
        Me.optAnyAssigned.Checked = True
        Me.optAnyAssigned.Location = New System.Drawing.Point(12, 22)
        Me.optAnyAssigned.Name = "optAnyAssigned"
        Me.optAnyAssigned.TabIndex = 0
        Me.optAnyAssigned.TabStop = True
        Me.optAnyAssigned.Text = "Any"
        Me.optAnyAssigned.UseVisualStyleBackColor = True
        '
        'optAssigned
        '
        Me.optAssigned.AutoSize = True
        Me.optAssigned.Location = New System.Drawing.Point(80, 22)
        Me.optAssigned.Name = "optAssigned"
        Me.optAssigned.TabIndex = 1
        Me.optAssigned.Text = "Assigned"
        Me.optAssigned.UseVisualStyleBackColor = True
        '
        'optNotAssigned
        '
        Me.optNotAssigned.AutoSize = True
        Me.optNotAssigned.Location = New System.Drawing.Point(185, 22)
        Me.optNotAssigned.Name = "optNotAssigned"
        Me.optNotAssigned.TabIndex = 2
        Me.optNotAssigned.Text = "Not Assigned"
        Me.optNotAssigned.UseVisualStyleBackColor = True
        '
        'lblQuickFind
        '
        Me.lblQuickFind.Location = New System.Drawing.Point(620, 24)
        Me.lblQuickFind.Name = "lblQuickFind"
        Me.lblQuickFind.Size = New System.Drawing.Size(70, 23)
        Me.lblQuickFind.TabIndex = 2
        Me.lblQuickFind.Text = "Ticket No"
        Me.lblQuickFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQuickFind
        '
        Me.txtQuickFind.Location = New System.Drawing.Point(695, 22)
        Me.txtQuickFind.MaxLength = 10
        Me.txtQuickFind.Name = "txtQuickFind"
        Me.txtQuickFind.Size = New System.Drawing.Size(90, 26)
        Me.txtQuickFind.TabIndex = 3
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(795, 17)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(110, 36)
        Me.cmdSearch.TabIndex = 4
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(920, 24)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(248, 23)
        Me.lblCount.TabIndex = 5
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFilterAccount
        '
        Me.lblFilterAccount.Location = New System.Drawing.Point(12, 68)
        Me.lblFilterAccount.Name = "lblFilterAccount"
        Me.lblFilterAccount.Size = New System.Drawing.Size(65, 23)
        Me.lblFilterAccount.TabIndex = 6
        Me.lblFilterAccount.Text = "Account"
        Me.lblFilterAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboFilterAccount
        '
        Me.cboFilterAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterAccount.Location = New System.Drawing.Point(80, 66)
        Me.cboFilterAccount.Name = "cboFilterAccount"
        Me.cboFilterAccount.Size = New System.Drawing.Size(270, 26)
        Me.cboFilterAccount.TabIndex = 7
        '
        'lblFilterUser
        '
        Me.lblFilterUser.Location = New System.Drawing.Point(365, 68)
        Me.lblFilterUser.Name = "lblFilterUser"
        Me.lblFilterUser.Size = New System.Drawing.Size(95, 23)
        Me.lblFilterUser.TabIndex = 8
        Me.lblFilterUser.Text = "Requested By"
        Me.lblFilterUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboFilterUser
        '
        Me.cboFilterUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterUser.Location = New System.Drawing.Point(462, 66)
        Me.cboFilterUser.Name = "cboFilterUser"
        Me.cboFilterUser.Size = New System.Drawing.Size(200, 26)
        Me.cboFilterUser.TabIndex = 9
        '
        'lblFilterPriority
        '
        Me.lblFilterPriority.Location = New System.Drawing.Point(677, 68)
        Me.lblFilterPriority.Name = "lblFilterPriority"
        Me.lblFilterPriority.Size = New System.Drawing.Size(55, 23)
        Me.lblFilterPriority.TabIndex = 10
        Me.lblFilterPriority.Text = "Priority"
        Me.lblFilterPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboFilterPriority
        '
        Me.cboFilterPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterPriority.Location = New System.Drawing.Point(735, 66)
        Me.cboFilterPriority.Name = "cboFilterPriority"
        Me.cboFilterPriority.Size = New System.Drawing.Size(170, 26)
        Me.cboFilterPriority.TabIndex = 11
        '
        'cmdClearFilter
        '
        Me.cmdClearFilter.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdClearFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdClearFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClearFilter.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearFilter.Location = New System.Drawing.Point(920, 61)
        Me.cmdClearFilter.Name = "cmdClearFilter"
        Me.cmdClearFilter.Size = New System.Drawing.Size(130, 36)
        Me.cmdClearFilter.TabIndex = 12
        Me.cmdClearFilter.Text = "Clear Filters"
        Me.cmdClearFilter.UseVisualStyleBackColor = False
        '
        'dgvTickets
        '
        Me.dgvTickets.AllowUserToAddRows = False
        Me.dgvTickets.AllowUserToDeleteRows = False
        Me.dgvTickets.AllowUserToResizeRows = False
        Me.dgvTickets.BackgroundColor = System.Drawing.Color.White
        Me.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTickets.Location = New System.Drawing.Point(12, 104)
        Me.dgvTickets.MultiSelect = False
        Me.dgvTickets.Name = "dgvTickets"
        Me.dgvTickets.ReadOnly = True
        Me.dgvTickets.RowHeadersVisible = False
        Me.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTickets.Size = New System.Drawing.Size(1156, 290)
        Me.dgvTickets.TabIndex = 13
        '
        'grpTicket
        '
        Me.grpTicket.Controls.Add(Me.lblTicketNo)
        Me.grpTicket.Controls.Add(Me.txtTicketNo)
        Me.grpTicket.Controls.Add(Me.lblAccount)
        Me.grpTicket.Controls.Add(Me.cboAccount)
        Me.grpTicket.Controls.Add(Me.lblRequestBy)
        Me.grpTicket.Controls.Add(Me.cboRequestBy)
        Me.grpTicket.Controls.Add(Me.lblAddContact)
        Me.grpTicket.Controls.Add(Me.cboAddContact)
        Me.grpTicket.Controls.Add(Me.lblCadenceID)
        Me.grpTicket.Controls.Add(Me.txtCadenceID)
        Me.grpTicket.Controls.Add(Me.cmdCadenceStatus)
        Me.grpTicket.Controls.Add(Me.lblOrderNbr)
        Me.grpTicket.Controls.Add(Me.txtOrderNbr)
        Me.grpTicket.Controls.Add(Me.lblPC_Nbr)
        Me.grpTicket.Controls.Add(Me.txtPC_Nbr)
        Me.grpTicket.Controls.Add(Me.lblStatus)
        Me.grpTicket.Controls.Add(Me.cboStatus)
        Me.grpTicket.Controls.Add(Me.lblPriority)
        Me.grpTicket.Controls.Add(Me.cboPriority)
        Me.grpTicket.Controls.Add(Me.lblSoftware)
        Me.grpTicket.Controls.Add(Me.cboSoftware)
        Me.grpTicket.Controls.Add(Me.lblAssignedTo)
        Me.grpTicket.Controls.Add(Me.cboAssignedTo)
        Me.grpTicket.Controls.Add(Me.lblTier)
        Me.grpTicket.Controls.Add(Me.cboTier)
        Me.grpTicket.Controls.Add(Me.lblResolution)
        Me.grpTicket.Controls.Add(Me.cboResolution)
        Me.grpTicket.Controls.Add(Me.lblRequestDate)
        Me.grpTicket.Controls.Add(Me.dtpRequestDate)
        Me.grpTicket.Controls.Add(Me.lblNeedBy)
        Me.grpTicket.Controls.Add(Me.dtpNeedBy)
        Me.grpTicket.Controls.Add(Me.lblCloseDate)
        Me.grpTicket.Controls.Add(Me.txtCloseDate)
        Me.grpTicket.Controls.Add(Me.lblAutoClose)
        Me.grpTicket.Controls.Add(Me.dtpAutoClose)
        Me.grpTicket.Controls.Add(Me.lblNotes)
        Me.grpTicket.Controls.Add(Me.txtNotes)
        Me.grpTicket.Controls.Add(Me.lblDescription)
        Me.grpTicket.Controls.Add(Me.txtDescription)
        Me.grpTicket.Enabled = False
        Me.grpTicket.Location = New System.Drawing.Point(12, 402)
        Me.grpTicket.Name = "grpTicket"
        Me.grpTicket.Size = New System.Drawing.Size(1156, 356)
        Me.grpTicket.TabIndex = 14
        Me.grpTicket.TabStop = False
        Me.grpTicket.Text = "Ticket (double-click a ticket above to open it)"
        '
        'lblTicketNo
        '
        Me.lblTicketNo.Location = New System.Drawing.Point(12, 26)
        Me.lblTicketNo.Name = "lblTicketNo"
        Me.lblTicketNo.Size = New System.Drawing.Size(110, 23)
        Me.lblTicketNo.TabIndex = 0
        Me.lblTicketNo.Text = "Current Ticket"
        Me.lblTicketNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTicketNo
        '
        Me.txtTicketNo.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicketNo.Location = New System.Drawing.Point(125, 24)
        Me.txtTicketNo.Name = "txtTicketNo"
        Me.txtTicketNo.ReadOnly = True
        Me.txtTicketNo.Size = New System.Drawing.Size(100, 26)
        Me.txtTicketNo.TabIndex = 1
        Me.txtTicketNo.TabStop = False
        '
        'lblAccount
        '
        Me.lblAccount.Location = New System.Drawing.Point(12, 58)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(110, 23)
        Me.lblAccount.TabIndex = 2
        Me.lblAccount.Text = "Account No"
        Me.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAccount
        '
        Me.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccount.Location = New System.Drawing.Point(125, 56)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(245, 26)
        Me.cboAccount.TabIndex = 3
        '
        'lblRequestBy
        '
        Me.lblRequestBy.Location = New System.Drawing.Point(12, 90)
        Me.lblRequestBy.Name = "lblRequestBy"
        Me.lblRequestBy.Size = New System.Drawing.Size(110, 23)
        Me.lblRequestBy.TabIndex = 4
        Me.lblRequestBy.Text = "Requested By"
        Me.lblRequestBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboRequestBy
        '
        Me.cboRequestBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRequestBy.Location = New System.Drawing.Point(125, 88)
        Me.cboRequestBy.Name = "cboRequestBy"
        Me.cboRequestBy.Size = New System.Drawing.Size(245, 26)
        Me.cboRequestBy.TabIndex = 5
        '
        'lblAddContact
        '
        Me.lblAddContact.Location = New System.Drawing.Point(12, 122)
        Me.lblAddContact.Name = "lblAddContact"
        Me.lblAddContact.Size = New System.Drawing.Size(110, 23)
        Me.lblAddContact.TabIndex = 6
        Me.lblAddContact.Text = "Add'l Contact"
        Me.lblAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAddContact
        '
        Me.cboAddContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddContact.Location = New System.Drawing.Point(125, 120)
        Me.cboAddContact.Name = "cboAddContact"
        Me.cboAddContact.Size = New System.Drawing.Size(245, 26)
        Me.cboAddContact.TabIndex = 7
        '
        'lblCadenceID
        '
        Me.lblCadenceID.Location = New System.Drawing.Point(12, 154)
        Me.lblCadenceID.Name = "lblCadenceID"
        Me.lblCadenceID.Size = New System.Drawing.Size(110, 23)
        Me.lblCadenceID.TabIndex = 8
        Me.lblCadenceID.Text = "Cadence ID"
        Me.lblCadenceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCadenceID
        '
        Me.txtCadenceID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCadenceID.Location = New System.Drawing.Point(125, 152)
        Me.txtCadenceID.MaxLength = 15
        Me.txtCadenceID.Name = "txtCadenceID"
        Me.txtCadenceID.Size = New System.Drawing.Size(150, 26)
        Me.txtCadenceID.TabIndex = 9
        '
        'cmdCadenceStatus
        '
        Me.cmdCadenceStatus.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdCadenceStatus.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdCadenceStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdCadenceStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdCadenceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCadenceStatus.Location = New System.Drawing.Point(282, 150)
        Me.cmdCadenceStatus.Name = "cmdCadenceStatus"
        Me.cmdCadenceStatus.Size = New System.Drawing.Size(88, 30)
        Me.cmdCadenceStatus.TabIndex = 10
        Me.cmdCadenceStatus.Text = "Status"
        Me.cmdCadenceStatus.UseVisualStyleBackColor = False
        '
        'lblOrderNbr
        '
        Me.lblOrderNbr.Location = New System.Drawing.Point(12, 186)
        Me.lblOrderNbr.Name = "lblOrderNbr"
        Me.lblOrderNbr.Size = New System.Drawing.Size(110, 23)
        Me.lblOrderNbr.TabIndex = 11
        Me.lblOrderNbr.Text = "Order Nbr"
        Me.lblOrderNbr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOrderNbr
        '
        Me.txtOrderNbr.Location = New System.Drawing.Point(125, 184)
        Me.txtOrderNbr.MaxLength = 25
        Me.txtOrderNbr.Name = "txtOrderNbr"
        Me.txtOrderNbr.Size = New System.Drawing.Size(245, 26)
        Me.txtOrderNbr.TabIndex = 12
        '
        'lblPC_Nbr
        '
        Me.lblPC_Nbr.Location = New System.Drawing.Point(12, 218)
        Me.lblPC_Nbr.Name = "lblPC_Nbr"
        Me.lblPC_Nbr.Size = New System.Drawing.Size(110, 23)
        Me.lblPC_Nbr.TabIndex = 13
        Me.lblPC_Nbr.Text = "PC Nbr"
        Me.lblPC_Nbr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPC_Nbr
        '
        Me.txtPC_Nbr.Location = New System.Drawing.Point(125, 216)
        Me.txtPC_Nbr.MaxLength = 10
        Me.txtPC_Nbr.Name = "txtPC_Nbr"
        Me.txtPC_Nbr.Size = New System.Drawing.Size(245, 26)
        Me.txtPC_Nbr.TabIndex = 14
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(390, 26)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(95, 23)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Status"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Location = New System.Drawing.Point(488, 24)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(230, 26)
        Me.cboStatus.TabIndex = 16
        '
        'lblPriority
        '
        Me.lblPriority.Location = New System.Drawing.Point(390, 58)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(95, 23)
        Me.lblPriority.TabIndex = 17
        Me.lblPriority.Text = "Priority"
        Me.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPriority
        '
        Me.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPriority.Location = New System.Drawing.Point(488, 56)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Size = New System.Drawing.Size(230, 26)
        Me.cboPriority.TabIndex = 18
        '
        'lblSoftware
        '
        Me.lblSoftware.Location = New System.Drawing.Point(390, 90)
        Me.lblSoftware.Name = "lblSoftware"
        Me.lblSoftware.Size = New System.Drawing.Size(95, 23)
        Me.lblSoftware.TabIndex = 19
        Me.lblSoftware.Text = "Software"
        Me.lblSoftware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSoftware
        '
        Me.cboSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSoftware.Location = New System.Drawing.Point(488, 88)
        Me.cboSoftware.Name = "cboSoftware"
        Me.cboSoftware.Size = New System.Drawing.Size(230, 26)
        Me.cboSoftware.TabIndex = 20
        '
        'lblAssignedTo
        '
        Me.lblAssignedTo.Location = New System.Drawing.Point(390, 122)
        Me.lblAssignedTo.Name = "lblAssignedTo"
        Me.lblAssignedTo.Size = New System.Drawing.Size(95, 23)
        Me.lblAssignedTo.TabIndex = 21
        Me.lblAssignedTo.Text = "Assigned To"
        Me.lblAssignedTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAssignedTo
        '
        Me.cboAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAssignedTo.Location = New System.Drawing.Point(488, 120)
        Me.cboAssignedTo.Name = "cboAssignedTo"
        Me.cboAssignedTo.Size = New System.Drawing.Size(230, 26)
        Me.cboAssignedTo.TabIndex = 22
        '
        'lblTier
        '
        Me.lblTier.Location = New System.Drawing.Point(390, 154)
        Me.lblTier.Name = "lblTier"
        Me.lblTier.Size = New System.Drawing.Size(95, 23)
        Me.lblTier.TabIndex = 23
        Me.lblTier.Text = "Tier Level"
        Me.lblTier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboTier
        '
        Me.cboTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTier.Location = New System.Drawing.Point(488, 152)
        Me.cboTier.Name = "cboTier"
        Me.cboTier.Size = New System.Drawing.Size(230, 26)
        Me.cboTier.TabIndex = 24
        '
        'lblResolution
        '
        Me.lblResolution.Location = New System.Drawing.Point(390, 186)
        Me.lblResolution.Name = "lblResolution"
        Me.lblResolution.Size = New System.Drawing.Size(95, 23)
        Me.lblResolution.TabIndex = 25
        Me.lblResolution.Text = "Resolution"
        Me.lblResolution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboResolution
        '
        Me.cboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResolution.Location = New System.Drawing.Point(488, 184)
        Me.cboResolution.Name = "cboResolution"
        Me.cboResolution.Size = New System.Drawing.Size(230, 26)
        Me.cboResolution.TabIndex = 26
        '
        'lblRequestDate
        '
        Me.lblRequestDate.Location = New System.Drawing.Point(735, 26)
        Me.lblRequestDate.Name = "lblRequestDate"
        Me.lblRequestDate.Size = New System.Drawing.Size(115, 23)
        Me.lblRequestDate.TabIndex = 27
        Me.lblRequestDate.Text = "Request Date"
        Me.lblRequestDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpRequestDate
        '
        Me.dtpRequestDate.CustomFormat = "MM/dd/yyyy  h:mm tt"
        Me.dtpRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRequestDate.Location = New System.Drawing.Point(853, 24)
        Me.dtpRequestDate.Name = "dtpRequestDate"
        Me.dtpRequestDate.Size = New System.Drawing.Size(290, 26)
        Me.dtpRequestDate.TabIndex = 28
        '
        'lblNeedBy
        '
        Me.lblNeedBy.Location = New System.Drawing.Point(735, 58)
        Me.lblNeedBy.Name = "lblNeedBy"
        Me.lblNeedBy.Size = New System.Drawing.Size(115, 23)
        Me.lblNeedBy.TabIndex = 29
        Me.lblNeedBy.Text = "Needed By Date"
        Me.lblNeedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpNeedBy
        '
        Me.dtpNeedBy.CustomFormat = "MM/dd/yyyy  h:mm tt"
        Me.dtpNeedBy.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNeedBy.Location = New System.Drawing.Point(853, 56)
        Me.dtpNeedBy.Name = "dtpNeedBy"
        Me.dtpNeedBy.ShowCheckBox = True
        Me.dtpNeedBy.Size = New System.Drawing.Size(290, 26)
        Me.dtpNeedBy.TabIndex = 30
        '
        'lblCloseDate
        '
        Me.lblCloseDate.Location = New System.Drawing.Point(735, 90)
        Me.lblCloseDate.Name = "lblCloseDate"
        Me.lblCloseDate.Size = New System.Drawing.Size(115, 23)
        Me.lblCloseDate.TabIndex = 31
        Me.lblCloseDate.Text = "Close Date"
        Me.lblCloseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCloseDate
        '
        Me.txtCloseDate.Location = New System.Drawing.Point(853, 88)
        Me.txtCloseDate.Name = "txtCloseDate"
        Me.txtCloseDate.ReadOnly = True
        Me.txtCloseDate.Size = New System.Drawing.Size(290, 26)
        Me.txtCloseDate.TabIndex = 32
        Me.txtCloseDate.TabStop = False
        '
        'lblAutoClose
        '
        Me.lblAutoClose.Location = New System.Drawing.Point(735, 122)
        Me.lblAutoClose.Name = "lblAutoClose"
        Me.lblAutoClose.Size = New System.Drawing.Size(115, 23)
        Me.lblAutoClose.TabIndex = 33
        Me.lblAutoClose.Text = "Auto Close Date"
        Me.lblAutoClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpAutoClose
        '
        Me.dtpAutoClose.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpAutoClose.Location = New System.Drawing.Point(853, 120)
        Me.dtpAutoClose.Name = "dtpAutoClose"
        Me.dtpAutoClose.ShowCheckBox = True
        Me.dtpAutoClose.Size = New System.Drawing.Size(290, 26)
        Me.dtpAutoClose.TabIndex = 34
        '
        'lblNotes
        '
        Me.lblNotes.Location = New System.Drawing.Point(735, 154)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(115, 23)
        Me.lblNotes.TabIndex = 35
        Me.lblNotes.Text = "Notes"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNotes
        '
        Me.txtNotes.AcceptsReturn = True
        Me.txtNotes.Location = New System.Drawing.Point(853, 152)
        Me.txtNotes.MaxLength = 1000
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(290, 194)
        Me.txtNotes.TabIndex = 36
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(12, 254)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(110, 23)
        Me.lblDescription.TabIndex = 37
        Me.lblDescription.Text = "Description"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.AcceptsReturn = True
        Me.txtDescription.Location = New System.Drawing.Point(125, 252)
        Me.txtDescription.MaxLength = 1024
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(593, 94)
        Me.txtDescription.TabIndex = 38
        '
        'chkNotifyUpdates
        '
        Me.chkNotifyUpdates.AutoSize = True
        Me.chkNotifyUpdates.Location = New System.Drawing.Point(14, 778)
        Me.chkNotifyUpdates.Name = "chkNotifyUpdates"
        Me.chkNotifyUpdates.TabIndex = 15
        Me.chkNotifyUpdates.Text = "Notify Updates"
        Me.chkNotifyUpdates.UseVisualStyleBackColor = True
        '
        'chkNotifyClose
        '
        Me.chkNotifyClose.AutoSize = True
        Me.chkNotifyClose.Checked = True
        Me.chkNotifyClose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNotifyClose.Location = New System.Drawing.Point(160, 778)
        Me.chkNotifyClose.Name = "chkNotifyClose"
        Me.chkNotifyClose.TabIndex = 16
        Me.chkNotifyClose.Text = "Notify Close"
        Me.chkNotifyClose.UseVisualStyleBackColor = True
        '
        'cmdQuickPrint
        '
        Me.cmdQuickPrint.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdQuickPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdQuickPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdQuickPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdQuickPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuickPrint.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuickPrint.Location = New System.Drawing.Point(408, 768)
        Me.cmdQuickPrint.Name = "cmdQuickPrint"
        Me.cmdQuickPrint.Size = New System.Drawing.Size(144, 40)
        Me.cmdQuickPrint.TabIndex = 21
        Me.cmdQuickPrint.Text = "Quick Print"
        Me.cmdQuickPrint.UseVisualStyleBackColor = False
        '
        'cmdUpdateTicket
        '
        Me.cmdUpdateTicket.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdUpdateTicket.Enabled = False
        Me.cmdUpdateTicket.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdUpdateTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdUpdateTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdUpdateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdateTicket.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdateTicket.Location = New System.Drawing.Point(560, 768)
        Me.cmdUpdateTicket.Name = "cmdUpdateTicket"
        Me.cmdUpdateTicket.Size = New System.Drawing.Size(144, 40)
        Me.cmdUpdateTicket.TabIndex = 17
        Me.cmdUpdateTicket.Text = "Update Ticket"
        Me.cmdUpdateTicket.UseVisualStyleBackColor = False
        '
        'cmdCloseTicket
        '
        Me.cmdCloseTicket.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdCloseTicket.Enabled = False
        Me.cmdCloseTicket.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdCloseTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(250, 140, 60)
        Me.cmdCloseTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(250, 140, 60)
        Me.cmdCloseTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCloseTicket.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseTicket.Location = New System.Drawing.Point(712, 768)
        Me.cmdCloseTicket.Name = "cmdCloseTicket"
        Me.cmdCloseTicket.Size = New System.Drawing.Size(144, 40)
        Me.cmdCloseTicket.TabIndex = 18
        Me.cmdCloseTicket.Text = "Close Ticket"
        Me.cmdCloseTicket.UseVisualStyleBackColor = False
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReset.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(864, 768)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(144, 40)
        Me.cmdReset.TabIndex = 19
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(1016, 768)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(144, 40)
        Me.cmdClose.TabIndex = 20
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'TicketEditForm
        '
        Me.AcceptButton = Me.cmdSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1180, 820)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.grpAssigned)
        Me.Controls.Add(Me.lblQuickFind)
        Me.Controls.Add(Me.txtQuickFind)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblFilterAccount)
        Me.Controls.Add(Me.cboFilterAccount)
        Me.Controls.Add(Me.lblFilterUser)
        Me.Controls.Add(Me.cboFilterUser)
        Me.Controls.Add(Me.lblFilterPriority)
        Me.Controls.Add(Me.cboFilterPriority)
        Me.Controls.Add(Me.cmdClearFilter)
        Me.Controls.Add(Me.dgvTickets)
        Me.Controls.Add(Me.grpTicket)
        Me.Controls.Add(Me.chkNotifyUpdates)
        Me.Controls.Add(Me.chkNotifyClose)
        Me.Controls.Add(Me.cmdQuickPrint)
        Me.Controls.Add(Me.cmdUpdateTicket)
        Me.Controls.Add(Me.cmdCloseTicket)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdClose)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TicketEditForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Help Desk Tickets"
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.grpAssigned.ResumeLayout(False)
        Me.grpAssigned.PerformLayout()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTicket.ResumeLayout(False)
        Me.grpTicket.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents cboFilterAccount As System.Windows.Forms.ComboBox
    Friend WithEvents lblFilterUser As System.Windows.Forms.Label
    Friend WithEvents cboFilterUser As System.Windows.Forms.ComboBox
    Friend WithEvents lblFilterPriority As System.Windows.Forms.Label
    Friend WithEvents cboFilterPriority As System.Windows.Forms.ComboBox
    Friend WithEvents cmdClearFilter As System.Windows.Forms.Button
    Friend WithEvents dgvTickets As System.Windows.Forms.DataGridView
    Friend WithEvents grpTicket As System.Windows.Forms.GroupBox
    Friend WithEvents lblTicketNo As System.Windows.Forms.Label
    Friend WithEvents txtTicketNo As System.Windows.Forms.TextBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents cboAccount As System.Windows.Forms.ComboBox
    Friend WithEvents lblRequestBy As System.Windows.Forms.Label
    Friend WithEvents cboRequestBy As System.Windows.Forms.ComboBox
    Friend WithEvents lblAddContact As System.Windows.Forms.Label
    Friend WithEvents cboAddContact As System.Windows.Forms.ComboBox
    Friend WithEvents lblCadenceID As System.Windows.Forms.Label
    Friend WithEvents txtCadenceID As System.Windows.Forms.TextBox
    Friend WithEvents cmdCadenceStatus As System.Windows.Forms.Button
    Friend WithEvents lblOrderNbr As System.Windows.Forms.Label
    Friend WithEvents txtOrderNbr As System.Windows.Forms.TextBox
    Friend WithEvents lblPC_Nbr As System.Windows.Forms.Label
    Friend WithEvents txtPC_Nbr As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents cboPriority As System.Windows.Forms.ComboBox
    Friend WithEvents lblSoftware As System.Windows.Forms.Label
    Friend WithEvents cboSoftware As System.Windows.Forms.ComboBox
    Friend WithEvents lblAssignedTo As System.Windows.Forms.Label
    Friend WithEvents cboAssignedTo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTier As System.Windows.Forms.Label
    Friend WithEvents cboTier As System.Windows.Forms.ComboBox
    Friend WithEvents lblResolution As System.Windows.Forms.Label
    Friend WithEvents cboResolution As System.Windows.Forms.ComboBox
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
End Class
