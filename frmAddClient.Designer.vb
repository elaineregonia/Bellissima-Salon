<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddClient
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
        Me.txtName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.lblPW = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtConNum = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtEmail = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtAddress = New Guna.UI.WinForms.GunaTextBox()
        Me.txtFirstIn = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.lbl.Size = New System.Drawing.Size(139, 46)
        Me.lbl.TabIndex = 136
        Me.lbl.Text = "Add Client"
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
        Me.btnClose.Location = New System.Drawing.Point(300, 325)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(87, 36)
        Me.btnClose.TabIndex = 152
        Me.btnClose.Text = "CANCEL"
        '
        'txtName
        '
        Me.txtName.Animated = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName.LineColor = System.Drawing.Color.Gainsboro
        Me.txtName.Location = New System.Drawing.Point(162, 65)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(226, 26)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "ADDRESS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "EMAIL"
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
        Me.btnSave.Location = New System.Drawing.Point(207, 325)
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
        Me.lblPW.Location = New System.Drawing.Point(15, 245)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(121, 14)
        Me.lblPW.TabIndex = 171
        Me.lblPW.Text = "CONTACT NUMBER"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtConNum
        '
        Me.txtConNum.Animated = True
        Me.txtConNum.BackColor = System.Drawing.Color.White
        Me.txtConNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConNum.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtConNum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConNum.LineColor = System.Drawing.Color.Gainsboro
        Me.txtConNum.Location = New System.Drawing.Point(160, 239)
        Me.txtConNum.Name = "txtConNum"
        Me.txtConNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConNum.SelectedText = ""
        Me.txtConNum.Size = New System.Drawing.Size(226, 26)
        Me.txtConNum.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.LineColor = System.Drawing.Color.Gainsboro
        Me.txtEmail.Location = New System.Drawing.Point(160, 196)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(226, 26)
        Me.txtEmail.TabIndex = 3
        Me.txtEmail.Text = " "
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
        Me.txtAddress.Location = New System.Drawing.Point(162, 106)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(226, 78)
        Me.txtAddress.TabIndex = 177
        '
        'txtFirstIn
        '
        Me.txtFirstIn.Animated = True
        Me.txtFirstIn.BackColor = System.Drawing.Color.White
        Me.txtFirstIn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstIn.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtFirstIn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstIn.LineColor = System.Drawing.Color.Gainsboro
        Me.txtFirstIn.Location = New System.Drawing.Point(160, 281)
        Me.txtFirstIn.Name = "txtFirstIn"
        Me.txtFirstIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstIn.SelectedText = ""
        Me.txtFirstIn.Size = New System.Drawing.Size(226, 26)
        Me.txtFirstIn.TabIndex = 178
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 14)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "FIRST-IN"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmAddClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 380)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtFirstIn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtConNum)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Monospac821 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmAddClient"
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
    Friend WithEvents txtName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ctrlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lblPW As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtConNum As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtEmail As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtAddress As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtFirstIn As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
