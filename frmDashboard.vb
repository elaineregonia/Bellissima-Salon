Imports System.Data.OleDb
Imports System.IO.File
Imports System.IO.FileStream
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tmDate.Start()

        Try

            reloadtxt("SELECT * FROM LoginDB")
            If dt.Rows.Count > 0 Then
                lblAllEmp.Text = dt.Rows.Count.ToString
            Else
                lblAllEmp.Text = ""
            End If
        Catch ex As Exception

        End Try

        Try
            reloadtxt("SELECT * FROM AttendanceDB WHERE LDATE LIKE '" & Date.Now.ToShortDateString & "' ")
            If dt.Rows.Count > 0 Then
                lblPresTod.Text = dt.Rows.Count.ToString
            Else
                lblPresTod.Text = "0"
            End If
        Catch ex As Exception

        End Try

        Try
            reloadtxt("SELECT * FROM AppointmentDB WHERE APPDATE LIKE '" & Date.Now.ToLongDateString & "' ")
            If dt.Rows.Count > 0 Then
                lblAppTod.Text = dt.Rows.Count.ToString
            Else
                lblAppTod.Text = "0"
            End If
        Catch ex As Exception

        End Try

        Try
            con.Open()
            cmd = New OleDbCommand("SELECT SUM(CASH) AS SUMCASH from PaymentDB", con)
            dr = cmd.ExecuteReader
            While dr.Read

                lblTotSales.Text = Format(dr.Item("SUMCASH"), "#,##0.00")

            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Sub toCSV(Sql As String, fname As String)
        Dim i, j As Integer

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        con.Open()
        Dim cmd As New OleDbDataAdapter(Sql, con)
        Dim ds As New DataSet
        cmd.Fill(ds)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                xlWorkSheet.Cells(i + 1, j + 1) =
                ds.Tables(0).Rows(i).Item(j)
            Next
        Next
        con.Close()
        Try
            Dim fbd As New FolderBrowserDialog

            If fbd.ShowDialog() = vbOK Then
                xlWorkSheet.SaveAs(fbd.SelectedPath & fname)

                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                MessageBox.Show("Succcessfully exported to Excel file!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub tmDate_Tick(sender As Object, e As EventArgs) Handles tmDate.Tick
        lblDate.Text = Date.Now.ToString("dddd, MMMM dd yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub pbCSV_Click(sender As Object, e As EventArgs) Handles pbCSV.Click
        toCSV("SELECT * FROM PaymentDB", "\Reports.xlsx")
    End Sub

    Private Sub pbCSVAtte_Click(sender As Object, e As EventArgs) Handles pbCSVAtte.Click
        toCSV("SELECT * FROM AttendanceDB", "\Attendance.xlsx")
    End Sub
End Class