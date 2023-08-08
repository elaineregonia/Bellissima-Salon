Imports MessagingToolkit.QRCode.Codec
Imports System.Data.OleDb
Imports System.IO
Public Class frmAddEmp

    Private Sub frmAddEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

#Region "Methods"

    Sub autoID()

        Try
            con.Open()
            cmd = New OleDbCommand("select ID from LoginDB ORDER BY ID DESC", con)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                txtUID.Text = Val(dr(0)) + 1
            Else
                txtUID.Text = 202020211
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            cmd.Dispose()
            con.Close()
        End Try

    End Sub

    Sub qrcodeGen()

        Dim color As Color

        If cbUT.Text = "Admin" Then
            color = Color.Pink
        ElseIf cbUT.Text = "Hair Stylist" Or cbUT.Text = "Makeup Artist" Then
            color = Color.DarkTurquoise
        End If

        Try
            Dim qrCode As New QRCodeEncoder
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            'qrCode.QRCodeForegroundColor = color
            Me.pbQR.Image = qrCode.Encode(txtUID.Text, System.Text.Encoding.UTF8)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub clear()
        autoID()
        txtName.Clear()
        txtAddress.Clear()
        cbGender.SelectedIndex = -1
        txtEmail.Clear()
        txtConNum.Clear()
        txtUN.Clear()
        txtPW.Clear()
        cbUT.SelectedIndex = -1
        pbImage.Image = pbDisplay.Image
    End Sub

    Sub loadUsertype()
        Try
            cbUT.Items.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from UsertypeDB", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbUT.Items.Add(dr.Item("USERTYPE").ToString)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

