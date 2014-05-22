Public Class formCmdeRecap

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmMenu.Show()

    End Sub

    Private Sub btnRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.Click
        

        commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text) - 1).clear()

        Me.Hide()
        formCmde.Show()
    End Sub

    Private Sub btnConfirmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmer.Click
        If (Val(formCmde.lblIndiceCmde.Text) < Val(formCmde.lbNbCmde.Text)) Then
            formCmde.lblIndiceCmde.Text = formCmde.lblIndiceCmde.Text + 1
            Call btnRetour_Click(sender, e)

        Else
            'Test a enlever
            Dim writer As New System.IO.StreamWriter("Cmdes.txt")
            writeCmde(writer, commandes.cmdeCourante)
            writer.Close()

            commandes.cmdes.Add(commandes.cmdeCourante)
            Me.Hide()
            frmMenu.Show()

            'Reset des forms a rajouter ici


        End If

    End Sub
End Class