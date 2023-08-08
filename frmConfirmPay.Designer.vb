<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmPay
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnYes = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNo = New Guna.UI2.WinForms.Guna2Button()
        Me.lblAllSer = New System.Windows.Forms.Label()
        Me.lblSubTot = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.pnlTop.Size = New System.Drawing.Size(315, 37)
        Me.pnlTop.TabIndex = 3
        '
        'lblInvoNum
        '
        Me.lblInvoNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoNum.AutoSize = True
        Me.lblInvoNum.Font = New System.Drawing.Font("Dutch801 Rm BT", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoNum.ForeColor = System.Drawing.Color.White
        Me.lblInvoNum.Location = New System.Drawing.Point(3, 3)
        Me.lblInvoNum.Name = "lblInvoNum"
        Me.lblInvoNum.Size = New System.Drawing.Size(160, 30)
        Me.lblInvoNum.TabIndex = 9
        Me.lblInvoNum.Text = "Confirmation"
        Me.lblInvoNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dutch801 Rm BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(50, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Do you really want to add "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Dutch801 Rm BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(85, 100)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(106, 23)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Hwang Yeji"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYes
        '
        Me.btnYes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYes.BorderRadius = 10
        Me.btnYes.CheckedState.Parent = Me.btnYes
        Me.btnYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYes.CustomImages.Parent = Me.btnYes
        Me.btnYes.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnYes.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.White
        Me.btnYes.HoverState.Parent = Me.btnYes
        Me.btnYes.Location = New System.Drawing.Point(68, 139)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.ShadowDecoration.Parent = Me.btnYes
        Me.btnYes.Size = New System.Drawing.Size(87, 36)
        Me.btnYes.TabIndex = 180
        Me.btnYes.Text = "YES"
        '
        'btnNo
        '
        Me.btnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNo.BorderRadius = 10
        Me.btnNo.CheckedState.Parent = Me.btnNo
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.CustomImages.Parent = Me.btnNo
        Me.btnNo.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNo.Font = New System.Drawing.Font("Swis721 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.White
        Me.btnNo.HoverState.Parent = Me.btnNo
        Me.btnNo.Location = New System.Drawing.Point(161, 139)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.ShadowDecoration.Parent = Me.btnNo
        Me.btnNo.Size = New System.Drawing.Size(87, 36)
        Me.btnNo.TabIndex = 179
        Me.btnNo.Text = "NO"
        '
        'lblAllSer
        '
        Me.lblAllSer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAllSer.AutoSize = True
        Me.lblAllSer.Font = New System.Drawing.Font("Dutch801 Rm BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllSer.ForeColor = System.Drawing.Color.White
        Me.lblAllSer.Location = New System.Drawing.Point(4, 40)
        Me.lblAllSer.Name = "lblAllSer"
        Me.lblAllSer.Size = New System.Drawing.Size(54, 23)
        Me.lblAllSer.TabIndex = 181
        Me.lblAllSer.Text = "name"
        Me.lblAllSer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTot
        '
        Me.lblSubTot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubTot.AutoSize = True
        Me.lblSubTot.Font = New System.Drawing.Font("Dutch801 Rm BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTot.ForeColor = System.Drawing.Color.White
        Me.lblSubTot.Location = New System.Drawing.Point(64, 40)
        Me.lblSubTot.Name = "lblSubTot"
        Me.lblSubTot.Size = New System.Drawing.Size(54, 23)
        Me.lblSubTot.TabIndex = 182
        Me.lblSubTot.Text = "name"
        Me.lblSubTot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlTop
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dutch801 Rm BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(200, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 23)
        Me.Label2.TabIndex = 183
        Me.Label2.Text = "?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmConfirmPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(315, 187)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSubTot)
        Me.Controls.Add(Me.lblAllSer)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfirmPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblInvoNum As Label
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnYes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblSubTot As Label
    Friend WithEvents lblAllSer As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label2 As Label
End Class
