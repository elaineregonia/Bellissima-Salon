Imports System.Data.OleDb
Public Class frmBookApp

    Public idapp As String
    Dim client As String
    Dim price As Double

    Private Sub frmBookApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadClient()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        dpDate.Value = Now.Date
    End Sub

#Region "Methods"
    Sub loadEmp()
        Try
            cbEmp.Items.Clear()
            con.Open()
            cmd = New OleDbCommand("select FNAME,LOGDATE from AttendanceDB WHERE LOGDATE = '" & Date.Now.ToString("dddd, MMMM dd yyyy") & "' AND TISTATUS = 'Time in'", con)

            dr = cmd.ExecuteReader
            While dr.Read
                cbEmp.Items.Add(dr.Item("FNAME").ToString)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Sub loadBlow()

        Try
            cbBlow.Items.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from ServiceDB WHERE SERCATE = 'Haircut and Blowdry'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbBlow.Items.Add(dr.Item("SERNAME").ToString)
                lblBlowPri.Text = Format(dr.Item("SERPRICE"), "###,###0.00")
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub loadColor()
        Try
            cbColor.Items.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from ServiceDB WHERE SERCATE = 'Hair Coloring'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbColor.Items.Add(dr.Item("SERNAME").ToString)
                lblColorPri.Text = dr.Item("SERPRICE")
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub loadStra()
        Try
            cbStra.Items.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from ServiceDB WHERE SERCATE = 'Straightening & Forming'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbStra.Items.Add(dr.Item("SERNAME").ToString)
                lblStraPri.Text = dr.Item("SERPRICE")
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub loadHMU()
        Try
            cbHMU.Items.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from ServiceDB WHERE SERCATE = 'Hair & Make-Up'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbHMU.Items.Add(dr.Item("SERNAME").ToString)
                lblHMUPri.Text = dr.Item("SERPRICE")
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub loadTreat()
        Try
            cbTre.Items.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from ServiceDB WHERE SERCATE = 'Hair Treatment'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbTre.Items.Add(dr.Item("SERNAME").ToString)
                lblTreatPri.Text = dr.Item("SERPRICE")
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub loadNaiWax()
        Try
            cbNaiWax.Items.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from ServiceDB WHERE SERCATE = 'Nail Care/Waxing/Threading'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbNaiWax.Items.Add(dr.Item("SERNAME").ToString)
                lblNaiWaxPri.Text = dr.Item("SERPRICE")
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub loadClient()
        Try
            ds.Tables.Add(dt)
            reloadtxt("SELECT FNAME FROM ClientsDB'")
            Dim r As DataRow
            txtName.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtName.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next

            txtName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub searchName()

    End Sub

    Sub clear()
        cbClient.SelectedIndex = -1
        txtName.Clear()
        cbBlowY.Checked = False
        cbColorY.Checked = False
        cbStraY.Checked = False
        cbHMUY.Checked = False
        cbTreY.Checked = False
        cbNaiWaxY.Checked = False
        cbEmp.SelectedIndex = -1
        dpDate.Value = Now.Date
        txtTime.Clear()
    End Sub
