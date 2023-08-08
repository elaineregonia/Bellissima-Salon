Imports System.Data.OleDb
Imports System.Net.Mail

Public Class frmForgetPW

    Private Sub frmForgetPW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        txtEmail.Focus()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim intAt, intDot As Integer
        Dim ValidChars As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim strpos As String
        Dim count As Integer
        Dim Randomize As New Random
        Dim Result As String = String.Empty

        My.Settings.OTPSave = ""

        While count <= 5
            strpos = Randomize.Next(0, ValidChars.Length)

            My.Settings.OTPSave = My.Settings.OTPSave & ValidChars(strpos)
            My.Settings.Save()
            count += 1
        End While

        If Len(txtEmail.Text) > 0 Then
            intAt = InStr(1, txtEmail.Text, "@")
            intDot = InStr(intAt + 1, txtEmail.Text, ".")
            If (intAt = 0) Or (intDot = 0) Or (intDot = (intAt + 1)) _
              Or (InStr(intAt + 1, txtEmail.Text, "@") < 0) _
                Or (Len(txtEmail.Text) < intDot + 1) _
                  Or (InStr(intDot + 1, txtEmail.Text, ".") < 0) Then
                ErrorProvider1.SetError(txtEmail, "Invalid Email Address!")
                txtEmail.BorderColor = Color.Red
                Return
                txtEmail.Focus()
                Exit Sub
            Else
                ErrorProvider1.SetError(txtEmail, "")
                txtEmail.BorderColor = Color.Gainsboro
            End If
        End If

        If empty2(txtEmail, ErrorProvider1) = True Then Return
        Try

                cmd = New OleDbCommand("SELECT * FROM LoginDB WHERE EMAIL= @EMAIL", con)
                Dim sqladapter As New OleDbDataAdapter(cmd)
                Dim sqltable As New DataTable()

                cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = txtEmail.Text
                sqladapter.Fill(sqltable)

                con.Open()

                Dim fname As String = sqltable.Rows(0)(1).ToString
                Dim pw As String = sqltable.Rows(0)(7).ToString

                Try
                    Dim smtp As New SmtpClient
                    Dim mail As New MailMessage

                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New Net.NetworkCredential("bellissimasalon2021@gmail.com", "ProjectInSoftwareDesign")
                    smtp.Port = 587
                    smtp.EnableSsl = True
                    smtp.Host = "smtp.gmail.com"

                    mail = New MailMessage
                    mail.From = New MailAddress("bellissimasalon2021@gmail.com")
                    mail.To.Add(txtEmail.Text)
                    mail.Subject = "Password Recovery"

                    mail.Body = "<h4><b>Hi, " & fname & "!</b></h4>" &
                        "<p>We sent this email in respond to your request to reset " &
                        "your password on Bellissima Salon. Copy& paste the code below to reset it.<br/><br/>" &
                        "<p>Here is your code: <b>'" & My.Settings.OTPSave & "'</b></p><br>" &
                        "<p>If you did not request a password reset, please ignore this email or " &
                        "reply to let us know. This password reset is only valid for the next 2 " &
                        "minutes.</p>" &
                        "<p>Thanks,<br>" &
                        "Bellissima Salon Management Team</p>" &
                        "<p><b>P.S.</b> We also love hearing from you and helping you with any issues " &
                        "you have. Please reply to this email if you want to ask a question or " &
                        "give us your feedback.<br><br>" &
                        "<hr><br>" &
                        "<sub>If you're having trouble resetting your password lets us know.</sub><br>" &
                        "<sub><u color='blue'>bellissimasalon2021@gmail.coml<u></sub>"

                    mail.IsBodyHtml = True
                    smtp.Send(mail)
                    con.Close()
                    MsgBox("Successfully sent to your Email.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sent.")

                    Me.Size = New Size(298, 341)
                    Panel2.Visible = True
                    Do Until Panel2.Height = 150
                        Panel2.Height += 1
                    Loop

                    PicGmail.Location = New Point(11, 75)
                    txtEmail.Location = New Point(81, 89)
                    btnSubmit.Location = New Point(104, 142)

                    Timer1.Start()

                Catch ex As Exception
                    con.Close()
                    MsgBox(ex.Message.ToString, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Failed to send")
                End Try
            Catch ex As Exception
                con.Close()
                'MsgBox(ex.Message.ToString, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Alert")
                MsgBox("Make sure you've entered the correct email address.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "No email match that information.")
                txtEmail.Clear()
                txtEmail.Focus()
            End Try
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        With frmLogin
            .Show()
            .txtUN.Focus()
        End With
    End Sub

    Private Sub btnSubmit1_Click(sender As System.Object, e As System.EventArgs) Handles btnSumbit1.Click
        If empty2(txtCode, ErrorProvider1) = True Then Return
        If txtCode.Text = My.Settings.OTPSave Then
            Timer1.Stop()
            GunaCircleProgressBar1.Visible = False

            frmResetPW.Show()
            Me.Close()

        Else
            MsgBox("Invalid OTP Code!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Alert")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not GunaCircleProgressBar1.Value = 0 Then
            GunaCircleProgressBar1.Decrement(1)

            If GunaCircleProgressBar1.Value = 0 Then
                MsgBox("Time is up. Resend Code!", vbInformation)

                Me.Size = New Size(298, 278)
                Panel2.Visible = False
                Do Until Panel2.Height = 36
                    Panel2.Height -= 0.6
                Loop

                PicGmail.Location = New Point(11, 129)
                txtEmail.Location = New Point(81, 143)
                btnSubmit.Location = New Point(104, 196)

                GunaCircleProgressBar1.Value = 100
            End If
        End If
    End Sub

End Class