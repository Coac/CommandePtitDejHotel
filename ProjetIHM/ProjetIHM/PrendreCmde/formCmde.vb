Public Class formCmde

    Dim nbViennois As Integer = 0

    Public Sub retourMenuPrincip(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmMenu.Show()

    End Sub


    Private Sub formCmde_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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


    Private Sub btnSupplements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplements.Click
        Me.Hide()
        formSupplements.Show()
    End Sub

    Private Sub btnRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.Click
        Me.Hide()
        formPreCmde.Show()
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged
        commandes.cmdeCourante.cmdes(Val(lblIndiceCmde.Text)).boissonChaude = sender.Text
    End Sub

    Private Sub btnSuivant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuivant.Click

        'Boisson Froide
        commandes.cmdeCourante.cmdes(Val(lblIndiceCmde.Text)).boissonFroide = cbBoissonFroide.SelectedItem


        'Viennoiseries
        Dim Cb As CheckBox
        For Each Cb In gbViennnoiseries.Controls
            If (Cb.Checked) Then
                commandes.cmdeCourante.cmdes(Val(lblIndiceCmde.Text)).viennoiseries.Add(New String(Cb.Text))
            End If
        Next


        'Accommodements
        If commandes.cmdeCourante.cmdes(lblIndiceCmde.Text).viennoiseries.Count > 0 Then
            For Each Cb In gbAccommodements.Controls
                If (Cb.Checked) Then
                    commandes.cmdeCourante.cmdes(Val(lblIndiceCmde.Text)).accodements.Add(New String(Cb.Text))
                End If
            Next
        End If

        Me.Hide()
        formCmdeRecap.Show()

    End Sub


End Class