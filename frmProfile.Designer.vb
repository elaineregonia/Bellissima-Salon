<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfile))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbQR = New AForge.Controls.PictureBox()
        Me.pbImage = New AForge.Controls.PictureBox()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.lblUN = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtAddress = New Guna.UI.WinForms.GunaTextBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtUN = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtConNum = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cbGender = New Guna.UI.WinForms.GunaComboBox()
        Me.txtEmail = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtUID = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.tooltip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.lblCE = New System.Windows.Forms.Label()
        Me.pbShowPW = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbHidePW = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtPW = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.pbQR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.pbShowPW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHidePW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Swis721 Blk BT", 10.25!)
        Me.Label10.Location = New System.Drawing.Point(111, 471)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 192
        Me.Label10.Text = "QR CODE"
        '
        'pbQR
        '
        Me.pbQR.Image = Nothing
        Me.pbQR.Location = New System.Drawing.Point(60, 312)
        Me.pbQR.Name = "pbQR"
        Me.pbQR.Size = New System.Drawing.Size(190, 151)
        Me.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbQR.TabIndex = 191
        Me.pbQR.TabStop = False
        '
        'pbImage
        '
        Me.pbImage.Image = Global.Bellissima_Salon.My.Resources.Resources.icons8_user_female_skin_type_7_64
        Me.pbImage.Location = New System.Drawing.Point(60, 102)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(190, 151)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 190
        Me.pbImage.TabStop = False
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPW.Location = New System.Drawing.Point(312, 393)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(76, 14)
        Me.lblPW.TabIndex = 188
        Me.lblPW.Text = "PASSWORD"
        '
        'lblUN
        '
        Me.lblUN.AutoSize = True
        Me.lblUN.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUN.Location = New System.Drawing.Point(312, 361)
        Me.lblUN.Name = "lblUN"
        Me.lblUN.Size = New System.Drawing.Size(75, 14)
        Me.lblUN.TabIndex = 187
        Me.lblUN.Text = "USERNAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 14)
        Me.Label6.TabIndex = 186
        Me.Label6.Text = "EMAIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 14)
        Me.Label5.TabIndex = 185
        Me.Label5.Text = "CONTACT NUMBER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 14)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "ADDRESS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "GENDER "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 182
        Me.Label2.Text = "USER ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "NAME"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lbl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(820, 46)
        Me.pnlTop.TabIndex = 193
        '
        'lbl
        '
        Me.lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Vegan Style Personal Use", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.White
        Me.lbl.Location = New System.Drawing.Point(5, -1)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(133, 46)
        Me.lbl.TabIndex = 136
        Me.lbl.Text = "My Profile"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAddress
        '
        Me.txtAddress.BaseColor = System.Drawing.Color.White
        Me.txtAddress.BorderColor = System.Drawing.Color.Gainsboro
        Me.txtAddress.BorderSize = 3
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Enabled = False
        Me.txtAddress.FocusedBaseColor = System.Drawing.Color.White
        Me.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.Location = New System.Drawing.Point(470, 206)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(227, 78)
        Me.txtAddress.TabIndex = 196
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 10
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(516, 451)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(87, 36)
        Me.btnSave.TabIndex = 204
        Me.btnSave.Text = "SAVE"
        '
        'txtUN
        '
        Me.txtUN.Animated = True
        Me.txtUN.BackColor = System.Drawing.Color.White
        Me.txtUN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUN.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtUN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUN.LineColor = System.Drawing.Color.Gainsboro
        Me.txtUN.Location = New System.Drawing.Point(470, 355)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUN.SelectedText = ""
        Me.txtUN.Size = New System.Drawing.Size(226, 26)
        Me.txtUN.TabIndex = 1
        '
        'txtConNum
        '
        Me.txtConNum.Animated = True
        Me.txtConNum.BackColor = System.Drawing.Color.White
        Me.txtConNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConNum.Enabled = False
        Me.txtConNum.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtConNum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConNum.LineColor = System.Drawing.Color.Gainsboro
        Me.txtConNum.Location = New System.Drawing.Point(470, 291)
        Me.txtConNum.Name = "txtConNum"
        Me.txtConNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConNum.SelectedText = ""
        Me.txtConNum.Size = New System.Drawing.Size(226, 26)
        Me.txtConNum.TabIndex = 197
        '
        'cbGender
        '
        Me.cbGender.BackColor = System.Drawing.Color.Transparent
        Me.cbGender.BaseColor = System.Drawing.Color.White
        Me.cbGender.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.Enabled = False
        Me.cbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbGender.ForeColor = System.Drawing.Color.Black
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Female", "Male", "Non-Binary"})
        Me.cbGender.Location = New System.Drawing.Point(470, 165)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbGender.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbGender.Size = New System.Drawing.Size(226, 26)
        Me.cbGender.TabIndex = 195
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Enabled = False
        Me.txtEmail.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.LineColor = System.Drawing.Color.Gainsboro
        Me.txtEmail.Location = New System.Drawing.Point(471, 323)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(226, 26)
        Me.txtEmail.TabIndex = 198
        '
        'txtName
        '
        Me.txtName.Animated = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Enabled = False
        Me.txtName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName.LineColor = System.Drawing.Color.Gainsboro
        Me.txtName.Location = New System.Drawing.Point(470, 128)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(226, 26)
        Me.txtName.TabIndex = 194
        '
        'txtUID
        '
        Me.txtUID.Animated = True
        Me.txtUID.BackColor = System.Drawing.Color.White
        Me.txtUID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUID.Enabled = False
        Me.txtUID.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtUID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUID.LineColor = System.Drawing.Color.Gainsboro
        Me.txtUID.Location = New System.Drawing.Point(470, 96)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUID.SelectedText = ""
        Me.txtUID.Size = New System.Drawing.Size(226, 26)
        Me.txtUID.TabIndex = 203
        '
        'btnClose
        '
        Me.btnClose.BorderRadius = 10
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(609, 451)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(87, 36)
        Me.btnClose.TabIndex = 202
        Me.btnClose.Text = "CANCEL"
        '
        'tooltip
        '
        Me.tooltip.AllowLinksHandling = True
        Me.tooltip.ForeColor = System.Drawing.Color.Black
        Me.tooltip.MaximumSize = New System.Drawing.Size(0, 0)
        Me.tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'lblCE
        '
        Me.lblCE.AutoSize = True
        Me.lblCE.Font = New System.Drawing.Font("Fake Receipt", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCE.Location = New System.Drawing.Point(272, 451)
        Me.lblCE.Name = "lblCE"
        Me.lblCE.Size = New System.Drawing.Size(170, 16)
        Me.lblCE.TabIndex = 205
        Me.lblCE.Text = " Why can't I edit?"
        '
        'pbShowPW
        '
        Me.pbShowPW.BackColor = System.Drawing.Color.Transparent
        Me.pbShowPW.Image = CType(resources.GetObject("pbShowPW.Image"), System.Drawing.Image)
        Me.pbShowPW.Location = New System.Drawing.Point(667, 391)
        Me.pbShowPW.Name = "pbShowPW"
        Me.pbShowPW.ShadowDecoration.Parent = Me.pbShowPW
        Me.pbShowPW.Size = New System.Drawing.Size(29, 16)
        Me.pbShowPW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbShowPW.TabIndex = 206
        Me.pbShowPW.TabStop = False
        Me.pbShowPW.UseTransparentBackground = True
        '
        'pbHidePW
        '
        Me.pbHidePW.BackColor = System.Drawing.Color.Transparent
        Me.pbHidePW.Image = CType(resources.GetObject("pbHidePW.Image"), System.Drawing.Image)
        Me.pbHidePW.Location = New System.Drawing.Point(667, 391)
        Me.pbHidePW.Name = "pbHidePW"
        Me.pbHidePW.ShadowDecoration.Parent = Me.pbHidePW
        Me.pbHidePW.Size = New System.Drawing.Size(29, 16)
        Me.pbHidePW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbHidePW.TabIndex = 207
        Me.pbHidePW.TabStop = False
        Me.pbHidePW.UseTransparentBackground = True
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
        Me.txtPW.Location = New System.Drawing.Point(470, 387)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPW.PlaceholderText = ""
        Me.txtPW.SelectedText = ""
        Me.txtPW.ShadowDecoration.Parent = Me.txtPW
        Me.txtPW.Size = New System.Drawing.Size(226, 26)
        Me.txtPW.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPW.TabIndex = 208
        Me.txtPW.UseSystemPasswordChar = True
        '
        'frmProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 589)
        Me.Controls.Add(Me.pbShowPW)
        Me.Controls.Add(Me.pbHidePW)
        Me.Controls.Add(Me.lblCE)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.txtConNum)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pbQR)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.lblUN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPW)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProfile"
        Me.Text = "frmProfile"
        CType(Me.pbQR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.pbShowPW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHidePW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents pbQR As AForge.Controls.PictureBox
    Friend WithEvents pbImage As AForge.Controls.PictureBox
    Friend WithEvents lblPW As Label
    Friend WithEvents lblUN As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lbl As Label
    Friend WithEvents txtAddress As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUN As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtConNum As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cbGender As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtEmail As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtUID As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tooltip As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents lblCE As Label
    Friend WithEvents pbShowPW As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pbHidePW As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtPW As Guna.UI2.WinForms.Guna2TextBox
End Class
