<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrdersInCompForm
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
        Me.lblList = New System.Windows.Forms.Label()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdClearTable = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblList
        '
        Me.lblList.Location = New System.Drawing.Point(16, 12)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(250, 23)
        Me.lblList.TabIndex = 0
        Me.lblList.Text = "Cadence IDs"
        Me.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvOrders
        '
        Me.dgvOrders.AllowUserToAddRows = False
        Me.dgvOrders.AllowUserToDeleteRows = False
        Me.dgvOrders.AllowUserToResizeRows = False
        Me.dgvOrders.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Location = New System.Drawing.Point(16, 40)
        Me.dgvOrders.MultiSelect = True
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.ReadOnly = True
        Me.dgvOrders.RowHeadersVisible = False
        Me.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrders.Size = New System.Drawing.Size(240, 440)
        Me.dgvOrders.TabIndex = 1
        '
        'lblAdd
        '
        Me.lblAdd.Location = New System.Drawing.Point(272, 12)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(240, 23)
        Me.lblAdd.TabIndex = 2
        Me.lblAdd.Text = "Add Cadence IDs (one per line)"
        Me.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAdd
        '
        Me.txtAdd.AcceptsReturn = True
        Me.txtAdd.Location = New System.Drawing.Point(272, 40)
        Me.txtAdd.MaxLength = 20000
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAdd.Size = New System.Drawing.Size(232, 300)
        Me.txtAdd.TabIndex = 3
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(272, 348)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(232, 36)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdRemove
        '
        Me.cmdRemove.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRemove.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Location = New System.Drawing.Point(272, 396)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(232, 36)
        Me.cmdRemove.TabIndex = 5
        Me.cmdRemove.Text = "Remove Selected"
        Me.cmdRemove.UseVisualStyleBackColor = False
        '
        'cmdClearTable
        '
        Me.cmdClearTable.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdClearTable.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdClearTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClearTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClearTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClearTable.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearTable.Location = New System.Drawing.Point(272, 444)
        Me.cmdClearTable.Name = "cmdClearTable"
        Me.cmdClearTable.Size = New System.Drawing.Size(232, 36)
        Me.cmdClearTable.TabIndex = 6
        Me.cmdClearTable.Text = "Clear Table"
        Me.cmdClearTable.UseVisualStyleBackColor = False
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(16, 490)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(240, 23)
        Me.lblCount.TabIndex = 7
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(189, 215, 238)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(360, 500)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(144, 40)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'OrdersInCompForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(520, 556)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.dgvOrders)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdClearTable)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.cmdClose)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OrdersInCompForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Orders In COMP"
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents dgvOrders As System.Windows.Forms.DataGridView
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents cmdClearTable As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
