Public Class formCmdeRecap

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmMenu.Show()

    End Sub

    Private Sub btnRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.Click
        

        commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text) - 1).clear()
        Me.clear()


        Me.Hide()
        formCmde.Show()
    End Sub

    Private Sub btnConfirmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmer.Click
        Dim reponse As Integer

        If (Val(formCmde.lblIndiceCmde.Text) < Val(formCmde.lbNbCmde.Text)) Then
            reponse = MsgBox("Confirmer ce petit déjeuner ?", vbYesNo, "Confirmation")
            If reponse = vbYes Then
                formCmde.lblIndiceCmde.Text = formCmde.lblIndiceCmde.Text + 1
                Call btnRetour_Click(sender, e)
            End If
        Else

            reponse = MsgBox("Vous allez confirmer la commande, voulez vous continuer ?", vbYesNo, "Confirmation")
            If reponse = vbYes Then


                


                'Ajout de la commande dans la liste
                commandes.cmdes.Add(commandes.cmdeCourante.clone())
                commandes.cmdeCourante.clear()

                'Enregistrement des commandes dans un fichier
                commandes.engegistrerCmdeFichier()

                Me.Hide()
                frmMenu.Show()
                Me.clear()
                formCmde.clear()
                formPreCmde.clear()
                formNumCh.clear()
                formSupplements.clear()
            End If

        End If

    End Sub

    Private Sub formCmdeRecap_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Clear
        Me.clear()


        lblNom.Text = commandes.cmdeCourante.nom
        lblPrenom.Text = commandes.cmdeCourante.prenom
        lblNumCh.Text = commandes.cmdeCourante.numCh
        lblNbPtiDej.Text = formCmde.lbNbCmde.Text

        If (commandes.cmdeCourante.lieu = 0) Then
            lblLieu.Text = "Vous avez prévu de manger en Salle"

        Else
            lblLieu.Text = "Votre commande va vous être livré dans votre chambre à " & commandes.cmdeCourante.lieu \ 60 & "h" & commandes.cmdeCourante.lieu Mod 60
        End If


        lblBoissonChaude.Text = commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text) - 1).boissonChaude
        lblBoissonFroide.Text = commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text) - 1).boissonFroide

        For Each viennoi As String In commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text) - 1).viennoiseries
            lbViennoi.Items.Add(viennoi)
        Next

        For Each accomo As String In commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text) - 1).accodements
            lbAccom.Items.Add(accomo)
        Next

        For Each supp As String In commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text) - 1).supplements
            lbSupp.Items.Add(supp)
        Next

    End Sub

    Sub clear()
        lbViennoi.Items.Clear()
        lbAccom.Items.Clear()
        lbSupp.Items.Clear()
    End Sub

    Private Sub formCmdeRecap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class