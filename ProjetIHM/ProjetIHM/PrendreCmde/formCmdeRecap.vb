Public Class formCmdeRecap

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmMenu.Show()

    End Sub

    Private Sub btnRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.Click
        'Test a enlever
        Dim writer As New System.IO.StreamWriter("Cmdes.txt")
        writeCmde(writer, commandes.cmdeCourante)
        writer.Close()


        Me.Hide()
        formCmde.Show()
    End Sub
End Class