<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiscount
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
        Me.lblInvoNum = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.cbDis = New Guna.UI.WinForms.GunaComboBox()
        Me.lblDis = New Guna.UI.WinForms.GunaLabel()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblInvoNum)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(382, 37)
        Me.pnlTop.TabIndex = 3
        '
        'lblInvoNum
        '
        Me.lblInvoNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoNum.AutoSize = True
        Me.lblInvoNum.Font = New System.Drawing.Font("Vegan Style Personal Use", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoNum.ForeColor = System.Drawing.Color.White
        Me.lblInvoNum.Location = New System.Drawing.Point(2, -5)
        Me.lblInvoNum.Name = "lblInvoNum"
        Me.lblInvoNum.Size = New System.Drawing.Size(107, 46)
        Me.lblInvoNum.TabIndex = 9
        Me.lblInvoNum.Text = "Discount"
        Me.lblInvoNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 14)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "DESCRIPTION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 14)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "DISCOUNT"
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
        Me.btnSave.Location = New System.Drawing.Point(146, 142)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(74, 25)
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
        Me.btnClose.Location = New System.Drawing.Point(239, 142)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(74, 25)
        Me.btnClose.TabIndex = 177
        Me.btnClose.Text = "CANCEL"
        '
        'cbDis
        '
        Me.cbDis.BackColor = System.Drawing.Color.Transparent
        Me.cbDis.BaseColor = System.Drawing.Color.White
        Me.cbDis.BorderColor = System.Drawing.Color.Silver
        Me.cbDis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDis.FocusedColor = System.Drawing.Color.Empty
        Me.cbDis.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDis.ForeColor = System.Drawing.Color.Black
        Me.cbDis.FormattingEnabled = True
        Me.cbDis.Items.AddRange(New Object() {"NONE", "PWD", "SENIOR"})
        Me.cbDis.Location = New System.Drawing.Point(146, 55)
        Me.cbDis.Name = "cbDis"
        Me.cbDis.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbDis.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbDis.Size = New System.Drawing.Size(199, 24)
        Me.cbDis.TabIndex = 179
        '
        'lblDis
        '
        Me.lblDis.AutoSize = True
        Me.lblDis.Font = New System.Drawing.Font("Fake Receipt", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDis.Location = New System.Drawing.Point(143, 107)
        Me.lblDis.Name = "lblDis"
        Me.lblDis.Size = New System.Drawing.Size(26, 16)
        Me.lblDis.TabIndex = 180
        Me.lblDis.Text = "0%"
        '
        'frmDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(382, 179)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDis)
        Me.Controls.Add(Me.cbDis)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblInvoNum As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDis As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbDis As Guna.UI.WinForms.GunaComboBox
End Class
