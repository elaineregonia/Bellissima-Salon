Imports System.Data.OleDb
Imports Guna.UI2.WinForms
Public Class frmRecepHome

    Private Sub frmEmpHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmDate.Start()
    End Sub

#Region "Methods"
    Sub loadtimeinout()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM AttendanceDB WHERE ID like '" & frmRecepMain.lblID.Text & "' AND LOGDATE LIKE '" & lblDate.Text & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                If dr.Item("TIMEIN").ToString = "" Then
                    lblTI.Text = "----"
                    unchecked(btnTI)
                Else
                    lblTI.Text = dr.Item("TIMEIN").ToString
                    checked(btnTI)
                End If

                If dr.Item("TIMEOUT").ToString = "" Then
                    lblTO.Text = "----"
                    unchecked(btnTO)
                Else
                    lblTO.Text = dr.Item("TIMEOUT").ToString
                    checked(btnTO)
                End If

                If dr.Item("LUNCHIN").ToString = "" Then
                    lblTILu.Text = "----"
                    unchecked(btnTILu)
                Else
                    lblTILu.Text = dr.Item("LUNCHIN").ToString
                    checked(btnTILu)
                End If

                If dr.Item("LUNCHOUT").ToString = "" Then
                    lblTOLu.Text = "----"
                    unchecked(btnTOLu)
                Else
                    lblTOLu.Text = dr.Item("LUNCHOUT").ToString
                    checked(btnTOLu)
                End If
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub successrecord()
        pnlAD.BackColor = System.Drawing.Color.FromArgb(15, 177, 8)
        lblAD.Text = "Time-in successfully!"
        pbAD.Image = My.Resources.ok_50px
    End Sub

    Sub unsuccess(txt As String)
        pnlAD.BackColor = System.Drawing.Color.FromArgb(157, 32, 30)
        lblAD.Text = txt
        pbAD.Image = My.Resources.cancel_50px
    End Sub

    Sub checked(btn As Guna2Button)
        btn.Image = My.Resources.ok_50px
        btn.FillColor = Color.Gainsboro
        btn.ForeColor = Color.DimGray
    End Sub

    Sub unchecked(btn As Guna2Button)
        btn.Image = Nothing
        btn.FillColor = System.Drawing.Color.FromArgb(247, 191, 210)
        btn.ForeColor = Color.White
    End Sub

