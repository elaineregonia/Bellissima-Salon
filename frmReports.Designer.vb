<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.dgRep = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.lblDis = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSubTot = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotSales = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDaily = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlTop.SuspendLayout()
        CType(Me.dgRep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblUserType)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1226, 46)
        Me.pnlTop.TabIndex = 14
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
        Me.lblUserType.Size = New System.Drawing.Size(105, 47)
        Me.lblUserType.TabIndex = 9
        Me.lblUserType.Text = "Reports"
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgRep
        '
        Me.dgRep.AllowUserToAddRows = False
        Me.dgRep.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgRep.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgRep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgRep.BackgroundColor = System.Drawing.Color.White
        Me.dgRep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgRep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgRep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRep.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgRep.ColumnHeadersHeight = 30
        Me.dgRep.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUID, Me.colNV, Me.colFName, Me.colSer, Me.colDate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRep.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgRep.EnableHeadersVisualStyles = False
        Me.dgRep.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.dgRep.Location = New System.Drawing.Point(12, 90)
        Me.dgRep.Name = "dgRep"
        Me.dgRep.ReadOnly = True
        Me.dgRep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgRep.RowHeadersVisible = False
        Me.dgRep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRep.Size = New System.Drawing.Size(1202, 468)
        Me.dgRep.TabIndex = 15
        Me.dgRep.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Pink
        Me.dgRep.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgRep.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgRep.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgRep.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgRep.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgRep.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgRep.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.dgRep.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgRep.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgRep.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgRep.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgRep.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgRep.ThemeStyle.HeaderStyle.Height = 30
        Me.dgRep.ThemeStyle.ReadOnly = True
        Me.dgRep.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgRep.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgRep.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgRep.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgRep.ThemeStyle.RowsStyle.Height = 22
        Me.dgRep.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.dgRep.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        'colNV
        '
        Me.colNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNV.HeaderText = "INVOICE NUMBER"
        Me.colNV.Name = "colNV"
        Me.colNV.ReadOnly = True
        Me.colNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colFName
        '
        Me.colFName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFName.HeaderText = "FULL NAME"
        Me.colFName.Name = "colFName"
        Me.colFName.ReadOnly = True
        Me.colFName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colSer
        '
        Me.colSer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSer.HeaderText = "SERVICE"
        Me.colSer.Name = "colSer"
        Me.colSer.ReadOnly = True
        Me.colSer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDate
        '
        Me.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDate.HeaderText = "DATE"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 565)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Total:"
        '
        'lblTot
        '
        Me.lblTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTot.AutoSize = True
        Me.lblTot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTot.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot.Location = New System.Drawing.Point(93, 565)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(20, 20)
        Me.lblTot.TabIndex = 17
        Me.lblTot.Text = "-"
        '
        'lblDis
        '
        Me.lblDis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDis.AutoSize = True
        Me.lblDis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDis.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDis.Location = New System.Drawing.Point(354, 565)
        Me.lblDis.Name = "lblDis"
        Me.lblDis.Size = New System.Drawing.Size(20, 20)
        Me.lblDis.TabIndex = 19
        Me.lblDis.Text = "-"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(231, 565)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "DISCOUNT:"
        '
        'lblSubTot
        '
        Me.lblSubTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubTot.AutoSize = True
        Me.lblSubTot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSubTot.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTot.Location = New System.Drawing.Point(626, 565)
        Me.lblSubTot.Name = "lblSubTot"
        Me.lblSubTot.Size = New System.Drawing.Size(20, 20)
        Me.lblSubTot.TabIndex = 21
        Me.lblSubTot.Text = "-"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(491, 565)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "SUB-TOTAL:"
        '
        'lblVat
        '
        Me.lblVat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVat.AutoSize = True
        Me.lblVat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblVat.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.Location = New System.Drawing.Point(873, 565)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(20, 20)
        Me.lblVat.TabIndex = 23
        Me.lblVat.Text = "-"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(762, 565)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "VATABLE:"
        '
        'lblTotSales
        '
        Me.lblTotSales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotSales.AutoSize = True
        Me.lblTotSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotSales.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSales.Location = New System.Drawing.Point(1149, 565)
        Me.lblTotSales.Name = "lblTotSales"
        Me.lblTotSales.Size = New System.Drawing.Size(20, 20)
        Me.lblTotSales.TabIndex = 25
        Me.lblTotSales.Text = "-"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(990, 565)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Total Sales:"
        '
        'lblDaily
        '
        Me.lblDaily.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDaily.AutoSize = True
        Me.lblDaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDaily.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaily.Location = New System.Drawing.Point(1072, 60)
        Me.lblDaily.Name = "lblDaily"
        Me.lblDaily.Size = New System.Drawing.Size(53, 20)
        Me.lblDaily.TabIndex = 27
        Me.lblDaily.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(841, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Total Daily Sales:"
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
        Me.txtSearch.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = CType(resources.GetObject("txtSearch.IconLeft"), System.Drawing.Image)
        Me.txtSearch.Location = New System.Drawing.Point(16, 51)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search a name here"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(818, 35)
        Me.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSearch.TabIndex = 153
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1226, 590)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblDaily)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTotSales)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSubTot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgRep)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReports"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.dgRep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblUserType As Label
    Friend WithEvents dgRep As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colUID As DataGridViewTextBoxColumn
    Friend WithEvents colNV As DataGridViewTextBoxColumn
    Friend WithEvents colFName As DataGridViewTextBoxColumn
    Friend WithEvents colSer As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTot As Label
    Friend WithEvents lblDis As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSubTot As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotSales As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDaily As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
