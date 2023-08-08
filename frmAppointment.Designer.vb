<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointment
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppointment))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnDisp = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.dgApp = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBook = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.colDel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colAdd = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colStat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTop.SuspendLayout()
        CType(Me.dgApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.btnDisp)
        Me.pnlTop.Controls.Add(Me.lblUserType)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(997, 46)
        Me.pnlTop.TabIndex = 1
        '
        'btnDisp
        '
        Me.btnDisp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDisp.FillColor = System.Drawing.Color.Transparent
        Me.btnDisp.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDisp.HoverState.Parent = Me.btnDisp
        Me.btnDisp.IconColor = System.Drawing.Color.White
        Me.btnDisp.Location = New System.Drawing.Point(941, 9)
        Me.btnDisp.Name = "btnDisp"
        Me.btnDisp.ShadowDecoration.Parent = Me.btnDisp
        Me.btnDisp.Size = New System.Drawing.Size(45, 29)
        Me.btnDisp.TabIndex = 10
        Me.btnDisp.Visible = False
        '
        'lblUserType
        '
        Me.lblUserType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Vegan Style Personal Use", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(2, -1)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(180, 51)
        Me.lblUserType.TabIndex = 9
        Me.lblUserType.Text = "Appointment"
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgApp
        '
        Me.dgApp.AllowUserToAddRows = False
        Me.dgApp.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgApp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgApp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgApp.BackgroundColor = System.Drawing.Color.White
        Me.dgApp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgApp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgApp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgApp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgApp.ColumnHeadersHeight = 30
        Me.dgApp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUID, Me.colID, Me.colFName, Me.colSer, Me.colEmp, Me.colDate, Me.colTime, Me.colStat, Me.colAdd, Me.colEdit, Me.colDel})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgApp.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgApp.EnableHeadersVisualStyles = False
        Me.dgApp.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.dgApp.Location = New System.Drawing.Point(12, 99)
        Me.dgApp.Name = "dgApp"
        Me.dgApp.ReadOnly = True
        Me.dgApp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgApp.RowHeadersVisible = False
        Me.dgApp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgApp.Size = New System.Drawing.Size(966, 474)
        Me.dgApp.TabIndex = 2
        Me.dgApp.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Pink
        Me.dgApp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgApp.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgApp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgApp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgApp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgApp.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgApp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.dgApp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgApp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgApp.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgApp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgApp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgApp.ThemeStyle.HeaderStyle.Height = 30
        Me.dgApp.ThemeStyle.ReadOnly = True
        Me.dgApp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgApp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgApp.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgApp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgApp.ThemeStyle.RowsStyle.Height = 22
        Me.dgApp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.dgApp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BorderRadius = 10
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(891, 57)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(87, 36)
        Me.btnClose.TabIndex = 154
        Me.btnClose.Text = "CANCEL"
        '
        'btnBook
        '
        Me.btnBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBook.BorderRadius = 10
        Me.btnBook.CheckedState.Parent = Me.btnBook
        Me.btnBook.CustomImages.Parent = Me.btnBook
        Me.btnBook.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnBook.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.Color.White
        Me.btnBook.HoverState.Parent = Me.btnBook
        Me.btnBook.Location = New System.Drawing.Point(768, 57)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.ShadowDecoration.Parent = Me.btnBook
        Me.btnBook.Size = New System.Drawing.Size(117, 36)
        Me.btnBook.TabIndex = 153
        Me.btnBook.Text = "BOOK APPOINTMENT"
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
        Me.txtSearch.Location = New System.Drawing.Point(13, 57)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search a name here"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(748, 35)
        Me.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSearch.TabIndex = 152
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlTop
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 0
        Me.GunaElipse1.TargetControl = Me
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
        'colAdd
        '
        Me.colAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAdd.HeaderText = ""
        Me.colAdd.Image = CType(resources.GetObject("colAdd.Image"), System.Drawing.Image)
        Me.colAdd.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.colAdd.Name = "colAdd"
        Me.colAdd.ReadOnly = True
        Me.colAdd.Visible = False
        Me.colAdd.Width = 5
        '
        'colStat
        '
        Me.colStat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStat.HeaderText = "STATUS"
        Me.colStat.Name = "colStat"
        Me.colStat.ReadOnly = True
        Me.colStat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colStat.Width = 66
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
        'colDate
        '
        Me.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDate.HeaderText = "DATE"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDate.Width = 48
        '
        'colEmp
        '
        Me.colEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEmp.HeaderText = "EMPLOYEE"
        Me.colEmp.Name = "colEmp"
        Me.colEmp.ReadOnly = True
        Me.colEmp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colSer
        '
        Me.colSer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSer.HeaderText = "SERVICE"
        Me.colSer.Name = "colSer"
        Me.colSer.ReadOnly = True
        Me.colSer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colFName
        '
        Me.colFName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFName.HeaderText = "FULL NAME"
        Me.colFName.Name = "colFName"
        Me.colFName.ReadOnly = True
        Me.colFName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
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
        'frmAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(997, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgApp)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmAppointment"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.dgApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblUserType As Label
    Friend WithEvents dgApp As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBook As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnDisp As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents colUID As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colFName As DataGridViewTextBoxColumn
    Friend WithEvents colSer As DataGridViewTextBoxColumn
    Friend WithEvents colEmp As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colTime As DataGridViewTextBoxColumn
    Friend WithEvents colStat As DataGridViewTextBoxColumn
    Friend WithEvents colAdd As DataGridViewImageColumn
    Friend WithEvents colEdit As DataGridViewImageColumn
    Friend WithEvents colDel As DataGridViewImageColumn
End Class
