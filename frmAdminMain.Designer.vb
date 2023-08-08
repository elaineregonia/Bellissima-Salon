<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminMain))
        Me.pnlTop = New Guna.UI.WinForms.GunaPanel()
        Me.lblID = New Guna.UI.WinForms.GunaLabel()
        Me.lblName = New Guna.UI.WinForms.GunaLabel()
        Me.GunaVSeparator2 = New Guna.UI.WinForms.GunaVSeparator()
        Me.pbAdown = New Guna.UI.WinForms.GunaPictureBox()
        Me.pbUserPic = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.pnBody = New Guna.UI.WinForms.GunaPanel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnDash = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnEmpMan = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnSer = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnRep = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnlExpand = New Guna.UI.WinForms.GunaPanel()
        Me.btnSeeProf = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlMenu = New Guna.UI.WinForms.GunaPanel()
        Me.btnLogHis = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlTop.SuspendLayout()
        CType(Me.pbAdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUserPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnBody.SuspendLayout()
        Me.pnlExpand.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblID)
        Me.pnlTop.Controls.Add(Me.lblName)
        Me.pnlTop.Controls.Add(Me.GunaVSeparator2)
        Me.pnlTop.Controls.Add(Me.pbAdown)
        Me.pnlTop.Controls.Add(Me.pbUserPic)
        Me.pnlTop.Controls.Add(Me.GunaLabel1)
        Me.pnlTop.Controls.Add(Me.GunaPictureBox1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(971, 55)
        Me.pnlTop.TabIndex = 2
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Vegan Style Personal Use", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblID.Location = New System.Drawing.Point(473, 7)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(170, 40)
        Me.lblID.TabIndex = 9
        Me.lblID.Text = "Bellissima Salon"
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(725, 17)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(175, 20)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Maria Elaine Regonia"
        '
        'GunaVSeparator2
        '
        Me.GunaVSeparator2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.GunaVSeparator2.Location = New System.Drawing.Point(898, 12)
        Me.GunaVSeparator2.Name = "GunaVSeparator2"
        Me.GunaVSeparator2.Size = New System.Drawing.Size(10, 32)
        Me.GunaVSeparator2.TabIndex = 7
        '
        'pbAdown
        '
        Me.pbAdown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbAdown.BaseColor = System.Drawing.Color.White
        Me.pbAdown.Image = CType(resources.GetObject("pbAdown.Image"), System.Drawing.Image)
        Me.pbAdown.Location = New System.Drawing.Point(952, 23)
        Me.pbAdown.Name = "pbAdown"
        Me.pbAdown.Size = New System.Drawing.Size(12, 12)
        Me.pbAdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAdown.TabIndex = 6
        Me.pbAdown.TabStop = False
        '
        'pbUserPic
        '
        Me.pbUserPic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbUserPic.BaseColor = System.Drawing.Color.White
        Me.pbUserPic.Image = CType(resources.GetObject("pbUserPic.Image"), System.Drawing.Image)
        Me.pbUserPic.Location = New System.Drawing.Point(914, 12)
        Me.pbUserPic.Name = "pbUserPic"
        Me.pbUserPic.Size = New System.Drawing.Size(32, 32)
        Me.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUserPic.TabIndex = 5
        Me.pbUserPic.TabStop = False
        Me.pbUserPic.UseTransfarantBackground = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Vegan Style Personal Use", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(55, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(170, 40)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Bellissima Salon"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(43, 32)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'pnBody
        '
        Me.pnBody.Controls.Add(Me.pnlMain)
        Me.pnBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnBody.Location = New System.Drawing.Point(0, 100)
        Me.pnBody.Name = "pnBody"
        Me.pnBody.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.pnBody.Size = New System.Drawing.Size(971, 393)
        Me.pnBody.TabIndex = 194
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 6)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(971, 387)
        Me.pnlMain.TabIndex = 0
        '
        'btnDash
        '
        Me.btnDash.Animated = True
        Me.btnDash.AnimationHoverSpeed = 0.07!
        Me.btnDash.AnimationSpeed = 0.03!
        Me.btnDash.BaseColor = System.Drawing.Color.White
        Me.btnDash.BorderColor = System.Drawing.Color.Black
        Me.btnDash.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnDash.Checked = True
        Me.btnDash.CheckedBaseColor = System.Drawing.Color.White
        Me.btnDash.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnDash.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnDash.CheckedImage = Nothing
        Me.btnDash.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnDash.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDash.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDash.FocusedColor = System.Drawing.Color.Empty
        Me.btnDash.Font = New System.Drawing.Font("Sitka Subheading", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnDash.Image = Nothing
        Me.btnDash.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDash.LineBottom = 4
        Me.btnDash.LineColor = System.Drawing.Color.White
        Me.btnDash.Location = New System.Drawing.Point(0, 0)
        Me.btnDash.Name = "btnDash"
        Me.btnDash.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnDash.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDash.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnDash.OnHoverImage = Nothing
        Me.btnDash.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnDash.OnPressedColor = System.Drawing.Color.Black
        Me.btnDash.OnPressedDepth = 0
        Me.btnDash.Size = New System.Drawing.Size(112, 45)
        Me.btnDash.TabIndex = 0
        Me.btnDash.Text = "Dashboard"
        Me.btnDash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEmpMan
        '
        Me.btnEmpMan.Animated = True
        Me.btnEmpMan.AnimationHoverSpeed = 0.07!
        Me.btnEmpMan.AnimationSpeed = 0.03!
        Me.btnEmpMan.BaseColor = System.Drawing.Color.White
        Me.btnEmpMan.BorderColor = System.Drawing.Color.Black
        Me.btnEmpMan.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnEmpMan.CheckedBaseColor = System.Drawing.Color.White
        Me.btnEmpMan.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnEmpMan.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnEmpMan.CheckedImage = Nothing
        Me.btnEmpMan.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnEmpMan.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEmpMan.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEmpMan.FocusedColor = System.Drawing.Color.Empty
        Me.btnEmpMan.Font = New System.Drawing.Font("Sitka Subheading", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpMan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnEmpMan.Image = Nothing
        Me.btnEmpMan.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEmpMan.LineBottom = 4
        Me.btnEmpMan.LineColor = System.Drawing.Color.White
        Me.btnEmpMan.Location = New System.Drawing.Point(112, 0)
        Me.btnEmpMan.Name = "btnEmpMan"
        Me.btnEmpMan.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnEmpMan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEmpMan.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnEmpMan.OnHoverImage = Nothing
        Me.btnEmpMan.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnEmpMan.OnPressedColor = System.Drawing.Color.Black
        Me.btnEmpMan.OnPressedDepth = 0
        Me.btnEmpMan.Size = New System.Drawing.Size(151, 45)
        Me.btnEmpMan.TabIndex = 1
        Me.btnEmpMan.Text = "Employee Management"
        Me.btnEmpMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSer
        '
        Me.btnSer.Animated = True
        Me.btnSer.AnimationHoverSpeed = 0.07!
        Me.btnSer.AnimationSpeed = 0.03!
        Me.btnSer.BaseColor = System.Drawing.Color.White
        Me.btnSer.BorderColor = System.Drawing.Color.Black
        Me.btnSer.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnSer.CheckedBaseColor = System.Drawing.Color.White
        Me.btnSer.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSer.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnSer.CheckedImage = Nothing
        Me.btnSer.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnSer.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSer.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSer.FocusedColor = System.Drawing.Color.Empty
        Me.btnSer.Font = New System.Drawing.Font("Sitka Subheading", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnSer.Image = Nothing
        Me.btnSer.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSer.LineBottom = 4
        Me.btnSer.LineColor = System.Drawing.Color.White
        Me.btnSer.Location = New System.Drawing.Point(263, 0)
        Me.btnSer.Name = "btnSer"
        Me.btnSer.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnSer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSer.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnSer.OnHoverImage = Nothing
        Me.btnSer.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnSer.OnPressedColor = System.Drawing.Color.Black
        Me.btnSer.OnPressedDepth = 0
        Me.btnSer.Size = New System.Drawing.Size(102, 45)
        Me.btnSer.TabIndex = 2
        Me.btnSer.Text = "Service"
        Me.btnSer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRep
        '
        Me.btnRep.Animated = True
        Me.btnRep.AnimationHoverSpeed = 0.07!
        Me.btnRep.AnimationSpeed = 0.03!
        Me.btnRep.BaseColor = System.Drawing.Color.White
        Me.btnRep.BorderColor = System.Drawing.Color.Black
        Me.btnRep.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnRep.CheckedBaseColor = System.Drawing.Color.White
        Me.btnRep.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnRep.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnRep.CheckedImage = Nothing
        Me.btnRep.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnRep.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRep.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRep.FocusedColor = System.Drawing.Color.Empty
        Me.btnRep.Font = New System.Drawing.Font("Sitka Subheading", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnRep.Image = Nothing
        Me.btnRep.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRep.LineBottom = 4
        Me.btnRep.LineColor = System.Drawing.Color.White
        Me.btnRep.Location = New System.Drawing.Point(365, 0)
        Me.btnRep.Name = "btnRep"
        Me.btnRep.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnRep.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRep.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnRep.OnHoverImage = Nothing
        Me.btnRep.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnRep.OnPressedColor = System.Drawing.Color.Black
        Me.btnRep.OnPressedDepth = 0
        Me.btnRep.Size = New System.Drawing.Size(112, 45)
        Me.btnRep.TabIndex = 5
        Me.btnRep.Text = "Reports"
        Me.btnRep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlExpand
        '
        Me.pnlExpand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlExpand.BackColor = System.Drawing.Color.White
        Me.pnlExpand.Controls.Add(Me.btnSeeProf)
        Me.pnlExpand.Controls.Add(Me.btnLogout)
        Me.pnlExpand.Location = New System.Drawing.Point(771, 45)
        Me.pnlExpand.Name = "pnlExpand"
        Me.pnlExpand.Size = New System.Drawing.Size(200, 90)
        Me.pnlExpand.TabIndex = 0
        Me.pnlExpand.Visible = False
        '
        'btnSeeProf
        '
        Me.btnSeeProf.CheckedState.Parent = Me.btnSeeProf
        Me.btnSeeProf.CustomImages.Parent = Me.btnSeeProf
        Me.btnSeeProf.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSeeProf.FillColor = System.Drawing.Color.Empty
        Me.btnSeeProf.Font = New System.Drawing.Font("Sitka Subheading", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeeProf.ForeColor = System.Drawing.Color.Black
        Me.btnSeeProf.HoverState.Parent = Me.btnSeeProf
        Me.btnSeeProf.Image = CType(resources.GetObject("btnSeeProf.Image"), System.Drawing.Image)
        Me.btnSeeProf.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSeeProf.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnSeeProf.Location = New System.Drawing.Point(0, 0)
        Me.btnSeeProf.Name = "btnSeeProf"
        Me.btnSeeProf.ShadowDecoration.Parent = Me.btnSeeProf
        Me.btnSeeProf.Size = New System.Drawing.Size(200, 45)
        Me.btnSeeProf.TabIndex = 8
        Me.btnSeeProf.Text = "See your profile"
        Me.btnSeeProf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSeeProf.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnLogout
        '
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.Empty
        Me.btnLogout.Font = New System.Drawing.Font("Sitka Subheading", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnLogout.Location = New System.Drawing.Point(0, 45)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(200, 45)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.TextOffset = New System.Drawing.Point(5, 0)
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.White
        Me.pnlMenu.Controls.Add(Me.btnLogHis)
        Me.pnlMenu.Controls.Add(Me.btnRep)
        Me.pnlMenu.Controls.Add(Me.btnSer)
        Me.pnlMenu.Controls.Add(Me.btnEmpMan)
        Me.pnlMenu.Controls.Add(Me.btnDash)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenu.Location = New System.Drawing.Point(0, 55)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(971, 45)
        Me.pnlMenu.TabIndex = 193
        '
        'btnLogHis
        '
        Me.btnLogHis.Animated = True
        Me.btnLogHis.AnimationHoverSpeed = 0.07!
        Me.btnLogHis.AnimationSpeed = 0.03!
        Me.btnLogHis.BaseColor = System.Drawing.Color.White
        Me.btnLogHis.BorderColor = System.Drawing.Color.Black
        Me.btnLogHis.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnLogHis.CheckedBaseColor = System.Drawing.Color.White
        Me.btnLogHis.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnLogHis.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnLogHis.CheckedImage = Nothing
        Me.btnLogHis.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnLogHis.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogHis.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLogHis.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogHis.Font = New System.Drawing.Font("Sitka Subheading", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogHis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnLogHis.Image = Nothing
        Me.btnLogHis.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogHis.LineBottom = 4
        Me.btnLogHis.LineColor = System.Drawing.Color.White
        Me.btnLogHis.Location = New System.Drawing.Point(477, 0)
        Me.btnLogHis.Name = "btnLogHis"
        Me.btnLogHis.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnLogHis.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogHis.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnLogHis.OnHoverImage = Nothing
        Me.btnLogHis.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnLogHis.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogHis.OnPressedDepth = 0
        Me.btnLogHis.Size = New System.Drawing.Size(112, 45)
        Me.btnLogHis.TabIndex = 6
        Me.btnLogHis.Text = "Log History"
        Me.btnLogHis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me.pnlExpand
        '
        'frmAdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 493)
        Me.Controls.Add(Me.pnlExpand)
        Me.Controls.Add(Me.pnBody)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdminMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Bellissima Salon"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.pbAdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUserPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnBody.ResumeLayout(False)
        Me.pnlExpand.ResumeLayout(False)
        Me.pnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaVSeparator2 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents pbAdown As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents pbUserPic As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents pnBody As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnDash As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnEmpMan As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnSer As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnRep As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pnlExpand As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnlMenu As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnSeeProf As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnLogHis As Guna.UI.WinForms.GunaAdvenceButton
End Class
