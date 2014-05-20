Public Class frmMenu



    Private Sub btnClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClient.Click
        Me.Hide()
        formNumCh.Show()
    End Sub


    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        commandes.cmdeCourante.cmdes(0) = New DetailCommande
        commandes.cmdeCourante.cmdes(1) = New DetailCommande
        commandes.cmdeCourante.cmdes(2) = New DetailCommande
        commandes.cmdeCourante.cmdes(3) = New DetailCommande

        commandes.cmdeCourante.cmdes(0).supplements(0) = New String("")
        commandes.cmdeCourante.cmdes(0).supplements(1) = New String("")
        commandes.cmdeCourante.cmdes(0).supplements(2) = New String("")
        commandes.cmdeCourante.cmdes(0).supplements(3) = New String("")
    End Sub
End Class
