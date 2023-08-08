Imports System.Data.OleDb

Public Class frmReports

#Region "Methods"

    Sub loadData()

        Try
            Dim i As Integer
            dgRep.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("select * from PaymentDB where CUSNAME like '" & txtSearch.Text & "%'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgRep.Rows.Add(i, dr.Item("INVOICE").ToString, dr.Item("CUSNAME").ToString, dr.Item("SERVICE").ToString, dr.Item("SDATE").ToString)
                dgRep.ClearSelection()
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Sub loadCurrency()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT SUM(SUBTOT) AS SUMSUBTOT, SUM(ATOTAL) AS SUMTOT, SUM(VAT) AS SUMVAT, SUM(CASH) AS SUMCASH, SUM(DISCOUNT) AS SUMDISC  from PaymentDB", con)
            dr = cmd.ExecuteReader
            While dr.Read

                lblTot.Text = Format(dr.Item("SUMTOT"), "#,##0.00")
                lblDis.Text = Format(dr.Item("SUMDISC"), "#,##0.00")
                lblSubTot.Text = Format(dr.Item("SUMSUBTOT"), "#,##0.00")
                lblVat.Text = Format(dr.Item("SUMVAT"), "#,##0.00")
                lblTotSales.Text = Format(dr.Item("SUMCASH"), "#,##0.00")

            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Sub dailySales()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT SUM(ATOTAL) AS SUMTOT from PaymentDB WHERE SDATE LIKE '" & Now.Date.ToShortDateString & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read

                If dr.Item("SUMTOT") Is System.DBNull.Value Then
                    lblDaily.Text = "0.00"
                Else
                    lblDaily.Text = Format(dr.Item("SUMTOT"), "#,##0.00")
                End If


            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        con.Close()
        End Try
    End Sub

#End Region
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadData()
    End Sub

End Class