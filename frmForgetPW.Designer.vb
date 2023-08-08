<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgetPW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForgetPW))
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.PicGmail = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSumbit1 = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox5 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaCircleProgressBar1 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.txtCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlTop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PicGmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BorderRadius = 15
        Me.btnSubmit.CheckedState.Parent = Me.btnSubmit
        Me.btnSubmit.CustomImages.Parent = Me.btnSubmit
        Me.btnSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.Parent = Me.btnSubmit
        Me.btnSubmit.Location = New System.Drawing.Point(115, 194)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Parent = Me.btnSubmit
        Me.btnSubmit.Size = New System.Drawing.Size(114, 32)
        Me.btnSubmit.TabIndex = 145
        Me.btnSubmit.Text = "Submit"
        '
        'PicGmail
        '
        Me.PicGmail.BackColor = System.Drawing.Color.Transparent
        Me.PicGmail.BaseColor = System.Drawing.Color.Black
        Me.PicGmail.Image = CType(resources.GetObject("PicGmail.Image"), System.Drawing.Image)
        Me.PicGmail.Location = New System.Drawing.Point(11, 129)
        Me.PicGmail.Name = "PicGmail"
        Me.PicGmail.Size = New System.Drawing.Size(64, 66)
        Me.PicGmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicGmail.TabIndex = 144
        Me.PicGmail.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.BorderThickness = 3
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(81, 143)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtEmail.PlaceholderText = "Enter Email Address"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(200, 36)
        Me.txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtEmail.TabIndex = 146
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSumbit1)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.GunaCircleProgressBar1)
        Me.Panel2.Controls.Add(Me.txtCode)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 242)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(298, 36)
        Me.Panel2.TabIndex = 147
        Me.Panel2.Visible = False
        '
        'btnSumbit1
        '
        Me.btnSumbit1.BackColor = System.Drawing.Color.Transparent
        Me.btnSumbit1.BorderRadius = 15
        Me.btnSumbit1.CheckedState.Parent = Me.btnSumbit1
        Me.btnSumbit1.CustomImages.Parent = Me.btnSumbit1
        Me.btnSumbit1.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnSumbit1.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumbit1.ForeColor = System.Drawing.Color.Black
        Me.btnSumbit1.HoverState.Parent = Me.btnSumbit1
        Me.btnSumbit1.Location = New System.Drawing.Point(115, 84)
        Me.btnSumbit1.Name = "btnSumbit1"
        Me.btnSumbit1.ShadowDecoration.Parent = Me.btnSumbit1
        Me.btnSumbit1.Size = New System.Drawing.Size(114, 32)
        Me.btnSumbit1.TabIndex = 148
        Me.btnSumbit1.Text = "Submit"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BaseColor = System.Drawing.Color.Black
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(13, 26)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(64, 66)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        '
        'GunaCircleProgressBar1
        '
        Me.GunaCircleProgressBar1.AnimationSpeed = 0.9!
        Me.GunaCircleProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleProgressBar1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleProgressBar1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleProgressBar1.IdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaCircleProgressBar1.IdleOffset = 5
        Me.GunaCircleProgressBar1.IdleThickness = 10
        Me.GunaCircleProgressBar1.Image = Nothing
        Me.GunaCircleProgressBar1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleProgressBar1.Location = New System.Drawing.Point(249, 42)
        Me.GunaCircleProgressBar1.Name = "GunaCircleProgressBar1"
        Me.GunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.PaleTurquoise
        Me.GunaCircleProgressBar1.ProgressOffset = 5
        Me.GunaCircleProgressBar1.ProgressThickness = 14
        Me.GunaCircleProgressBar1.Size = New System.Drawing.Size(31, 31)
        Me.GunaCircleProgressBar1.TabIndex = 30
        Me.GunaCircleProgressBar1.Value = 100
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtCode.BorderThickness = 3
        Me.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCode.DefaultText = ""
        Me.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCode.DisabledState.Parent = Me.txtCode
        Me.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCode.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtCode.FocusedState.Parent = Me.txtCode
        Me.txtCode.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtCode.HoverState.Parent = Me.txtCode
        Me.txtCode.Location = New System.Drawing.Point(83, 42)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtCode.PlaceholderText = "Enter OTP Code"
        Me.txtCode.SelectedText = ""
        Me.txtCode.ShadowDecoration.Parent = Me.txtCode
        Me.txtCode.Size = New System.Drawing.Size(200, 36)
        Me.txtCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCode.TabIndex = 147
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlTop
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.ShadowDecoration.Parent = Me.pnlTop
        Me.pnlTop.Size = New System.Drawing.Size(298, 21)
        Me.pnlTop.TabIndex = 149
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(282, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(12, 15)
        Me.Guna2ControlBox1.TabIndex = 148
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 45)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Reset Password"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmForgetPW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(298, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.PicGmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmForgetPW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forget Password"
        CType(Me.PicGmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PicGmail As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox5 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaCircleProgressBar1 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents txtCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSumbit1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
