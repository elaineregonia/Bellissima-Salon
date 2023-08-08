Imports System.Data.OleDb

Public Class frmResetPW
    Private Sub frmResetPW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If empty2(txtUN, ErrorProvider1) = True Then Return
        If empty2(txtPW, ErrorProvider1) = True Then Return
        If empty2(txtRPW, ErrorProvider1) = True Then Return

        If txtRPW.Text <> txtPW.Text Then
                ErrorProvider1.SetError(txtRPW, "Passwords do not match - please re-enter.")
                txtRPW.BorderColor = Color.Red
                Return
                txtRPW.Clear()
                txtRPW.Focus()
            Else
                ErrorProvider1.SetError(txtRPW, "")
            txtRPW.BorderColor = Color.Gainsboro
            Try
            If MsgBox("Are you sure you want to reset your password?", vbYesNo + vbQuestion) = vbYes Then

                    con.Open()
                    cmd = New OleDbCommand("UPDATE LoginDB SET " &
                    "[PASSWORD]=@PASSWORD WHERE USERNAME=@USERNAME", con)
                    With cmd
                        .Parameters.AddWithValue("@PASSWORD", txtPW.Text)
                        .Parameters.AddWithValue("@USERNAME", txtUN.Text)
                        .ExecuteNonQuery()
                    End With

                    MsgBox("Password has been sucessfully changed.", vbInformation)
                    con.Close()
                    Me.Dispose()
                    With frmLogin
                        .Show()
                        .txtUN.Clear()
                        .txtPW.Focus()
                    End With
                End If
            Catch ex As Exception

                con.Close()
                MsgBox(ex.Message, vbCritical)

            End Try
        End If
    End Sub

End Class