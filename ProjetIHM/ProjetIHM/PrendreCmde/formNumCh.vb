Public Class formNumCh

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Call formCmde.retourMenuPrincip(sender, e)

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
            Exit Sub
        End If


        Dim numChambre As String = ""
        numChambre += txtboxNumCh.Text.Chars(1) & txtboxNumCh.Text.Chars(2)

        If txtboxNumCh.Text.Chars(0) < "1" Or txtboxNumCh.Text.Chars(0) > "6" Or numChambre < 1 Or numChambre > 16 Then
            MsgBox("La chambre n'existe pas.")
            Exit Sub
        End If

        formPreCmde.lblNumCh.Text = txtboxNumCh.Text


        commandes.cmdeCourante.numCh = txtboxNumCh.Text


        Me.Hide()
        formPreCmde.Show()


    End Sub

End Class