<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New Guna.UI.WinForms.GunaLabel()
        Me.lblChange = New Guna.UI.WinForms.GunaLabel()
        Me.btnPay = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "TOTAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "CASH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "CHANGE"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Lime
        Me.lblTotal.Location = New System.Drawing.Point(174, 25)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(64, 20)
        Me.lblTotal.TabIndex = 181
        Me.lblTotal.Text = "₱0.00"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.Lime
        Me.lblChange.Location = New System.Drawing.Point(187, 107)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(53, 20)
        Me.lblChange.TabIndex = 183
        Me.lblChange.Text = "0.00"
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnPay.CheckedState.Parent = Me.btnPay
        Me.btnPay.CustomImages.Parent = Me.btnPay
        Me.btnPay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPay.FillColor = System.Drawing.Color.Empty
        Me.btnPay.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.HoverState.Parent = Me.btnPay
        Me.btnPay.Image = CType(resources.GetObject("btnPay.Image"), System.Drawing.Image)
        Me.btnPay.ImageOffset = New System.Drawing.Point(0, 3)
        Me.btnPay.Location = New System.Drawing.Point(0, 142)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.PressedColor = System.Drawing.Color.Thistle
        Me.btnPay.ShadowDecoration.Parent = Me.btnPay
        Me.btnPay.Size = New System.Drawing.Size(278, 45)
        Me.btnPay.TabIndex = 184
        Me.btnPay.Text = "[ENTER] PAY"
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCash.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.ForeColor = System.Drawing.Color.Lime
        Me.txtCash.Location = New System.Drawing.Point(191, 67)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(112, 20)
        Me.txtCash.TabIndex = 185
        Me.txtCash.Text = "0.00"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Lime
        Me.GunaLabel1.Location = New System.Drawing.Point(174, 67)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(20, 20)
        Me.GunaLabel1.TabIndex = 186
        Me.GunaLabel1.Text = "₱"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Fake Receipt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Lime
        Me.GunaLabel2.Location = New System.Drawing.Point(174, 106)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(20, 20)
        Me.GunaLabel2.TabIndex = 187
        Me.GunaLabel2.Text = "₱"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(278, 187)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblChange As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnPay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCash As TextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
