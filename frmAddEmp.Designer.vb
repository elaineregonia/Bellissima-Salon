<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmp
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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.txtUID = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtEmail = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cbGender = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConNum = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.lblUN = New System.Windows.Forms.Label()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.lblUT = New System.Windows.Forms.Label()
        Me.txtUN = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtPW = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cbUT = New Guna.UI.WinForms.GunaComboBox()
        Me.UsertypeDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BellissimaSalonDataSet = New Bellissima_Salon.BellissimaSalonDataSet()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pbQR = New AForge.Controls.PictureBox()
        Me.pbImage = New AForge.Controls.PictureBox()
        Me.txtAddress = New Guna.UI.WinForms.GunaTextBox()
        Me.pbDisplay = New AForge.Controls.PictureBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UsertypeDBTableAdapter = New Bellissima_Salon.BellissimaSalonDataSetTableAdapters.UsertypeDBTableAdapter()
        Me.pnlTop.SuspendLayout()
        CType(Me.UsertypeDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BellissimaSalonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lbl)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(651, 46)
        Me.pnlTop.TabIndex = 135
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
        Me.lbl.Size = New System.Drawing.Size(182, 46)
        Me.lbl.TabIndex = 136
        Me.lbl.Text = "Add Employee"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BorderRadius = 10
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(355, 470)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(87, 36)
        Me.btnClose.TabIndex = 152
        Me.btnClose.Text = "CANCEL"
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
        Me.txtUID.Location = New System.Drawing.Point(162, 65)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUID.SelectedText = ""
        Me.txtUID.Size = New System.Drawing.Size(226, 26)
        Me.txtUID.TabIndex = 157
        '
        'txtName
        '
        Me.txtName.Animated = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName.LineColor = System.Drawing.Color.Gainsboro
        Me.txtName.Location = New System.Drawing.Point(162, 103)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(226, 26)
        Me.txtName.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.LineColor = System.Drawing.Color.Gainsboro
        Me.txtEmail.Location = New System.Drawing.Point(162, 309)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(226, 26)
        Me.txtEmail.TabIndex = 5
        '
        'cbGender
        '
        Me.cbGender.BackColor = System.Drawing.Color.Transparent
        Me.cbGender.BaseColor = System.Drawing.Color.White
        Me.cbGender.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbGender.ForeColor = System.Drawing.Color.Black
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Female", "Male", "Non-Binary"})
        Me.cbGender.Location = New System.Drawing.Point(162, 140)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbGender.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbGender.Size = New System.Drawing.Size(226, 26)
        Me.cbGender.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "USER ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "GENDER "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 14)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "ADDRESS"
        '
        'txtConNum
        '
        Me.txtConNum.Animated = True
        Me.txtConNum.BackColor = System.Drawing.Color.White
        Me.txtConNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConNum.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtConNum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConNum.LineColor = System.Drawing.Color.Gainsboro
        Me.txtConNum.Location = New System.Drawing.Point(162, 272)
        Me.txtConNum.Name = "txtConNum"
        Me.txtConNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConNum.SelectedText = ""
        Me.txtConNum.Size = New System.Drawing.Size(226, 26)
        Me.txtConNum.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 14)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "CONTACT NUMBER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 14)
        Me.Label6.TabIndex = 169
        Me.Label6.Text = "EMAIL"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BorderRadius = 10
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(262, 470)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(87, 36)
        Me.btnSave.TabIndex = 176
        Me.btnSave.Text = "SAVE"
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.BorderRadius = 10
        Me.btnBrowse.CheckedState.Parent = Me.btnBrowse
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.CustomImages.Parent = Me.btnBrowse
        Me.btnBrowse.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnBrowse.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.HoverState.Parent = Me.btnBrowse
        Me.btnBrowse.Location = New System.Drawing.Point(444, 223)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.ShadowDecoration.Parent = Me.btnBrowse
        Me.btnBrowse.Size = New System.Drawing.Size(190, 36)
        Me.btnBrowse.TabIndex = 179
        Me.btnBrowse.Text = "BROWSE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Swis721 Blk BT", 10.25!)
        Me.Label10.Location = New System.Drawing.Point(501, 437)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 180
        Me.Label10.Text = "QR CODE"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlTop
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'lblUN
        '
        Me.lblUN.AutoSize = True
        Me.lblUN.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUN.Location = New System.Drawing.Point(15, 350)
        Me.lblUN.Name = "lblUN"
        Me.lblUN.Size = New System.Drawing.Size(75, 14)
        Me.lblUN.TabIndex = 170
        Me.lblUN.Text = "USERNAME"
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPW.Location = New System.Drawing.Point(15, 384)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(76, 14)
        Me.lblPW.TabIndex = 171
        Me.lblPW.Text = "PASSWORD"
        '
        'lblUT
        '
        Me.lblUT.AutoSize = True
        Me.lblUT.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUT.Location = New System.Drawing.Point(15, 423)
        Me.lblUT.Name = "lblUT"
        Me.lblUT.Size = New System.Drawing.Size(75, 14)
        Me.lblUT.TabIndex = 172
        Me.lblUT.Text = "USER TYPE"
        '
        'txtUN
        '
        Me.txtUN.Animated = True
        Me.txtUN.BackColor = System.Drawing.Color.White
        Me.txtUN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUN.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtUN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUN.LineColor = System.Drawing.Color.Gainsboro
        Me.txtUN.Location = New System.Drawing.Point(162, 344)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUN.SelectedText = ""
        Me.txtUN.Size = New System.Drawing.Size(226, 26)
        Me.txtUN.TabIndex = 6
        '
        'txtPW
        '
        Me.txtPW.Animated = True
        Me.txtPW.BackColor = System.Drawing.Color.White
        Me.txtPW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPW.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtPW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPW.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPW.Location = New System.Drawing.Point(162, 378)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPW.SelectedText = ""
        Me.txtPW.Size = New System.Drawing.Size(226, 26)
        Me.txtPW.TabIndex = 7
        Me.txtPW.UseSystemPasswordChar = True
        '
        'cbUT
        '
        Me.cbUT.BackColor = System.Drawing.Color.Transparent
        Me.cbUT.BaseColor = System.Drawing.Color.White
        Me.cbUT.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbUT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUT.FocusedColor = System.Drawing.Color.Empty
        Me.cbUT.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbUT.ForeColor = System.Drawing.Color.Black
        Me.cbUT.FormattingEnabled = True
        Me.cbUT.Items.AddRange(New Object() {"Admin", "Receptionist", "Hair Stylist", "Makeup Artist"})
        Me.cbUT.Location = New System.Drawing.Point(162, 417)
        Me.cbUT.Name = "cbUT"
        Me.cbUT.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbUT.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbUT.Size = New System.Drawing.Size(226, 26)
        Me.cbUT.TabIndex = 8
        '
        'UsertypeDBBindingSource
        '
        Me.UsertypeDBBindingSource.DataMember = "UsertypeDB"
        Me.UsertypeDBBindingSource.DataSource = Me.BellissimaSalonDataSet
        '
        'BellissimaSalonDataSet
        '
        Me.BellissimaSalonDataSet.DataSetName = "BellissimaSalonDataSet"
        Me.BellissimaSalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pbQR
        '
        Me.pbQR.Image = Nothing
        Me.pbQR.Location = New System.Drawing.Point(444, 283)
        Me.pbQR.Name = "pbQR"
        Me.pbQR.Size = New System.Drawing.Size(190, 151)
        Me.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbQR.TabIndex = 178
        Me.pbQR.TabStop = False
        '
        'pbImage
        '
        Me.pbImage.Image = Global.Bellissima_Salon.My.Resources.Resources.icons8_user_female_skin_type_7_64
        Me.pbImage.Location = New System.Drawing.Point(444, 66)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(190, 151)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 177
        Me.pbImage.TabStop = False
        '
        'txtAddress
        '
        Me.txtAddress.BaseColor = System.Drawing.Color.White
        Me.txtAddress.BorderColor = System.Drawing.Color.Gainsboro
        Me.txtAddress.BorderSize = 3
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.FocusedBaseColor = System.Drawing.Color.White
        Me.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.Location = New System.Drawing.Point(162, 181)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(227, 78)
        Me.txtAddress.TabIndex = 3
        '
        'pbDisplay
        '
        Me.pbDisplay.Image = Global.Bellissima_Salon.My.Resources.Resources.icons8_user_female_skin_type_7_64
        Me.pbDisplay.Location = New System.Drawing.Point(513, 121)
        Me.pbDisplay.Name = "pbDisplay"
        Me.pbDisplay.Size = New System.Drawing.Size(58, 45)
        Me.pbDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDisplay.TabIndex = 183
        Me.pbDisplay.TabStop = False
        Me.pbDisplay.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UsertypeDBTableAdapter
        '
        Me.UsertypeDBTableAdapter.ClearBeforeFill = True
        '
        'frmAddEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(651, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.pbQR)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbUT)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.lblUT)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.lblUN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtConNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pbDisplay)
        Me.Font = New System.Drawing.Font("Monospac821 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmAddEmp"
        Me.Padding = New System.Windows.Forms.Padding(27, 44, 27, 25)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.UsertypeDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BellissimaSalonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lbl As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUID As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtEmail As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cbGender As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConNum As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbImage As AForge.Controls.PictureBox
    Friend WithEvents pbQR As AForge.Controls.PictureBox
    Friend WithEvents btnBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents cbUT As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtPW As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtUN As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblUT As Label
    Friend WithEvents lblPW As Label
    Friend WithEvents lblUN As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtAddress As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents pbDisplay As AForge.Controls.PictureBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BellissimaSalonDataSet As BellissimaSalonDataSet
    Friend WithEvents UsertypeDBBindingSource As BindingSource
    Friend WithEvents UsertypeDBTableAdapter As BellissimaSalonDataSetTableAdapters.UsertypeDBTableAdapter
End Class