#End Region

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            If emptycbx(cbClient, ErrorProvider1) = True Then Return
            If empty2(txtName, ErrorProvider1) = True Then Return
            If emptycbx(cbEmp, ErrorProvider1) = True Then Return
            If emptyline(txtTime, ErrorProvider1) = True Then Return

            If Edata Then
                If MsgBox("Do you really want to book it?", vbQuestion + vbYesNo) = vbYes Then

                    con.Open()
                    cmd = New OleDbCommand("INSERT INTO AppointmentDB ([TYPE],[CLIENT],[HBD], HBDPRI,[HC],HCPRI,[STRA],STRAPRI,[HMU],HMUPRI,[TREAT],TREATPRI,[NAILWAX],NAILWAXPRI,[EMPLOYEE], [APPDATE], [TIME])VALUES(@TYPE,@CLIENT,@HBD,@HBDPRI,@HC,@HCPRI,@STRA,@STRAPRI,@HMU, @HMUPRI,@TREAT, @TREATPRI, @NAILWAX, @NAILWAXPRI,@EMPLOYEE,@APPDATE,@TIME)", con)
                    With cmd
                        .Parameters.AddWithValue("@TYPE", cbClient.Text)
                        .Parameters.AddWithValue("@CLIENT", txtName.Text)
                        If cbBlowY.Checked Then
                            .Parameters.AddWithValue("@HBD", cbBlow.Text)
                            .Parameters.AddWithValue("@HBDPRI", lblBlowPri.Text)
                        Else
                            .Parameters.AddWithValue("@HBD", System.DBNull.Value)
                            .Parameters.AddWithValue("@HBDPRI", 0)
                        End If
                        If cbColorY.Checked Then
                            .Parameters.AddWithValue("@HC", cbColor.Text)
                            .Parameters.AddWithValue("@HCPRI", lblColorPri.Text)
                        Else
                            .Parameters.AddWithValue("@HC", System.DBNull.Value)
                            .Parameters.AddWithValue("@HCPRI", 0)
                        End If
                        If cbStraY.Checked Then
                            .Parameters.AddWithValue("@STRA", cbStra.Text)
                            .Parameters.AddWithValue("@STRAPRI", lblStraPri.Text)
                        Else
                            .Parameters.AddWithValue("@STRA", System.DBNull.Value)
                            .Parameters.AddWithValue("@STRAPRI", 0)
                        End If
                        If cbHMUY.Checked Then
                            .Parameters.AddWithValue("@HMU", cbHMU.Text)
                            .Parameters.AddWithValue("@HMUPRI", lblHMUPri.Text)
                        Else
                            .Parameters.AddWithValue("@HMU", System.DBNull.Value)
                            .Parameters.AddWithValue("@HMUPRI", 0)
                        End If
                        If cbTreY.Checked Then
                            .Parameters.AddWithValue("@TREAT", cbTre.Text)
                            .Parameters.AddWithValue("@TREATPRI", lblTreatPri.Text)
                        Else
                            .Parameters.AddWithValue("@TREAT", System.DBNull.Value)
                            .Parameters.AddWithValue("@TREATPRI", 0)
                        End If
                        If cbNaiWaxY.Checked Then
                            .Parameters.AddWithValue("@NAILWAX", cbNaiWax.Text)
                            .Parameters.AddWithValue("@NAILWAXPRI", lblNaiWaxPri.Text)
                        Else
                            .Parameters.AddWithValue("@NAILWAXPRI", System.DBNull.Value)
                            .Parameters.AddWithValue("@NAILWAXPRI", 0)
                        End If
                        .Parameters.AddWithValue("@EMPLOYEE", cbEmp.Text)
                        .Parameters.AddWithValue("@APPDATE", dpDate.Text)
                        .Parameters.AddWithValue("@TIME", txtTime.Text)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    MsgBox("Booking has been sucessfully appointed.", vbInformation)
                    clear()
                    frmAppointment.loadData()
                End If
            Else
                If MsgBox("Do you really want to update " + txtName.Text + "?", vbQuestion + vbYesNo) = vbYes Then
                    con.Open()
                    cmd = New OleDbCommand("update AppointmentDB set [CLIENT]=@CLIENT,HBD=@HBD,HC=@HC,STRA=@STRA,HMU=@HMU,TREAT=@TREAT,NAILWAX=@NAILWAX,[EMPLOYEE]=@EMPLOYEE,APPDATE=@APPDATE,[TIME]=@TIME where ID=@ID", con)
                    With cmd
                        .Parameters.AddWithValue("@CLIENT", client)
                        .Parameters.AddWithValue("@HBD", cbBlow.Text)
                        .Parameters.AddWithValue("@HC", cbColor.Text)
                        .Parameters.AddWithValue("@STRA", cbStra.Text)
                        .Parameters.AddWithValue("@HMU", cbHMU.Text)
                        .Parameters.AddWithValue("@TREAT", cbTre.Text)
                        .Parameters.AddWithValue("@NAILWAX", cbNaiWax.Text)
                        .Parameters.AddWithValue("@EMPLOYEE", cbEmp.Text)
                        .Parameters.AddWithValue("@APPDATE", dpDate.Text)
                        .Parameters.AddWithValue("@TIME", txtTime.Text)
                        .Parameters.AddWithValue("@ID", idapp)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    MsgBox("Booking has been sucessfully updated.", vbInformation)
                    Me.Dispose()
                    frmAppointment.loadData()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmBookApp_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Dispose()
        End Select
    End Sub

    Private Sub cbBlowY_CheckedChanged(sender As Object, e As EventArgs) Handles cbBlowY.CheckedChanged
        If cbBlowY.Checked = True Then
            cbBlow.Enabled = True
            loadBlow()

        Else
            cbBlow.SelectedIndex = -1
            cbBlow.Enabled = False
            lblBlowPri.Text = "0.00"
        End If
    End Sub

    Private Sub cbNaiWaxY_CheckedChanged(sender As Object, e As EventArgs) Handles cbNaiWaxY.CheckedChanged
        If cbNaiWaxY.Checked = True Then
            cbNaiWax.Enabled = True
            loadNaiWax()
        Else
            cbNaiWax.SelectedIndex = -1
            cbNaiWax.Enabled = False
            lblNaiWaxPri.Text = "0.00"
        End If
    End Sub

    Private Sub cbStraY_CheckedChanged(sender As Object, e As EventArgs) Handles cbStraY.CheckedChanged
        If cbStraY.Checked = True Then
            cbStra.Enabled = True
            loadStra()
        Else
            cbStra.SelectedIndex = -1
            cbStra.Enabled = False
            lblStraPri.Text = "0.00"
        End If
    End Sub

    Private Sub cbHMUY_CheckedChanged(sender As Object, e As EventArgs) Handles cbHMUY.CheckedChanged
        If cbHMUY.Checked = True Then
            cbHMU.Enabled = True
            loadHMU()
        Else
            cbHMU.SelectedIndex = -1
            cbHMU.Enabled = False
            lblHMUPri.Text = "0.00"
        End If
    End Sub

    Private Sub cbTreY_CheckedChanged(sender As Object, e As EventArgs) Handles cbTreY.CheckedChanged
        If cbTreY.Checked = True Then
            cbTre.Enabled = True
            loadTreat()
        Else
            cbTre.SelectedIndex = -1
            cbTre.Enabled = False
            lblTreatPri.Text = "0.00"
        End If
    End Sub

    Private Sub cbColorY_CheckedChanged(sender As Object, e As EventArgs) Handles cbColorY.CheckedChanged
        If cbColorY.Checked = True Then
            cbColor.Enabled = True
            loadColor()
        ElseIf cbColorY.Checked = False Then
            cbColor.SelectedIndex = -1
            cbColor.Enabled = False
            lblColorPri.Text = "0.00"
        End If
    End Sub

    Private Sub cbBlow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBlow.SelectedIndexChanged
        lblBlowPri.Text = Format(getPrice("select SERPRICE from ServiceDB WHERE SERNAME LIKE '" & cbBlow.Text & "'"), "###,###0.00")
    End Sub

    Private Sub cbColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColor.SelectedIndexChanged
        lblColorPri.Text = Format(getPrice("select SERPRICE from ServiceDB WHERE SERNAME LIKE '" & cbColor.Text & "'"), "###,###0.00")
    End Sub

    Private Sub cbStra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStra.SelectedIndexChanged
        lblStraPri.Text = Format(getPrice("select SERPRICE from ServiceDB WHERE SERNAME LIKE '" & cbStra.Text & "'"), "###,###0.00")
    End Sub

    Private Sub cbHMU_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHMU.SelectedIndexChanged
        lblHMUPri.Text = Format(getPrice("select SERPRICE from ServiceDB WHERE SERNAME LIKE '" & cbHMU.Text & "'"), "###,###0.00")
    End Sub

    Private Sub cbTre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTre.SelectedIndexChanged
        lblTreatPri.Text = Format(getPrice("select SERPRICE from ServiceDB WHERE SERNAME LIKE '" & cbTre.Text & "'"), "###,###0.00")
    End Sub

    Private Sub cbNaiWax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNaiWax.SelectedIndexChanged
        lblNaiWaxPri.Text = Format(getPrice("select SERPRICE from ServiceDB WHERE SERNAME LIKE '" & cbNaiWax.Text & "'"), "###,###0.00")
    End Sub
End Class