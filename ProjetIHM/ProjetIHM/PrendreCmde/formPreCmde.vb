Public Class formPreCmde

    Private Sub txtNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress, txtPrenom.KeyPress
        If (e.KeyChar >= "A" And e.KeyChar <= "z" Or e.KeyChar = vbBack Or e.KeyChar = " ") Then
            e.KeyChar = StrConv(e.KeyChar, vbUpperCase)
            Exit Sub
        End If
        e.KeyChar = Chr(0)
    End Sub


    Private Sub txtNom_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNom.LostFocus, txtPrenom.LostFocus
        sender.Text = StrConv(sender.Text, vbUpperCase)
        sender.Text = Trim(sender.Text)
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub formPreCmde_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call frmMenu.majHeure(sender, e)
    End Sub

    Private Sub formPreCmde_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = Me.Text
        Dim tab() As Integer = {1, 2, 3, 4}
        cbNbPtitDej.DataSource = tab

        cbNbPtitDej.SelectedIndex = 0

        hsbHeure.LargeChange = 12
        hsbHeure.Minimum = 6 * 60 / 5
        hsbHeure.Maximum = 9 * 60 / 5 + 9 'Le plus 9 ici est rajouté, car sans ceci, la valeur max serait de 99 au lieu de 108
    End Sub

    Private Sub hsbHeure_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbHeure.Scroll
        lblHeure.Text = (hsbHeure.Value * 5 \ 60) & "h" & (hsbHeure.Value * 5 Mod 60)
        commandes.cmdeCourante.lieu = hsbHeure.Value * 5
    End Sub

    Private Sub rdbSalle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbSalle.Click
        gbHeure.Hide()
        MsgBox("Le service du petit déjeuner est ouvert de 7 heures à 10 heures.")
        commandes.cmdeCourante.lieu = 0
    End Sub

    Private Sub rdbChambre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbChambre.Click
        gbHeure.Show()
    End Sub

    Private Sub btnSuivant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuivant.Click
        If txtNom.Text = "" Or txtPrenom.Text = "" Then
            MsgBox("Renseignez tous les champs")
            Exit Sub
        End If

        formCmde.lblNom.Text = "Nom : " & txtNom.Text & " " & txtPrenom.Text




        commandes.cmdeCourante.nom = txtNom.Text
        commandes.cmdeCourante.prenom = txtPrenom.Text

        formCmde.lbNbCmde.Text = cbNbPtitDej.SelectedItem


        ReDim cmdeCourante.cmdes(3)
        For i = 0 To 3
            cmdeCourante.cmdes(i) = New DetailCommande()
        Next

        'heure
        If (rdbChambre.Checked) Then
            commandes.cmdeCourante.lieu = hsbHeure.Value * 5
        End If


        Me.Hide()
        formCmde.Show()
    End Sub


    Sub clear()
        txtNom.Text = ""
        txtPrenom.Text = ""
        rdbChambre.PerformClick()
        cbNbPtitDej.SelectedIndex = 0

        hsbHeure.Value = hsbHeure.Minimum
        lblHeure.Text = (hsbHeure.Value * 5 \ 60) & "h" & (hsbHeure.Value * 5 Mod 60)
        commandes.cmdeCourante.lieu = hsbHeure.Value * 5
    End Sub

    Private Sub rdbChambre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbChambre.CheckedChanged

    End Sub
End Class