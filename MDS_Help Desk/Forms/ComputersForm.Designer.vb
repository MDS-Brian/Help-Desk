<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComputersForm
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
        Me.lblFilterType = New System.Windows.Forms.Label()
        Me.cboFilterType = New BorderedComboBox()
        Me.lblFilterWhse = New System.Windows.Forms.Label()
        Me.cboFilterWhse = New BorderedComboBox()
        Me.cmdClearFilter = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.dgvComputers = New System.Windows.Forms.DataGridView()
        Me.grpComputer = New System.Windows.Forms.GroupBox()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.txtComputer = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblCml = New System.Windows.Forms.Label()
        Me.txtCml = New System.Windows.Forms.TextBox()
        Me.lblWindows = New System.Windows.Forms.Label()
        Me.cboWindows = New BorderedComboBox()
        Me.lblOffice = New System.Windows.Forms.Label()
        Me.txtOffice = New System.Windows.Forms.TextBox()
        Me.lblPackstation = New System.Windows.Forms.Label()
        Me.dtpPackstation = New System.Windows.Forms.DateTimePicker()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cboType = New BorderedComboBox()
        Me.lblSentinel = New System.Windows.Forms.Label()
        Me.cboSentinel = New BorderedComboBox()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.lblWarehouse = New System.Windows.Forms.Label()
        Me.cboWarehouse = New BorderedComboBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblVpn = New System.Windows.Forms.Label()
        Me.cboVpn = New BorderedComboBox()
        Me.lblUps = New System.Windows.Forms.Label()
        Me.txtUps = New System.Windows.Forms.TextBox()
        Me.lblUsps = New System.Windows.Forms.Label()
        Me.txtUsps = New System.Windows.Forms.TextBox()
        Me.lblFedex = New System.Windows.Forms.Label()
        Me.txtFedex = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpComputer.SuspendLayout()
        CType(Me.dgvComputers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFilterType
        '
        Me.lblFilterType.Location = New System.Drawing.Point(16, 16)
        Me.lblFilterType.Name = "lblFilterType"
        Me.lblFilterType.Size = New System.Drawing.Size(80, 23)
        Me.lblFilterType.TabIndex = 0
        Me.lblFilterType.Text = "Type Filter"
        Me.lblFilterType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboFilterType
        '
        Me.cboFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterType.Location = New System.Drawing.Point(100, 14)
        Me.cboFilterType.Name = "cboFilterType"
        Me.cboFilterType.Size = New System.Drawing.Size(200, 26)
        Me.cboFilterType.TabIndex = 1
        '
        'lblFilterWhse
        '
        Me.lblFilterWhse.Location = New System.Drawing.Point(320, 16)
        Me.lblFilterWhse.Name = "lblFilterWhse"
        Me.lblFilterWhse.Size = New System.Drawing.Size(110, 23)
        Me.lblFilterWhse.TabIndex = 2
        Me.lblFilterWhse.Text = "Location Filter"
        Me.lblFilterWhse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboFilterWhse
        '
        Me.cboFilterWhse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterWhse.Location = New System.Drawing.Point(435, 14)
        Me.cboFilterWhse.Name = "cboFilterWhse"
        Me.cboFilterWhse.Size = New System.Drawing.Size(200, 26)
        Me.cboFilterWhse.TabIndex = 3
        '
        'cmdClearFilter
        '
        Me.cmdClearFilter.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdClearFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdClearFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClearFilter.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearFilter.Location = New System.Drawing.Point(650, 9)
        Me.cmdClearFilter.Name = "cmdClearFilter"
        Me.cmdClearFilter.Size = New System.Drawing.Size(130, 36)
        Me.cmdClearFilter.TabIndex = 4
        Me.cmdClearFilter.Text = "Clear Filter"
        Me.cmdClearFilter.UseVisualStyleBackColor = False
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(790, 16)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(294, 23)
        Me.lblCount.TabIndex = 5
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvComputers
        '
        Me.dgvComputers.AllowUserToAddRows = False
        Me.dgvComputers.AllowUserToDeleteRows = False
        Me.dgvComputers.AllowUserToResizeRows = False
        Me.dgvComputers.BackgroundColor = System.Drawing.Color.White
        Me.dgvComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComputers.Location = New System.Drawing.Point(16, 56)
        Me.dgvComputers.MultiSelect = False
        Me.dgvComputers.Name = "dgvComputers"
        Me.dgvComputers.ReadOnly = True
        Me.dgvComputers.RowHeadersVisible = False
        Me.dgvComputers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComputers.Size = New System.Drawing.Size(1068, 300)
        Me.dgvComputers.TabIndex = 6
        '
        'grpComputer
        '
        Me.grpComputer.Controls.Add(Me.lblComputer)
        Me.grpComputer.Controls.Add(Me.txtComputer)
        Me.grpComputer.Controls.Add(Me.lblUser)
        Me.grpComputer.Controls.Add(Me.txtUser)
        Me.grpComputer.Controls.Add(Me.lblCml)
        Me.grpComputer.Controls.Add(Me.txtCml)
        Me.grpComputer.Controls.Add(Me.lblWindows)
        Me.grpComputer.Controls.Add(Me.cboWindows)
        Me.grpComputer.Controls.Add(Me.lblOffice)
        Me.grpComputer.Controls.Add(Me.txtOffice)
        Me.grpComputer.Controls.Add(Me.lblPackstation)
        Me.grpComputer.Controls.Add(Me.dtpPackstation)
        Me.grpComputer.Controls.Add(Me.lblType)
        Me.grpComputer.Controls.Add(Me.cboType)
        Me.grpComputer.Controls.Add(Me.lblSentinel)
        Me.grpComputer.Controls.Add(Me.cboSentinel)
        Me.grpComputer.Controls.Add(Me.lblIP)
        Me.grpComputer.Controls.Add(Me.txtIP)
        Me.grpComputer.Controls.Add(Me.lblWarehouse)
        Me.grpComputer.Controls.Add(Me.cboWarehouse)
        Me.grpComputer.Controls.Add(Me.lblModel)
        Me.grpComputer.Controls.Add(Me.txtModel)
        Me.grpComputer.Controls.Add(Me.lblVpn)
        Me.grpComputer.Controls.Add(Me.cboVpn)
        Me.grpComputer.Controls.Add(Me.lblUps)
        Me.grpComputer.Controls.Add(Me.txtUps)
        Me.grpComputer.Controls.Add(Me.lblUsps)
        Me.grpComputer.Controls.Add(Me.txtUsps)
        Me.grpComputer.Controls.Add(Me.lblFedex)
        Me.grpComputer.Controls.Add(Me.txtFedex)
        Me.grpComputer.Controls.Add(Me.lblNotes)
        Me.grpComputer.Controls.Add(Me.txtNotes)
        Me.grpComputer.Enabled = False
        Me.grpComputer.Location = New System.Drawing.Point(16, 366)
        Me.grpComputer.Name = "grpComputer"
        Me.grpComputer.Size = New System.Drawing.Size(1068, 330)
        Me.grpComputer.TabIndex = 7
        Me.grpComputer.TabStop = False
        Me.grpComputer.Text = "Computer"
        '
        'lblComputer
        '
        Me.lblComputer.Location = New System.Drawing.Point(12, 26)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(115, 23)
        Me.lblComputer.TabIndex = 0
        Me.lblComputer.Text = "Computer No"
        Me.lblComputer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtComputer
        '
        Me.txtComputer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComputer.Location = New System.Drawing.Point(130, 24)
        Me.txtComputer.MaxLength = 10
        Me.txtComputer.Name = "txtComputer"
        Me.txtComputer.Size = New System.Drawing.Size(200, 26)
        Me.txtComputer.TabIndex = 1
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(12, 58)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(115, 23)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "User"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(130, 56)
        Me.txtUser.MaxLength = 25
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(200, 26)
        Me.txtUser.TabIndex = 3
        '
        'lblCml
        '
        Me.lblCml.Location = New System.Drawing.Point(12, 90)
        Me.lblCml.Name = "lblCml"
        Me.lblCml.Size = New System.Drawing.Size(115, 23)
        Me.lblCml.TabIndex = 4
        Me.lblCml.Text = "CMLWIN ID"
        Me.lblCml.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCml
        '
        Me.txtCml.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCml.Location = New System.Drawing.Point(130, 88)
        Me.txtCml.MaxLength = 5
        Me.txtCml.Name = "txtCml"
        Me.txtCml.Size = New System.Drawing.Size(200, 26)
        Me.txtCml.TabIndex = 5
        '
        'lblWindows
        '
        Me.lblWindows.Location = New System.Drawing.Point(12, 122)
        Me.lblWindows.Name = "lblWindows"
        Me.lblWindows.Size = New System.Drawing.Size(115, 23)
        Me.lblWindows.TabIndex = 6
        Me.lblWindows.Text = "Windows Ver"
        Me.lblWindows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboWindows
        '
        Me.cboWindows.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboWindows.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboWindows.Location = New System.Drawing.Point(130, 120)
        Me.cboWindows.MaxLength = 10
        Me.cboWindows.Name = "cboWindows"
        Me.cboWindows.Size = New System.Drawing.Size(200, 26)
        Me.cboWindows.TabIndex = 7
        '
        'lblOffice
        '
        Me.lblOffice.Location = New System.Drawing.Point(12, 154)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(115, 23)
        Me.lblOffice.TabIndex = 8
        Me.lblOffice.Text = "Office Ver"
        Me.lblOffice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOffice
        '
        Me.txtOffice.Location = New System.Drawing.Point(130, 152)
        Me.txtOffice.MaxLength = 10
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(200, 26)
        Me.txtOffice.TabIndex = 9
        '
        'lblPackstation
        '
        Me.lblPackstation.Location = New System.Drawing.Point(12, 186)
        Me.lblPackstation.Name = "lblPackstation"
        Me.lblPackstation.Size = New System.Drawing.Size(115, 23)
        Me.lblPackstation.TabIndex = 10
        Me.lblPackstation.Text = "Packstation Ver"
        Me.lblPackstation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpPackstation
        '
        Me.dtpPackstation.Checked = False
        Me.dtpPackstation.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpPackstation.Location = New System.Drawing.Point(130, 184)
        Me.dtpPackstation.Name = "dtpPackstation"
        Me.dtpPackstation.ShowCheckBox = True
        Me.dtpPackstation.Size = New System.Drawing.Size(200, 26)
        Me.dtpPackstation.TabIndex = 11
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(350, 26)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(100, 23)
        Me.lblType.TabIndex = 12
        Me.lblType.Text = "Type"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboType
        '
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.Location = New System.Drawing.Point(455, 24)
        Me.cboType.MaxLength = 15
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(200, 26)
        Me.cboType.TabIndex = 13
        '
        'lblSentinel
        '
        Me.lblSentinel.Location = New System.Drawing.Point(350, 58)
        Me.lblSentinel.Name = "lblSentinel"
        Me.lblSentinel.Size = New System.Drawing.Size(100, 23)
        Me.lblSentinel.TabIndex = 14
        Me.lblSentinel.Text = "Sentinel"
        Me.lblSentinel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSentinel
        '
        Me.cboSentinel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSentinel.Location = New System.Drawing.Point(455, 56)
        Me.cboSentinel.Name = "cboSentinel"
        Me.cboSentinel.Size = New System.Drawing.Size(200, 26)
        Me.cboSentinel.TabIndex = 15
        '
        'lblIP
        '
        Me.lblIP.Location = New System.Drawing.Point(350, 90)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(100, 23)
        Me.lblIP.TabIndex = 16
        Me.lblIP.Text = "IP Address"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIP
        '
        Me.txtIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIP.Location = New System.Drawing.Point(455, 88)
        Me.txtIP.MaxLength = 15
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(200, 26)
        Me.txtIP.TabIndex = 17
        '
        'lblWarehouse
        '
        Me.lblWarehouse.Location = New System.Drawing.Point(350, 122)
        Me.lblWarehouse.Name = "lblWarehouse"
        Me.lblWarehouse.Size = New System.Drawing.Size(100, 23)
        Me.lblWarehouse.TabIndex = 18
        Me.lblWarehouse.Text = "Warehouse"
        Me.lblWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboWarehouse
        '
        Me.cboWarehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboWarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboWarehouse.Location = New System.Drawing.Point(455, 120)
        Me.cboWarehouse.MaxLength = 5
        Me.cboWarehouse.Name = "cboWarehouse"
        Me.cboWarehouse.Size = New System.Drawing.Size(200, 26)
        Me.cboWarehouse.TabIndex = 19
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(350, 154)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 23)
        Me.lblModel.TabIndex = 20
        Me.lblModel.Text = "Model Nbr"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(455, 152)
        Me.txtModel.MaxLength = 25
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(200, 26)
        Me.txtModel.TabIndex = 21
        '
        'lblVpn
        '
        Me.lblVpn.Location = New System.Drawing.Point(350, 186)
        Me.lblVpn.Name = "lblVpn"
        Me.lblVpn.Size = New System.Drawing.Size(100, 23)
        Me.lblVpn.TabIndex = 22
        Me.lblVpn.Text = "VPN"
        Me.lblVpn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboVpn
        '
        Me.cboVpn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVpn.Location = New System.Drawing.Point(455, 184)
        Me.cboVpn.Name = "cboVpn"
        Me.cboVpn.Size = New System.Drawing.Size(200, 26)
        Me.cboVpn.TabIndex = 23
        '
        'lblUps
        '
        Me.lblUps.Location = New System.Drawing.Point(675, 26)
        Me.lblUps.Name = "lblUps"
        Me.lblUps.Size = New System.Drawing.Size(100, 23)
        Me.lblUps.TabIndex = 24
        Me.lblUps.Text = "UPS Table"
        Me.lblUps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUps
        '
        Me.txtUps.Location = New System.Drawing.Point(780, 24)
        Me.txtUps.MaxLength = 30
        Me.txtUps.Name = "txtUps"
        Me.txtUps.Size = New System.Drawing.Size(270, 26)
        Me.txtUps.TabIndex = 25
        '
        'lblUsps
        '
        Me.lblUsps.Location = New System.Drawing.Point(675, 58)
        Me.lblUsps.Name = "lblUsps"
        Me.lblUsps.Size = New System.Drawing.Size(100, 23)
        Me.lblUsps.TabIndex = 26
        Me.lblUsps.Text = "USPS Table"
        Me.lblUsps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsps
        '
        Me.txtUsps.Location = New System.Drawing.Point(780, 56)
        Me.txtUsps.MaxLength = 30
        Me.txtUsps.Name = "txtUsps"
        Me.txtUsps.Size = New System.Drawing.Size(270, 26)
        Me.txtUsps.TabIndex = 27
        '
        'lblFedex
        '
        Me.lblFedex.Location = New System.Drawing.Point(675, 90)
        Me.lblFedex.Name = "lblFedex"
        Me.lblFedex.Size = New System.Drawing.Size(100, 23)
        Me.lblFedex.TabIndex = 28
        Me.lblFedex.Text = "Fedex Table"
        Me.lblFedex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFedex
        '
        Me.txtFedex.Location = New System.Drawing.Point(780, 88)
        Me.txtFedex.MaxLength = 30
        Me.txtFedex.Name = "txtFedex"
        Me.txtFedex.Size = New System.Drawing.Size(270, 26)
        Me.txtFedex.TabIndex = 29
        '
        'lblNotes
        '
        Me.lblNotes.Location = New System.Drawing.Point(675, 122)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(100, 23)
        Me.lblNotes.TabIndex = 30
        Me.lblNotes.Text = "Notes"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNotes
        '
        Me.txtNotes.AcceptsReturn = True
        Me.txtNotes.Location = New System.Drawing.Point(780, 122)
        Me.txtNotes.MaxLength = 500
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(270, 196)
        Me.txtNotes.TabIndex = 31
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdNew.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNew.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(16, 706)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(144, 40)
        Me.cmdNew.TabIndex = 8
        Me.cmdNew.Text = "New"
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdSave.Enabled = False
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(168, 706)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(144, 40)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(320, 706)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(144, 40)
        Me.cmdDelete.TabIndex = 10
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(472, 706)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(144, 40)
        Me.cmdPrint.TabIndex = 11
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(940, 706)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(144, 40)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'ComputersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 762)
        Me.Controls.Add(Me.lblFilterType)
        Me.Controls.Add(Me.cboFilterType)
        Me.Controls.Add(Me.lblFilterWhse)
        Me.Controls.Add(Me.cboFilterWhse)
        Me.Controls.Add(Me.cmdClearFilter)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.dgvComputers)
        Me.Controls.Add(Me.grpComputer)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdClose)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ComputersForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Computers"
        CType(Me.dgvComputers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpComputer.ResumeLayout(False)
        Me.grpComputer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFilterType As System.Windows.Forms.Label
    Friend WithEvents cboFilterType As BorderedComboBox
    Friend WithEvents lblFilterWhse As System.Windows.Forms.Label
    Friend WithEvents cboFilterWhse As BorderedComboBox
    Friend WithEvents cmdClearFilter As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents dgvComputers As System.Windows.Forms.DataGridView
    Friend WithEvents grpComputer As System.Windows.Forms.GroupBox
    Friend WithEvents lblComputer As System.Windows.Forms.Label
    Friend WithEvents txtComputer As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblCml As System.Windows.Forms.Label
    Friend WithEvents txtCml As System.Windows.Forms.TextBox
    Friend WithEvents lblWindows As System.Windows.Forms.Label
    Friend WithEvents cboWindows As BorderedComboBox
    Friend WithEvents lblOffice As System.Windows.Forms.Label
    Friend WithEvents txtOffice As System.Windows.Forms.TextBox
    Friend WithEvents lblPackstation As System.Windows.Forms.Label
    Friend WithEvents dtpPackstation As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents cboType As BorderedComboBox
    Friend WithEvents lblSentinel As System.Windows.Forms.Label
    Friend WithEvents cboSentinel As BorderedComboBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents lblWarehouse As System.Windows.Forms.Label
    Friend WithEvents cboWarehouse As BorderedComboBox
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents lblVpn As System.Windows.Forms.Label
    Friend WithEvents cboVpn As BorderedComboBox
    Friend WithEvents lblUps As System.Windows.Forms.Label
    Friend WithEvents txtUps As System.Windows.Forms.TextBox
    Friend WithEvents lblUsps As System.Windows.Forms.Label
    Friend WithEvents txtUsps As System.Windows.Forms.TextBox
    Friend WithEvents lblFedex As System.Windows.Forms.Label
    Friend WithEvents txtFedex As System.Windows.Forms.TextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
