Public Class formSupplements
    Public prix As Single = 0

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        formCmde.retourMenuPrincip(sender, e)
    End Sub

    Private Sub formSupplements_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim supplements() As String = {"Céréales",
                                    "Fromage",
                                    "Oeuf Coque",
                                    "Oeufs au plat",
                                    "Oeufs Brouillés",
                                    "Saumon Fumé",
                                    "Blanc",
                                    "Rouge",
                                    "Bière",
                                    "Champagne"}

        Dim prix() As Single = {1.5, 2.65, 1.8, 1.95, 2.2, 5.5, 25.0, 28.0, 8.0, 55.0}

        Dim i As Integer = 0
        For Each Cb In pnlNoms.Controls
            Cb.Text = supplements(i) & "        " & prix(i)
            Cb.Tag = prix(i)
            i = i + 1
        Next
        i = 0
    End Sub

    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged, CheckBox15.CheckedChanged, CheckBox16.CheckedChanged, CheckBox17.CheckedChanged, CheckBox18.CheckedChanged, CheckBox19.CheckedChanged, CheckBox20.CheckedChanged, CheckBox21.CheckedChanged, CheckBox22.CheckedChanged, CheckBox23.CheckedChanged
        If (sender.Checked) Then
            prix += sender.tag
        Else
            prix -= sender.tag
        End If

        lblPrix.Text = "Prix Total : " & prix
    End Sub

    Private Sub btnRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.Click
        'Suppléments
        Dim Cb As CheckBox
        Dim i As Integer = 0
        For Each Cb In pnlNoms.Controls
            If (Cb.Checked) Then
                commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text)).supplements(commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text)).nbSupplements) = Cb.Text
                commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text)).nbSupplements = commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text)).nbSupplements + 1
            End If
            i = i + 1
        Next

        'Prix
        commandes.cmdeCourante.cmdes(Val(formCmde.lblIndiceCmde.Text)).prix = prix


        Me.Hide()
        formCmde.Show()
    End Sub
End Class