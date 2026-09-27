<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KnowledgeBaseForm
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
        Me.lblSearchProcess = New System.Windows.Forms.Label()
        Me.cboSearchProcess = New System.Windows.Forms.ComboBox()
        Me.lblKeyword = New System.Windows.Forms.Label()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdNewSearch = New System.Windows.Forms.Button()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.grpEntry = New System.Windows.Forms.GroupBox()
        Me.lblRecordNo = New System.Windows.Forms.Label()
        Me.txtRecordNo = New System.Windows.Forms.TextBox()
        Me.lblEntered = New System.Windows.Forms.Label()
        Me.dtpEntered = New System.Windows.Forms.DateTimePicker()
        Me.lblEntryProcess = New System.Windows.Forms.Label()
        Me.cboEntryProcess = New System.Windows.Forms.ComboBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtError = New System.Windows.Forms.TextBox()
        Me.lblWorkaround = New System.Windows.Forms.Label()
        Me.txtWorkaround = New System.Windows.Forms.TextBox()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntry.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSearchProcess
        '
        Me.lblSearchProcess.Location = New System.Drawing.Point(16, 16)
        Me.lblSearchProcess.Name = "lblSearchProcess"
        Me.lblSearchProcess.Size = New System.Drawing.Size(60, 23)
        Me.lblSearchProcess.TabIndex = 0
        Me.lblSearchProcess.Text = "Process"
        Me.lblSearchProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSearchProcess
        '
        Me.cboSearchProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchProcess.Location = New System.Drawing.Point(80, 14)
        Me.cboSearchProcess.Name = "cboSearchProcess"
        Me.cboSearchProcess.Size = New System.Drawing.Size(260, 26)
        Me.cboSearchProcess.TabIndex = 1
        '
        'lblKeyword
        '
        Me.lblKeyword.Location = New System.Drawing.Point(360, 16)
        Me.lblKeyword.Name = "lblKeyword"
        Me.lblKeyword.Size = New System.Drawing.Size(75, 23)
        Me.lblKeyword.TabIndex = 2
        Me.lblKeyword.Text = "Key Word"
        Me.lblKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKeyword
        '
        Me.txtKeyword.Location = New System.Drawing.Point(440, 14)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(260, 26)
        Me.txtKeyword.TabIndex = 3
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(715, 8)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(120, 38)
        Me.cmdSearch.TabIndex = 4
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'cmdNewSearch
        '
        Me.cmdNewSearch.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdNewSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdNewSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdNewSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdNewSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNewSearch.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewSearch.Location = New System.Drawing.Point(845, 8)
        Me.cmdNewSearch.Name = "cmdNewSearch"
        Me.cmdNewSearch.Size = New System.Drawing.Size(139, 38)
        Me.cmdNewSearch.TabIndex = 5
        Me.cmdNewSearch.Text = "New Search"
        Me.cmdNewSearch.UseVisualStyleBackColor = False
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AllowUserToResizeRows = False
        Me.dgvResults.BackgroundColor = System.Drawing.Color.White
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(16, 56)
        Me.dgvResults.MultiSelect = False
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.RowHeadersVisible = False
        Me.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResults.Size = New System.Drawing.Size(968, 200)
        Me.dgvResults.TabIndex = 6
        '
        'grpEntry
        '
        Me.grpEntry.Controls.Add(Me.lblRecordNo)
        Me.grpEntry.Controls.Add(Me.txtRecordNo)
        Me.grpEntry.Controls.Add(Me.lblEntered)
        Me.grpEntry.Controls.Add(Me.dtpEntered)
        Me.grpEntry.Controls.Add(Me.lblEntryProcess)
        Me.grpEntry.Controls.Add(Me.cboEntryProcess)
        Me.grpEntry.Controls.Add(Me.lblError)
        Me.grpEntry.Controls.Add(Me.txtError)
        Me.grpEntry.Controls.Add(Me.lblWorkaround)
        Me.grpEntry.Controls.Add(Me.txtWorkaround)
        Me.grpEntry.Enabled = False
        Me.grpEntry.Location = New System.Drawing.Point(16, 266)
        Me.grpEntry.Name = "grpEntry"
        Me.grpEntry.Size = New System.Drawing.Size(968, 330)
        Me.grpEntry.TabIndex = 7
        Me.grpEntry.TabStop = False
        Me.grpEntry.Text = "Entry"
        '
        'lblRecordNo
        '
        Me.lblRecordNo.Location = New System.Drawing.Point(12, 28)
        Me.lblRecordNo.Name = "lblRecordNo"
        Me.lblRecordNo.Size = New System.Drawing.Size(80, 23)
        Me.lblRecordNo.TabIndex = 0
        Me.lblRecordNo.Text = "Record No"
        Me.lblRecordNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRecordNo
        '
        Me.txtRecordNo.Location = New System.Drawing.Point(95, 26)
        Me.txtRecordNo.Name = "txtRecordNo"
        Me.txtRecordNo.ReadOnly = True
        Me.txtRecordNo.Size = New System.Drawing.Size(90, 26)
        Me.txtRecordNo.TabIndex = 1
        Me.txtRecordNo.TabStop = False
        '
        'lblEntered
        '
        Me.lblEntered.Location = New System.Drawing.Point(210, 28)
        Me.lblEntered.Name = "lblEntered"
        Me.lblEntered.Size = New System.Drawing.Size(95, 23)
        Me.lblEntered.TabIndex = 2
        Me.lblEntered.Text = "Date Entered"
        Me.lblEntered.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpEntered
        '
        Me.dtpEntered.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpEntered.Location = New System.Drawing.Point(310, 26)
        Me.dtpEntered.Name = "dtpEntered"
        Me.dtpEntered.Size = New System.Drawing.Size(150, 26)
        Me.dtpEntered.TabIndex = 3
        '
        'lblEntryProcess
        '
        Me.lblEntryProcess.Location = New System.Drawing.Point(490, 28)
        Me.lblEntryProcess.Name = "lblEntryProcess"
        Me.lblEntryProcess.Size = New System.Drawing.Size(65, 23)
        Me.lblEntryProcess.TabIndex = 4
        Me.lblEntryProcess.Text = "Process"
        Me.lblEntryProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEntryProcess
        '
        Me.cboEntryProcess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEntryProcess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEntryProcess.Location = New System.Drawing.Point(560, 26)
        Me.cboEntryProcess.MaxLength = 100
        Me.cboEntryProcess.Name = "cboEntryProcess"
        Me.cboEntryProcess.Size = New System.Drawing.Size(396, 26)
        Me.cboEntryProcess.TabIndex = 5
        '
        'lblError
        '
        Me.lblError.Location = New System.Drawing.Point(12, 62)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(250, 23)
        Me.lblError.TabIndex = 6
        Me.lblError.Text = "Problem or Error:"
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtError
        '
        Me.txtError.AcceptsReturn = True
        Me.txtError.Location = New System.Drawing.Point(12, 86)
        Me.txtError.MaxLength = 3000
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtError.Size = New System.Drawing.Size(460, 232)
        Me.txtError.TabIndex = 7
        '
        'lblWorkaround
        '
        Me.lblWorkaround.Location = New System.Drawing.Point(490, 62)
        Me.lblWorkaround.Name = "lblWorkaround"
        Me.lblWorkaround.Size = New System.Drawing.Size(250, 23)
        Me.lblWorkaround.TabIndex = 8
        Me.lblWorkaround.Text = "Solution or Work Around:"
        Me.lblWorkaround.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtWorkaround
        '
        Me.txtWorkaround.AcceptsReturn = True
        Me.txtWorkaround.Location = New System.Drawing.Point(490, 86)
        Me.txtWorkaround.MaxLength = 3000
        Me.txtWorkaround.Multiline = True
        Me.txtWorkaround.Name = "txtWorkaround"
        Me.txtWorkaround.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWorkaround.Size = New System.Drawing.Size(466, 232)
        Me.txtWorkaround.TabIndex = 9
        '
        'cmdAddNew
        '
        Me.cmdAddNew.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdAddNew.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddNew.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNew.Location = New System.Drawing.Point(16, 606)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(144, 40)
        Me.cmdAddNew.TabIndex = 8
        Me.cmdAddNew.Text = "Add New"
        Me.cmdAddNew.UseVisualStyleBackColor = False
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
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(320, 606)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(144, 40)
        Me.cmdPrint.TabIndex = 10
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
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'KnowledgeBaseForm
        '
        Me.AcceptButton = Me.cmdSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 660)
        Me.Controls.Add(Me.lblSearchProcess)
        Me.Controls.Add(Me.cboSearchProcess)
        Me.Controls.Add(Me.lblKeyword)
        Me.Controls.Add(Me.txtKeyword)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdNewSearch)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.grpEntry)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdClose)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KnowledgeBaseForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Knowledge Base"
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntry.ResumeLayout(False)
        Me.grpEntry.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSearchProcess As System.Windows.Forms.Label
    Friend WithEvents cboSearchProcess As System.Windows.Forms.ComboBox
    Friend WithEvents lblKeyword As System.Windows.Forms.Label
    Friend WithEvents txtKeyword As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdNewSearch As System.Windows.Forms.Button
    Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
    Friend WithEvents grpEntry As System.Windows.Forms.GroupBox
    Friend WithEvents lblRecordNo As System.Windows.Forms.Label
    Friend WithEvents txtRecordNo As System.Windows.Forms.TextBox
    Friend WithEvents lblEntered As System.Windows.Forms.Label
    Friend WithEvents dtpEntered As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEntryProcess As System.Windows.Forms.Label
    Friend WithEvents cboEntryProcess As System.Windows.Forms.ComboBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtError As System.Windows.Forms.TextBox
    Friend WithEvents lblWorkaround As System.Windows.Forms.Label
    Friend WithEvents txtWorkaround As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
