Public Class FormMenuFin

    Private Sub ButtonNoCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNoCom.Click
        Me.Hide()
        FormNoCommand.Show()
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Hide()
        FormCancel.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChCmde.Click
        Me.Hide()
        FormCommandeFin.Show()
    End Sub

    Private Sub ButtonRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        frmMenu.Show()

    End Sub

    Private Sub ButtonQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuit.Click
        Application.Exit()
    End Sub

    Private Sub FormMenuFin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call frmMenu.majHeure(sender, e)
    End Sub

    Private Sub FormMenuFin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = Me.Text
    End Sub
End Class