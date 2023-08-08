<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRecepHome
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecepHome))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmDate = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTI = New System.Windows.Forms.Label()
        Me.lblTO = New System.Windows.Forms.Label()
        Me.btnTI = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTO = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnTOLu = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTILu = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTOLu = New System.Windows.Forms.Label()
        Me.lblTILu = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.pnlAD = New Guna.UI.WinForms.GunaPanel()
        Me.lblAD = New System.Windows.Forms.Label()
        Me.pbAD = New System.Windows.Forms.PictureBox()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tmLoadData = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTop.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.pnlAD.SuspendLayout()
        CType(Me.pbAD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblUserType)
        Me.BunifuTransition1.SetDecoration(Me.pnlTop, BunifuAnimatorNS.DecorationType.None)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(820, 46)
        Me.pnlTop.TabIndex = 1
        '
        'lblUserType
        '
        Me.lblUserType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserType.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblUserType, BunifuAnimatorNS.DecorationType.None)
        Me.lblUserType.Font = New System.Drawing.Font("Vegan Style Personal Use", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(2, -2)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(91, 47)
        Me.lblUserType.TabIndex = 9
        Me.lblUserType.Text = "Home"
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Daily Time Record"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDate.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblDate, BunifuAnimatorNS.DecorationType.None)
        Me.lblDate.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(287, 123)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(248, 17)
        Me.lblDate.TabIndex = 11
        Me.lblDate.Text = "Friday, April  08, 2000 "
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblTime, BunifuAnimatorNS.DecorationType.None)
        Me.lblTime.Font = New System.Drawing.Font("Monospac821 BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(233, 140)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(344, 57)
        Me.lblTime.TabIndex = 12
        Me.lblTime.Text = "12:17:05 PM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmDate
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.AliceBlue
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(28, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "TIME IN :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.AliceBlue
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "TIME OUT:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTI
        '
        Me.lblTI.AutoSize = True
        Me.lblTI.BackColor = System.Drawing.Color.AliceBlue
        Me.BunifuTransition1.SetDecoration(Me.lblTI, BunifuAnimatorNS.DecorationType.None)
        Me.lblTI.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTI.ForeColor = System.Drawing.Color.Black
        Me.lblTI.Location = New System.Drawing.Point(158, 281)
        Me.lblTI.Name = "lblTI"
        Me.lblTI.Size = New System.Drawing.Size(48, 17)
        Me.lblTI.TabIndex = 15
        Me.lblTI.Text = "----"
        Me.lblTI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTO
        '
        Me.lblTO.AutoSize = True
        Me.lblTO.BackColor = System.Drawing.Color.AliceBlue
        Me.BunifuTransition1.SetDecoration(Me.lblTO, BunifuAnimatorNS.DecorationType.None)
        Me.lblTO.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTO.ForeColor = System.Drawing.Color.Black
        Me.lblTO.Location = New System.Drawing.Point(158, 326)
        Me.lblTO.Name = "lblTO"
        Me.lblTO.Size = New System.Drawing.Size(48, 17)
        Me.lblTO.TabIndex = 16
        Me.lblTO.Text = "----"
        Me.lblTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTI
        '
        Me.btnTI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTI.BackColor = System.Drawing.Color.Transparent
        Me.btnTI.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnTI.BorderRadius = 10
        Me.btnTI.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnTI.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnTI.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnTI.CheckedState.Image = CType(resources.GetObject("btnTI.CheckedState.Image"), System.Drawing.Image)
        Me.btnTI.CheckedState.Parent = Me.btnTI
        Me.btnTI.CustomImages.Parent = Me.btnTI
        Me.BunifuTransition1.SetDecoration(Me.btnTI, BunifuAnimatorNS.DecorationType.None)
        Me.btnTI.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnTI.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTI.ForeColor = System.Drawing.Color.White
        Me.btnTI.HoverState.Parent = Me.btnTI
        Me.btnTI.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTI.Location = New System.Drawing.Point(596, 9)
        Me.btnTI.Name = "btnTI"
        Me.btnTI.ShadowDecoration.Parent = Me.btnTI
        Me.btnTI.Size = New System.Drawing.Size(180, 36)
        Me.btnTI.TabIndex = 17
        Me.btnTI.Text = "TIME IN"
        '
        'btnTO
        '
        Me.btnTO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTO.BackColor = System.Drawing.Color.Transparent
        Me.btnTO.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnTO.BorderRadius = 10
        Me.btnTO.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnTO.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnTO.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnTO.CheckedState.Image = CType(resources.GetObject("btnTO.CheckedState.Image"), System.Drawing.Image)
        Me.btnTO.CheckedState.Parent = Me.btnTO
        Me.btnTO.CustomImages.Parent = Me.btnTO
        Me.BunifuTransition1.SetDecoration(Me.btnTO, BunifuAnimatorNS.DecorationType.None)
        Me.btnTO.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnTO.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTO.ForeColor = System.Drawing.Color.White
        Me.btnTO.HoverState.Parent = Me.btnTO
        Me.btnTO.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTO.Location = New System.Drawing.Point(596, 51)
        Me.btnTO.Name = "btnTO"
        Me.btnTO.ShadowDecoration.Parent = Me.btnTO
        Me.btnTO.Size = New System.Drawing.Size(180, 36)
        Me.btnTO.TabIndex = 18
        Me.btnTO.Text = "TIME OUT"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransition1.SetDecoration(Me.Guna2Separator1, BunifuAnimatorNS.DecorationType.None)
        Me.Guna2Separator1.Location = New System.Drawing.Point(31, 356)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(779, 10)
        Me.Guna2Separator1.TabIndex = 19
        '
        'btnTOLu
        '
        Me.btnTOLu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTOLu.BackColor = System.Drawing.Color.Transparent
        Me.btnTOLu.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnTOLu.BorderRadius = 10
        Me.btnTOLu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnTOLu.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnTOLu.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnTOLu.CheckedState.Image = CType(resources.GetObject("btnTOLu.CheckedState.Image"), System.Drawing.Image)
        Me.btnTOLu.CheckedState.Parent = Me.btnTOLu
        Me.btnTOLu.CustomImages.Parent = Me.btnTOLu
        Me.BunifuTransition1.SetDecoration(Me.btnTOLu, BunifuAnimatorNS.DecorationType.None)
        Me.btnTOLu.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnTOLu.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTOLu.ForeColor = System.Drawing.Color.White
        Me.btnTOLu.HoverState.Parent = Me.btnTOLu
        Me.btnTOLu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTOLu.Location = New System.Drawing.Point(628, 421)
        Me.btnTOLu.Name = "btnTOLu"
        Me.btnTOLu.ShadowDecoration.Parent = Me.btnTOLu
        Me.btnTOLu.Size = New System.Drawing.Size(180, 36)
        Me.btnTOLu.TabIndex = 25
        Me.btnTOLu.Text = "LUNCH OUT"
        '
        'btnTILu
        '
        Me.btnTILu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTILu.BackColor = System.Drawing.Color.Transparent
        Me.btnTILu.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnTILu.BorderRadius = 10
        Me.btnTILu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnTILu.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnTILu.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnTILu.CheckedState.Image = CType(resources.GetObject("btnTILu.CheckedState.Image"), System.Drawing.Image)
        Me.btnTILu.CheckedState.Parent = Me.btnTILu
        Me.btnTILu.CustomImages.Parent = Me.btnTILu
        Me.BunifuTransition1.SetDecoration(Me.btnTILu, BunifuAnimatorNS.DecorationType.None)
        Me.btnTILu.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnTILu.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTILu.ForeColor = System.Drawing.Color.White
        Me.btnTILu.HoverState.Parent = Me.btnTILu
        Me.btnTILu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTILu.Location = New System.Drawing.Point(628, 372)
        Me.btnTILu.Name = "btnTILu"
        Me.btnTILu.ShadowDecoration.Parent = Me.btnTILu
        Me.btnTILu.Size = New System.Drawing.Size(180, 36)
        Me.btnTILu.TabIndex = 24
        Me.btnTILu.Text = "LUNCH IN"
        '
        'lblTOLu
        '
        Me.lblTOLu.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblTOLu, BunifuAnimatorNS.DecorationType.None)
        Me.lblTOLu.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTOLu.ForeColor = System.Drawing.Color.Black
        Me.lblTOLu.Location = New System.Drawing.Point(388, 431)
        Me.lblTOLu.Name = "lblTOLu"
        Me.lblTOLu.Size = New System.Drawing.Size(48, 17)
        Me.lblTOLu.TabIndex = 23
        Me.lblTOLu.Text = "----"
        Me.lblTOLu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTILu
        '
        Me.lblTILu.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblTILu, BunifuAnimatorNS.DecorationType.None)
        Me.lblTILu.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTILu.ForeColor = System.Drawing.Color.Black
        Me.lblTILu.Location = New System.Drawing.Point(388, 385)
        Me.lblTILu.Name = "lblTILu"
        Me.lblTILu.Size = New System.Drawing.Size(48, 17)
        Me.lblTILu.TabIndex = 22
        Me.lblTILu.Text = "----"
        Me.lblTILu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(258, 431)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "END  :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(258, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "START:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(27, 404)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 24)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Lunch Break"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransition1.SetDecoration(Me.Guna2Separator2, BunifuAnimatorNS.DecorationType.None)
        Me.Guna2Separator2.Location = New System.Drawing.Point(29, 463)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(779, 10)
        Me.Guna2Separator2.TabIndex = 27
        '
        'Guna2Separator4
        '
        Me.Guna2Separator4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Separator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Guna2Separator4, BunifuAnimatorNS.DecorationType.None)
        Me.Guna2Separator4.Location = New System.Drawing.Point(29, 250)
        Me.Guna2Separator4.Name = "Guna2Separator4"
        Me.Guna2Separator4.Size = New System.Drawing.Size(779, 10)
        Me.Guna2Separator4.TabIndex = 36
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel1.BackColor = System.Drawing.Color.AliceBlue
        Me.GunaPanel1.Controls.Add(Me.btnTO)
        Me.GunaPanel1.Controls.Add(Me.btnTI)
        Me.BunifuTransition1.SetDecoration(Me.GunaPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.GunaPanel1.Location = New System.Drawing.Point(29, 257)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(779, 97)
        Me.GunaPanel1.TabIndex = 37
        '
        'pnlAD
        '
        Me.pnlAD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAD.BackColor = System.Drawing.Color.White
        Me.pnlAD.Controls.Add(Me.lblAD)
        Me.BunifuTransition1.SetDecoration(Me.pnlAD, BunifuAnimatorNS.DecorationType.None)
        Me.pnlAD.Location = New System.Drawing.Point(84, 520)
        Me.pnlAD.Name = "pnlAD"
        Me.pnlAD.Size = New System.Drawing.Size(726, 39)
        Me.pnlAD.TabIndex = 39
        '
        'lblAD
        '
        Me.lblAD.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblAD, BunifuAnimatorNS.DecorationType.None)
        Me.lblAD.Font = New System.Drawing.Font("Perpetua Titling MT", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAD.ForeColor = System.Drawing.Color.White
        Me.lblAD.Location = New System.Drawing.Point(16, 10)
        Me.lblAD.Name = "lblAD"
        Me.lblAD.Size = New System.Drawing.Size(446, 21)
        Me.lblAD.TabIndex = 40
        Me.lblAD.Text = "Your attendance is successfully record!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbAD
        '
        Me.pbAD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransition1.SetDecoration(Me.pbAD, BunifuAnimatorNS.DecorationType.None)
        Me.pbAD.Location = New System.Drawing.Point(33, 520)
        Me.pbAD.Name = "pbAD"
        Me.pbAD.Size = New System.Drawing.Size(45, 39)
        Me.pbAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAD.TabIndex = 40
        Me.pbAD.TabStop = False
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'tmLoadData
        '
        '
        'frmRecepHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 589)
        Me.Controls.Add(Me.lblTI)
        Me.Controls.Add(Me.lblTO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pbAD)
        Me.Controls.Add(Me.btnTOLu)
        Me.Controls.Add(Me.pnlAD)
        Me.Controls.Add(Me.Guna2Separator4)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnTILu)
        Me.Controls.Add(Me.lblTOLu)
        Me.Controls.Add(Me.lblTILu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.GunaPanel1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecepHome"
        Me.Text = "frmRecepHome"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        Me.pnlAD.ResumeLayout(False)
        Me.pnlAD.PerformLayout()
        CType(Me.pbAD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblUserType As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents tmDate As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTI As Label
    Friend WithEvents lblTO As Label
    Friend WithEvents btnTI As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnTOLu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTILu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTOLu As Label
    Friend WithEvents lblTILu As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnlAD As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lblAD As Label
    Friend WithEvents pbAD As PictureBox
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tmLoadData As Timer
End Class
