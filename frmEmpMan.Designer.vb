<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpMan
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpMan))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.dgEmpMan = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colConNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAddEmp = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotEmp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New AForge.Controls.PictureBox()
        Me.pnlTop.SuspendLayout()
        CType(Me.dgEmpMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlTop.Size = New System.Drawing.Size(997, 46)
        Me.pnlTop.TabIndex = 0
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
        Me.lblUserType.Size = New System.Drawing.Size(270, 47)
        Me.lblUserType.TabIndex = 9
        Me.lblUserType.Text = "Employee Management"
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgEmpMan
        '
        Me.dgEmpMan.AllowUserToAddRows = False
        Me.dgEmpMan.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgEmpMan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgEmpMan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEmpMan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEmpMan.BackgroundColor = System.Drawing.Color.White
        Me.dgEmpMan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEmpMan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgEmpMan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEmpMan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgEmpMan.ColumnHeadersHeight = 30
        Me.dgEmpMan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNum, Me.colUID, Me.colFName, Me.colAddress, Me.colGender, Me.colEmail, Me.colConNum, Me.colUN, Me.colPW, Me.colUT, Me.colImage, Me.colEdit, Me.colDel})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEmpMan.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgEmpMan.EnableHeadersVisualStyles = False
        Me.dgEmpMan.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.dgEmpMan.Location = New System.Drawing.Point(9, 104)
        Me.dgEmpMan.Name = "dgEmpMan"
        Me.dgEmpMan.ReadOnly = True
        Me.dgEmpMan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEmpMan.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgEmpMan.RowHeadersVisible = False
        Me.dgEmpMan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgEmpMan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEmpMan.Size = New System.Drawing.Size(980, 474)
        Me.dgEmpMan.TabIndex = 0
        Me.dgEmpMan.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Pink
        Me.dgEmpMan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgEmpMan.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgEmpMan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgEmpMan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgEmpMan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgEmpMan.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgEmpMan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.dgEmpMan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgEmpMan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgEmpMan.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgEmpMan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgEmpMan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgEmpMan.ThemeStyle.HeaderStyle.Height = 30
        Me.dgEmpMan.ThemeStyle.ReadOnly = True
        Me.dgEmpMan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgEmpMan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgEmpMan.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgEmpMan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgEmpMan.ThemeStyle.RowsStyle.Height = 22
        Me.dgEmpMan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.dgEmpMan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'colNum
        '
        Me.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNum.HeaderText = "#"
        Me.colNum.Name = "colNum"
        Me.colNum.ReadOnly = True
        Me.colNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colNum.Width = 21
        '
        'colUID
        '
        Me.colUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colUID.HeaderText = "USER ID"
        Me.colUID.Name = "colUID"
        Me.colUID.ReadOnly = True
        Me.colUID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colUID.Width = 75
        '
        'colFName
        '
        Me.colFName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFName.HeaderText = "FULL NAME"
        Me.colFName.Name = "colFName"
        Me.colFName.ReadOnly = True
        Me.colFName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colAddress
        '
        Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAddress.HeaderText = "ADDRESS"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colGender
        '
        Me.colGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colGender.HeaderText = "GENDER"
        Me.colGender.Name = "colGender"
        Me.colGender.ReadOnly = True
        Me.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colGender.Width = 66
        '
        'colEmail
        '
        Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEmail.HeaderText = "EMAIL"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colConNum
        '
        Me.colConNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colConNum.HeaderText = "CONTACT NUMBER"
        Me.colConNum.Name = "colConNum"
        Me.colConNum.ReadOnly = True
        Me.colConNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colConNum.Width = 138
        '
        'colUN
        '
        Me.colUN.HeaderText = "USERNAME"
        Me.colUN.Name = "colUN"
        Me.colUN.ReadOnly = True
        Me.colUN.Visible = False
        '
        'colPW
        '
        Me.colPW.HeaderText = "PASSWORD"
        Me.colPW.Name = "colPW"
        Me.colPW.ReadOnly = True
        Me.colPW.Visible = False
        '
        'colUT
        '
        Me.colUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colUT.HeaderText = "USER TYPE"
        Me.colUT.Name = "colUT"
        Me.colUT.ReadOnly = True
        Me.colUT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colUT.Visible = False
        Me.colUT.Width = 93
        '
        'colImage
        '
        Me.colImage.HeaderText = "IMAGE"
        Me.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.colImage.Name = "colImage"
        Me.colImage.ReadOnly = True
        Me.colImage.Visible = False
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
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeftSize = New System.Drawing.Size(15, 15)
        Me.txtSearch.Location = New System.Drawing.Point(38, 62)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search a name here"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(718, 35)
        Me.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSearch.TabIndex = 149
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEmp.BorderRadius = 10
        Me.btnAddEmp.CheckedState.Parent = Me.btnAddEmp
        Me.btnAddEmp.CustomImages.Parent = Me.btnAddEmp
        Me.btnAddEmp.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAddEmp.Font = New System.Drawing.Font("Swis721 Blk BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.ForeColor = System.Drawing.Color.White
        Me.btnAddEmp.HoverState.Parent = Me.btnAddEmp
        Me.btnAddEmp.Location = New System.Drawing.Point(764, 62)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.ShadowDecoration.Parent = Me.btnAddEmp
        Me.btnAddEmp.Size = New System.Drawing.Size(117, 36)
        Me.btnAddEmp.TabIndex = 150
        Me.btnAddEmp.Text = "ADD EMPLOYEE"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BorderRadius = 10
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Swis721 Blk BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(887, 62)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(87, 36)
        Me.btnClose.TabIndex = 151
        Me.btnClose.Text = "CANCEL"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotEmp)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 598)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(996, 25)
        Me.Panel1.TabIndex = 152
        '
        'lblTotEmp
        '
        Me.lblTotEmp.AutoSize = True
        Me.lblTotEmp.Font = New System.Drawing.Font("Digital-7", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotEmp.ForeColor = System.Drawing.Color.Red
        Me.lblTotEmp.Location = New System.Drawing.Point(154, 4)
        Me.lblTotEmp.Name = "lblTotEmp"
        Me.lblTotEmp.Size = New System.Drawing.Size(24, 16)
        Me.lblTotEmp.TabIndex = 1
        Me.lblTotEmp.Text = "XX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL EMPLOYEE:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Bellissima_Salon.My.Resources.Resources.ICONsearch
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(14, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 21)
        Me.PictureBox2.TabIndex = 158
        Me.PictureBox2.TabStop = False
        '
        'frmEmpMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(996, 623)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddEmp)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.dgEmpMan)
        Me.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEmpMan"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.dgEmpMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblUserType As Label
    Friend WithEvents dgEmpMan As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAddEmp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotEmp As Label
    Friend WithEvents PictureBox2 As AForge.Controls.PictureBox
    Friend WithEvents colNum As DataGridViewTextBoxColumn
    Friend WithEvents colUID As DataGridViewTextBoxColumn
    Friend WithEvents colFName As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colGender As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colConNum As DataGridViewTextBoxColumn
    Friend WithEvents colUN As DataGridViewTextBoxColumn
    Friend WithEvents colPW As DataGridViewTextBoxColumn
    Friend WithEvents colUT As DataGridViewTextBoxColumn
    Friend WithEvents colImage As DataGridViewImageColumn
    Friend WithEvents colEdit As DataGridViewImageColumn
    Friend WithEvents colDel As DataGridViewImageColumn
End Class
