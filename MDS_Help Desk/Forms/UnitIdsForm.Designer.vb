<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UnitIdsForm
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
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cboWarehouse = New System.Windows.Forms.ComboBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.dgvUnits = New System.Windows.Forms.DataGridView()
        Me.cmdClose = New System.Windows.Forms.Button()
        CType(Me.dgvUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFilter
        '
        Me.lblFilter.Location = New System.Drawing.Point(16, 16)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(70, 23)
        Me.lblFilter.TabIndex = 0
        Me.lblFilter.Text = "Filter By"
        Me.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboWarehouse
        '
        Me.cboWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWarehouse.Location = New System.Drawing.Point(90, 14)
        Me.cboWarehouse.Name = "cboWarehouse"
        Me.cboWarehouse.Size = New System.Drawing.Size(260, 26)
        Me.cboWarehouse.TabIndex = 1
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(360, 16)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(184, 23)
        Me.lblCount.TabIndex = 2
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvUnits
        '
        Me.dgvUnits.AllowUserToAddRows = False
        Me.dgvUnits.AllowUserToDeleteRows = False
        Me.dgvUnits.AllowUserToResizeRows = False
        Me.dgvUnits.BackgroundColor = System.Drawing.Color.White
        Me.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnits.Location = New System.Drawing.Point(16, 52)
        Me.dgvUnits.MultiSelect = False
        Me.dgvUnits.Name = "dgvUnits"
        Me.dgvUnits.ReadOnly = True
        Me.dgvUnits.RowHeadersVisible = False
        Me.dgvUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnits.Size = New System.Drawing.Size(528, 400)
        Me.dgvUnits.TabIndex = 3
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(400, 464)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(144, 40)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'UnitIdsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(560, 520)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.cboWarehouse)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.dgvUnits)
        Me.Controls.Add(Me.cmdClose)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UnitIdsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadence Unit ID's"
        CType(Me.dgvUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents cboWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents dgvUnits As System.Windows.Forms.DataGridView
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
