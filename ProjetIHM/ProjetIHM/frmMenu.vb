Public Class frmMenu



    Private Sub btnClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClient.Click
        Me.Hide()
        formNumCh.Show()
    End Sub

    Private Sub frmMenu_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call majHeure(sender, e)
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmr.Start()
        Me.Tag = Me.Text
    End Sub

    Private Sub btnHote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHote.Click
        Me.Hide()
        FormBilan.Show()
    End Sub


    Public Sub majHeure(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick
        On Error Resume Next
        ActiveForm.Text = ActiveForm.Tag & " " & Now
    End Sub

    Private Sub btnFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFin.Click
        Me.Hide()
        FormMenuFin.Show()

    End Sub
End Class
