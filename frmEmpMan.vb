Imports System.Data.OleDb
Public Class frmEmpMan
    Private Sub frmEmpMan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "Methods"

    Sub loadData()


        Try
            Dim i As Integer
            dgEmpMan.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from LoginDB where FULLNAME like '" & txtSearch.Text & "%'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim empimage() As Byte = dr.Item("PIC")
                Dim ms As New System.IO.MemoryStream(empimage)
                Dim image As Image = Image.FromStream(ms, True)
                i += 1
                dgEmpMan.Rows.Add(i, dr.Item("ID").ToString, dr.Item("FULLNAME").ToString, dr.Item("ADDRESS").ToString, dr.Item("GENDER").ToString, dr.Item("EMAIL").ToString, dr.Item("CONTACTNUMBER").ToString, dr.Item("USERNAME").ToString, dr.Item("PASSWORD").ToString, dr.Item("USERTYPE").ToString, image)
                dgEmpMan.ClearSelection()
                lblTotEmp.Text = dgEmpMan.Rows.Count
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
#End Region

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        With frmAddEmp
            Edata = True
            .lbl.Text = "Add Employee"
            .txtName.Select()
            .cbUT.SelectedIndex = -1
            .autoID()
            .loadUsertype()
            .clear()
            .ShowDialog()
        End With
    End Sub

    Private Sub dgEmpMan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpMan.CellContentClick

        Try
            Dim colname As String = dgEmpMan.Columns(e.ColumnIndex).Name
            If colname = "colEdit" Then
                'FOR EDITING DATA
                Edata = False
                With frmAddEmp
                    .lbl.Text = "Edit Employee"
                    .txtUID.Text = dgEmpMan.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtName.Text = dgEmpMan.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtAddress.Text = dgEmpMan.Rows(e.RowIndex).Cells(3).Value.ToString
                    .cbGender.Text = dgEmpMan.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtEmail.Text = dgEmpMan.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtConNum.Text = dgEmpMan.Rows(e.RowIndex).Cells(6).Value.ToString
                    .txtUN.Text = dgEmpMan.Rows(e.RowIndex).Cells(7).Value.ToString
                    .txtPW.Text = dgEmpMan.Rows(e.RowIndex).Cells(8).Value.ToString
                    .cbUT.Text = dgEmpMan.Rows(e.RowIndex).Cells(9).Value.ToString
                    .pbImage.Image = CType(dgEmpMan.Rows(e.RowIndex).Cells(10).Value, Image)
                    .ShowDialog()
                End With
            ElseIf colname = "colDel" Then
                'REMOVING DATA
                'If dgEmpMan.Rows(e.RowIndex).Cells(9).Value = "Admin" Then Return
                If dgEmpMan.Rows(e.RowIndex).Cells(2).Value.ToString = frmAdminMain.lblName.Text Then
                    MsgBox("You cannot delete it while your account is open.", vbExclamation)
                Else
                    If MsgBox("Are you sure you want to remove " + dgEmpMan.Rows(e.RowIndex).Cells(2).Value.ToString + "?", vbYesNo + vbQuestion) = vbYes Then

                        con.Open()
                        cmd = New OleDbCommand("DELETE FROM LoginDB WHERE ID LIKE '" & dgEmpMan.SelectedCells(1).Value & "'", con)
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MsgBox("Record has been successfully delete.", vbInformation)
                        loadData()
                    Else
                        MsgBox("Cancelled.", vbExclamation)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadData()
    End Sub
End Class