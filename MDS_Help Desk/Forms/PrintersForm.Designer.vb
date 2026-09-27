<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintersForm
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
        Me.lblFilterType = New System.Windows.Forms.Label()
        Me.cboFilterType = New System.Windows.Forms.ComboBox()
        Me.lblFilterLocation = New System.Windows.Forms.Label()
        Me.cboFilterLocation = New System.Windows.Forms.ComboBox()
        Me.cmdClearFilter = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.dgvPrinters = New System.Windows.Forms.DataGridView()
        Me.grpPrinter = New System.Windows.Forms.GroupBox()
        Me.lblPrinter = New System.Windows.Forms.Label()
        Me.txtPrinter = New System.Windows.Forms.TextBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblMaker = New System.Windows.Forms.Label()
        Me.txtMaker = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.lblConnected = New System.Windows.Forms.Label()
        Me.txtConnected = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpPrinter.SuspendLayout()
        CType(Me.dgvPrinters, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblFilterLocation
        '
        Me.lblFilterLocation.Location = New System.Drawing.Point(320, 16)
        Me.lblFilterLocation.Name = "lblFilterLocation"
        Me.lblFilterLocation.Size = New System.Drawing.Size(110, 23)
        Me.lblFilterLocation.TabIndex = 2
        Me.lblFilterLocation.Text = "Location Filter"
        Me.lblFilterLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboFilterLocation
        '
        Me.cboFilterLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterLocation.Location = New System.Drawing.Point(435, 14)
        Me.cboFilterLocation.Name = "cboFilterLocation"
        Me.cboFilterLocation.Size = New System.Drawing.Size(200, 26)
        Me.cboFilterLocation.TabIndex = 3
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
        Me.lblCount.Size = New System.Drawing.Size(194, 23)
        Me.lblCount.TabIndex = 5
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvPrinters
        '
        Me.dgvPrinters.AllowUserToAddRows = False
        Me.dgvPrinters.AllowUserToDeleteRows = False
        Me.dgvPrinters.AllowUserToResizeRows = False
        Me.dgvPrinters.BackgroundColor = System.Drawing.Color.White
        Me.dgvPrinters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrinters.Location = New System.Drawing.Point(16, 56)
        Me.dgvPrinters.MultiSelect = False
        Me.dgvPrinters.Name = "dgvPrinters"
        Me.dgvPrinters.ReadOnly = True
        Me.dgvPrinters.RowHeadersVisible = False
        Me.dgvPrinters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrinters.Size = New System.Drawing.Size(968, 260)
        Me.dgvPrinters.TabIndex = 6
        '
        'grpPrinter
        '
        Me.grpPrinter.Controls.Add(Me.lblPrinter)
        Me.grpPrinter.Controls.Add(Me.txtPrinter)
        Me.grpPrinter.Controls.Add(Me.lblModel)
        Me.grpPrinter.Controls.Add(Me.txtModel)
        Me.grpPrinter.Controls.Add(Me.lblMaker)
        Me.grpPrinter.Controls.Add(Me.txtMaker)
        Me.grpPrinter.Controls.Add(Me.lblType)
        Me.grpPrinter.Controls.Add(Me.cboType)
        Me.grpPrinter.Controls.Add(Me.lblIP)
        Me.grpPrinter.Controls.Add(Me.txtIP)
        Me.grpPrinter.Controls.Add(Me.lblConnected)
        Me.grpPrinter.Controls.Add(Me.txtConnected)
        Me.grpPrinter.Controls.Add(Me.lblLocation)
        Me.grpPrinter.Controls.Add(Me.cboLocation)
        Me.grpPrinter.Controls.Add(Me.lblNotes)
        Me.grpPrinter.Controls.Add(Me.txtNotes)
        Me.grpPrinter.Enabled = False
        Me.grpPrinter.Location = New System.Drawing.Point(16, 326)
        Me.grpPrinter.Name = "grpPrinter"
        Me.grpPrinter.Size = New System.Drawing.Size(968, 270)
        Me.grpPrinter.TabIndex = 7
        Me.grpPrinter.TabStop = False
        Me.grpPrinter.Text = "Printer"
        '
        'lblPrinter
        '
        Me.lblPrinter.Location = New System.Drawing.Point(12, 26)
        Me.lblPrinter.Name = "lblPrinter"
        Me.lblPrinter.Size = New System.Drawing.Size(115, 23)
        Me.lblPrinter.TabIndex = 0
        Me.lblPrinter.Text = "Printer"
        Me.lblPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrinter
        '
        Me.txtPrinter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrinter.Location = New System.Drawing.Point(130, 24)
        Me.txtPrinter.MaxLength = 15
        Me.txtPrinter.Name = "txtPrinter"
        Me.txtPrinter.Size = New System.Drawing.Size(220, 26)
        Me.txtPrinter.TabIndex = 1
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(12, 58)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(115, 23)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model No"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(130, 56)
        Me.txtModel.MaxLength = 10
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(220, 26)
        Me.txtModel.TabIndex = 3
        '
        'lblMaker
        '
        Me.lblMaker.Location = New System.Drawing.Point(12, 90)
        Me.lblMaker.Name = "lblMaker"
        Me.lblMaker.Size = New System.Drawing.Size(115, 23)
        Me.lblMaker.TabIndex = 4
        Me.lblMaker.Text = "Manufacturer"
        Me.lblMaker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMaker
        '
        Me.txtMaker.Location = New System.Drawing.Point(130, 88)
        Me.txtMaker.MaxLength = 10
        Me.txtMaker.Name = "txtMaker"
        Me.txtMaker.Size = New System.Drawing.Size(220, 26)
        Me.txtMaker.TabIndex = 5
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(12, 122)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(115, 23)
        Me.lblType.TabIndex = 6
        Me.lblType.Text = "Type"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboType
        '
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.Location = New System.Drawing.Point(130, 120)
        Me.cboType.MaxLength = 15
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(220, 26)
        Me.cboType.TabIndex = 7
        '
        'lblIP
        '
        Me.lblIP.Location = New System.Drawing.Point(370, 26)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(105, 23)
        Me.lblIP.TabIndex = 8
        Me.lblIP.Text = "IP Address"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIP
        '
        Me.txtIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIP.Location = New System.Drawing.Point(480, 24)
        Me.txtIP.MaxLength = 15
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(220, 26)
        Me.txtIP.TabIndex = 9
        '
        'lblConnected
        '
        Me.lblConnected.Location = New System.Drawing.Point(370, 58)
        Me.lblConnected.Name = "lblConnected"
        Me.lblConnected.Size = New System.Drawing.Size(105, 23)
        Me.lblConnected.TabIndex = 10
        Me.lblConnected.Text = "Connected To"
        Me.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConnected
        '
        Me.txtConnected.Location = New System.Drawing.Point(480, 56)
        Me.txtConnected.MaxLength = 10
        Me.txtConnected.Name = "txtConnected"
        Me.txtConnected.Size = New System.Drawing.Size(220, 26)
        Me.txtConnected.TabIndex = 11
        '
        'lblLocation
        '
        Me.lblLocation.Location = New System.Drawing.Point(370, 90)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(105, 23)
        Me.lblLocation.TabIndex = 12
        Me.lblLocation.Text = "Location"
        Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboLocation
        '
        Me.cboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLocation.Location = New System.Drawing.Point(480, 88)
        Me.cboLocation.MaxLength = 25
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(220, 26)
        Me.cboLocation.TabIndex = 13
        '
        'lblNotes
        '
        Me.lblNotes.Location = New System.Drawing.Point(720, 26)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(100, 23)
        Me.lblNotes.TabIndex = 14
        Me.lblNotes.Text = "Notes"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNotes
        '
        Me.txtNotes.AcceptsReturn = True
        Me.txtNotes.Location = New System.Drawing.Point(720, 50)
        Me.txtNotes.MaxLength = 500
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(236, 210)
        Me.txtNotes.TabIndex = 15
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdNew.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNew.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(16, 606)
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
        Me.cmdSave.Location = New System.Drawing.Point(168, 606)
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
        Me.cmdDelete.Location = New System.Drawing.Point(320, 606)
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
        Me.cmdPrint.Location = New System.Drawing.Point(472, 606)
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
        Me.cmdClose.Location = New System.Drawing.Point(840, 606)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(144, 40)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'PrintersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 662)
        Me.Controls.Add(Me.lblFilterType)
        Me.Controls.Add(Me.cboFilterType)
        Me.Controls.Add(Me.lblFilterLocation)
        Me.Controls.Add(Me.cboFilterLocation)
        Me.Controls.Add(Me.cmdClearFilter)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.dgvPrinters)
        Me.Controls.Add(Me.grpPrinter)
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
        Me.Name = "PrintersForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Printers"
        CType(Me.dgvPrinters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPrinter.ResumeLayout(False)
        Me.grpPrinter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFilterType As System.Windows.Forms.Label
    Friend WithEvents cboFilterType As System.Windows.Forms.ComboBox
    Friend WithEvents lblFilterLocation As System.Windows.Forms.Label
    Friend WithEvents cboFilterLocation As System.Windows.Forms.ComboBox
    Friend WithEvents cmdClearFilter As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents dgvPrinters As System.Windows.Forms.DataGridView
    Friend WithEvents grpPrinter As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrinter As System.Windows.Forms.Label
    Friend WithEvents txtPrinter As System.Windows.Forms.TextBox
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents lblMaker As System.Windows.Forms.Label
    Friend WithEvents txtMaker As System.Windows.Forms.TextBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents lblConnected As System.Windows.Forms.Label
    Friend WithEvents txtConnected As System.Windows.Forms.TextBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents cboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
