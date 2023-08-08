Imports System.Data.OleDb
Public Class frmEmpAD
    Private Sub frmEmpAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

#Region "Methods"
    Sub loadAll()
        Try
            Dim i As Integer
            dgAtt.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from AttendanceDB where FNAME like '" & frmEmpMain.lblName.Text & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgAtt.Rows.Add(i, dr.Item("LOGDATE").ToString, dr.Item("TIMEIN").ToString, dr.Item("LUNCHIN").ToString, dr.Item("LUNCHOUT").ToString, dr.Item("TIMEOUT").ToString)
                dgAtt.ClearSelection()
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub filterbydate()
        Try
            Dim i As Integer
            dgAtt.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from AttendanceDB where LOGDATE >='" & dpFrom.Value.ToLongDateString & "' AND LOGDATE <= '" & dpTo.Value.ToLongDateString & "'  AND  FNAME like '" & frmEmpMain.lblName.Text & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgAtt.Rows.Add(i, dr.Item("LOGDATE").ToString, dr.Item("TIMEIN").ToString, dr.Item("LUNCHIN").ToString, dr.Item("LUNCHOUT").ToString, dr.Item("TIMEOUT").ToString)
                dgAtt.ClearSelection()
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub dpTo_ValueChanged(sender As Object, e As EventArgs) Handles dpTo.ValueChanged
        filterbydate()
    End Sub

    Private Sub dpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dpFrom.ValueChanged
        filterbydate()
    End Sub
End Class