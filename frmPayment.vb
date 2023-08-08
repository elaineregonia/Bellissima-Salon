Imports System.Data.OleDb
Public Class frmPayment
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        txtCash.Select()
    End Sub
#Region "Methods"

    Sub settlePay()
        If Val(txtCash.Text) < 0 Then
            MsgBox("Insufficient amount!", vbCritical, "Invalid Transaction")
            txtCash.Clear()
            txtCash.Focus()
            Return
        End If
        Try
            con.Open()
            cmd = Nothing
            cmd = New OleDbCommand("UPDATE PaymentDB SET SUBTOT=@SUBTOT, ATOTAL=@ATOTAL, VAT=@VAT, DISCOUNT=@DISCOUT,CASH=@CASH, CHANGE=@CHANGE, SDATE=@SDATE WHERE INVOICE=@INVOICE", con)
            With cmd
                .Parameters.AddWithValue("@SUBTOT", CDbl(frmBilling.lblSubTot.Text))
                .Parameters.AddWithValue("@ATOTAL", CDbl(frmBilling.lblPayAmo.Text))
                .Parameters.AddWithValue("@VAT", CDbl(frmBilling.lblVat.Text))
                .Parameters.AddWithValue("@DISCOUNT", frmBilling.lblDisc.Text)
                .Parameters.AddWithValue("@CASH", CDbl(txtCash.Text))
                .Parameters.AddWithValue("@CHANGE", CDbl(lblChange.Text))
                .Parameters.AddWithValue("@SDATE", Date.Now.ToShortDateString)
                .Parameters.AddWithValue("@INVOICE", frmBilling.lblInvoNum.Text)
                .ExecuteNonQuery()
            End With
            con.Close()
            With frmBilling
                .loadCart()
                .compute()
                .autoIV()
            End With
            Me.Dispose()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

#End Region
    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged

        Dim change As Double = Val(txtCash.Text) - (lblTotal.Text)
            If change < 0 Then
                lblChange.Text = "0.00"
            Else
                lblChange.Text = Format(change, "###,###0.00")
            End If

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        'If Val(txtCash.Text) < 0 Then
        '    MsgBox("Insufficient amount!", vbCritical, "Invalid Transaction")
        '    txtCash.Clear()
        '    txtCash.Focus()
        'Else
        '    settlePay()
        'End If
        settlePay()
    End Sub

    Private Sub frmPayment_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Dispose()
        End Select
    End Sub

    Private Sub txtCash_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCash.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPay_Click(Nothing, Nothing)
        End If
    End Sub
End Class