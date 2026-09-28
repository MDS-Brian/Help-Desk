<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoriesForm
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
        Me.lblCategories = New System.Windows.Forms.Label()
        Me.lstCategories = New System.Windows.Forms.ListBox()
        Me.lblEntries = New System.Windows.Forms.Label()
        Me.dgvEntries = New System.Windows.Forms.DataGridView()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        CType(Me.dgvEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCategories
        '
        Me.lblCategories.Location = New System.Drawing.Point(16, 12)
        Me.lblCategories.Name = "lblCategories"
        Me.lblCategories.Size = New System.Drawing.Size(200, 23)
        Me.lblCategories.TabIndex = 0
        Me.lblCategories.Text = "Category"
        Me.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstCategories
        '
        Me.lstCategories.IntegralHeight = False
        Me.lstCategories.Location = New System.Drawing.Point(16, 40)
        Me.lstCategories.Name = "lstCategories"
        Me.lstCategories.Size = New System.Drawing.Size(200, 418)
        Me.lstCategories.TabIndex = 1
        '
        'lblEntries
        '
        Me.lblEntries.Location = New System.Drawing.Point(232, 12)
        Me.lblEntries.Name = "lblEntries"
        Me.lblEntries.Size = New System.Drawing.Size(400, 23)
        Me.lblEntries.TabIndex = 2
        Me.lblEntries.Text = "Entries"
        Me.lblEntries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvEntries
        '
        Me.dgvEntries.AllowUserToAddRows = False
        Me.dgvEntries.AllowUserToDeleteRows = False
        Me.dgvEntries.AllowUserToResizeRows = False
        Me.dgvEntries.BackgroundColor = System.Drawing.Color.White
        Me.dgvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntries.Location = New System.Drawing.Point(232, 40)
        Me.dgvEntries.MultiSelect = False
        Me.dgvEntries.Name = "dgvEntries"
        Me.dgvEntries.ReadOnly = False
        Me.dgvEntries.RowHeadersVisible = False
        Me.dgvEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvEntries.Size = New System.Drawing.Size(512, 376)
        Me.dgvEntries.TabIndex = 3
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(232, 424)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(160, 36)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add Entry"
        Me.cmdAdd.UseVisualStyleBackColor = False
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
        Me.cmdSave.Location = New System.Drawing.Point(400, 424)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(160, 36)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Save Changes"
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
        Me.cmdDelete.Location = New System.Drawing.Point(568, 424)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(176, 36)
        Me.cmdDelete.TabIndex = 6
        Me.cmdDelete.Text = "Delete Entry"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(600, 470)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(144, 40)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'CategoriesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(760, 522)
        Me.Controls.Add(Me.lblCategories)
        Me.Controls.Add(Me.lstCategories)
        Me.Controls.Add(Me.lblEntries)
        Me.Controls.Add(Me.dgvEntries)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdClose)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CategoriesForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Categories"
        CType(Me.dgvEntries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCategories As System.Windows.Forms.Label
    Friend WithEvents lstCategories As System.Windows.Forms.ListBox
    Friend WithEvents lblEntries As System.Windows.Forms.Label
    Friend WithEvents dgvEntries As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
