<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResetPW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResetPW))
        Me.txtPW = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtRPW = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaTransfarantPictureBox5 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPW
        '
        Me.txtPW.BorderThickness = 3
        Me.txtPW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPW.DefaultText = ""
        Me.txtPW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPW.DisabledState.Parent = Me.txtPW
        Me.txtPW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtPW.FocusedState.Parent = Me.txtPW
        Me.txtPW.ForeColor = System.Drawing.Color.Black
        Me.txtPW.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtPW.HoverState.Parent = Me.txtPW
        Me.txtPW.Location = New System.Drawing.Point(105, 137)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPW.PlaceholderText = "Enter New Password"
        Me.txtPW.SelectedText = ""
        Me.txtPW.ShadowDecoration.Parent = Me.txtPW
        Me.txtPW.Size = New System.Drawing.Size(200, 36)
        Me.txtPW.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPW.TabIndex = 148
        '
        'btnSubmit
        '
        Me.btnSubmit.BorderRadius = 15
        Me.btnSubmit.CheckedState.Parent = Me.btnSubmit
        Me.btnSubmit.CustomImages.Parent = Me.btnSubmit
        Me.btnSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.Parent = Me.btnSubmit
        Me.btnSubmit.Location = New System.Drawing.Point(123, 230)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Parent = Me.btnSubmit
        Me.btnSubmit.Size = New System.Drawing.Size(114, 32)
        Me.btnSubmit.TabIndex = 147
        Me.btnSubmit.Text = "Submit"
        '
        'txtRPW
        '
        Me.txtRPW.BorderThickness = 3
        Me.txtRPW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRPW.DefaultText = ""
        Me.txtRPW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRPW.DisabledState.Parent = Me.txtRPW
        Me.txtRPW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRPW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtRPW.FocusedState.Parent = Me.txtRPW
        Me.txtRPW.ForeColor = System.Drawing.Color.Black
        Me.txtRPW.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtRPW.HoverState.Parent = Me.txtRPW
        Me.txtRPW.Location = New System.Drawing.Point(105, 179)
        Me.txtRPW.Name = "txtRPW"
        Me.txtRPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRPW.PlaceholderText = "Re-enter New Password"
        Me.txtRPW.SelectedText = ""
        Me.txtRPW.ShadowDecoration.Parent = Me.txtRPW
        Me.txtRPW.Size = New System.Drawing.Size(200, 36)
        Me.txtRPW.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtRPW.TabIndex = 149
        '
        'txtUN
        '
        Me.txtUN.BorderThickness = 3
        Me.txtUN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUN.DefaultText = ""
        Me.txtUN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUN.DisabledState.Parent = Me.txtUN
        Me.txtUN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtUN.FocusedState.Parent = Me.txtUN
        Me.txtUN.ForeColor = System.Drawing.Color.Black
        Me.txtUN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtUN.HoverState.Parent = Me.txtUN
        Me.txtUN.Location = New System.Drawing.Point(105, 95)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUN.PlaceholderText = "Enter Username"
        Me.txtUN.SelectedText = ""
        Me.txtUN.ShadowDecoration.Parent = Me.txtUN
        Me.txtUN.Size = New System.Drawing.Size(200, 36)
        Me.txtUN.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtUN.TabIndex = 150
        '
        'GunaTransfarantPictureBox5
        '
        Me.GunaTransfarantPictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox5.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox5.Image = CType(resources.GetObject("GunaTransfarantPictureBox5.Image"), System.Drawing.Image)
        Me.GunaTransfarantPictureBox5.Location = New System.Drawing.Point(3, 109)
        Me.GunaTransfarantPictureBox5.Name = "GunaTransfarantPictureBox5"
        Me.GunaTransfarantPictureBox5.Size = New System.Drawing.Size(87, 91)
        Me.GunaTransfarantPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox5.TabIndex = 151
        Me.GunaTransfarantPictureBox5.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 45)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Reset Password"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.ShadowDecoration.Parent = Me.pnlTop
        Me.pnlTop.Size = New System.Drawing.Size(330, 20)
        Me.pnlTop.TabIndex = 152
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(314, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(12, 15)
        Me.Guna2ControlBox1.TabIndex = 148
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlTop
        '
        'frmResetPW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(330, 273)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.GunaTransfarantPictureBox5)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.txtRPW)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.btnSubmit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmResetPW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password"
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPW As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtRPW As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaTransfarantPictureBox5 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
