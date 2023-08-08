Public Class frmDiscount
    Private Sub cbDis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDis.SelectedIndexChanged
        With frmBilling
            If cbDis.SelectedIndex = 1 Then
                .custype = "PWD"
                .compute()
                lblDis.Text = "20%"

            ElseIf cbDis.SelectedIndex = 2 Then

                .custype = "Senior"
                .compute()
                lblDis.Text = "20%"

            Else
                .custype = "Regular"
                .compute()
                lblDis.Text = "0%"
            End If
        End With
    End Sub

    Private Sub frmDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        cbDis.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmBilling.compute()
        Me.Dispose()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class