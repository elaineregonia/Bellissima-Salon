Imports System.Data.OleDb
Public Class frmClients
    Private Sub frmClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "Methods"

    Sub loadData()

        Try
            Dim i As Integer
            dgClients.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from ClientsDB where FNAME like '" & txtSearch.Text & "%'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgClients.Rows.Add(i, dr.Item("ID").ToString, dr.Item("FNAME").ToString, dr.Item("ADDRESS").ToString, dr.Item("EMAIL").ToString, dr.Item("CONTACTNUMBER").ToString, dr.Item("FIRSTIN").ToString)
                dgClients.ClearSelection()
                lblTotEmp.Text = dgClients.Rows.Count
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
#End Region

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        With frmAddClient
            Edata = True
            .lbl.Text = "ADD CLIENT"
            .txtName.Select()
            .clear()
            .ShowDialog()
        End With
    End Sub

    Private Sub dgClients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClients.CellContentClick

        Try
            Dim colname As String = dgClients.Columns(e.ColumnIndex).Name
            If colname = "colEdit" Then
                'FOR EDITING DATA
                Edata = False
                With frmAddClient
                    .lbl.Text = "EDIT CLIENT"
                    .idcli = dgClients.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtName.Text = dgClients.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtAddress.Text = dgClients.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtEmail.Text = dgClients.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtConNum.Text = dgClients.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtFirstIn.Text = dgClients.Rows(e.RowIndex).Cells(6).Value.ToString
                    .ShowDialog()
                End With
            ElseIf colname = "colDel" Then
                'REMOVING DATA
                If MsgBox("Are you sure you want to remove " + dgClients.Rows(e.RowIndex).Cells(2).Value.ToString + "?", vbYesNo + vbQuestion) = vbYes Then

                    con.Open()
                    cmd = New OleDbCommand("DELETE FROM ClientsDB WHERE ID LIKE '" & dgClients.SelectedCells(1).Value & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record has been successfully delete.", vbInformation)
                    loadData()
                Else
                    MsgBox("Cancelled.", vbExclamation)
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