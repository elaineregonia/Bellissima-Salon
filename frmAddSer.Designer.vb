<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddSer
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
        Me.ctrlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSerName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cbCategory = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.lblPW = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtEstTime = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtPrice = New Guna.UI.WinForms.GunaLineTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlTop.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.ctrlClose)
        Me.pnlTop.Controls.Add(Me.lbl)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(651, 46)
        Me.pnlTop.TabIndex = 135
        '
        'ctrlClose
        '
        Me.ctrlClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ctrlClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ctrlClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ctrlClose.HoverState.IconColor = System.Drawing.Color.White
        Me.ctrlClose.HoverState.Parent = Me.ctrlClose
        Me.ctrlClose.IconColor = System.Drawing.Color.White
        Me.ctrlClose.Location = New System.Drawing.Point(603, 8)
        Me.ctrlClose.Name = "ctrlClose"
        Me.ctrlClose.ShadowDecoration.Parent = Me.ctrlClose
        Me.ctrlClose.Size = New System.Drawing.Size(45, 29)
        Me.ctrlClose.TabIndex = 137
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
        Me.lbl.Size = New System.Drawing.Size(157, 46)
        Me.lbl.TabIndex = 136
        Me.lbl.Text = "Add Service"
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
        Me.btnClose.Location = New System.Drawing.Point(221, 226)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(87, 36)
        Me.btnClose.TabIndex = 152
        Me.btnClose.Text = "CANCEL"
        '
        'txtSerName
        '
        Me.txtSerName.Animated = True
        Me.txtSerName.BackColor = System.Drawing.Color.White
        Me.txtSerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtSerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSerName.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSerName.Location = New System.Drawing.Point(162, 65)
        Me.txtSerName.Name = "txtSerName"
        Me.txtSerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSerName.SelectedText = ""
        Me.txtSerName.Size = New System.Drawing.Size(226, 26)
        Me.txtSerName.TabIndex = 1
        '
        'cbCategory
        '
        Me.cbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cbCategory.BaseColor = System.Drawing.Color.White
        Me.cbCategory.BorderColor = System.Drawing.Color.Gainsboro
        Me.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbCategory.ForeColor = System.Drawing.Color.Black
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"Haircut and Blowdry", "Hair Coloring", "Straightening & Forming", "Hair & Make-Up", "Hair Treatment", "Nail Care/Waxing/Threading"})
        Me.cbCategory.Location = New System.Drawing.Point(162, 108)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cbCategory.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbCategory.Size = New System.Drawing.Size(226, 26)
        Me.cbCategory.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 14)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "CATEGORY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 14)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "SERVICE NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "PRICE"
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
        Me.btnSave.Location = New System.Drawing.Point(128, 226)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(87, 36)
        Me.btnSave.TabIndex = 176
        Me.btnSave.Text = "SAVE"
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
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPW.Location = New System.Drawing.Point(15, 183)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(109, 14)
        Me.lblPW.TabIndex = 171
        Me.lblPW.Text = "ESTIMATED TIME"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtEstTime
        '
        Me.txtEstTime.Animated = True
        Me.txtEstTime.BackColor = System.Drawing.Color.White
        Me.txtEstTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEstTime.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtEstTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEstTime.LineColor = System.Drawing.Color.Gainsboro
        Me.txtEstTime.Location = New System.Drawing.Point(162, 183)
        Me.txtEstTime.Name = "txtEstTime"
        Me.txtEstTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstTime.SelectedText = ""
        Me.txtEstTime.Size = New System.Drawing.Size(226, 26)
        Me.txtEstTime.TabIndex = 4
        '
        'txtPrice
        '
        Me.txtPrice.Animated = True
        Me.txtPrice.BackColor = System.Drawing.Color.White
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPrice.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPrice.Location = New System.Drawing.Point(162, 140)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.Size = New System.Drawing.Size(226, 26)
        Me.txtPrice.TabIndex = 3
        Me.txtPrice.Text = " "
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmAddSer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 283)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtEstTime)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCategory)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtSerName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Monospac821 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmAddSer"
        Me.Padding = New System.Windows.Forms.Padding(27, 44, 27, 25)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lbl As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSerName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cbCategory As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ctrlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lblPW As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtEstTime As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtPrice As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
