Public Class frmRecepMain
    Private Sub frmRecepMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        Timer1.Start()
        btnHome_Click(Nothing, Nothing)
    End Sub

#Region "Methods"
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Width = Screen.GetWorkingArea(Me).Width
        Me.Height = Screen.GetWorkingArea(Me).Height + 1
    End Sub

    Sub closeForm()

        For Each form In pnlMain.Controls.OfType(Of Form).ToList()
            form.Close()
        Next
    End Sub
#End Region

    Private Sub pbMenu_Click(sender As Object, e As EventArgs) Handles pbMenu.Click
        If pnlMenu.Width = 45 Then
            pnlMenu.Width = 253S
        ElseIf pnlMenu.Width = 253 Then
            pnlMenu.Width = 45
        End If
    End Sub

    Private Sub pnlMain_Resize(sender As Object, e As EventArgs) Handles pnlMain.Resize
        For Each f As Form In pnlMain.Controls
            f.Width = pnlMain.Width
            f.Height = pnlMain.Height
        Next
    End Sub

    Private Sub btnApp_Click(sender As Object, e As EventArgs) Handles btnApp.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmAppointment.Name Then Return
        Next
        closeForm()

        With frmAppointment
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmAppointment)
            .loadData()
            .Show()
        End With
    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmClients.Name Then Return
        Next
        closeForm()
        With frmClients
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmClients)
            .loadData()
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmRecepHome.Name Then Return
        Next

        closeForm()

        With frmRecepHome
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmRecepHome)
            .pnlTop.BackColor = System.Drawing.Color.FromArgb(0, 185, 198)
            .tmLoadData.Start()
            .Show()
        End With
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Me.Hide()

        With frmBilling
            .autoIV()
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Dispose()
        With frmLogin
            .Show()
            .txtUN.Focus()
            .cbCam.SelectedIndex = 0
            .cbCam_SelectedIndexChanged(Nothing, Nothing)
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblLog.Text = Date.Now.ToString("MM-dd-yyyy hh:mm:ss tt")
    End Sub

    Private Sub btnPro_Click(sender As Object, e As EventArgs) Handles btnPro.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmProfile.Name Then Return
        Next
        closeForm()
        With frmProfile
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmProfile)
            .loadData(lblID.Text)
            .Show()
        End With
    End Sub
End Class