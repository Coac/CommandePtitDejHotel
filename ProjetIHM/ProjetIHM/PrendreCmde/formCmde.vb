Public Class formCmde

    Dim nbViennois As Integer = 0

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

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

    Private Sub formCmde_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbNbPtitDej.SelectedIndex = 0

        Dim Rb As RadioButton
        Dim boissonsChaudes() As String = {"Café Noir", "Café au lait", "Thé", "Chocolat", "Cappucino", "Thé au Citron", "Thé au Lait"}
        Dim i As Integer = 0
        For Each Rb In gbBoissonChaude.Controls
            Rb.Text = boissonsChaudes(i)
            i = i + 1
        Next

        Dim Cb As CheckBox
        Dim viennoiseries() As String = {"Pain", "Toast", "Biscotte", "Croissant", "Brioche", "Pain au Chocolat", "Pain aux Raisins", "Chausson aux Pommes"}
        i = 0
        For Each Cb In gbViennnoiseries.Controls
            Cb.Text = viennoiseries(i)
            i = i + 1
        Next



        Dim accommodements() As String = {"Beurre", "Confiture", "Compote", "Pâte à tartiner", "Miel"}
        i = 0
        For Each Cb In gbAccommodements.Controls
            Cb.Text = accommodements(i)
            i = i + 1
        Next
        gbAccommodements.Hide()


        Dim boissonsFroides() As String = {"Abricot", "Ananas", "Citron", "Coca-Cola", "Fruit de la Passion", "Orange", "Pamplemousse", "Tomate"}
        cbBoissonFroide.DataSource = boissonsFroides
        cbBoissonFroide.SelectedIndex = 0



        Dim supplements() As String = {"Céréale         1.5€",
                                       "Fromage         2.65€",
                                       "Oeuf Coque      1.80€",
                                       "Oeufs au plat   1.95€",
                                       "Oeufs Brouillés 2.20€",
                                       "Saumon Fumé     5.50€",
                                       "Blanc           25€",
                                       "Rouge           28€",
                                       "Bière           8€",
                                       "Champagne       55€"}
        i = 0
        For Each Cb In gbSupplements.Controls
            Cb.Text = supplements(i)
            i = i + 1
        Next



    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox6.CheckedChanged, CheckBox7.CheckedChanged, CheckBox8.CheckedChanged
        If (sender.checked) Then
            nbViennois = nbViennois + 1
            If (nbViennois > 3) Then
                MsgBox("Le nombre maximum de Viennoiseries est de 3 !")
                sender.checked = False

            End If
        Else
            nbViennois = nbViennois - 1
        End If

        If (nbViennois = 0) Then
            gbAccommodements.Hide()
        Else
            gbAccommodements.Show()
        End If
    End Sub

    Private Sub rdbSalle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSalle.CheckedChanged
        If (rdbSalle.Checked) Then
            MsgBox("Le service du petit déjeuner es ouvert de 7 heures à 10 heures.")
        End If
    End Sub
End Class