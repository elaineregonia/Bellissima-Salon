Public Class frmEmpMain

    Private Sub frmEmpMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        btnHome_Click(sender, e)
    End Sub

#Region "Methods"

    Sub closeForm()

        For Each form In pnlMain.Controls.OfType(Of Form).ToList()
            form.Close()
        Next
    End Sub
#End Region

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Dispose()
        With frmLogin
            .Show()
            .txtUN.Focus()
            .cbCam.SelectedIndex = 0
            .cbCam_SelectedIndexChanged(Nothing, Nothing)
        End With
    End Sub

    Private Sub pbMenu_Click(sender As Object, e As EventArgs) Handles pbMenu.Click
        If pnlMenu.Width = 45 Then
            pnlMenu.Width = 253
        ElseIf pnlMenu.Width = 253 Then
            pnlMenu.Width = 45
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblLog.Text = Date.Now.ToString("MM-dd-yyyy hh:mm:ss tt")
    End Sub

    Private Sub pnlMain_Resize(sender As Object, e As EventArgs) Handles pnlMain.Resize
        For Each f As Form In pnlMain.Controls
            f.Width = pnlMain.Width
            f.Height = pnlMain.Height
        Next
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        For Each f As Form In My.Application.OpenForms
            If f.Name = frmEmpHome.Name Then Return
        Next

        closeForm()

        With frmEmpHome
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmEmpHome)
            .tmLoadData.Start()
            .Show()
        End With
    End Sub

    Private Sub btnAttend_Click(sender As Object, e As EventArgs) Handles btnAttend.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmEmpAD.Name Then Return
        Next
        closeForm()
        With frmEmpAD
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmEmpAD)
            .loadAll()
            .Show()
        End With
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmProfile.Name Then Return
        Next
        closeForm()
        With frmProfile
            .Width = pnlMain.Width
            .Height = pnlMain.Height
            .TopLevel = False
            pnlMain.Controls.Add(frmProfile)
            .pnlTop.BackColor = System.Drawing.Color.FromArgb(247, 191, 210)
            .loadData(lblID.Text)
            .Show()
        End With
    End Sub
End Class