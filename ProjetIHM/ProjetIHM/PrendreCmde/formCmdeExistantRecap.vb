﻿Public Class formCmdeExistantRecap

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub btnConfirmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmer.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub btnAnnul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnul.Click
        Dim cmde As Commande
        cmde = commandes.getCmde(lblNumCh.Text)
        cmde.annul = True
        writeCmde(cmde)
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub btnRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.Click
        Me.Hide()
        formNumCh.Show()
    End Sub
End Class