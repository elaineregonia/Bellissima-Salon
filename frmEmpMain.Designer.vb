<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpMain))
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProfile = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAttend = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlTopPic = New System.Windows.Forms.Panel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.pbMenu = New System.Windows.Forms.PictureBox()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pbMainPic = New System.Windows.Forms.PictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMenu.SuspendLayout()
        Me.pnlTopPic.SuspendLayout()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMainPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(253, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(820, 589)
        Me.pnlMain.TabIndex = 10
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.btnProfile)
        Me.pnlMenu.Controls.Add(Me.btnAttend)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Controls.Add(Me.pnlTopPic)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(253, 589)
        Me.pnlMenu.TabIndex = 9
        '
        'btnLogout
        '
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.Empty
        Me.btnLogout.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnLogout.Location = New System.Drawing.Point(0, 544)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 3, 99, 3)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(253, 45)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnProfile
        '
        Me.btnProfile.CheckedState.Parent = Me.btnProfile
        Me.btnProfile.CustomImages.Parent = Me.btnProfile
        Me.btnProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProfile.FillColor = System.Drawing.Color.Empty
        Me.btnProfile.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.HoverState.Parent = Me.btnProfile
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnProfile.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnProfile.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnProfile.Location = New System.Drawing.Point(0, 352)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.PressedColor = System.Drawing.Color.Thistle
        Me.btnProfile.ShadowDecoration.Parent = Me.btnProfile
        Me.btnProfile.Size = New System.Drawing.Size(253, 45)
        Me.btnProfile.TabIndex = 3
        Me.btnProfile.Text = "MY PROFILE"
        Me.btnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnProfile.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnAttend
        '
        Me.btnAttend.CheckedState.Parent = Me.btnAttend
        Me.btnAttend.CustomImages.Parent = Me.btnAttend
        Me.btnAttend.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAttend.FillColor = System.Drawing.Color.Empty
        Me.btnAttend.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttend.ForeColor = System.Drawing.Color.White
        Me.btnAttend.HoverState.Parent = Me.btnAttend
        Me.btnAttend.Image = CType(resources.GetObject("btnAttend.Image"), System.Drawing.Image)
        Me.btnAttend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttend.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnAttend.Location = New System.Drawing.Point(0, 307)
        Me.btnAttend.Name = "btnAttend"
        Me.btnAttend.PressedColor = System.Drawing.Color.Thistle
        Me.btnAttend.ShadowDecoration.Parent = Me.btnAttend
        Me.btnAttend.Size = New System.Drawing.Size(253, 45)
        Me.btnAttend.TabIndex = 2
        Me.btnAttend.Text = "MY ATTENDANCE"
        Me.btnAttend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttend.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnHome
        '
        Me.btnHome.CheckedState.Parent = Me.btnHome
        Me.btnHome.CustomImages.Parent = Me.btnHome
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FillColor = System.Drawing.Color.Empty
        Me.btnHome.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.HoverState.Parent = Me.btnHome
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnHome.Location = New System.Drawing.Point(0, 262)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.PressedColor = System.Drawing.Color.Thistle
        Me.btnHome.ShadowDecoration.Parent = Me.btnHome
        Me.btnHome.Size = New System.Drawing.Size(253, 45)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "HOME"
        Me.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.TextOffset = New System.Drawing.Point(10, 0)
        '
        'pnlTopPic
        '
        Me.pnlTopPic.Controls.Add(Me.lblID)
        Me.pnlTopPic.Controls.Add(Me.pbMenu)
        Me.pnlTopPic.Controls.Add(Me.lblLog)
        Me.pnlTopPic.Controls.Add(Me.lblUserType)
        Me.pnlTopPic.Controls.Add(Me.lblName)
        Me.pnlTopPic.Controls.Add(Me.pbMainPic)
        Me.pnlTopPic.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopPic.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopPic.Name = "pnlTopPic"
        Me.pnlTopPic.Size = New System.Drawing.Size(253, 262)
        Me.pnlTopPic.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lblID.Location = New System.Drawing.Point(105, 18)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(40, 18)
        Me.lblID.TabIndex = 40
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblID.Visible = False
        '
        'pbMenu
        '
        Me.pbMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMenu.Image = CType(resources.GetObject("pbMenu.Image"), System.Drawing.Image)
        Me.pbMenu.Location = New System.Drawing.Point(6, 6)
        Me.pbMenu.Name = "pbMenu"
        Me.pbMenu.Size = New System.Drawing.Size(32, 30)
        Me.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMenu.TabIndex = 10
        Me.pbMenu.TabStop = False
        '
        'lblLog
        '
        Me.lblLog.Font = New System.Drawing.Font("Digital-7", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.ForeColor = System.Drawing.Color.White
        Me.lblLog.Location = New System.Drawing.Point(-9, 240)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(284, 18)
        Me.lblLog.TabIndex = 9
        Me.lblLog.Text = "2020/12/08 03:12:01 AM"
        Me.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserType
        '
        Me.lblUserType.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(-9, 215)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(284, 25)
        Me.lblUserType.TabIndex = 8
        Me.lblUserType.Text = "Receptionist"
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(-8, 197)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(284, 18)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Shin Yuna"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbMainPic
        '
        Me.pbMainPic.Image = CType(resources.GetObject("pbMainPic.Image"), System.Drawing.Image)
        Me.pbMainPic.Location = New System.Drawing.Point(49, 44)
        Me.pbMainPic.Name = "pbMainPic"
        Me.pbMainPic.Size = New System.Drawing.Size(156, 138)
        Me.pbMainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMainPic.TabIndex = 6
        Me.pbMainPic.TabStop = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlTopPic
        '
        'Timer1
        '
        '
        'frmEmpMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1073, 589)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmpMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmpMain"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlTopPic.ResumeLayout(False)
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMainPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProfile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAttend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlTopPic As Panel
    Friend WithEvents pbMenu As PictureBox
    Friend WithEvents lblLog As Label
    Friend WithEvents lblUserType As Label
    Friend WithEvents lblName As Label
    Friend WithEvents pbMainPic As PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblID As Label
End Class