#End Region

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        Dim intAt, intDot As Integer
        If Len(txtEmail.Text) = 0 Then
            Exit Sub
        Else
            intAt = InStr(1, txtEmail.Text, "@")
            intDot = InStr(intAt + 1, txtEmail.Text, ".")
            If (intAt = 0) Or (intDot = 0) Or (intDot = (intAt + 1)) _
              Or (InStr(intAt + 1, txtEmail.Text, "@") < 0) _
                Or (Len(txtEmail.Text) < intDot + 1) _
                  Or (InStr(intDot + 1, txtEmail.Text, ".") < 0) Then
                MsgBox("Invalid email address.")
                txtEmail.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtUID_TextChanged(sender As Object, e As EventArgs) Handles txtUID.TextChanged
        Try
            'qrcodeGen()
            QRCodee(pbQR, txtUID.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cbGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbUT.KeyPress, cbGender.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtConNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConNum.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 47 To 58
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim success As Boolean = False
        Try

            If permission(rupdate) = 1 Then Return
            If emptyline(txtName, ErrorProvider1) = True Then Return
            If empty(txtAddress, ErrorProvider1) = True Then Return
            If emptycbx(cbGender, ErrorProvider1) = True Then Return
            If emptyline(txtEmail, ErrorProvider1) = True Then Return
            If emptyline(txtConNum, ErrorProvider1) = True Then Return
            If emptyline(txtUN, ErrorProvider1) = True Then Return
            If emptyline(txtPW, ErrorProvider1) = True Then Return
            If emptycbx(cbUT, ErrorProvider1) = True Then Return

            If Edata Then
                con.Open()
                cmd = New OleDbCommand("select * from LoginDB where USERNAME like '" & txtUN.Text.Trim & "' OR CONTACTNUMBER like '" & txtConNum.Text.Trim & "' OR EMAIL like '" & txtEmail.Text.Trim & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    uname = dr.Item("USERNAME").ToString
                    connum = dr.Item("CONTACTNUMBER")
                    email = dr.Item("EMAIL").ToString
                    success = True
                End If
                dr.Close()
                con.Close()
                If success = True Then
                    If uname.Count > 0 Then
                        ErrorProvider1.SetError(txtUN, "Username is already taken.")
                        txtUN.LineColor = Color.Red
                    Else
                        ErrorProvider1.SetError(txtUN, "")
                        txtUN.LineColor = Color.Gainsboro
                    End If

                    If connum.Count > 0 Then
                        ErrorProvider1.SetError(txtConNum, "Contact Number is already taken.")
                        txtConNum.LineColor = Color.Red
                    Else
                        ErrorProvider1.SetError(txtConNum, "")
                        txtConNum.LineColor = Color.Gainsboro
                    End If

                    If email.Count > 0 Then
                        ErrorProvider1.SetError(txtEmail, "Email is already taken.")
                        txtEmail.LineColor = Color.Red
                    Else
                        ErrorProvider1.SetError(txtEmail, "")
                        txtEmail.LineColor = Color.Gainsboro
                    End If
                Else
                    If MsgBox("Do you really want to add " + txtName.Text + "?", vbQuestion + vbYesNo) = vbYes Then

                        con.Open()
                        cmd = New OleDbCommand("INSERT INTO LoginDB ([ID], [FULLNAME], [ADDRESS], [GENDER], [EMAIL], [CONTACTNUMBER], [USERNAME], [PASSWORD], [USERTYPE],[PIC])VALUES(@ID,@FULLNAME,@ADDRESS,@GENDER,@EMAIL,@CONTACTNUMBER,@USERNAME,@PASSWORD,@USERTYPE,@PIC)", con)
                        With cmd
                            .Parameters.AddWithValue("@ID", txtUID.Text)
                            .Parameters.AddWithValue("@FULLNAME", txtName.Text.Trim)
                            .Parameters.AddWithValue("@ADDRESS", txtAddress.Text.Trim)
                            .Parameters.AddWithValue("@GENDER", cbGender.Text)
                            .Parameters.AddWithValue("@EMAIL", txtEmail.Text.Trim)
                            .Parameters.AddWithValue("@CONTACTNUMBER", txtConNum.Text.Trim)
                            .Parameters.AddWithValue("@USERNAME", txtUN.Text.Trim)
                            .Parameters.AddWithValue("@PASSWORD", txtPW.Text.Trim)
                            .Parameters.AddWithValue("@USERTYPE", cbUT.Text)
                            .Parameters.AddWithValue("@PIC", pic)
                            .ExecuteNonQuery()
                        End With
                        con.Close()
                        MsgBox("Record has been sucessfully saved.", vbInformation)
                        clear()
                        frmEmpMan.loadData()
                    End If
                End If
                Else
                If MsgBox("Do you really want to update " + txtName.Text + "?", vbQuestion + vbYesNo) = vbYes Then
                    con.Open()
                    cmd = New OleDbCommand("update LoginDB set FULLNAME=@FULLNAME,ADDRESS=@ADDRESS,GENDER=@GENDER,EMAIL=@EMAIL,CONTACTNUMBER=@CONTACTNUMBER,USERNAME=@USERNAME,[PASSWORD]=@PASSWORD,USERTYPE=@USERTYPE,PIC=@PIC where ID =@ID", con)
                    With cmd
                        .Parameters.AddWithValue("@FULLNAME", txtName.Text.Trim)
                        .Parameters.AddWithValue("@ADDRESS", txtAddress.Text.Trim)
                        .Parameters.AddWithValue("@GENDER", cbGender.Text)
                        .Parameters.AddWithValue("@EMAIL", txtEmail.Text.Trim)
                        .Parameters.AddWithValue("@CONTACTNUMBER", txtConNum.Text.ToString)
                        .Parameters.AddWithValue("@USERNAME", txtUN.Text.Trim)
                        .Parameters.AddWithValue("@PASSWORD", txtPW.Text.Trim)
                        .Parameters.AddWithValue("@USERTYPE", cbUT.Text)
                        .Parameters.AddWithValue("@PIC", pic)
                        .Parameters.AddWithValue("@ID", txtUID.Text)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    MsgBox("Record has been sucessfully updated.", vbInformation)
                    Me.Dispose()
                    frmEmpMan.loadData()
                    con.Open()
                    cmd = New OleDbCommand("select * from LoginQR", con)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    pic = CType(dr.Item("PIC"), Byte())
                    'Dim empimage() As Byte = dr.Item("PIC")
                    Dim ms As New System.IO.MemoryStream(pic)
                    Dim imagee As Image

                    If dr.HasRows Then
                        imagee = Image.FromStream(ms, True)
                        success = True
                    End If
                    dr.Close()
                    con.Close()
                    If success = True Then
                        With frmAdminMain
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                            .pbUserPic.Image = CType(imagee, Image)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
                        End With
                    End If
                End If
                End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'With OpenFileDialog1
        '    .FileName = ""
        '    .Multiselect = False
        '    .Filter = "Image Files(*.png; *.jpg; *.gif; *.svg; *.ico) | *.png; *.jpg; *.gif; *.svg; *.ico"
        'End With

        'If OpenFileDialog1.ShowDialog = DialogResult.OK Then pbImage.Image = Image.FromFile(OpenFileDialog1.FileName)
        ofd.Filter = "Image Files(*.png; *.jpg; *.gif; *.svg; *.ico) | *.png; *.jpg; *.gif; *.svg; *.ico"

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fs As New FileStream(ofd.FileName, FileMode.Open)
            Dim br As New BinaryReader(fs)
            pic = br.ReadBytes(CInt(fs.Length))
            br.Close()

            Dim ms As New MemoryStream(pic)
            pbImage.Image = Image.FromStream(ms)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtPW_GotFocus(sender As Object, e As EventArgs) Handles txtPW.GotFocus

    End Sub

    Private Sub frmAddEmp_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Dispose()
        End Select
    End Sub
End Class