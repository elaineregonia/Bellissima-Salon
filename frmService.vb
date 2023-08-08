Imports System.Data.OleDb
Public Class frmService

    Private Sub frmService_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "Methods"

    Sub loadData()

        Try
            Dim i As Integer
            dgSer.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from ServiceDB where SERNAME like '" & txtSearch.Text & "%'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgSer.Rows.Add(i, dr.Item("ID").ToString, dr.Item("SERNAME").ToString, dr.Item("SERCATE").ToString, dr.Item("SERPRICE").ToString, dr.Item("ESTTIME").ToString)
                dgSer.ClearSelection()
                'lblTotEmp.Text = dgApp.Rows.Count
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

#End Region

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmAddSer
            Edata = True
            .ShowDialog()
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadData()
    End Sub

    Private Sub dgSer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSer.CellContentClick
        Dim success As Boolean = False
        Try
            Dim colname As String = dgSer.Columns(e.ColumnIndex).Name
            If colname = "colEdit" Then
                'FOR EDITING DATA
                Edata = False
                With frmAddSer
                    .lbl.Text = "Edit Service"
                    .idser = dgSer.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtSerName.Text = dgSer.Rows(e.RowIndex).Cells(2).Value.ToString
                    .cbCategory.Text = dgSer.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtPrice.Text = dgSer.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtEstTime.Text = dgSer.Rows(e.RowIndex).Cells(5).Value.ToString
                    .ShowDialog()
                End With
            ElseIf colname = "colDel" Then
                'REMOVING DATA
                'If dgEmpMan.Rows(e.RowIndex).Cells(9).Value = "Admin" Then Return
                If MsgBox("Are you sure you want to remove " + dgSer.Rows(e.RowIndex).Cells(2).Value.ToString + "?", vbYesNo + vbQuestion) = vbYes Then

                    con.Open()
                    cmd = New OleDbCommand("DELETE FROM ServiceDB WHERE ID LIKE '" & dgSer.SelectedCells(1).Value & "'", con)
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


End Class