Imports System.Data.OleDb
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing.Common
Imports ZXing
Imports ZXing.QrCode
Imports System.ComponentModel
Imports System.IO
Public Class frmLogin

    Dim VideoCaptureSource As VideoCaptureDevice
    Dim VideoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
    Dim bit As Bitmap
    Dim res As String
    Dim idlog As String

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        pbShowPW.Hide()
        pbHidePW.Hide()

        If VideoDevices.Count = 0 Then
            cbCam.Items.Add("No Video Devices")
        Else
            For Each MySingleDevice In VideoDevices
                cbCam.Items.Add(MySingleDevice.Name)
            Next
        End If

        cbCam.SelectedIndex = 0
    End Sub

#Region "Methods"
    Sub clear()
        txtUN.Clear()
        txtPW.Clear()
    End Sub

    Sub loadUN()
        Dim found As Boolean = False
        Try
            con.Open()
            cmd = New OleDbCommand("Select * from LoginDB where ID like '" & res & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                idlog = dr.Item("ID")
                uname1 = dr.Item("USERNAME").ToString
                pword = dr.Item("PASSWORD").ToString
                role = dr.Item("USERTYPE").ToString
                found = True
            End If
            dr.Close()
            con.Close()
            If found = True Then

                If role = "Hair Stylist" Or role = "Makeup Artist" Then
                    txtUN.Text = uname1
                    txtPW.Text = pword
                    btnLogin_Click(Nothing, Nothing)
                Else
                    txtUN.Text = uname1
                End If
            Else
                    con.Close()
                MsgBox("Invalid QRCode! Try again.", vbExclamation)
            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
#End Region

    Sub cbCam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCam.SelectedIndexChanged
        If cbCam.SelectedItem <> "No Video Devices" Then
            If VideoSourcePlayer1.IsRunning = True Then
                VideoSourcePlayer1.SignalToStop()
                VideoSourcePlayer1.WaitForStop()
            End If

            VideoCaptureSource = New VideoCaptureDevice(VideoDevices(cbCam.SelectedIndex).MonikerString)
            VideoSourcePlayer1.VideoSource = VideoCaptureSource
            VideoSourcePlayer1.Start()
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rd As New BarcodeReader

        Try
            If VideoSourcePlayer1.IsRunning = True Then bit = VideoSourcePlayer1.GetCurrentVideoFrame.Clone
            Dim result As Result = rd.Decode(bit)
            If result IsNot Nothing Then
                Dim decoded As String = result.ToString().Trim()
                res = decoded
                txtPW.Focus()
                cbCam.SelectedIndex = 0
                btnScan_Click(sender, e)
                loadUN()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        If cbCam.Visible = False And VideoSourcePlayer1.Visible = False Then

            txtUN.Size = New Size(210, 23)
            txtPW.Size = New Size(210, 23)
            btnScan.Location = New Point(326, 337)
            pbShowPW.Location = New Point(455, 263)
            pbHidePW.Location = New Point(455, 263)
            cbCam.Visible = True
            VideoSourcePlayer1.Visible = True
        Else
            txtUN.Size = New Size(334, 23)
            txtPW.Size = New Size(334, 23)
            btnScan.Location = New Point(489, 305)
            pbShowPW.Location = New Point(584, 263)
            pbHidePW.Location = New Point(584, 263)
            cbCam.Visible = False
            VideoSourcePlayer1.Visible = False
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        VideoSourcePlayer1.SignalToStop()
        VideoSourcePlayer1.WaitForStop()
        VideoDevices = Nothing
        VideoCaptureSource = Nothing
        Me.Dispose()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try

            If empty2(txtUN, ErrorProvider1) = True Then Return
            If empty2(txtPW, ErrorProvider1) = True Then Return


            con.Open()
            cmd = New OleDbCommand("select * from LoginQR where USERNAME like '" & txtUN.Text.Trim & "' and [PASSWORD] like '" & txtPW.Text.Trim & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            pic = CType(dr.Item("PIC"), Byte())
            'Dim empimage() As Byte = dr.Item("PIC")
            Dim ms As New System.IO.MemoryStream(pic)
            Dim imagee As Image

            If dr.HasRows Then
                idlog = dr.Item("ID").ToString
                fname = dr.Item("FULLNAME").ToString
                uname = dr.Item("USERNAME").ToString
                pword = dr.Item("PASSWORD").ToString
                role = dr.Item("USERTYPE").ToString
                imagee = Image.FromStream(ms, True)
                rinsert = Boolean.Parse(dr.Item("RINSERT"))
                rupdate = Boolean.Parse(dr.Item("RUPDATE"))
                rdel = Boolean.Parse(dr.Item("RDELETE"))
                rview = Boolean.Parse(dr.Item("RVIEW"))
                success = True
            End If
            dr.Close()
            con.Close()

            If success = True Then

                If StrComp(txtUN.Text, uname, CompareMethod.Binary) Or StrComp(txtPW.Text, pword, CompareMethod.Binary) Then
                    MsgBox("Invalid Username or Password!", vbExclamation)
                    clear()
                    txtUN.Focus()
                Else
                    MsgBox("Login Successfully!", vbInformation)
                    clear()
                    Me.Hide()

                    If role = "Admin" Then
                        With frmAdminMain
                            .Show()
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                            .pbUserPic.Image = imagee
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
                            .lblName.Text = fname
                            .lblID.Text = idlog
                        End With
                    ElseIf role = "Receptionist" Then

                        With frmRecepMain
                            .Show()
                            .pbMainPic.Image = imagee
                            .lblName.Text = fname
                            .lblID.Text = idlog
                        End With
                    ElseIf role = "Hair Stylist" Or role = "Makeup Artist" Then
                        With frmEmpMain
                            .Show()
                            .pbMainPic.Image = imagee
                            .lblName.Text = fname
                            .lblUserType.Text = role
                            .lblID.Text = idlog
                        End With
                    End If
                End If
            Else
                MsgBox("Invalid Username or Password!", vbExclamation)
                clear()
                txtUN.Focus()
            End If

        Catch ex As Exception
            con.Close()
            MsgBox("Invalid Username or Password!", vbExclamation)
            clear()
            txtUN.Focus()
            'MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUN.KeyDown, txtPW.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub llblFPW_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblFPW.LinkClicked
        Me.Hide()
        With frmForgetPW
            .txtEmail.Focus()
            .Show()
        End With
    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs) Handles txtPW.TextChanged
        If txtPW.TextLength > 0 And txtPW.UseSystemPasswordChar = True Then

            pbShowPW.Show()

        ElseIf txtPw.TextLength > 0 And txtPW.UseSystemPasswordChar = False Then

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

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                btnClose_Click(sender, e)
        End Select
    End Sub

    'Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
    '    frmResetPW.Location = MousePosition
    '    frmResetPW.Show()
    'End Sub
End Class