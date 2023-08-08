Imports System.Data.OleDb
Public Class frmAddClient

    Public idcli As String
    Private Sub frmAddClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

#Region "Methods"

    Sub clear()
        txtName.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        txtConNum.Clear()
        txtFirstIn.Clear()
    End Sub

#End Region

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            'If permission(rupdate) = 1 Then Return
            If emptyline(txtEmail, ErrorProvider1) = True Then Return
            If emptyline(txtConNum, ErrorProvider1) = True Then Return
            If emptyline(txtName, ErrorProvider1) = True Then Return
            If Edata Then
                If MsgBox("Do you really want to add " + txtName.Text + "?", vbQuestion + vbYesNo) = vbYes Then

                    con.Open()
                    cmd = New OleDbCommand("INSERT INTO ClientsDB ([FNAME], [ADDRESS], [EMAIL], [CONTACTNUMBER], [FIRSTIN])VALUES(@FNAME, @ADDRESS, @EMAIL, @CONTACTNUMBER, @FIRSTIN)", con)
                    With cmd
                        .Parameters.AddWithValue("@FNAME", txtName.Text)
                        .Parameters.AddWithValue("@ADDRESS", txtAddress.Text)
                        .Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                        .Parameters.AddWithValue("@CONTACTNUMBER", txtConNum.Text)
                        .Parameters.AddWithValue("@FIRSTIN", txtFirstIn.Text)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    MsgBox("Record has been sucessfully saved.", vbInformation)
                    clear()
                    frmClients.loadData()
                End If
            Else
                If MsgBox("Do you really want to update " + txtName.Text + "?", vbQuestion + vbYesNo) = vbYes Then
                    con.Open()
                    cmd = New OleDbCommand("UPDATE ClientsDB set FNAME=@FNAME, ADDRESS=@ADDRESS, EMAIL=@EMAIL, CONTACTNUMBER=@CONTACTNUMBER, FIRSTIN=@FIRSTIN where ID=@ID", con)
                    With cmd
                        .Parameters.AddWithValue("@FNAME", txtName.Text)
                        .Parameters.AddWithValue("@ADDRESS", txtAddress.Text)
                        .Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                        .Parameters.AddWithValue("@CONTACTNUMBER", txtConNum.Text)
                        .Parameters.AddWithValue("@FIRSTIN", txtFirstIn.Text)
                        .Parameters.AddWithValue("@ID", idcli)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    MsgBox("Record has been sucessfully updated.", vbInformation)
                    Me.Dispose()
                    frmClients.loadData()
                End If
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmAddClient_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Dispose()
        End Select
    End Sub
End Class