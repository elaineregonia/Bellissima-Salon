Imports System.Data.OleDb

Public Class frmLogHis
    Private Sub frmLogHis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "Methods"

    Sub loadall()
        Try
            Dim i As Integer
            dgAtt.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from AttendanceDB where FNAME like '" & txtSearch.Text & "%'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgAtt.Rows.Add(i, dr.Item("FNAME").ToString, dr.Item("LOGDATE").ToString, dr.Item("TIMEIN").ToString, dr.Item("LUNCHIN").ToString, dr.Item("LUNCHOUT").ToString, dr.Item("TIMEOUT").ToString)
                dgAtt.ClearSelection()
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub daily()
        Try
            Dim i As Integer
            dgAtt.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from AttendanceDB WHERE LOGDATE like '" & Date.Now.ToString("dddd, MMMM dd yyyy") & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgAtt.Rows.Add(i, dr.Item("FNAME").ToString, dr.Item("LOGDATE").ToString, dr.Item("TIMEIN").ToString, dr.Item("LUNCHIN").ToString, dr.Item("LUNCHOUT").ToString, dr.Item("TIMEOUT").ToString)
                dgAtt.ClearSelection()
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub weekly()
        Try
            Dim i As Integer
            dgAtt.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from AttendanceDB WHERE WEEKDAY(LDATE)=WEEKDAY(NOW())", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgAtt.Rows.Add(i, dr.Item("FNAME").ToString, dr.Item("LOGDATE").ToString, dr.Item("TIMEIN").ToString, dr.Item("LUNCHIN").ToString, dr.Item("LUNCHOUT").ToString, dr.Item("TIMEOUT").ToString)
                dgAtt.ClearSelection()
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub monthly()
        Try
            Dim i As Integer
            dgAtt.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from AttendanceDB WHERE MONTH(LDATE)=MONTH(NOW())", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgAtt.Rows.Add(i, dr.Item("FNAME").ToString, dr.Item("LOGDATE").ToString, dr.Item("TIMEIN").ToString, dr.Item("LUNCHIN").ToString, dr.Item("LUNCHOUT").ToString, dr.Item("TIMEOUT").ToString)
                dgAtt.ClearSelection()
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadall()
    End Sub

    Private Sub cbSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSort.SelectedIndexChanged
        If cbSort.SelectedIndex = 0 Then
            loadall()
        ElseIf cbSort.SelectedIndex = 1 Then
            daily()
        ElseIf cbSort.SelectedIndex = 2 Then
            weekly()
        Else
            monthly()
        End If
    End Sub
End Class