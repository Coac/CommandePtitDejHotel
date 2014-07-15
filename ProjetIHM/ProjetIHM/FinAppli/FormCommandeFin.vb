Public Class FormCommandeFin

 
    Private Sub FormCommandeFin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Call frmMenu.majHeure(sender, e)
        ListBoxHidden.Items.Clear()
        ListBoxNum.Items.Clear()
        ListBoxNom.Items.Clear()
        ListBoxPrenom.Items.Clear()
        ListBoxNbP.Items.Clear()
        ListBoxPrix.Items.Clear()
        Dim c As Commande
        Dim s As String
        For i = 100 To 600 Step 100
            For j = 1 To 16
                c = getCmde(i + j)
                If c.nom IsNot Nothing And c.numCh <> 0 Then
                    s = i + j
                    ListBoxHidden.Items.Add(s)
                End If
            Next
        Next

        For i = 0 To (ListBoxHidden.Items.Count - 1)
            c = getCmde(CInt(ListBoxHidden.Items(i)))
            ListBoxNum.Items.Add(c.numCh)
            ListBoxNom.Items.Add(c.nom)
            ListBoxPrenom.Items.Add(c.prenom)
            ListBoxNbP.Items.Add(c.nbCmde)
            ListBoxPrix.Items.Add(c.cmdes(0).prix + c.cmdes(1).prix + c.cmdes(2).prix)
        Next i


    End Sub

    Private Sub ButtonRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        FormMenuFin.Show()

    End Sub

    Private Sub FormCommandeFin_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = Me.Text
    End Sub

    Private Sub ListBoxPrix_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxPrix.Click, ListBoxNum.Click, ListBoxNom.Click, ListBoxPrenom.Click, ListBoxNbP.Click
        Dim k As Integer
        Dim l As ListBox
        k = sender.selectedIndex

        ListBoxNum.SelectedIndex = k
        ListBoxNom.SelectedIndex = k
        ListBoxPrenom.SelectedIndex = k
        ListBoxNbP.SelectedIndex = k
        ListBoxPrix.SelectedIndex = k

    End Sub



End Class