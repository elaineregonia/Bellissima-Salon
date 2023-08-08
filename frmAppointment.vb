Imports System.Data.OleDb
Public Class frmAppointment

#Region "Methods"

    Sub loadData()

        Try
            Dim i As Integer
            dgApp.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("select ID, CLIENT, (HBD & ' ' & STRA & ' ' & HMU & ' ' & TREAT & ' ' & NAILWAX & ' ') as service, EMPLOYEE, APPDATE, TIME,STAT from AppointmentDB where CLIENT like '" & txtSearch.Text & "%' AND STAT like 'Pending'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgApp.Rows.Add(i, dr.Item("ID"), dr.Item("CLIENT").ToString, dr.Item("service").ToString, dr.Item("EMPLOYEE").ToString, CDate(dr.Item("APPDATE")).ToShortDateString, dr.Item("TIME").ToString, dr.Item("STAT"))
                dgApp.ClearSelection()
                'lblTotEmp.Text = dgApp.Rows.Count
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)

        End Try
    End Sub


#End Region

    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'frmBilling.srch(txtSearch)
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        With frmBookApp
            Edata = True
            .loadEmp()
            .ShowDialog()
        End With
    End Sub

    Private Sub dgApp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgApp.CellContentClick
        Try
            Dim colname As String = dgApp.Columns(e.ColumnIndex).Name
            If colname = "colEdit" Then
                'FOR EDITING DATA
                Edata = False
                Try
                    con.Open()
                    cmd = New OleDbCommand("select TYPE, CLIENT, EMPLOYEE, APPDATE, TIME, HBD,HC,STRA,HMU,TREAT,NAILWAX from AppointmentDB", con)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then

                        With frmBookApp
                            .lbl.Text = "Edit Appointment"
                            .idapp = dgApp.Rows(e.RowIndex).Cells(1).Value.ToString
                            .cbClient.Text = dr.Item("TYPE")
                            .txtName.Text = dr.Item("CLIENT")
                            .cbEmp.Text = dr.Item("EMPLOYEE")
                            .dpDate.Text = dr.Item("APPDATE")
                            .txtTime.Text = dr.Item("TIME")
                        End With
                    End If
                    con.Close()
                Catch ex As Exception
                    con.Close()
                    MsgBox(ex.Message)
                End Try
                With frmBookApp
                    .loadEmp()
                    .ShowDialog()
                End With
            ElseIf colname = "colDel" Then
                'REMOVING DATA
                If MsgBox("Are you sure you want to remove " + dgApp.Rows(e.RowIndex).Cells(2).Value.ToString + "?", vbYesNo + vbQuestion) = vbYes Then

                    con.Open()
                    cmd = New OleDbCommand("DELETE FROM AppointmentDB WHERE ID LIKE '" & dgApp.SelectedCells(1).Value & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record has been successfully delete.", vbInformation)
                    loadData()
                Else
                    MsgBox("Cancelled.", vbExclamation)
                End If
            ElseIf colname = "colAdd" Then
                opencon()
                frmBilling.search(dgApp.SelectedCells(2).Value)
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadData 
    End Sub

    Private Sub frmAppointment_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Dispose()
        End Select
    End Sub

    Private Sub btnDisp_Click(sender As Object, e As EventArgs) Handles btnDisp.Click
        Me.Dispose()
    End Sub
End Class