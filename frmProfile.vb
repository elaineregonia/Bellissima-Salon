Imports System.Data.OleDb
Imports System.IO

Public Class frmProfile
    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tooltip.SetToolTip(lblCE, "Some details, like your name may be provided by your IT or human resources
                                     department. If you want to update those details, contact them or your admin.")

        pbShowPW.Hide()
        pbHidePW.Hide()
    End Sub
#Region "Methods"

    Sub loadData(id As String)
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM LoginDB WHERE ID like '" & id & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim empimage() As Byte = dr.Item("PIC")
                Dim ms As New System.IO.MemoryStream(empimage)
                Dim image As Image = Image.FromStream(ms, True)

                txtUID.Text = dr.Item("ID").ToString
                txtName.Text = dr.Item("FULLNAME").ToString
                cbGender.Text = dr.Item("GENDER").ToString
                txtAddress.Text = dr.Item("ADDRESS").ToString
                txtConNum.Text = dr.Item("CONTACTNUMBER").ToString
                txtEmail.Text = dr.Item("EMAIL").ToString
                txtUN.Text = dr.Item("USERNAME").ToString
                txtPW.Text = dr.Item("PASSWORD").ToString
                pbImage.Image = image
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub txtUID_TextChanged(sender As Object, e As EventArgs) Handles txtUID.TextChanged
        QRCodee(pbQR, txtUID.Text)
    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs) Handles txtPW.Click
        If txtPW.TextLength > 0 And txtPW.UseSystemPasswordChar = True Then

            pbShowPW.Show()

        ElseIf txtPW.TextLength > 0 And txtPW.UseSystemPasswordChar = False Then

            pbHidePW.Show()

        Else
            pbShowPW.Hide()
            pbHidePW.Hide()
        End If
    End Sub

    Private Sub pbShowPW_Click(sender As Object, e As EventArgs) Handles pbShowPW.Click

        'Code for show password
        txtPW.UseSystemPasswordChar = False
        pbShowPW.Hide()
        pbHidePW.Show()

    End Sub

    Private Sub pbHidePW_Click(sender As Object, e As EventArgs) Handles pbHidePW.Click

        'Code for hiding password
        txtPW.UseSystemPasswordChar = True
        pbHidePW.Hide()
        pbShowPW.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If MsgBox("Are you sure you want to change your password?", vbYesNo + vbQuestion) = vbYes Then

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

            End If
        Catch ex As Exception

            con.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub
End Class