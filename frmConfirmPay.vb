Imports System.Data.OleDb
Public Class frmConfirmPay

    Sub addTocart()
        Try
            con.Open()
            cmd = New OleDbCommand("INSERT INTO PaymentDB (INVOICE, CUSNAME, SERVICE, PRICE)VALUES(@INVOICE,@CUSNAME,@SERVICE,@PRICE)", con)

            With cmd
                .Parameters.AddWithValue("@INVOICE", frmBilling.lblInvoNum.Text)
                .Parameters.AddWithValue("@CUSNAME", lblName.Text)
                .Parameters.AddWithValue("@SERVICE", lblAllSer.Text)
                .Parameters.AddWithValue("@PRICE", lblSubTot.Text)
                .ExecuteNonQuery()
            End With
            con.Close()
            Me.Dispose()
            With frmBilling
                .loadCart()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        addTocart()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Dispose()
    End Sub

    Private Sub frmConfirmPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
End Class