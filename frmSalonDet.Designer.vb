<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalonDet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalonDet))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtSalonName = New Guna.UI.WinForms.GunaTextBox()
        Me.txtAddress = New Guna.UI.WinForms.GunaTextBox()
        Me.txtPhone = New Guna.UI.WinForms.GunaTextBox()
        Me.txtEmail = New Guna.UI.WinForms.GunaTextBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.pbLogo = New AForge.Controls.PictureBox()
        Me.pbFav = New AForge.Controls.PictureBox()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.pbAddFav = New System.Windows.Forms.PictureBox()
        Me.pbAddLogo = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlTop.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddFav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblUserType)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1032, 53)
        Me.pnlTop.TabIndex = 2
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
        Me.lblUserType.Size = New System.Drawing.Size(180, 51)
        Me.lblUserType.TabIndex = 9
        Me.lblUserType.Text = "Salon Details"
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monospac821 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(705, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 22)
        Me.Label5.TabIndex = 179
        Me.Label5.Text = "SET FAVICON"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monospac821 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(220, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 22)
        Me.Label4.TabIndex = 178
        Me.Label4.Text = "EMAIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monospac821 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 22)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "PHONE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monospac821 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(220, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "ADDRESS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monospac821 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 22)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "SALON NAME"
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 10
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Monospac821 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(451, 463)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(87, 36)
        Me.btnSave.TabIndex = 186
        Me.btnSave.Text = "Save"
        '
        'btnClose
        '
        Me.btnClose.BorderRadius = 10
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Monospac821 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(637, 463)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(87, 36)
        Me.btnClose.TabIndex = 185
        Me.btnClose.Text = "Cancel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monospac821 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(705, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 22)
        Me.Label6.TabIndex = 188
        Me.Label6.Text = "SET LOGO"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtSalonName
        '
        Me.txtSalonName.BaseColor = System.Drawing.Color.White
        Me.txtSalonName.BorderColor = System.Drawing.Color.Silver
        Me.txtSalonName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSalonName.Enabled = False
        Me.txtSalonName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSalonName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSalonName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSalonName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSalonName.Location = New System.Drawing.Point(224, 118)
        Me.txtSalonName.Name = "txtSalonName"
        Me.txtSalonName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSalonName.SelectedText = ""
        Me.txtSalonName.Size = New System.Drawing.Size(314, 31)
        Me.txtSalonName.TabIndex = 192
        '
        'txtAddress
        '
        Me.txtAddress.BaseColor = System.Drawing.Color.White
        Me.txtAddress.BorderColor = System.Drawing.Color.Silver
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Enabled = False
        Me.txtAddress.FocusedBaseColor = System.Drawing.Color.White
        Me.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.Location = New System.Drawing.Point(224, 194)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(314, 82)
        Me.txtAddress.TabIndex = 193
        '
        'txtPhone
        '
        Me.txtPhone.BaseColor = System.Drawing.Color.White
        Me.txtPhone.BorderColor = System.Drawing.Color.Silver
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.Enabled = False
        Me.txtPhone.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPhone.Location = New System.Drawing.Point(224, 315)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.Size = New System.Drawing.Size(314, 31)
        Me.txtPhone.TabIndex = 194
        '
        'txtEmail
        '
        Me.txtEmail.BaseColor = System.Drawing.Color.White
        Me.txtEmail.BorderColor = System.Drawing.Color.Silver
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Enabled = False
        Me.txtEmail.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.Location = New System.Drawing.Point(224, 401)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(314, 31)
        Me.txtEmail.TabIndex = 195
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(699, 290)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(297, 148)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 189
        Me.pbLogo.TabStop = False
        '
        'pbFav
        '
        Me.pbFav.Image = CType(resources.GetObject("pbFav.Image"), System.Drawing.Image)
        Me.pbFav.Location = New System.Drawing.Point(699, 108)
        Me.pbFav.Name = "pbFav"
        Me.pbFav.Size = New System.Drawing.Size(198, 148)
        Me.pbFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFav.TabIndex = 184
        Me.pbFav.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.BorderRadius = 10
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Monospac821 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(544, 463)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(87, 36)
        Me.btnEdit.TabIndex = 196
        Me.btnEdit.Text = "Edit"
        '
        'pbAddFav
        '
        Me.pbAddFav.BackColor = System.Drawing.Color.Transparent
        Me.pbAddFav.Enabled = False
        Me.pbAddFav.Image = CType(resources.GetObject("pbAddFav.Image"), System.Drawing.Image)
        Me.pbAddFav.Location = New System.Drawing.Point(856, 220)
        Me.pbAddFav.Name = "pbAddFav"
        Me.pbAddFav.Size = New System.Drawing.Size(41, 36)
        Me.pbAddFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAddFav.TabIndex = 197
        Me.pbAddFav.TabStop = False
        '
        'pbAddLogo
        '
        Me.pbAddLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbAddLogo.Enabled = False
        Me.pbAddLogo.Image = CType(resources.GetObject("pbAddLogo.Image"), System.Drawing.Image)
        Me.pbAddLogo.Location = New System.Drawing.Point(955, 402)
        Me.pbAddLogo.Name = "pbAddLogo"
        Me.pbAddLogo.Size = New System.Drawing.Size(41, 36)
        Me.pbAddLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAddLogo.TabIndex = 198
        Me.pbAddLogo.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSalonDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1032, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbAddLogo)
        Me.Controls.Add(Me.pbAddFav)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtSalonName)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pbFav)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Monospac821 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalonDet"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddFav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblUserType As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbFav As AForge.Controls.PictureBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbLogo As AForge.Controls.PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtSalonName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtAddress As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtPhone As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtEmail As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbAddLogo As PictureBox
    Friend WithEvents pbAddFav As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
