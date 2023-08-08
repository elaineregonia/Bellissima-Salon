<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClients))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.dgClients = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFirstIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAddClient = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotEmp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlTop.SuspendLayout()
        CType(Me.dgClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblUserType)
        Me.pnlTop.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblUserType.Font = New System.Drawing.Font("Vegan Style Personal Use", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(2, 1)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(93, 51)
        Me.lblUserType.TabIndex = 9
        Me.lblUserType.Text = "Clients"
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgClients
        '
        Me.dgClients.AllowUserToAddRows = False
        Me.dgClients.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgClients.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgClients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgClients.BackgroundColor = System.Drawing.Color.White
        Me.dgClients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgClients.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgClients.ColumnHeadersHeight = 30
        Me.dgClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUID, Me.colID, Me.colFName, Me.colAddress, Me.colEmail, Me.colNum, Me.colFirstIn, Me.colEdit, Me.colDel})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgClients.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgClients.EnableHeadersVisualStyles = False
        Me.dgClients.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.dgClients.Location = New System.Drawing.Point(18, 104)
        Me.dgClients.Name = "dgClients"
        Me.dgClients.ReadOnly = True
        Me.dgClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgClients.RowHeadersVisible = False
        Me.dgClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClients.Size = New System.Drawing.Size(966, 474)
        Me.dgClients.TabIndex = 159
        Me.dgClients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Pink
        Me.dgClients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgClients.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgClients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgClients.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgClients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.dgClients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgClients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgClients.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgClients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgClients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgClients.ThemeStyle.HeaderStyle.Height = 30
        Me.dgClients.ThemeStyle.ReadOnly = True
        Me.dgClients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgClients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgClients.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgClients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgClients.ThemeStyle.RowsStyle.Height = 22
        Me.dgClients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.dgClients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
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
        'colEmail
        '
        Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEmail.HeaderText = "EMAIL"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colNum
        '
        Me.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNum.HeaderText = "CONTACT NUMBER"
        Me.colNum.Name = "colNum"
        Me.colNum.ReadOnly = True
        Me.colNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colNum.Width = 138
        '
        'colFirstIn
        '
        Me.colFirstIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colFirstIn.HeaderText = "FIRST-IN"
        Me.colFirstIn.Name = "colFirstIn"
        Me.colFirstIn.ReadOnly = True
        Me.colFirstIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colFirstIn.Width = 84
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
        Me.txtSearch.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = CType(resources.GetObject("txtSearch.IconLeft"), System.Drawing.Image)
        Me.txtSearch.Location = New System.Drawing.Point(18, 62)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search a name here"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(739, 35)
        Me.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSearch.TabIndex = 149
        '
        'btnAddClient
        '
        Me.btnAddClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddClient.CheckedState.Parent = Me.btnAddClient
        Me.btnAddClient.CustomImages.Parent = Me.btnAddClient
        Me.btnAddClient.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAddClient.Font = New System.Drawing.Font("Swis721 Blk BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClient.ForeColor = System.Drawing.Color.White
        Me.btnAddClient.HoverState.Parent = Me.btnAddClient
        Me.btnAddClient.Location = New System.Drawing.Point(764, 62)
        Me.btnAddClient.Name = "btnAddClient"
        Me.btnAddClient.ShadowDecoration.Parent = Me.btnAddClient
        Me.btnAddClient.Size = New System.Drawing.Size(117, 36)
        Me.btnAddClient.TabIndex = 150
        Me.btnAddClient.Text = "ADD CLIENTS"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL CLIENTS:"
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
        'frmClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(996, 623)
        Me.Controls.Add(Me.dgClients)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddClient)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmClients"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.dgClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblUserType As Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAddClient As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotEmp As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents dgClients As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colUID As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colFName As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colNum As DataGridViewTextBoxColumn
    Friend WithEvents colFirstIn As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewImageColumn
    Friend WithEvents colDel As DataGridViewImageColumn
End Class
