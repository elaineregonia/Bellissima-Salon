<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmService))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.dgSer = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlTop.SuspendLayout()
        CType(Me.dgSer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblUserType)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1052, 37)
        Me.pnlTop.TabIndex = 1
        '
        'lblUserType
        '
        Me.lblUserType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Vegan Style Personal Use", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(2, -5)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(97, 47)
        Me.lblUserType.TabIndex = 9
        Me.lblUserType.Text = "Service"
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgSer
        '
        Me.dgSer.AllowUserToAddRows = False
        Me.dgSer.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgSer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSer.BackgroundColor = System.Drawing.Color.White
        Me.dgSer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgSer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgSer.ColumnHeadersHeight = 30
        Me.dgSer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUID, Me.colID, Me.colSer, Me.colCat, Me.colPrice, Me.colTime, Me.colEdit, Me.colDel})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSer.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgSer.EnableHeadersVisualStyles = False
        Me.dgSer.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.dgSer.Location = New System.Drawing.Point(12, 89)
        Me.dgSer.Name = "dgSer"
        Me.dgSer.ReadOnly = True
        Me.dgSer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgSer.RowHeadersVisible = False
        Me.dgSer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgSer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSer.Size = New System.Drawing.Size(572, 484)
        Me.dgSer.TabIndex = 2
        Me.dgSer.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Pink
        Me.dgSer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgSer.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgSer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgSer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgSer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgSer.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgSer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.dgSer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgSer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgSer.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgSer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgSer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgSer.ThemeStyle.HeaderStyle.Height = 30
        Me.dgSer.ThemeStyle.ReadOnly = True
        Me.dgSer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgSer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgSer.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgSer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgSer.ThemeStyle.RowsStyle.Height = 22
        Me.dgSer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.dgSer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        'colID
        '
        Me.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colID.Visible = False
        Me.colID.Width = 30
        '
        'colSer
        '
        Me.colSer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSer.HeaderText = "SERVICE"
        Me.colSer.Name = "colSer"
        Me.colSer.ReadOnly = True
        Me.colSer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colCat
        '
        Me.colCat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCat.HeaderText = "CATEGORY"
        Me.colCat.Name = "colCat"
        Me.colCat.ReadOnly = True
        Me.colCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colCat.Width = 84
        '
        'colPrice
        '
        Me.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPrice.HeaderText = "PRICE"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colTime
        '
        Me.colTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTime.HeaderText = "TIME"
        Me.colTime.Name = "colTime"
        Me.colTime.ReadOnly = True
        Me.colTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTime.Width = 48
        '
        'colEdit
        '
        Me.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEdit.HeaderText = ""
        Me.colEdit.Image = CType(resources.GetObject("colEdit.Image"), System.Drawing.Image)
        Me.colEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Width = 5
        '
        'colDel
        '
        Me.colDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDel.HeaderText = ""
        Me.colDel.Image = CType(resources.GetObject("colDel.Image"), System.Drawing.Image)
        Me.colDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.colDel.Name = "colDel"
        Me.colDel.ReadOnly = True
        Me.colDel.Width = 5
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderRadius = 10
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Swis721 Blk BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(456, 47)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(117, 36)
        Me.btnAdd.TabIndex = 153
        Me.btnAdd.Text = "ADD SERVICE"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.Transparent
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtSearch.BorderRadius = 10
        Me.txtSearch.BorderThickness = 3
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = CType(resources.GetObject("txtSearch.IconLeft"), System.Drawing.Image)
        Me.txtSearch.Location = New System.Drawing.Point(12, 47)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search service here"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(437, 35)
        Me.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSearch.TabIndex = 152
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Bellissima_Salon.My.Resources.Resources.list
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(590, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 526)
        Me.PictureBox1.TabIndex = 155
        Me.PictureBox1.TabStop = False
        '
        'frmService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Bellissima_Salon.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1052, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgSer)
        Me.Controls.Add(Me.pnlTop)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmService"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.dgSer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblUserType As Label
    Friend WithEvents dgSer As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents colUID As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colSer As DataGridViewTextBoxColumn
    Friend WithEvents colCat As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colTime As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewImageColumn
    Friend WithEvents colDel As DataGridViewImageColumn
End Class
