Public Class frmAdminMain
    Private Sub frmAdminMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        btnDash_CheckedChanged(Nothing, Nothing)

        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnBody, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
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

    Private Sub btnEmpMan_CheckedChanged(sender As Object, e As EventArgs) Handles btnEmpMan.CheckedChanged
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmEmpMan.Name Then Return
        Next

        closeForm()
        With frmEmpMan
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmEmpMan)
            .loadData()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub pnlMain_Resize(sender As Object, e As EventArgs) Handles pnlMain.Resize
        For Each f As Form In pnlMain.Controls
            f.Width = pnlMain.Width
            f.Height = pnlMain.Height
        Next
    End Sub

    Private Sub pbAdown_Click(sender As Object, e As EventArgs) Handles pbAdown.Click

        If pnlExpand.Visible = False Then
            pnlExpand.Visible = True 
        Else
            pnlExpand.Visible = False
        End If

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

    Private Sub btnSeeProf_Click(sender As Object, e As EventArgs) Handles btnSeeProf.Click
        pnlExpand.Hide()
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

    Private Sub btnLogHis_CheckedChanged(sender As Object, e As EventArgs) Handles btnLogHis.CheckedChanged
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmLogHis.Name Then Return
        Next

        closeForm()
        With frmLogHis
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmLogHis)
            .loadall()
            .Show()
        End With
    End Sub

    Private Sub btnDash_CheckedChanged(sender As Object, e As EventArgs) Handles btnDash.CheckedChanged
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmDashboard.Name Then Return
        Next

        closeForm()
        With frmDashboard
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmDashboard)
            .Show()
        End With
    End Sub

    Private Sub btnSer_CheckedChanged(sender As Object, e As EventArgs) Handles btnSer.CheckedChanged
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmService.Name Then Return
        Next

        closeForm()
        With frmService
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmService)
            .Show()
        End With
    End Sub

    Private Sub btnRep_CheckedChanged(sender As Object, e As EventArgs) Handles btnRep.CheckedChanged
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmReports.Name Then Return
        Next

        closeForm()
        With frmReports
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmReports)
            .loadData()
            .loadCurrency()
            .dailySales()
            .Show()
        End With
    End Sub

End Class