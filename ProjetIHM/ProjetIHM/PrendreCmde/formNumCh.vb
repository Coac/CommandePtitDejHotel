Public Class formNumCh

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmMenu.Show()

    End Sub

    Private Sub txtboxNumCh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxNumCh.KeyPress
        If (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            Exit Sub
        End If
        e.KeyChar = Chr(0)
    End Sub


    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click
        If txtboxNumCh.Text.Length <= 2 Then
            MsgBox("Il manque des chiffres.")
            txtboxNumCh.Focus()
            Exit Sub
        End If


        Dim numChambre As String = ""
        numChambre += txtboxNumCh.Text.Chars(1) & txtboxNumCh.Text.Chars(2)

        If txtboxNumCh.Text.Chars(0) < "1" Or txtboxNumCh.Text.Chars(0) > "6" Or numChambre < 1 Or numChambre > 16 Then
            MsgBox("La chambre n'existe pas.")
            txtboxNumCh.Focus()
            Exit Sub
        End If


        For Each cmde As Commande In commandes.cmdes
            If cmde.numCh = Val(txtboxNumCh.Text) Then
                If cmde.annul = True Then
                    MsgBox("La commande pour cette chambre a été annulée")
                    Exit Sub
                End If

                formCmdeExistantRecap.lblNom.Text = cmde.nom
                formCmdeExistantRecap.lblPrenom.Text = cmde.prenom
                formCmdeExistantRecap.lblNumCh.Text = cmde.numCh
                formCmdeExistantRecap.lblNbPtiDej.Text = cmde.cmdes.Count

                If (commandes.cmdeCourante.lieu = 0) Then
                    formCmdeExistantRecap.lblLieu.Text = "Vous avez prévu de manger en Salle"

                Else
                    formCmdeExistantRecap.lblLieu.Text = "Votre commande va vous être livré dans votre chambre à " & commandes.cmdeCourante.lieu \ 60 & "h" & commandes.cmdeCourante.lieu Mod 60
                End If

                formCmdeExistantRecap.lblNumCh.Tag = cmde

                Me.Hide()
                formCmdeExistantRecap.Show()
                Exit Sub
            End If
        Next


        formPreCmde.lblNumCh.Text = txtboxNumCh.Text


        'Numero de Chambre
        commandes.cmdeCourante.numCh = Val(txtboxNumCh.Text)


        Me.Hide()
        formPreCmde.Show()


    End Sub

    Sub clear()
        txtboxNumCh.Text = ""
    End Sub

End Class