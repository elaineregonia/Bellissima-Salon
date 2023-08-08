Imports System.Data.OleDb
Public Class frmAddSer

    Public idser As String
    Private Sub frmAddEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

#Region "Methods"


    Sub clear()
        txtPrice.Clear()
        txtSerName.Clear()
        txtEstTime.Clear()
        cbCategory.SelectedIndex = -1
    End Sub

#End Region

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            'If permission(rupdate) = 1 Then Return
            If emptyline(txtPrice, ErrorProvider1) = True Then Return
            If emptyline(txtEstTime, ErrorProvider1) = True Then Return
            If emptycbx(cbCategory, ErrorProvider1) = True Then Return
            If emptyline(txtSerName, ErrorProvider1) = True Then Return
            If Edata Then
                If MsgBox("Do you really want to add " + txtSerName.Text + "?", vbQuestion + vbYesNo) = vbYes Then

                    con.Open()
                    cmd = New OleDbCommand("INSERT INTO ServiceDB ([SERNAME], [SERCATE], [SERPRICE], [ESTTIME])VALUES(@SERNAME,@SERCATE,@SERPRICE,@ESTTIME)", con)
                    With cmd
                        .Parameters.AddWithValue("@SERNAME", txtSerName.Text)
                        .Parameters.AddWithValue("@SERCATE", cbCategory.Text)
                        .Parameters.AddWithValue("@SERPRICE", txtPrice.Text)
                        .Parameters.AddWithValue("@ESTTIME", txtEstTime.Text)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    MsgBox("Record has been sucessfully saved.", vbInformation)
                    clear()
                    frmService.loadData()
                End If
            Else
                If MsgBox("Do you really want to update " + txtSerName.Text + "?", vbQuestion + vbYesNo) = vbYes Then
                    con.Open()
                    cmd = New OleDbCommand("UPDATE ServiceDB set [SERNAME]=@SERNAME,[SERCATE]=@SERCATE,[SERPRICE]=@SERPRICE,[ESTTIME]=@ESTTIME where ID=@ID", con)
                    With cmd
                        .Parameters.AddWithValue("@SERNAME", txtSerName.Text)
                        .Parameters.AddWithValue("@SERCATE", cbCategory.Text)
                        .Parameters.AddWithValue("@SERPRICE", txtPrice.Text)
                        .Parameters.AddWithValue("@ESTTIME", txtEstTime.Text)
                        .Parameters.AddWithValue("@ID", idser)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    MsgBox("Record has been sucessfully updated.", vbInformation)
                    Me.Dispose()
                    frmService.loadData()
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

    Private Sub frmAddSer_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnSave_Click(sender, e)
            Case Keys.Escape
                Me.Dispose()
        End Select
    End Sub
End Class