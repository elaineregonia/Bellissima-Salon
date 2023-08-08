<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRecepMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecepMain))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPay = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClients = New Guna.UI2.WinForms.Guna2Button()
        Me.btnApp = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlTopPic = New System.Windows.Forms.Panel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.pbMenu = New System.Windows.Forms.PictureBox()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pbMainPic = New System.Windows.Forms.PictureBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPro = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlMenu.SuspendLayout()
        Me.pnlTopPic.SuspendLayout()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMainPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnPro)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.btnPay)
        Me.pnlMenu.Controls.Add(Me.btnClients)
        Me.pnlMenu.Controls.Add(Me.btnApp)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Controls.Add(Me.pnlTopPic)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(253, 596)
        Me.pnlMenu.TabIndex = 7
        '
        'btnLogout
        '
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.Empty
        Me.btnLogout.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnLogout.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnLogout.Location = New System.Drawing.Point(0, 551)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 3, 99, 3)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(253, 45)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnPay
        '
        Me.btnPay.CheckedState.Parent = Me.btnPay
        Me.btnPay.CustomImages.Parent = Me.btnPay
        Me.btnPay.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPay.FillColor = System.Drawing.Color.Empty
        Me.btnPay.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.Black
        Me.btnPay.HoverState.Parent = Me.btnPay
        Me.btnPay.Image = CType(resources.GetObject("btnPay.Image"), System.Drawing.Image)
        Me.btnPay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPay.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPay.Location = New System.Drawing.Point(0, 397)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.PressedColor = System.Drawing.Color.Thistle
        Me.btnPay.ShadowDecoration.Parent = Me.btnPay
        Me.btnPay.Size = New System.Drawing.Size(253, 45)
        Me.btnPay.TabIndex = 4
        Me.btnPay.Text = "BILLING"
        Me.btnPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnClients
        '
        Me.btnClients.CheckedState.Parent = Me.btnClients
        Me.btnClients.CustomImages.Parent = Me.btnClients
        Me.btnClients.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClients.FillColor = System.Drawing.Color.Empty
        Me.btnClients.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClients.ForeColor = System.Drawing.Color.Black
        Me.btnClients.HoverState.Parent = Me.btnClients
        Me.btnClients.Image = CType(resources.GetObject("btnClients.Image"), System.Drawing.Image)
        Me.btnClients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClients.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnClients.Location = New System.Drawing.Point(0, 352)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.PressedColor = System.Drawing.Color.Thistle
        Me.btnClients.ShadowDecoration.Parent = Me.btnClients
        Me.btnClients.Size = New System.Drawing.Size(253, 45)
        Me.btnClients.TabIndex = 3
        Me.btnClients.Text = "CLIENTS"
        Me.btnClients.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnApp
        '
        Me.btnApp.CheckedState.Parent = Me.btnApp
        Me.btnApp.CustomImages.Parent = Me.btnApp
        Me.btnApp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnApp.FillColor = System.Drawing.Color.Empty
        Me.btnApp.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApp.ForeColor = System.Drawing.Color.Black
        Me.btnApp.HoverState.Parent = Me.btnApp
        Me.btnApp.Image = CType(resources.GetObject("btnApp.Image"), System.Drawing.Image)
        Me.btnApp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnApp.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnApp.Location = New System.Drawing.Point(0, 307)
        Me.btnApp.Name = "btnApp"
        Me.btnApp.PressedColor = System.Drawing.Color.Thistle
        Me.btnApp.ShadowDecoration.Parent = Me.btnApp
        Me.btnApp.Size = New System.Drawing.Size(253, 45)
        Me.btnApp.TabIndex = 2
        Me.btnApp.Text = "APPOINTMENT"
        Me.btnApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnApp.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnHome
        '
        Me.btnHome.CheckedState.Parent = Me.btnHome
        Me.btnHome.CustomImages.Parent = Me.btnHome
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FillColor = System.Drawing.Color.Empty
        Me.btnHome.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.Black
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
        Me.btnHome.Text = " HOME"
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
        Me.lblID.Location = New System.Drawing.Point(45, 18)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(166, 18)
        Me.lblID.TabIndex = 11
        Me.lblID.Text = "202210"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblID.Visible = False
        '
        'pbMenu
        '
        Me.pbMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMenu.Image = CType(resources.GetObject("pbMenu.Image"), System.Drawing.Image)
        Me.pbMenu.Location = New System.Drawing.Point(5, 6)
        Me.pbMenu.Name = "pbMenu"
        Me.pbMenu.Size = New System.Drawing.Size(32, 30)
        Me.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMenu.TabIndex = 10
        Me.pbMenu.TabStop = False
        '
        'lblLog
        '
        Me.lblLog.Font = New System.Drawing.Font("Digital-7", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(253, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(777, 596)
        Me.pnlMain.TabIndex = 8
        '
        'Timer1
        '
        '
        'btnPro
        '
        Me.btnPro.CheckedState.Parent = Me.btnPro
        Me.btnPro.CustomImages.Parent = Me.btnPro
        Me.btnPro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPro.FillColor = System.Drawing.Color.Empty
        Me.btnPro.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPro.ForeColor = System.Drawing.Color.Black
        Me.btnPro.HoverState.Parent = Me.btnPro
        Me.btnPro.Image = CType(resources.GetObject("btnPro.Image"), System.Drawing.Image)
        Me.btnPro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPro.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPro.Location = New System.Drawing.Point(0, 442)
        Me.btnPro.Name = "btnPro"
        Me.btnPro.PressedColor = System.Drawing.Color.Thistle
        Me.btnPro.ShadowDecoration.Parent = Me.btnPro
        Me.btnPro.Size = New System.Drawing.Size(253, 45)
        Me.btnPro.TabIndex = 7
        Me.btnPro.Text = "MY PROFILE"
        Me.btnPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'frmRecepMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 596)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecepMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Bellissima Salon"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlTopPic.ResumeLayout(False)
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMainPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClients As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnApp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlTopPic As Panel
    Friend WithEvents pbMenu As PictureBox
    Friend WithEvents lblLog As Label
    Friend WithEvents lblUserType As Label
    Friend WithEvents lblName As Label
    Friend WithEvents pbMainPic As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnPay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblID As Label
    Friend WithEvents btnPro As Guna.UI2.WinForms.Guna2Button
End Class
