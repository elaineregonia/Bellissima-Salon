<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.txtUN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPW = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.btnScan = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.VideoSourcePlayer1 = New AForge.Controls.VideoSourcePlayer()
        Me.lblFPW = New System.Windows.Forms.Label()
        Me.llblFPW = New System.Windows.Forms.LinkLabel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbCam = New Guna.UI.WinForms.GunaComboBox()
        Me.pbShowPW = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbHidePW = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShowPW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHidePW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'txtUN
        '
        Me.txtUN.BackColor = System.Drawing.Color.Transparent
        Me.txtUN.BorderRadius = 10
        Me.txtUN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUN.DefaultText = ""
        Me.txtUN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUN.DisabledState.Parent = Me.txtUN
        Me.txtUN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUN.FillColor = System.Drawing.SystemColors.Window
        Me.txtUN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUN.FocusedState.Parent = Me.txtUN
        Me.txtUN.ForeColor = System.Drawing.Color.Black
        Me.txtUN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUN.HoverState.Parent = Me.txtUN
        Me.txtUN.Location = New System.Drawing.Point(285, 195)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUN.PlaceholderText = ""
        Me.txtUN.SelectedText = ""
        Me.txtUN.ShadowDecoration.Parent = Me.txtUN
        Me.txtUN.Size = New System.Drawing.Size(334, 23)
        Me.txtUN.TabIndex = 0
        '
        'txtPW
        '
        Me.txtPW.BackColor = System.Drawing.Color.Transparent
        Me.txtPW.BorderRadius = 10
        Me.txtPW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPW.DefaultText = ""
        Me.txtPW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPW.DisabledState.Parent = Me.txtPW
        Me.txtPW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPW.FillColor = System.Drawing.SystemColors.Window
        Me.txtPW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPW.FocusedState.Parent = Me.txtPW
        Me.txtPW.ForeColor = System.Drawing.Color.Black
        Me.txtPW.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPW.HoverState.Parent = Me.txtPW
        Me.txtPW.Location = New System.Drawing.Point(285, 260)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPW.PlaceholderText = ""
        Me.txtPW.SelectedText = ""
        Me.txtPW.ShadowDecoration.Parent = Me.txtPW
        Me.txtPW.Size = New System.Drawing.Size(334, 23)
        Me.txtPW.TabIndex = 1
        Me.txtPW.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderRadius = 12
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.White
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(297, 305)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(79, 26)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        '
        'btnScan
        '
        Me.btnScan.BackColor = System.Drawing.Color.Transparent
        Me.btnScan.BorderRadius = 5
        Me.btnScan.CheckedState.Parent = Me.btnScan
        Me.btnScan.CustomImages.Parent = Me.btnScan
        Me.btnScan.FillColor = System.Drawing.Color.White
        Me.btnScan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnScan.ForeColor = System.Drawing.Color.Black
        Me.btnScan.HoverState.Parent = Me.btnScan
        Me.btnScan.Image = Global.Bellissima_Salon.My.Resources.Resources.ICONscanner
        Me.btnScan.Location = New System.Drawing.Point(489, 305)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.ShadowDecoration.Parent = Me.btnScan
        Me.btnScan.Size = New System.Drawing.Size(115, 26)
        Me.btnScan.TabIndex = 6
        Me.btnScan.Text = "Scan QR CODE"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'btnClose
        '
        Me.btnClose.AutoRoundedCorners = True
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BorderRadius = 12
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(392, 305)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(79, 26)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        '
        'VideoSourcePlayer1
        '
        Me.VideoSourcePlayer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.VideoSourcePlayer1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VideoSourcePlayer1.Location = New System.Drawing.Point(522, 197)
        Me.VideoSourcePlayer1.Name = "VideoSourcePlayer1"
        Me.VideoSourcePlayer1.Size = New System.Drawing.Size(147, 129)
        Me.VideoSourcePlayer1.TabIndex = 12
        Me.VideoSourcePlayer1.Text = "VideoSourcePlayer1"
        Me.VideoSourcePlayer1.VideoSource = Nothing
        Me.VideoSourcePlayer1.Visible = False
        '
        'lblFPW
        '
        Me.lblFPW.AutoSize = True
        Me.lblFPW.BackColor = System.Drawing.Color.Transparent
        Me.lblFPW.Font = New System.Drawing.Font("Monospac821 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFPW.Location = New System.Drawing.Point(290, 286)
        Me.lblFPW.Name = "lblFPW"
        Me.lblFPW.Size = New System.Drawing.Size(161, 14)
        Me.lblFPW.TabIndex = 13
        Me.lblFPW.Text = "Forgot Password? Click"
        '
        'llblFPW
        '
        Me.llblFPW.AutoSize = True
        Me.llblFPW.BackColor = System.Drawing.Color.Transparent
        Me.llblFPW.Font = New System.Drawing.Font("Monospac821 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblFPW.LinkColor = System.Drawing.Color.Navy
        Me.llblFPW.Location = New System.Drawing.Point(449, 286)
        Me.llblFPW.Name = "llblFPW"
        Me.llblFPW.Size = New System.Drawing.Size(35, 14)
        Me.llblFPW.TabIndex = 14
        Me.llblFPW.TabStop = True
        Me.llblFPW.Text = "Here"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cbCam
        '
        Me.cbCam.BackColor = System.Drawing.Color.Transparent
        Me.cbCam.BaseColor = System.Drawing.Color.White
        Me.cbCam.BorderColor = System.Drawing.Color.Silver
        Me.cbCam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCam.FocusedColor = System.Drawing.Color.Empty
        Me.cbCam.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbCam.ForeColor = System.Drawing.Color.Black
        Me.cbCam.FormattingEnabled = True
        Me.cbCam.Location = New System.Drawing.Point(522, 165)
        Me.cbCam.Name = "cbCam"
        Me.cbCam.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCam.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbCam.Size = New System.Drawing.Size(147, 26)
        Me.cbCam.TabIndex = 15
        Me.cbCam.Visible = False
        '
        'pbShowPW
        '
        Me.pbShowPW.BackColor = System.Drawing.Color.Transparent
        Me.pbShowPW.Image = CType(resources.GetObject("pbShowPW.Image"), System.Drawing.Image)
        Me.pbShowPW.Location = New System.Drawing.Point(584, 263)
        Me.pbShowPW.Name = "pbShowPW"
        Me.pbShowPW.ShadowDecoration.Parent = Me.pbShowPW
        Me.pbShowPW.Size = New System.Drawing.Size(29, 16)
        Me.pbShowPW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbShowPW.TabIndex = 34
        Me.pbShowPW.TabStop = False
        Me.pbShowPW.UseTransparentBackground = True
        '
        'pbHidePW
        '
        Me.pbHidePW.BackColor = System.Drawing.Color.Transparent
        Me.pbHidePW.Image = CType(resources.GetObject("pbHidePW.Image"), System.Drawing.Image)
        Me.pbHidePW.Location = New System.Drawing.Point(584, 263)
        Me.pbHidePW.Name = "pbHidePW"
        Me.pbHidePW.ShadowDecoration.Parent = Me.pbHidePW
        Me.pbHidePW.Size = New System.Drawing.Size(29, 16)
        Me.pbHidePW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbHidePW.TabIndex = 35
        Me.pbHidePW.TabStop = False
        Me.pbHidePW.UseTransparentBackground = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bellissima_Salon.My.Resources.Resources.login
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(897, 472)
        Me.Controls.Add(Me.cbCam)
        Me.Controls.Add(Me.llblFPW)
        Me.Controls.Add(Me.lblFPW)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.VideoSourcePlayer1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.pbShowPW)
        Me.Controls.Add(Me.pbHidePW)
        Me.Controls.Add(Me.txtPW)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bellissima Salon"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShowPW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHidePW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnScan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPW As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents VideoSourcePlayer1 As AForge.Controls.VideoSourcePlayer
    Friend WithEvents llblFPW As LinkLabel
    Friend WithEvents lblFPW As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cbCam As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents pbShowPW As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pbHidePW As Guna.UI2.WinForms.Guna2PictureBox
End Class
