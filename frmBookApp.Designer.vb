<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookApp
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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbStra = New Guna.UI.WinForms.GunaComboBox()
        Me.AppointmentDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BellissimaSalonDataSet = New Bellissima_Salon.BellissimaSalonDataSet()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.cbEmp = New Guna.UI.WinForms.GunaComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtTime = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.cbClient = New Guna.UI.WinForms.GunaComboBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AppointmentDBTableAdapter = New Bellissima_Salon.BellissimaSalonDataSetTableAdapters.AppointmentDBTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbBlow = New Guna.UI.WinForms.GunaComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbColor = New Guna.UI.WinForms.GunaComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbHMU = New Guna.UI.WinForms.GunaComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbTre = New Guna.UI.WinForms.GunaComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbNaiWax = New Guna.UI.WinForms.GunaComboBox()
        Me.cbBlowY = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cbColorY = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cbStraY = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cbNaiWaxY = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cbTreY = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cbHMUY = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.lblBlowPri = New Guna.UI.WinForms.GunaLabel()
        Me.lblColorPri = New Guna.UI.WinForms.GunaLabel()
        Me.lblStraPri = New Guna.UI.WinForms.GunaLabel()
        Me.lblHMUPri = New Guna.UI.WinForms.GunaLabel()
        Me.lblTreatPri = New Guna.UI.WinForms.GunaLabel()
        Me.lblNaiWaxPri = New Guna.UI.WinForms.GunaLabel()
        Me.pnlTop.SuspendLayout()
        CType(Me.AppointmentDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BellissimaSalonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lbl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(432, 46)
        Me.pnlTop.TabIndex = 136
        '
        'lbl
        '
        Me.lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Vegan Style Personal Use", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.White
        Me.lbl.Location = New System.Drawing.Point(4, 2)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(219, 46)
        Me.lbl.TabIndex = 136
        Me.lbl.Text = "Book Appointment"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "NAME"
        '
        'cbStra
        '
        Me.cbStra.BackColor = System.Drawing.Color.Transparent
        Me.cbStra.BaseColor = System.Drawing.Color.White
        Me.cbStra.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbStra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentDBBindingSource, "SERVICE", True))
        Me.cbStra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbStra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStra.Enabled = False
        Me.cbStra.FocusedColor = System.Drawing.Color.Empty
        Me.cbStra.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbStra.ForeColor = System.Drawing.Color.Black
        Me.cbStra.FormattingEnabled = True
        Me.cbStra.Location = New System.Drawing.Point(171, 319)
        Me.cbStra.Name = "cbStra"
        Me.cbStra.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbStra.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbStra.Size = New System.Drawing.Size(205, 26)
        Me.cbStra.TabIndex = 166
        '
        'AppointmentDBBindingSource
        '
        Me.AppointmentDBBindingSource.DataMember = "AppointmentDB"
        Me.AppointmentDBBindingSource.DataSource = Me.BellissimaSalonDataSet
        '
        'BellissimaSalonDataSet
        '
        Me.BellissimaSalonDataSet.DataSetName = "BellissimaSalonDataSet"
        Me.BellissimaSalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp.Location = New System.Drawing.Point(32, 140)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(73, 14)
        Me.lblEmp.TabIndex = 170
        Me.lblEmp.Text = "EMPLOYEE"
        '
        'cbEmp
        '
        Me.cbEmp.BackColor = System.Drawing.Color.Transparent
        Me.cbEmp.BaseColor = System.Drawing.Color.White
        Me.cbEmp.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentDBBindingSource, "EMPLOYEE", True))
        Me.cbEmp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmp.FocusedColor = System.Drawing.Color.Empty
        Me.cbEmp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbEmp.ForeColor = System.Drawing.Color.Black
        Me.cbEmp.FormattingEnabled = True
        Me.cbEmp.Location = New System.Drawing.Point(170, 134)
        Me.cbEmp.Name = "cbEmp"
        Me.cbEmp.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbEmp.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbEmp.Size = New System.Drawing.Size(226, 26)
        Me.cbEmp.TabIndex = 169
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(32, 175)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 14)
        Me.lblDate.TabIndex = 171
        Me.lblDate.Text = "DATE"
        '
        'dpDate
        '
        Me.dpDate.Animated = True
        Me.dpDate.CheckedState.Parent = Me.dpDate
        Me.dpDate.FillColor = System.Drawing.Color.Gainsboro
        Me.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dpDate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.dpDate.HoverState.Parent = Me.dpDate
        Me.dpDate.Location = New System.Drawing.Point(170, 170)
        Me.dpDate.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.dpDate.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dpDate.Name = "dpDate"
        Me.dpDate.ShadowDecoration.Parent = Me.dpDate
        Me.dpDate.Size = New System.Drawing.Size(226, 25)
        Me.dpDate.TabIndex = 172
        Me.dpDate.Value = New Date(2021, 3, 20, 22, 38, 14, 500)
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(32, 213)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(36, 14)
        Me.lblTime.TabIndex = 174
        Me.lblTime.Text = "TIME"
        '
        'txtTime
        '
        Me.txtTime.Animated = True
        Me.txtTime.BackColor = System.Drawing.Color.White
        Me.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTime.LineColor = System.Drawing.Color.Gainsboro
        Me.txtTime.Location = New System.Drawing.Point(170, 207)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTime.SelectedText = ""
        Me.txtTime.Size = New System.Drawing.Size(226, 26)
        Me.txtTime.TabIndex = 173
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
        Me.btnSave.Location = New System.Drawing.Point(216, 473)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(87, 36)
        Me.btnSave.TabIndex = 178
        Me.btnSave.Text = "SAVE"
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
        Me.btnClose.Location = New System.Drawing.Point(309, 473)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(87, 36)
        Me.btnClose.TabIndex = 177
        Me.btnClose.Text = "CANCEL"
        '
        'cbClient
        '
        Me.cbClient.BackColor = System.Drawing.Color.Transparent
        Me.cbClient.BaseColor = System.Drawing.Color.White
        Me.cbClient.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbClient.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentDBBindingSource, "CLIENT", True))
        Me.cbClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClient.FocusedColor = System.Drawing.Color.Empty
        Me.cbClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbClient.ForeColor = System.Drawing.Color.Black
        Me.cbClient.FormattingEnabled = True
        Me.cbClient.Items.AddRange(New Object() {"REGISTERED", "WALK-IN"})
        Me.cbClient.Location = New System.Drawing.Point(170, 65)
        Me.cbClient.Name = "cbClient"
        Me.cbClient.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbClient.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbClient.Size = New System.Drawing.Size(226, 26)
        Me.cbClient.TabIndex = 179
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlTop
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AppointmentDBTableAdapter
        '
        Me.AppointmentDBTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 14)
        Me.Label2.TabIndex = 182
        Me.Label2.Text = "CLIENT TYPE"
        '
        'txtName
        '
        Me.txtName.BorderColor = System.Drawing.Color.Gainsboro
        Me.txtName.BorderThickness = 3
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.Parent = Me.txtName
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtName.FocusedState.Parent = Me.txtName
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.Gainsboro
        Me.txtName.HoverState.Parent = Me.txtName
        Me.txtName.Location = New System.Drawing.Point(170, 97)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Parent = Me.txtName
        Me.txtName.Size = New System.Drawing.Size(226, 26)
        Me.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtName.TabIndex = 183
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 28)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "HAIRCUT AND " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   BLOWDRY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 14)
        Me.Label4.TabIndex = 185
        Me.Label4.Text = "HAIR COLORING"
        '
        'cbBlow
        '
        Me.cbBlow.BackColor = System.Drawing.Color.Transparent
        Me.cbBlow.BaseColor = System.Drawing.Color.White
        Me.cbBlow.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbBlow.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentDBBindingSource, "SERVICE", True))
        Me.cbBlow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbBlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBlow.Enabled = False
        Me.cbBlow.FocusedColor = System.Drawing.Color.Empty
        Me.cbBlow.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbBlow.ForeColor = System.Drawing.Color.Black
        Me.cbBlow.FormattingEnabled = True
        Me.cbBlow.Location = New System.Drawing.Point(171, 248)
        Me.cbBlow.Name = "cbBlow"
        Me.cbBlow.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbBlow.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbBlow.Size = New System.Drawing.Size(205, 26)
        Me.cbBlow.TabIndex = 187
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 28)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "STRAIGHTENING " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " AND FORMING"
        '
        'cbColor
        '
        Me.cbColor.BackColor = System.Drawing.Color.Transparent
        Me.cbColor.BaseColor = System.Drawing.Color.White
        Me.cbColor.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbColor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentDBBindingSource, "SERVICE", True))
        Me.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColor.Enabled = False
        Me.cbColor.FocusedColor = System.Drawing.Color.Empty
        Me.cbColor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbColor.ForeColor = System.Drawing.Color.Black
        Me.cbColor.FormattingEnabled = True
        Me.cbColor.Location = New System.Drawing.Point(171, 283)
        Me.cbColor.Name = "cbColor"
        Me.cbColor.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbColor.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbColor.Size = New System.Drawing.Size(205, 26)
        Me.cbColor.TabIndex = 198
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 14)
        Me.Label5.TabIndex = 203
        Me.Label5.Text = "HAIR AND MAKE-UP"
        '
        'cbHMU
        '
        Me.cbHMU.BackColor = System.Drawing.Color.Transparent
        Me.cbHMU.BaseColor = System.Drawing.Color.White
        Me.cbHMU.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbHMU.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentDBBindingSource, "SERVICE", True))
        Me.cbHMU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbHMU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHMU.Enabled = False
        Me.cbHMU.FocusedColor = System.Drawing.Color.Empty
        Me.cbHMU.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbHMU.ForeColor = System.Drawing.Color.Black
        Me.cbHMU.FormattingEnabled = True
        Me.cbHMU.Location = New System.Drawing.Point(171, 354)
        Me.cbHMU.Name = "cbHMU"
        Me.cbHMU.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbHMU.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbHMU.Size = New System.Drawing.Size(205, 26)
        Me.cbHMU.TabIndex = 202
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 395)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 14)
        Me.Label7.TabIndex = 207
        Me.Label7.Text = "HAIR TREATMENT"
        '
        'cbTre
        '
        Me.cbTre.BackColor = System.Drawing.Color.Transparent
        Me.cbTre.BaseColor = System.Drawing.Color.White
        Me.cbTre.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbTre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentDBBindingSource, "SERVICE", True))
        Me.cbTre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTre.Enabled = False
        Me.cbTre.FocusedColor = System.Drawing.Color.Empty
        Me.cbTre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbTre.ForeColor = System.Drawing.Color.Black
        Me.cbTre.FormattingEnabled = True
        Me.cbTre.Location = New System.Drawing.Point(171, 389)
        Me.cbTre.Name = "cbTre"
        Me.cbTre.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbTre.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbTre.Size = New System.Drawing.Size(205, 26)
        Me.cbTre.TabIndex = 206
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 423)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 28)
        Me.Label8.TabIndex = 211
        Me.Label8.Text = "NAIL CARE/WAXING " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      THREADING" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cbNaiWax
        '
        Me.cbNaiWax.BackColor = System.Drawing.Color.Transparent
        Me.cbNaiWax.BaseColor = System.Drawing.Color.White
        Me.cbNaiWax.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbNaiWax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentDBBindingSource, "SERVICE", True))
        Me.cbNaiWax.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbNaiWax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNaiWax.Enabled = False
        Me.cbNaiWax.FocusedColor = System.Drawing.Color.Empty
        Me.cbNaiWax.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbNaiWax.ForeColor = System.Drawing.Color.Black
        Me.cbNaiWax.FormattingEnabled = True
        Me.cbNaiWax.Location = New System.Drawing.Point(171, 424)
        Me.cbNaiWax.Name = "cbNaiWax"
        Me.cbNaiWax.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbNaiWax.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbNaiWax.Size = New System.Drawing.Size(205, 26)
        Me.cbNaiWax.TabIndex = 210
        '
        'cbBlowY
        '
        Me.cbBlowY.AutoSize = True
        Me.cbBlowY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbBlowY.CheckedState.BorderRadius = 2
        Me.cbBlowY.CheckedState.BorderThickness = 0
        Me.cbBlowY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbBlowY.Location = New System.Drawing.Point(150, 251)
        Me.cbBlowY.Name = "cbBlowY"
        Me.cbBlowY.Size = New System.Drawing.Size(15, 14)
        Me.cbBlowY.TabIndex = 214
        Me.cbBlowY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbBlowY.UncheckedState.BorderRadius = 2
        Me.cbBlowY.UncheckedState.BorderThickness = 0
        Me.cbBlowY.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbBlowY.UseVisualStyleBackColor = True
        '
        'cbColorY
        '
        Me.cbColorY.AutoSize = True
        Me.cbColorY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbColorY.CheckedState.BorderRadius = 2
        Me.cbColorY.CheckedState.BorderThickness = 0
        Me.cbColorY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbColorY.Location = New System.Drawing.Point(150, 288)
        Me.cbColorY.Name = "cbColorY"
        Me.cbColorY.Size = New System.Drawing.Size(15, 14)
        Me.cbColorY.TabIndex = 216
        Me.cbColorY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbColorY.UncheckedState.BorderRadius = 2
        Me.cbColorY.UncheckedState.BorderThickness = 0
        Me.cbColorY.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbColorY.UseVisualStyleBackColor = True
        '
        'cbStraY
        '
        Me.cbStraY.AutoSize = True
        Me.cbStraY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbStraY.CheckedState.BorderRadius = 2
        Me.cbStraY.CheckedState.BorderThickness = 0
        Me.cbStraY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbStraY.Location = New System.Drawing.Point(150, 324)
        Me.cbStraY.Name = "cbStraY"
        Me.cbStraY.Size = New System.Drawing.Size(15, 14)
        Me.cbStraY.TabIndex = 218
        Me.cbStraY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbStraY.UncheckedState.BorderRadius = 2
        Me.cbStraY.UncheckedState.BorderThickness = 0
        Me.cbStraY.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbStraY.UseVisualStyleBackColor = True
        '
        'cbNaiWaxY
        '
        Me.cbNaiWaxY.AutoSize = True
        Me.cbNaiWaxY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbNaiWaxY.CheckedState.BorderRadius = 2
        Me.cbNaiWaxY.CheckedState.BorderThickness = 0
        Me.cbNaiWaxY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbNaiWaxY.Location = New System.Drawing.Point(150, 430)
        Me.cbNaiWaxY.Name = "cbNaiWaxY"
        Me.cbNaiWaxY.Size = New System.Drawing.Size(15, 14)
        Me.cbNaiWaxY.TabIndex = 221
        Me.cbNaiWaxY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbNaiWaxY.UncheckedState.BorderRadius = 2
        Me.cbNaiWaxY.UncheckedState.BorderThickness = 0
        Me.cbNaiWaxY.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbNaiWaxY.UseVisualStyleBackColor = True
        '
        'cbTreY
        '
        Me.cbTreY.AutoSize = True
        Me.cbTreY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbTreY.CheckedState.BorderRadius = 2
        Me.cbTreY.CheckedState.BorderThickness = 0
        Me.cbTreY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbTreY.Location = New System.Drawing.Point(150, 394)
        Me.cbTreY.Name = "cbTreY"
        Me.cbTreY.Size = New System.Drawing.Size(15, 14)
        Me.cbTreY.TabIndex = 220
        Me.cbTreY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbTreY.UncheckedState.BorderRadius = 2
        Me.cbTreY.UncheckedState.BorderThickness = 0
        Me.cbTreY.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbTreY.UseVisualStyleBackColor = True
        '
        'cbHMUY
        '
        Me.cbHMUY.AutoSize = True
        Me.cbHMUY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbHMUY.CheckedState.BorderRadius = 2
        Me.cbHMUY.CheckedState.BorderThickness = 0
        Me.cbHMUY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbHMUY.Location = New System.Drawing.Point(150, 357)
        Me.cbHMUY.Name = "cbHMUY"
        Me.cbHMUY.Size = New System.Drawing.Size(15, 14)
        Me.cbHMUY.TabIndex = 219
        Me.cbHMUY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbHMUY.UncheckedState.BorderRadius = 2
        Me.cbHMUY.UncheckedState.BorderThickness = 0
        Me.cbHMUY.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbHMUY.UseVisualStyleBackColor = True
        '
        'lblBlowPri
        '
        Me.lblBlowPri.AutoSize = True
        Me.lblBlowPri.Font = New System.Drawing.Font("Fake Receipt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlowPri.Location = New System.Drawing.Point(379, 253)
        Me.lblBlowPri.Name = "lblBlowPri"
        Me.lblBlowPri.Size = New System.Drawing.Size(39, 15)
        Me.lblBlowPri.TabIndex = 222
        Me.lblBlowPri.Text = "0.00"
        '
        'lblColorPri
        '
        Me.lblColorPri.AutoSize = True
        Me.lblColorPri.Font = New System.Drawing.Font("Fake Receipt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColorPri.Location = New System.Drawing.Point(378, 288)
        Me.lblColorPri.Name = "lblColorPri"
        Me.lblColorPri.Size = New System.Drawing.Size(39, 15)
        Me.lblColorPri.TabIndex = 223
        Me.lblColorPri.Text = "0.00"
        '
        'lblStraPri
        '
        Me.lblStraPri.AutoSize = True
        Me.lblStraPri.Font = New System.Drawing.Font("Fake Receipt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraPri.Location = New System.Drawing.Point(378, 324)
        Me.lblStraPri.Name = "lblStraPri"
        Me.lblStraPri.Size = New System.Drawing.Size(39, 15)
        Me.lblStraPri.TabIndex = 224
        Me.lblStraPri.Text = "0.00"
        '
        'lblHMUPri
        '
        Me.lblHMUPri.AutoSize = True
        Me.lblHMUPri.Font = New System.Drawing.Font("Fake Receipt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHMUPri.Location = New System.Drawing.Point(378, 359)
        Me.lblHMUPri.Name = "lblHMUPri"
        Me.lblHMUPri.Size = New System.Drawing.Size(39, 15)
        Me.lblHMUPri.TabIndex = 225
        Me.lblHMUPri.Text = "0.00"
        '
        'lblTreatPri
        '
        Me.lblTreatPri.AutoSize = True
        Me.lblTreatPri.Font = New System.Drawing.Font("Fake Receipt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreatPri.Location = New System.Drawing.Point(378, 395)
        Me.lblTreatPri.Name = "lblTreatPri"
        Me.lblTreatPri.Size = New System.Drawing.Size(39, 15)
        Me.lblTreatPri.TabIndex = 226
        Me.lblTreatPri.Text = "0.00"
        '
        'lblNaiWaxPri
        '
        Me.lblNaiWaxPri.AutoSize = True
        Me.lblNaiWaxPri.Font = New System.Drawing.Font("Fake Receipt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaiWaxPri.Location = New System.Drawing.Point(378, 429)
        Me.lblNaiWaxPri.Name = "lblNaiWaxPri"
        Me.lblNaiWaxPri.Size = New System.Drawing.Size(39, 15)
        Me.lblNaiWaxPri.TabIndex = 227
        Me.lblNaiWaxPri.Text = "0.00"
        '
        'frmBookApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(432, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNaiWaxPri)
        Me.Controls.Add(Me.lblTreatPri)
        Me.Controls.Add(Me.lblHMUPri)
        Me.Controls.Add(Me.lblStraPri)
        Me.Controls.Add(Me.lblColorPri)
        Me.Controls.Add(Me.lblBlowPri)
        Me.Controls.Add(Me.cbNaiWaxY)
        Me.Controls.Add(Me.cbTreY)
        Me.Controls.Add(Me.cbHMUY)
        Me.Controls.Add(Me.cbStraY)
        Me.Controls.Add(Me.cbColorY)
        Me.Controls.Add(Me.cbBlowY)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbNaiWax)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbTre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbHMU)
        Me.Controls.Add(Me.cbColor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbBlow)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbClient)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.dpDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.cbEmp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbStra)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmBookApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBookApp"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.AppointmentDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BellissimaSalonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lbl As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lblEmp As Label
    Friend WithEvents cbEmp As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbStra As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents lblTime As Label
    Friend WithEvents txtTime As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents dpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbClient As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BellissimaSalonDataSet As BellissimaSalonDataSet
    Friend WithEvents AppointmentDBBindingSource As BindingSource
    Friend WithEvents AppointmentDBTableAdapter As BellissimaSalonDataSetTableAdapters.AppointmentDBTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbBlow As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbHMU As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cbColor As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbTre As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbNaiWax As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cbBlowY As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cbStraY As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cbColorY As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cbNaiWaxY As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cbHMUY As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cbTreY As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents lblStraPri As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblColorPri As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblBlowPri As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblNaiWaxPri As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblTreatPri As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblHMUPri As Guna.UI.WinForms.GunaLabel
End Class
