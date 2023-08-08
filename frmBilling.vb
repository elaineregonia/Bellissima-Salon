Imports System.Data.OleDb
Imports Guna.UI2.WinForms
Public Class frmBilling

    Dim sdate As String = Now.ToString("yyyyMMdd")
    Public custype As String
    Dim id_, client_, ser_, subtot_ As String

    Private Sub frmBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tmDate.Start()
    End Sub

#Region "Methods"

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Width = Screen.GetWorkingArea(Me).Width
        Me.Height = Screen.GetWorkingArea(Me).Height + 1
    End Sub

    Sub autoIV()

        Try
            con.Open()
            cmd = New OleDbCommand("select INVOICE from PaymentDB ORDER BY INVOICE DESC", con)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                lblInvoNum.Text = Val(dr(0)) + 1
            Else
                lblInvoNum.Text = sdate + "00001"
            End If
            'con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            cmd.Dispose()
            con.Close()
        End Try

    End Sub

    Sub loadCart()
        Try
            Dim i As Integer
            dgPay.Rows.Clear()
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM PaymentDB WHERE INVOICE='" & lblInvoNum.Text & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgPay.Rows.Add(i, lblInvoNum.Text, dr.Item("CUSNAME").ToString, dr.Item("SERVICE").ToString, dr.Item("PRICE"))
                dgPay.ClearSelection()
                compute()
            End While
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub updateStat()
        Try
            con.Open()
            cmd = New OleDbCommand("UPDATE AppointmentDB SET STAT= 'Pending' WHERE CLIENT = '" & dgPay.SelectedCells(2).Value.ToString & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    Sub search(name As String)
        Try
            con.Open()
            If name = String.Empty Then Return
            cmd = New OleDbCommand("SELECT * FROM AppointmentDB WHERE CLIENT='" & name & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                With frmConfirmPay
                    .lblName.Text = dr.Item("CLIENT").ToString
                    .lblAllSer.Text = dr.Item("ALLSER").ToString
                    .lblSubTot.Text = dr.Item("SUBTOT")
                    dr.Close()
                    con.Close()
                    .ShowDialog()
                End With
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub srch(name As Guna2TextBox)
        Try
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter("SELECT CLIENT FROM AppointmentDB", con)
            da.Fill(dt)
            Dim r As DataRow
            name.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                name.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next

            name.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            name.AutoCompleteSource = AutoCompleteSource.CustomSource
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub compute()
        Dim vat As Decimal = Total() * 0.12
        Dim totalpay, senior, pwd As Decimal
        Dim discounts As Decimal
        Dim iTotal As Decimal
        Dim iDiscount As Decimal
        Dim bFlag

        bFlag = Decimal.TryParse(lblDisc.Text.Trim(), iDiscount)
        bFlag = Decimal.TryParse(Total, iTotal)

        If dgPay.Rows.Count > 0 Then

            lblVat.Text = vat.ToString("₱0.00")
            'lblVat.Font = New Font("Fake Receipt", 12, FontStyle.Regular)
            'lblVat.Location = New Point(167, 15)
            lblDisc.Text = "₱0.00"
            lblSubTot.Text = Total().ToString("₱0.00")
            totalpay = Total() + vat
            lblPayAmo.Text = totalpay.ToString("₱0.00")
            lblTot.Text = lblPayAmo.Text

            If custype = "PWD" Then

                discounts = iTotal * 0.2
                lblVat.Text = "₱0.00"
                'lblVat.Font = New Font("Fake Receipt", 10, FontStyle.Regular)
                'lblVat.Location = New Point(124, 18)
                lblDisc.Text = discounts.ToString("₱0.00")
                pwd = iTotal - discounts
                lblPayAmo.Text = pwd.ToString("₱0.00")
                lblTot.Text = lblPayAmo.Text
                'custype = "PWD"

            ElseIf custype = "Senior" Then

                discounts = iTotal * 0.2
                lblVat.Text = "₱0.00"
                'lblVat.Font = New Font("Fake Receipt", 10, FontStyle.Regular)
                'lblVat.Location = New Point(124, 18)
                lblDisc.Text = discounts.ToString("₱0.00")
                senior = iTotal - discounts
                lblPayAmo.Text = senior.ToString("₱0.00")
                lblTot.Text = lblPayAmo.Text
                'custype = "Senior"

            ElseIf custype = "Regular" Then

                lblDisc.Text = "₱0.00"
                lblVat.Text = vat.ToString("₱0.00")
                'lblVat.Font = New Font("Fake Receipt", 12, FontStyle.Regular)
                'lblVat.Location = New Point(167, 15)
                totalpay = Total() + vat
                lblPayAmo.Text = totalpay.ToString("₱0.00")
                lblTot.Text = lblPayAmo.Text
                'custype = "Regular"

            End If

        Else
            lblVat.Text = "₱0.00"
            'lblVat.Font = New Font("Fake Receipt", 12, FontStyle.Regular)
            'lblVat.Location = New Point(167, 15)
            lblDisc.Text = "₱0.00"
            lblSubTot.Text = Total().ToString("₱0.00")
            lblPayAmo.Text = totalpay.ToString("₱0.00")
            lblTot.Text = lblPayAmo.Text
            'custype = "Regular"
        End If

    End Sub

    Private Function Total() As Double
        Dim tot As Double = 0
        Dim i As Integer = 0

        For i = 0 To dgPay.Rows.Count - 1
            tot += Convert.ToDouble(dgPay.Rows(i).Cells(4).Value)
        Next i
        Return tot


    End Function

#End Region

    Private Sub tmDate_Tick(sender As Object, e As EventArgs) Handles tmDate.Tick
        lblDate.Text = Date.Now.ToString("dddd, MMMM dd yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
        With frmRecepMain
            .btnHome_Click(sender, e)
            .Show()
        End With
    End Sub

    Sub btnNewTran_Click(sender As Object, e As EventArgs) Handles btnNewTran.Click

        If dgPay.Rows.Count > 0 Then
            MsgBox("There is a current transaction. Try again later.", vbInformation)
        Else
            autoIV()
        End If

    End Sub

    Private Sub frmBilling_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                btnNewTran_Click(Nothing, Nothing)
            Case Keys.F2
                btnApp_Click(Nothing, Nothing)
            Case Keys.F3
                btnDisc_Click(Nothing, Nothing)
            Case Keys.F4
                btnPay_Click(sender, e)
            Case Keys.Escape
                Me.Dispose()
                With frmRecepMain
                    .btnHome_Click(sender, e)
                    .Show()
                End With
        End Select
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        If dgPay.Rows.Count > 0 Then
            With frmPayment
                .lblTotal.Text = lblTot.Text
                .txtCash.Select()
                .ShowDialog()
            End With
        Else
            MsgBox("Cart is empty put something in first.", vbExclamation)
        End If
    End Sub

    Private Sub dgPay_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPay.CellContentClick
        Try
            Dim colname As String = dgPay.Columns(e.ColumnIndex).Name
            If colname = "colDel" Then
                'REMOVING DATA
                'If dgEmpMan.Rows(e.RowIndex).Cells(9).Value = "Admin" Then Return
                If MsgBox("Are you sure you want to remove " + dgPay.Rows(e.RowIndex).Cells(2).Value.ToString + "?", vbYesNo + vbQuestion) = vbYes Then

                    con.Open()
                    cmd = New OleDbCommand("DELETE FROM PaymentDB WHERE INVOICE LIKE '" & dgPay.SelectedCells(1).Value & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record has been successfully delete.", vbInformation)
                    loadCart()
                    updateStat()
                    compute()
                Else
                    MsgBox("Cancelled.", vbExclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        con.Close()
        End Try
    End Sub

    Private Sub btnApp_Click(sender As Object, e As EventArgs) Handles btnApp.Click
        With frmAppointment
            .Show()
            .txtSearch.Size = New Size(965, 35)
            .btnBook.Visible = False
            .btnClose.Visible = False
            .btnDisp.Visible = True
            .colEdit.Visible = False
            .colDel.Visible = False
            .colAdd.Visible = True
            .GunaElipse1.Radius = 20
            Guna.UI.Lib.GraphicsHelper.ShadowForm(frmAppointment)
        End With
    End Sub

    Private Sub btnDisc_Click(sender As Object, e As EventArgs) Handles btnDisc.Click
        If dgPay.Rows.Count > 0 Then
            With frmDiscount
                .cbDis.SelectedIndex = 0
                .lblDis.Text = 0%
                .ShowDialog()
            End With
        Else
            MsgBox("Cart is empty put something in first.", vbExclamation)
        End If
    End Sub

    Private Sub frmBilling_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'srch(txtSearch)
    End Sub
End Class