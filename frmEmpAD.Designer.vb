<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpAD
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpAD))
        Me.dgAtt = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLogDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.dpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAtt
        '
        Me.dgAtt.AllowUserToAddRows = False
        Me.dgAtt.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgAtt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgAtt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAtt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgAtt.BackgroundColor = System.Drawing.Color.White
        Me.dgAtt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgAtt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgAtt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAtt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgAtt.ColumnHeadersHeight = 30
        Me.dgAtt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUID, Me.colLogDate, Me.colTimeIn, Me.colLI, Me.colLO, Me.colTimeOut})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAtt.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgAtt.EnableHeadersVisualStyles = False
        Me.dgAtt.GridColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgAtt.Location = New System.Drawing.Point(12, 104)
        Me.dgAtt.Name = "dgAtt"
        Me.dgAtt.ReadOnly = True
        Me.dgAtt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgAtt.RowHeadersVisible = False
        Me.dgAtt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgAtt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAtt.Size = New System.Drawing.Size(800, 410)
        Me.dgAtt.TabIndex = 3
        Me.dgAtt.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Cyan
        Me.dgAtt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgAtt.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgAtt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgAtt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgAtt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgAtt.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgAtt.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgAtt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.dgAtt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgAtt.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgAtt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgAtt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgAtt.ThemeStyle.HeaderStyle.Height = 30
        Me.dgAtt.ThemeStyle.ReadOnly = True
        Me.dgAtt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.dgAtt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgAtt.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgAtt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgAtt.ThemeStyle.RowsStyle.Height = 22
        Me.dgAtt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgAtt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'colUID
        '
        Me.colUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colUID.HeaderText = "#"
        Me.colUID.Name = "colUID"
        Me.colUID.ReadOnly = True
        Me.colUID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colUID.Width = 21
        '
        'colLogDate
        '
        Me.colLogDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colLogDate.HeaderText = "LOG DATE"
        Me.colLogDate.Name = "colLogDate"
        Me.colLogDate.ReadOnly = True
        Me.colLogDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colTimeIn
        '
        Me.colTimeIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTimeIn.HeaderText = "TIME IN"
        Me.colTimeIn.Name = "colTimeIn"
        Me.colTimeIn.ReadOnly = True
        Me.colTimeIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTimeIn.Width = 75
        '
        'colLI
        '
        Me.colLI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLI.HeaderText = "LUNCH IN"
        Me.colLI.Name = "colLI"
        Me.colLI.ReadOnly = True
        Me.colLI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colLI.Width = 84
        '
        'colLO
        '
        Me.colLO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLO.HeaderText = "LUNCH OUT"
        Me.colLO.Name = "colLO"
        Me.colLO.ReadOnly = True
        Me.colLO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colLO.Width = 93
        '
        'colTimeOut
        '
        Me.colTimeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTimeOut.HeaderText = "TIME OUT"
        Me.colTimeOut.Name = "colTimeOut"
        Me.colTimeOut.ReadOnly = True
        Me.colTimeOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTimeOut.Width = 84
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblUserType)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(820, 46)
        Me.pnlTop.TabIndex = 4
        '
        'lblUserType
        '
        Me.lblUserType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Vegan Style Personal Use", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(2, -2)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(197, 47)
        Me.lblUserType.TabIndex = 9
        Me.lblUserType.Text = "My Attendance"
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dpTo
        '
        Me.dpTo.CheckedState.Parent = Me.dpTo
        Me.dpTo.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dpTo.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dpTo.HoverState.Parent = Me.dpTo
        Me.dpTo.Location = New System.Drawing.Point(426, 64)
        Me.dpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dpTo.Name = "dpTo"
        Me.dpTo.ShadowDecoration.Parent = Me.dpTo
        Me.dpTo.Size = New System.Drawing.Size(182, 27)
        Me.dpTo.TabIndex = 160
        Me.dpTo.Value = New Date(2021, 4, 10, 23, 33, 36, 128)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 162
        Me.PictureBox1.TabStop = False
        '
        'dpFrom
        '
        Me.dpFrom.CheckedState.Parent = Me.dpFrom
        Me.dpFrom.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dpFrom.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dpFrom.HoverState.Parent = Me.dpFrom
        Me.dpFrom.Location = New System.Drawing.Point(193, 64)
        Me.dpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dpFrom.Name = "dpFrom"
        Me.dpFrom.ShadowDecoration.Parent = Me.dpFrom
        Me.dpFrom.Size = New System.Drawing.Size(182, 27)
        Me.dpFrom.TabIndex = 163
        Me.dpFrom.Value = New Date(2021, 4, 10, 23, 33, 36, 128)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 15)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "FILTER BY [FROM]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "[TO]"
        '
        'frmEmpAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 589)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dpFrom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dpTo)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.dgAtt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmpAD"
        Me.Text = "frmEmpAD"
        CType(Me.dgAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgAtt As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblUserType As Label
    Friend WithEvents dpTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dpFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents colUID As DataGridViewTextBoxColumn
    Friend WithEvents colLogDate As DataGridViewTextBoxColumn
    Friend WithEvents colTimeIn As DataGridViewTextBoxColumn
    Friend WithEvents colLI As DataGridViewTextBoxColumn
    Friend WithEvents colLO As DataGridViewTextBoxColumn
    Friend WithEvents colTimeOut As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
