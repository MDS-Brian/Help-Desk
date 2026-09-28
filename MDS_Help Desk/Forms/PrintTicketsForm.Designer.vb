<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintTicketsForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpRange = New System.Windows.Forms.GroupBox()
        Me.optRangeAll = New System.Windows.Forms.RadioButton()
        Me.optRange1Week = New System.Windows.Forms.RadioButton()
        Me.optRange2Weeks = New System.Windows.Forms.RadioButton()
        Me.optRangeMonths = New System.Windows.Forms.RadioButton()
        Me.nudMonths = New System.Windows.Forms.NumericUpDown()
        Me.lblMonths = New System.Windows.Forms.Label()
        Me.optRangeDates = New System.Windows.Forms.RadioButton()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.grpLimit = New System.Windows.Forms.GroupBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.cboAccount = New BorderedComboBox()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.cboPriority = New BorderedComboBox()
        Me.lblRequestBy = New System.Windows.Forms.Label()
        Me.cboRequestBy = New BorderedComboBox()
        Me.lblAssignedTo = New System.Windows.Forms.Label()
        Me.cboAssignedTo = New BorderedComboBox()
        Me.cmdPreviewTickets = New System.Windows.Forms.Button()
        Me.grpCounts = New System.Windows.Forms.GroupBox()
        Me.optCountsAccount = New System.Windows.Forms.RadioButton()
        Me.optCountsPriority = New System.Windows.Forms.RadioButton()
        Me.cmdPreviewCounts = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpRange.SuspendLayout()
        CType(Me.nudMonths, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLimit.SuspendLayout()
        Me.grpCounts.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Print Tickets"
        '
        'grpRange
        '
        Me.grpRange.Controls.Add(Me.optRangeAll)
        Me.grpRange.Controls.Add(Me.optRange1Week)
        Me.grpRange.Controls.Add(Me.optRange2Weeks)
        Me.grpRange.Controls.Add(Me.optRangeMonths)
        Me.grpRange.Controls.Add(Me.nudMonths)
        Me.grpRange.Controls.Add(Me.lblMonths)
        Me.grpRange.Controls.Add(Me.optRangeDates)
        Me.grpRange.Controls.Add(Me.dtpStart)
        Me.grpRange.Controls.Add(Me.lblTo)
        Me.grpRange.Controls.Add(Me.dtpEnd)
        Me.grpRange.Location = New System.Drawing.Point(20, 50)
        Me.grpRange.Name = "grpRange"
        Me.grpRange.Size = New System.Drawing.Size(520, 170)
        Me.grpRange.TabIndex = 1
        Me.grpRange.TabStop = False
        Me.grpRange.Text = "Open tickets requested"
        '
        'optRangeAll
        '
        Me.optRangeAll.AutoSize = True
        Me.optRangeAll.Checked = True
        Me.optRangeAll.Location = New System.Drawing.Point(15, 25)
        Me.optRangeAll.Name = "optRangeAll"
        Me.optRangeAll.TabIndex = 0
        Me.optRangeAll.TabStop = True
        Me.optRangeAll.Text = "Any time (all open tickets)"
        Me.optRangeAll.UseVisualStyleBackColor = True
        '
        'optRange1Week
        '
        Me.optRange1Week.AutoSize = True
        Me.optRange1Week.Location = New System.Drawing.Point(15, 52)
        Me.optRange1Week.Name = "optRange1Week"
        Me.optRange1Week.TabIndex = 1
        Me.optRange1Week.Text = "In the last week"
        Me.optRange1Week.UseVisualStyleBackColor = True
        '
        'optRange2Weeks
        '
        Me.optRange2Weeks.AutoSize = True
        Me.optRange2Weeks.Location = New System.Drawing.Point(15, 79)
        Me.optRange2Weeks.Name = "optRange2Weeks"
        Me.optRange2Weeks.TabIndex = 2
        Me.optRange2Weeks.Text = "In the last 2 weeks"
        Me.optRange2Weeks.UseVisualStyleBackColor = True
        '
        'optRangeMonths
        '
        Me.optRangeMonths.AutoSize = True
        Me.optRangeMonths.Location = New System.Drawing.Point(15, 106)
        Me.optRangeMonths.Name = "optRangeMonths"
        Me.optRangeMonths.TabIndex = 3
        Me.optRangeMonths.Text = "In the last"
        Me.optRangeMonths.UseVisualStyleBackColor = True
        '
        'nudMonths
        '
        Me.nudMonths.Enabled = False
        Me.nudMonths.Location = New System.Drawing.Point(120, 104)
        Me.nudMonths.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudMonths.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMonths.Name = "nudMonths"
        Me.nudMonths.Size = New System.Drawing.Size(60, 26)
        Me.nudMonths.TabIndex = 4
        Me.nudMonths.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMonths
        '
        Me.lblMonths.AutoSize = True
        Me.lblMonths.Location = New System.Drawing.Point(186, 107)
        Me.lblMonths.Name = "lblMonths"
        Me.lblMonths.TabIndex = 5
        Me.lblMonths.Text = "months"
        '
        'optRangeDates
        '
        Me.optRangeDates.AutoSize = True
        Me.optRangeDates.Location = New System.Drawing.Point(15, 133)
        Me.optRangeDates.Name = "optRangeDates"
        Me.optRangeDates.TabIndex = 6
        Me.optRangeDates.Text = "From"
        Me.optRangeDates.UseVisualStyleBackColor = True
        '
        'dtpStart
        '
        Me.dtpStart.Enabled = False
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpStart.Location = New System.Drawing.Point(120, 131)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(130, 26)
        Me.dtpStart.TabIndex = 7
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(258, 134)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.TabIndex = 8
        Me.lblTo.Text = "to"
        '
        'dtpEnd
        '
        Me.dtpEnd.Enabled = False
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpEnd.Location = New System.Drawing.Point(282, 131)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(130, 26)
        Me.dtpEnd.TabIndex = 9
        '
        'grpLimit
        '
        Me.grpLimit.Controls.Add(Me.lblAccount)
        Me.grpLimit.Controls.Add(Me.cboAccount)
        Me.grpLimit.Controls.Add(Me.lblPriority)
        Me.grpLimit.Controls.Add(Me.cboPriority)
        Me.grpLimit.Controls.Add(Me.lblRequestBy)
        Me.grpLimit.Controls.Add(Me.cboRequestBy)
        Me.grpLimit.Controls.Add(Me.lblAssignedTo)
        Me.grpLimit.Controls.Add(Me.cboAssignedTo)
        Me.grpLimit.Location = New System.Drawing.Point(20, 230)
        Me.grpLimit.Name = "grpLimit"
        Me.grpLimit.Size = New System.Drawing.Size(520, 160)
        Me.grpLimit.TabIndex = 2
        Me.grpLimit.TabStop = False
        Me.grpLimit.Text = "Limit to"
        '
        'lblAccount
        '
        Me.lblAccount.Location = New System.Drawing.Point(15, 28)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(110, 23)
        Me.lblAccount.TabIndex = 0
        Me.lblAccount.Text = "Account"
        Me.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAccount
        '
        Me.cboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccount.Location = New System.Drawing.Point(130, 26)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(370, 26)
        Me.cboAccount.TabIndex = 1
        '
        'lblPriority
        '
        Me.lblPriority.Location = New System.Drawing.Point(15, 60)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(110, 23)
        Me.lblPriority.TabIndex = 2
        Me.lblPriority.Text = "Priority"
        Me.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPriority
        '
        Me.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPriority.Location = New System.Drawing.Point(130, 58)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Size = New System.Drawing.Size(370, 26)
        Me.cboPriority.TabIndex = 3
        '
        'lblRequestBy
        '
        Me.lblRequestBy.Location = New System.Drawing.Point(15, 92)
        Me.lblRequestBy.Name = "lblRequestBy"
        Me.lblRequestBy.Size = New System.Drawing.Size(110, 23)
        Me.lblRequestBy.TabIndex = 4
        Me.lblRequestBy.Text = "Requested By"
        Me.lblRequestBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboRequestBy
        '
        Me.cboRequestBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRequestBy.Location = New System.Drawing.Point(130, 90)
        Me.cboRequestBy.Name = "cboRequestBy"
        Me.cboRequestBy.Size = New System.Drawing.Size(370, 26)
        Me.cboRequestBy.TabIndex = 5
        '
        'lblAssignedTo
        '
        Me.lblAssignedTo.Location = New System.Drawing.Point(15, 124)
        Me.lblAssignedTo.Name = "lblAssignedTo"
        Me.lblAssignedTo.Size = New System.Drawing.Size(110, 23)
        Me.lblAssignedTo.TabIndex = 6
        Me.lblAssignedTo.Text = "Assigned To"
        Me.lblAssignedTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAssignedTo
        '
        Me.cboAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAssignedTo.Location = New System.Drawing.Point(130, 122)
        Me.cboAssignedTo.Name = "cboAssignedTo"
        Me.cboAssignedTo.Size = New System.Drawing.Size(370, 26)
        Me.cboAssignedTo.TabIndex = 7
        '
        'cmdPreviewTickets
        '
        Me.cmdPreviewTickets.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdPreviewTickets.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdPreviewTickets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdPreviewTickets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdPreviewTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPreviewTickets.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPreviewTickets.Location = New System.Drawing.Point(396, 398)
        Me.cmdPreviewTickets.Name = "cmdPreviewTickets"
        Me.cmdPreviewTickets.Size = New System.Drawing.Size(144, 40)
        Me.cmdPreviewTickets.TabIndex = 3
        Me.cmdPreviewTickets.Text = "Print Tickets"
        Me.cmdPreviewTickets.UseVisualStyleBackColor = False
        '
        'grpCounts
        '
        Me.grpCounts.Controls.Add(Me.optCountsAccount)
        Me.grpCounts.Controls.Add(Me.optCountsPriority)
        Me.grpCounts.Controls.Add(Me.cmdPreviewCounts)
        Me.grpCounts.Location = New System.Drawing.Point(20, 450)
        Me.grpCounts.Name = "grpCounts"
        Me.grpCounts.Size = New System.Drawing.Size(520, 76)
        Me.grpCounts.TabIndex = 4
        Me.grpCounts.TabStop = False
        Me.grpCounts.Text = "Open ticket counts"
        '
        'optCountsAccount
        '
        Me.optCountsAccount.AutoSize = True
        Me.optCountsAccount.Checked = True
        Me.optCountsAccount.Location = New System.Drawing.Point(15, 33)
        Me.optCountsAccount.Name = "optCountsAccount"
        Me.optCountsAccount.TabIndex = 0
        Me.optCountsAccount.TabStop = True
        Me.optCountsAccount.Text = "By Account"
        Me.optCountsAccount.UseVisualStyleBackColor = True
        '
        'optCountsPriority
        '
        Me.optCountsPriority.AutoSize = True
        Me.optCountsPriority.Location = New System.Drawing.Point(140, 33)
        Me.optCountsPriority.Name = "optCountsPriority"
        Me.optCountsPriority.TabIndex = 1
        Me.optCountsPriority.Text = "By Priority"
        Me.optCountsPriority.UseVisualStyleBackColor = True
        '
        'cmdPreviewCounts
        '
        Me.cmdPreviewCounts.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdPreviewCounts.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdPreviewCounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdPreviewCounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdPreviewCounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPreviewCounts.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPreviewCounts.Location = New System.Drawing.Point(362, 22)
        Me.cmdPreviewCounts.Name = "cmdPreviewCounts"
        Me.cmdPreviewCounts.Size = New System.Drawing.Size(144, 40)
        Me.cmdPreviewCounts.TabIndex = 2
        Me.cmdPreviewCounts.Text = "Print Counts"
        Me.cmdPreviewCounts.UseVisualStyleBackColor = False
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
        Me.cmdClose.Location = New System.Drawing.Point(396, 540)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(144, 40)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'PrintTicketsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(560, 596)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpRange)
        Me.Controls.Add(Me.grpLimit)
        Me.Controls.Add(Me.cmdPreviewTickets)
        Me.Controls.Add(Me.grpCounts)
        Me.Controls.Add(Me.cmdClose)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintTicketsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print Options"
        Me.grpRange.ResumeLayout(False)
        Me.grpRange.PerformLayout()
        CType(Me.nudMonths, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLimit.ResumeLayout(False)
        Me.grpCounts.ResumeLayout(False)
        Me.grpCounts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpRange As System.Windows.Forms.GroupBox
    Friend WithEvents optRangeAll As System.Windows.Forms.RadioButton
    Friend WithEvents optRange1Week As System.Windows.Forms.RadioButton
    Friend WithEvents optRange2Weeks As System.Windows.Forms.RadioButton
    Friend WithEvents optRangeMonths As System.Windows.Forms.RadioButton
    Friend WithEvents nudMonths As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMonths As System.Windows.Forms.Label
    Friend WithEvents optRangeDates As System.Windows.Forms.RadioButton
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpLimit As System.Windows.Forms.GroupBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents cboAccount As BorderedComboBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents cboPriority As BorderedComboBox
    Friend WithEvents lblRequestBy As System.Windows.Forms.Label
    Friend WithEvents cboRequestBy As BorderedComboBox
    Friend WithEvents lblAssignedTo As System.Windows.Forms.Label
    Friend WithEvents cboAssignedTo As BorderedComboBox
    Friend WithEvents cmdPreviewTickets As System.Windows.Forms.Button
    Friend WithEvents grpCounts As System.Windows.Forms.GroupBox
    Friend WithEvents optCountsAccount As System.Windows.Forms.RadioButton
    Friend WithEvents optCountsPriority As System.Windows.Forms.RadioButton
    Friend WithEvents cmdPreviewCounts As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
