Imports System.Data.OleDb
Imports System.IO
Public Class frmSalonDet

    Dim fav As Byte()
    Dim logoo As Byte()
    Dim iddet As String
    Private Sub frmSalonDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#Region "Methods"
    Sub loadData()
        Try
            con.Open()
            cmd = New OleDbCommand("select * from SalonDetailsDB", con)
            dr = cmd.ExecuteReader
            While dr.Read
                iddet = dr.Item("ID").ToString
                txtSalonName.Text = dr.Item("SALNAME").ToString
                txtAddress.Text = dr.Item("ADDRESS").ToString
                txtPhone.Text = dr.Item("PHONE")
                txtEmail.Text = dr.Item("EMAIL").ToString
                fav = CType(dr.Item("FAVI"), Byte())
                logoo = CType(dr.Item("SALLOGO"), Byte())
            End While

            Dim ms As New MemoryStream(fav)
            pbFav.Image = Image.FromStream(ms)
            ms.Close()

            Dim ms1 As New MemoryStream(logoo)
            pbLogo.Image = Image.FromStream(ms1)
            ms1.Close()

            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub enab()
        txtSalonName.Enabled = True
        txtAddress.Enabled = True
        txtEmail.Enabled = True
        txtPhone.Enabled = True
        pbAddLogo.Enabled = True
        pbAddFav.Enabled = True
    End Sub

    Sub disab()
        txtSalonName.Enabled = False
        txtAddress.Enabled = False
        txtEmail.Enabled = False
        txtPhone.Enabled = False
        pbAddLogo.Enabled = False
        pbAddFav.Enabled = False
    End Sub
#End Region


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            'Dim ms As New System.IO.MemoryStream
            'pbFav.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            'Dim fav() As Byte = ms.GetBuffer
            'pbLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            'Dim logoo() As Byte = ms.GetBuffer

            'If permission(rupdate) = 1 Then Return
            If empty(txtSalonName, ErrorProvider1) = True Then Return
            If empty(txtAddress, ErrorProvider1) = True Then Return
            If empty(txtPhone, ErrorProvider1) = True Then Return
            If empty(txtEmail, ErrorProvider1) = True Then Return

            If Edata Then

                If MsgBox("Do you really want to add?", vbQuestion + vbYesNo) = vbYes Then

                    con.Open()
                    cmd = New OleDbCommand("INSERT INTO SalonDetailsDB ([SALNAME],[ADDRESS],[PHONE],[EMAIL],[FAVI],[SALLOGO])VALUES(@SALNAME,@ADDRESS,@PHONE,@EMAIL,@FAVI,@SALLOGO)", con)
                    With cmd
                        .Parameters.AddWithValue("@SALNAME", txtSalonName.Text)
                        .Parameters.AddWithValue("@ADDRESS", txtAddress.Text.Trim)
                        .Parameters.AddWithValue("@PHONE", txtPhone.Text.Trim)
                        .Parameters.AddWithValue("@EMAIL", txtEmail.Text.Trim)
                        .Parameters.AddWithValue("@FAVI", fav)
                        .Parameters.AddWithValue("@SALLOGO", logoo)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    MsgBox("Record has been sucessfully saved.", vbInformation)
                    loadData()
                    disab()
                End If
            Else

                If MsgBox("Do you really want to update ?", vbQuestion + vbYesNo) = vbYes Then
                    con.Open()
                    cmd = New OleDbCommand("update SalonDetailsDB set SALNAME=@SALNAME,[ADDRESS]=@ADDRESS,PHONE=@PHONE,EMAIL=@EMAIL,FAVI=@FAVI,SALLOGO=@SALLOGO where ID=@ID", con)
                    With cmd
                        .Parameters.AddWithValue("@SALNAME", txtSalonName.Text)
                        .Parameters.AddWithValue("@ADDRESS", txtAddress.Text.Trim)
                        .Parameters.AddWithValue("@PHONE", txtPhone.Text.Trim)
                        .Parameters.AddWithValue("@EMAIL", txtEmail.Text.Trim)
                        .Parameters.AddWithValue("@FAVI", fav)
                        .Parameters.AddWithValue("@SALLOGO", logoo)
                        .Parameters.AddWithValue("@ID", iddet)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    MsgBox("Record has been sucessfully updated.", vbInformation)
                    loadData()
                    disab()
                End If
            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edata = False
        enab()

    End Sub

    Private Sub pbAddLogo_Click(sender As Object, e As EventArgs) Handles pbAddLogo.Click
        OpenFileDialog1.Filter = "Image Files(*.png; *.jpg; *.gif; *.svg; *.ico) | *.png; *.jpg; *.gif; *.svg; *.ico"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim fs As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            Dim breader As New BinaryReader(fs)
            Dim logoo(fs.Length) As Byte
            breader.Read(logoo, 0, fs.Length)
            fs.Close()

            Dim ms As New MemoryStream(logoo)
            pbLogo.Image = Image.FromStream(ms)
        End If

    End Sub

    Private Sub pbAddFav_Click(sender As Object, e As EventArgs) Handles pbAddFav.Click
        OpenFileDialog1.Filter = "Image Files(*.png; *.jpg; *.gif; *.svg; *.ico) | *.png; *.jpg; *.gif; *.svg; *.ico"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim fs As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            Dim breader As New BinaryReader(fs)
            Dim fav(fs.Length) As Byte
            breader.Read(fav, 0, fs.Length)
            fs.Close()

            Dim ms As New MemoryStream(fav)
            pbFav.Image = Image.FromStream(ms)
        End If
    End Sub
End Class