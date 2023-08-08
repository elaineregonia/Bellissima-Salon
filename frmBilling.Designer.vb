<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBilling
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBilling))
        Me.lblInvoNum = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.dgPay = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSubTot = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDisc = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblPayAmo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tmDate = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnPay = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDisc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnApp = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNewTran = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInvoNum
        '
        Me.lblInvoNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoNum.AutoSize = True
        Me.lblInvoNum.Font = New System.Drawing.Font("Fake Receipt", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoNum.ForeColor = System.Drawing.Color.White
        Me.lblInvoNum.Location = New System.Drawing.Point(12, 4)
        Me.lblInvoNum.Name = "lblInvoNum"
        Me.lblInvoNum.Size = New System.Drawing.Size(167, 31)
        Me.lblInvoNum.TabIndex = 9
        Me.lblInvoNum.Text = "202100001"
        Me.lblInvoNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblInvoNum)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1067, 37)
        Me.pnlTop.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTot)
        Me.Panel1.Location = New System.Drawing.Point(804, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 60)
        Me.Panel1.TabIndex = 10
        '
        'lblTot
        '
        Me.lblTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTot.AutoSize = True
        Me.lblTot.Font = New System.Drawing.Font("Fake Receipt", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot.ForeColor = System.Drawing.Color.Lime
        Me.lblTot.Location = New System.Drawing.Point(116, 13)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(99, 31)
        Me.lblTot.TabIndex = 10
        Me.lblTot.Text = "₱0.00"
        Me.lblTot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgPay
        '
        Me.dgPay.AllowUserToAddRows = False
        Me.dgPay.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgPay.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPay.BackgroundColor = System.Drawing.Color.White
        Me.dgPay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgPay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgPay.ColumnHeadersHeight = 30
        Me.dgPay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUID, Me.colIV, Me.colName, Me.colSer, Me.colPrice, Me.colDel})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPay.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgPay.EnableHeadersVisualStyles = False
        Me.dgPay.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgPay.Location = New System.Drawing.Point(12, 43)
        Me.dgPay.Name = "dgPay"
        Me.dgPay.ReadOnly = True
        Me.dgPay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgPay.RowHeadersVisible = False
        Me.dgPay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPay.Size = New System.Drawing.Size(780, 597)
        Me.dgPay.TabIndex = 12
        Me.dgPay.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.dgPay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgPay.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgPay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgPay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgPay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgPay.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgPay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgPay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dgPay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgPay.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgPay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgPay.ThemeStyle.HeaderStyle.Height = 30
        Me.dgPay.ThemeStyle.ReadOnly = True
        Me.dgPay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgPay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgPay.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgPay.ThemeStyle.RowsStyle.Height = 22
        Me.dgPay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.dgPay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
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
        'colIV
        '
        Me.colIV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colIV.HeaderText = "INVOICE NUMBER"
        Me.colIV.Name = "colIV"
        Me.colIV.ReadOnly = True
        Me.colIV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colIV.Width = 138
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colName.HeaderText = "NAME"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colSer
        '
        Me.colSer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSer.HeaderText = "SERVICE"
        Me.colSer.Name = "colSer"
        Me.colSer.ReadOnly = True
        Me.colSer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colSer.Width = 75
        '
        'colPrice
        '
        Me.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPrice.HeaderText = "PRICE"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 646)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1067, 37)
        Me.Panel2.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Image = Global.Bellissima_Salon.My.Resources.Resources.cancel_50px
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClose.ImageOffset = New System.Drawing.Point(5, 2)
        Me.btnClose.Location = New System.Drawing.Point(931, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.Thistle
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(133, 32)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "[Esc] Close"
        Me.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClose.TextOffset = New System.Drawing.Point(0, 2)
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lblSubTot)
        Me.Panel3.Location = New System.Drawing.Point(804, 284)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(256, 45)
        Me.Panel3.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Sub-Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTot
        '
        Me.lblSubTot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubTot.AutoSize = True
        Me.lblSubTot.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTot.ForeColor = System.Drawing.Color.Black
        Me.lblSubTot.Location = New System.Drawing.Point(165, 13)
        Me.lblSubTot.Name = "lblSubTot"
        Me.lblSubTot.Size = New System.Drawing.Size(64, 20)
        Me.lblSubTot.TabIndex = 10
        Me.lblSubTot.Text = "₱0.00"
        Me.lblSubTot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lblDisc)
        Me.Panel4.Location = New System.Drawing.Point(804, 335)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(256, 45)
        Me.Panel4.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "DISCOUNT"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisc
        '
        Me.lblDisc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisc.AutoSize = True
        Me.lblDisc.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisc.ForeColor = System.Drawing.Color.Black
        Me.lblDisc.Location = New System.Drawing.Point(167, 13)
        Me.lblDisc.Name = "lblDisc"
        Me.lblDisc.Size = New System.Drawing.Size(64, 20)
        Me.lblDisc.TabIndex = 11
        Me.lblDisc.Text = "₱0.00"
        Me.lblDisc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblVat)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(804, 386)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(256, 45)
        Me.Panel5.TabIndex = 19
        '
        'lblVat
        '
        Me.lblVat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVat.AutoSize = True
        Me.lblVat.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.ForeColor = System.Drawing.Color.Black
        Me.lblVat.Location = New System.Drawing.Point(167, 15)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(64, 20)
        Me.lblVat.TabIndex = 13
        Me.lblVat.Text = "₱0.00"
        Me.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "VATABLE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lblPayAmo)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(804, 437)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(256, 45)
        Me.Panel6.TabIndex = 19
        '
        'lblPayAmo
        '
        Me.lblPayAmo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPayAmo.AutoSize = True
        Me.lblPayAmo.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayAmo.ForeColor = System.Drawing.Color.Black
        Me.lblPayAmo.Location = New System.Drawing.Point(167, 12)
        Me.lblPayAmo.Name = "lblPayAmo"
        Me.lblPayAmo.Size = New System.Drawing.Size(64, 20)
        Me.lblPayAmo.TabIndex = 14
        Me.lblPayAmo.Text = "₱0.00"
        Me.lblPayAmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "TOTAL DUE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel7.Controls.Add(Me.lblTime)
        Me.Panel7.Controls.Add(Me.lblDate)
        Me.Panel7.Location = New System.Drawing.Point(804, 485)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(256, 155)
        Me.Panel7.TabIndex = 20
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Monospac821 BT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(29, 78)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(202, 35)
        Me.lblTime.TabIndex = 23
        Me.lblTime.Text = "12:17:05 PM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Monospac821 BT", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(27, 46)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(229, 20)
        Me.lblDate.TabIndex = 22
        Me.lblDate.Text = "Friday, May  02, 2000 "
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmDate
        '
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'btnPay
        '
        Me.btnPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnPay.CheckedState.Parent = Me.btnPay
        Me.btnPay.CustomImages.Parent = Me.btnPay
        Me.btnPay.FillColor = System.Drawing.Color.Empty
        Me.btnPay.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.HoverState.Parent = Me.btnPay
        Me.btnPay.Image = CType(resources.GetObject("btnPay.Image"), System.Drawing.Image)
        Me.btnPay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPay.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnPay.Location = New System.Drawing.Point(804, 233)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.PressedColor = System.Drawing.Color.Thistle
        Me.btnPay.ShadowDecoration.Parent = Me.btnPay
        Me.btnPay.Size = New System.Drawing.Size(256, 45)
        Me.btnPay.TabIndex = 16
        Me.btnPay.Text = "[F4] - Payment"
        Me.btnPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPay.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnDisc
        '
        Me.btnDisc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDisc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnDisc.CheckedState.Parent = Me.btnDisc
        Me.btnDisc.CustomImages.Parent = Me.btnDisc
        Me.btnDisc.FillColor = System.Drawing.Color.Empty
        Me.btnDisc.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisc.ForeColor = System.Drawing.Color.White
        Me.btnDisc.HoverState.Parent = Me.btnDisc
        Me.btnDisc.Image = CType(resources.GetObject("btnDisc.Image"), System.Drawing.Image)
        Me.btnDisc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDisc.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnDisc.Location = New System.Drawing.Point(804, 182)
        Me.btnDisc.Name = "btnDisc"
        Me.btnDisc.PressedColor = System.Drawing.Color.Thistle
        Me.btnDisc.ShadowDecoration.Parent = Me.btnDisc
        Me.btnDisc.Size = New System.Drawing.Size(256, 45)
        Me.btnDisc.TabIndex = 15
        Me.btnDisc.Text = "[F3] - Add Discount"
        Me.btnDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDisc.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnApp
        '
        Me.btnApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnApp.CheckedState.Parent = Me.btnApp
        Me.btnApp.CustomImages.Parent = Me.btnApp
        Me.btnApp.FillColor = System.Drawing.Color.Empty
        Me.btnApp.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApp.ForeColor = System.Drawing.Color.White
        Me.btnApp.HoverState.Parent = Me.btnApp
        Me.btnApp.Image = CType(resources.GetObject("btnApp.Image"), System.Drawing.Image)
        Me.btnApp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnApp.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnApp.Location = New System.Drawing.Point(804, 131)
        Me.btnApp.Name = "btnApp"
        Me.btnApp.PressedColor = System.Drawing.Color.Thistle
        Me.btnApp.ShadowDecoration.Parent = Me.btnApp
        Me.btnApp.Size = New System.Drawing.Size(256, 45)
        Me.btnApp.TabIndex = 14
        Me.btnApp.Text = "[F2] - Appointments"
        Me.btnApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnApp.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnNewTran
        '
        Me.btnNewTran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewTran.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnNewTran.CheckedState.Parent = Me.btnNewTran
        Me.btnNewTran.CustomImages.Parent = Me.btnNewTran
        Me.btnNewTran.FillColor = System.Drawing.Color.Empty
        Me.btnNewTran.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTran.ForeColor = System.Drawing.Color.White
        Me.btnNewTran.HoverState.Parent = Me.btnNewTran
        Me.btnNewTran.Image = CType(resources.GetObject("btnNewTran.Image"), System.Drawing.Image)
        Me.btnNewTran.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnNewTran.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnNewTran.Location = New System.Drawing.Point(804, 80)
        Me.btnNewTran.Name = "btnNewTran"
        Me.btnNewTran.PressedColor = System.Drawing.Color.Thistle
        Me.btnNewTran.ShadowDecoration.Parent = Me.btnNewTran
        Me.btnNewTran.Size = New System.Drawing.Size(256, 45)
        Me.btnNewTran.TabIndex = 13
        Me.btnNewTran.Text = "[F1] - New Transaction"
        Me.btnNewTran.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnNewTran.TextOffset = New System.Drawing.Point(10, 0)
        '
        'frmBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 683)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnDisc)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnApp)
        Me.Controls.Add(Me.btnNewTran)
        Me.Controls.Add(Me.dgPay)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmBilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblInvoNum As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgPay As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnNewTran As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTot As Label
    Friend WithEvents btnApp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDisc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblSubTot As Label
    Friend WithEvents lblDisc As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPayAmo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents colUID As DataGridViewTextBoxColumn
    Friend WithEvents colIV As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colSer As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colDel As DataGridViewImageColumn
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents tmDate As Timer
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
End Class