#End Region

    Private Sub tmDate_Tick(sender As Object, e As EventArgs) Handles tmDate.Tick
        lblDate.Text = Date.Now.ToString("dddd, MMMM dd yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub tmLoadData_Tick(sender As Object, e As EventArgs) Handles tmLoadData.Tick
        loadtimeinout()
    End Sub

    Private Sub btnTI_Click(sender As Object, e As EventArgs) Handles btnTI.Click

        Try
            reloadtxt("SELECT * FROM AttendanceDB WHERE ID='" & frmRecepMain.lblID.Text & "' And LOGDATE ='" & lblDate.Text & "' AND TISTATUS='Time In' AND LDATE LIKE '" & Date.Now.ToShortDateString & "' ")
            If dt.Rows.Count > 0 Then
                unsuccess("You have already time in today.")
            Else
                con.Open()
                cmd = New OleDbCommand("INSERT INTO AttendanceDB (ID,FNAME,LOGDATE,TIMEIN,TISTATUS,LDATE)VALUES('" & frmRecepMain.lblID.Text & "','" & frmRecepMain.lblName.Text & "','" & lblDate.Text & "','" & TimeOfDay & "','Time In', '" & Date.Now.ToShortDateString & "')", con)
                With cmd
                    .ExecuteNonQuery()
                End With
                con.Close()
                checked(btnTI)
                successrecord()
                loadtimeinout()
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnTO_Click(sender As Object, e As EventArgs) Handles btnTO.Click
        Try
            reloadtxt("SELECT * FROM AttendanceDB WHERE ID='" & frmRecepMain.lblID.Text & "'")
            If dt.Rows.Count > 0 Then
                unsuccess("Please time in or lunch in or lunch out first.")
                reloadtxt("SELECT * FROM AttendanceDB WHERE ID='" & frmRecepMain.lblID.Text & "' And LOGDATE ='" & lblDate.Text & "' AND TISTATUS='Time In'  AND TOSTATUS='Time Out' AND LISTATUS='Time In' AND LOSTATUS='Time Out'")
                If dt.Rows.Count > 0 Then
                    unsuccess("You have already time out today.")
                Else
                    reloadtxt("SELECT * FROM AttendanceDB WHERE ID='" & frmRecepMain.lblID.Text & "' And LOGDATE ='" & lblDate.Text & "' AND LOSTATUS='Time Out'")
                    If dt.Rows.Count > 0 Then
                        con.Open()
                        cmd = New OleDbCommand("UPDATE AttendanceDB SET TIMEOUT='" & TimeOfDay & "', TOSTATUS='Time Out' where ID like'" & frmRecepMain.lblID.Text & "' AND LOGDATE LIKE '" & lblDate.Text & "'", con)
                        With cmd
                            .ExecuteNonQuery()
                        End With
                        con.Close()
                        checked(btnTO)
                        successrecord()
                        loadtimeinout()
                    End If
                End If
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnTILu_Click(sender As Object, e As EventArgs) Handles btnTILu.Click

        Try
            reloadtxt("SELECT * FROM AttendanceDB WHERE ID='" & frmRecepMain.lblID.Text & "'")
            If dt.Rows.Count > 0 Then
                unsuccess("Please time in first.")
                reloadtxt("SELECT * FROM AttendanceDB WHERE ID='" & frmRecepMain.lblID.Text & "' And LOGDATE ='" & lblDate.Text & "' AND TISTATUS='Time In' AND LISTATUS='Time In'")
                If dt.Rows.Count > 0 Then
                    unsuccess("You have already lunch in today.")
                Else
                    reloadtxt("SELECT * FROM AttendanceDB WHERE ID='" & frmRecepMain.lblID.Text & "' And LOGDATE ='" & lblDate.Text & "' AND TISTATUS='Time In'")
                    If dt.Rows.Count > 0 Then
                        con.Open()
                        cmd = New OleDbCommand("UPDATE AttendanceDB SET LUNCHIN='" & TimeOfDay & "', LISTATUS='Time In' where ID like'" & frmRecepMain.lblID.Text & "' And LOGDATE ='" & lblDate.Text & "'", con)
                        With cmd
                            .ExecuteNonQuery()
                        End With
                        con.Close()
                        checked(btnTOLu)
                        successrecord()
                        loadtimeinout()
                    End If
                End If
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnTOLu_Click(sender As Object, e As EventArgs) Handles btnTOLu.Click
        Try
            reloadtxt("SELECT * FROM AttendanceDB WHERE ID='" & frmRecepMain.lblID.Text & "'")
            If dt.Rows.Count > 0 Then
                unsuccess("Please time in or lunch in first.")
                reloadtxt("SELECT * FROM AttendanceDB WHERE ID='" & frmRecepMain.lblID.Text & "' And LOGDATE ='" & lblDate.Text & "' AND TISTATUS='Time In' AND LISTATUS='Time In' AND LOSTATUS='Time Out'")
                If dt.Rows.Count > 0 Then
                    unsuccess("You have already lunch out today.")
                Else
                    reloadtxt("SELECT * FROM AttendanceDB WHERE ID='" & frmRecepMain.lblID.Text & "' And LOGDATE ='" & lblDate.Text & "' AND LISTATUS='Time In'")
                    If dt.Rows.Count > 0 Then
                        con.Open()
                        cmd = New OleDbCommand("UPDATE AttendanceDB SET LUNCHOUT='" & TimeOfDay & "', LOSTATUS='Time Out' where ID like'" & frmRecepMain.lblID.Text & "' And LOGDATE ='" & lblDate.Text & "'", con)
                        With cmd
                            .ExecuteNonQuery()
                        End With
                        con.Close()
                        checked(btnTOLu)
                        successrecord()
                        loadtimeinout()
                    End If
                End If
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


End Class