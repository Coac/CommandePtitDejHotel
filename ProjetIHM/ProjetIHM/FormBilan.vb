Imports System.IO
Public Class FormBilan

    Private Sub ListBoxTrié_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FormBilan_Activated1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call frmMenu.majHeure(sender, e)
        ListBoxTrié.Items.Clear()
        ListBoxHoraireVien.Items.Clear()
        ListBoxToasts.Items.Clear()
        ListBoxCroissants.Items.Clear()
        ListBoxBrioches.Items.Clear()
        ListBoxPainsChoco.Items.Clear()
        ListBoxPainsRais.Items.Clear()
        ListBoxChaussonPommes.Items.Clear()

        ListBoxViennoiseries.Items.Clear()
        ListBoxBoissonChaude.Items.Clear()
        ListBoxSup.Items.Clear()
        ListBoxBoissonFroide.Items.Clear()
        ListBoxHoraire.Items.Clear()
        ListBoxNumClient.Items.Clear()
        ListBoxChambre.Items.Clear()

        Dim C As Commande
        Dim lieuH As Integer
        Dim lieuHV As Integer
        Dim raw As Integer
        Dim nbDej As Integer
        Dim heure As String
        Dim cptT, cptCr, cptBr, cptPc, cptPr, cptCp As Integer
        nbDej = 0
        raw = -1

        getCmdForHotelier()

        For i = 0 To (ListBoxTrié.Items.Count - 1)
            C = getCmde(Val(Strings.Right(ListBoxTrié.Items(i), 3)))
            lieuH = 360
            lieuHV = 360

            If i <> 0 Then
                If lieuH + 30 >= C.lieu Then
                    ListBoxHoraire.Items.Add("--")
                Else
                    While lieuH + 30 <= C.lieu
                        lieuH = lieuH + 30
                    End While
                    ListBoxHoraire.Items.Add(lieuH \ 60 & "h" & If(lieuH Mod 60 = 0, "", lieuH Mod 60))
                End If
            Else
                lieuH = lieuH + 30
                ListBoxHoraire.Items.Add(lieuH \ 60 & "h" & If(lieuH Mod 60 = 0, "", lieuH Mod 60))
            End If


            For k = 0 To C.nbCmde - 1
                nbDej = nbDej + 1
                If k = 0 Then
                    ListBoxChambre.Items.Add(C.numCh)
                Else
                    ListBoxChambre.Items.Add("--")
                End If
                If k > 0 Then
                    ListBoxHoraire.Items.Add("--")
                End If

                ListBoxNumClient.Items.Add(k + 1 & "/" & C.nbCmde)
                ListBoxBoissonChaude.Items.Add(C.cmdes(k).boissonChaude)
                ListBoxBoissonFroide.Items.Add(C.cmdes(k).boissonFroide)
                If C.cmdes(k).viennoiseries(0) = "" Then
                    ListBoxViennoiseries.Items.Add("")
                Else
                    ListBoxViennoiseries.Items.Add("*")
                End If
                If C.cmdes(k).supplements(0) = "" Then
                    ListBoxSup.Items.Add("")
                Else
                    ListBoxSup.Items.Add("*")
                End If
            Next k



            For j = 0 To C.nbCmde - 1
                For Each item As String In C.cmdes(j).viennoiseries
                    If InStr(item, "Toast") > 0 Then
                        cptT = cptT + 1
                    ElseIf InStr(item, "Croissant") > 0 Then
                        cptCr = cptCr + 1
                    ElseIf InStr(item, "Brioche") > 0 Then
                        cptBr = cptBr + 1
                    ElseIf InStr(item, "Pain au Chocolat") > 0 Then
                        cptPc = cptPc + 1
                    ElseIf InStr(item, "Pain aux Raisins") > 0 Then
                        cptPr = cptPr + 1
                    ElseIf InStr(item, "Chausson aux Pommes") > 0 Then
                        cptCp = cptCp + 1
                    End If
                Next

                Dim minutes As Integer = C.lieu Mod 60
                minutes = minutes / 30
                minutes = minutes * 30
                If String.Compare(heure, C.lieu \ 60 & "h" & minutes) <> 0 Then
                    heure = C.lieu \ 60 & "h" & minutes
                    ListBoxHoraireVien.Items.Add(C.lieu \ 60 & "h" & minutes)
                    ListBoxToasts.Items.Add(cptT)
                    ListBoxCroissants.Items.Add(cptCr)
                    ListBoxBrioches.Items.Add(cptBr)
                    ListBoxPainsChoco.Items.Add(cptPc)
                    ListBoxPainsRais.Items.Add(cptPr)
                    ListBoxChaussonPommes.Items.Add(cptCp)
                    cptBr = 0
                    cptCp = 0
                    cptCr = 0
                    cptPc = 0
                    cptPr = 0
                    cptT = 0
                End If


            Next j

        Next i




        lblnbdej.Text = nbDej.ToString

    End Sub

    Public Sub getCmdForHotelier()
        Dim c As Commande
        Dim s As String
        For i = 100 To 600 Step 100
            For j = 1 To 16
                c = getCmde(i + j)
                If c.lieu > 0 Then
                    s = c.lieu.ToString & " " & c.numCh.ToString
                    ListBoxTrié.Items.Add(s)
                End If
            Next
        Next
    End Sub


    Private Sub ListBoxViennoiseries_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxViennoiseries.SelectedIndexChanged, ListBoxBoissonChaude.SelectedIndexChanged, ListBoxBoissonFroide.SelectedIndexChanged, ListBoxChambre.SelectedIndexChanged, ListBoxHoraire.SelectedIndexChanged, ListBoxNumClient.SelectedIndexChanged, ListBoxSup.SelectedIndexChanged
        Dim C As Commande
        PanelComplement.Visible = True
        ListBoxViennoiseries.SelectedIndex = sender.selectedindex
        ListBoxBoissonChaude.SelectedIndex = sender.selectedindex
        ListBoxSup.SelectedIndex = sender.selectedindex
        ListBoxBoissonFroide.SelectedIndex = sender.selectedindex
        ListBoxHoraire.SelectedIndex = sender.selectedindex
        ListBoxNumClient.SelectedIndex = sender.selectedindex
        ListBoxChambre.SelectedIndex = sender.selectedindex

        ListBoxVienComp.Items.Clear()
        ListBoxSupComp.Items.Clear()
        ListBoxAccComp.Items.Clear()

        If ListBoxNumClient.Items(sender.selectedindex)(0) = "1" Then
            C = getCmde(Val(ListBoxChambre.Items(sender.selectedindex)))
            ListBoxVienComp.Items.AddRange(C.cmdes(0).viennoiseries)
            ListBoxSupComp.Items.AddRange(C.cmdes(0).supplements)
            ListBoxAccComp.Items.AddRange(C.cmdes(0).accodements)
        ElseIf ListBoxNumClient.Items(sender.selectedindex)(0) = "2" Then
            C = getCmde(Val(ListBoxChambre.Items(sender.selectedIndex - 1)))
            ListBoxVienComp.Items.AddRange(C.cmdes(1).viennoiseries)
            ListBoxSupComp.Items.AddRange(C.cmdes(1).supplements)
            ListBoxAccComp.Items.AddRange(C.cmdes(1).accodements)
        ElseIf ListBoxNumClient.Items(sender.selectedindex)(0) = "3" Then
            C = getCmde(Val(ListBoxChambre.Items(sender.selectedIndex - 2)))
            ListBoxVienComp.Items.AddRange(C.cmdes(2).viennoiseries)
            ListBoxSupComp.Items.AddRange(C.cmdes(2).supplements)
            ListBoxAccComp.Items.AddRange(C.cmdes(2).accodements)
        End If


    End Sub

    Private Sub ButtonRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        frmMenu.Show()
    End Sub


    Private Sub ButtonRetour_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        frmMenu.Show()
    End Sub


    Private Sub txtboxNCh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNch.KeyPress
        If (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            Exit Sub
        End If
        e.KeyChar = Chr(0)
    End Sub


    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVal.Click
        If TextBoxNch.Text.Length <= 2 Then
            lbldejcheck.Text = "Il manque des chiffres."
            TextBoxNch.Focus()
            Exit Sub
        End If


        Dim numChambre As String = ""
        numChambre += TextBoxNch.Text.Chars(1) & TextBoxNch.Text.Chars(2)

        ' Check Numéro Chambre
        If TextBoxNch.Text.Chars(0) < "1" Or TextBoxNch.Text.Chars(0) > "6" Or numChambre < 1 Or numChambre > 16 Then
            lbldejcheck.Text = "La chambre n'existe pas."
            TextBoxNch.Focus()
            Exit Sub
        End If

        Dim c As Commande
        c = getCmde(CInt(TextBoxNch.Text))
        If c.annul Then
            lbldejcheck.Text = "La commande est annulée"
        End If
        If c.lieu < DateAndTime.Hour(Now) * 60 + DateAndTime.Minute(Now) Then
            lbldejcheck.Text = "Le petit déjeuner a été servi"
        Else
            lbldejcheck.Text = "Le petit déjeuner n'a pas été servi"
        End If
    End Sub


    Private Sub FormBilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = Me.Text
    End Sub

    Private Sub ListBoxPainsRais_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxPainsRais.Click, ListBoxHoraireVien.Click, ListBoxToasts.Click, ListBoxCroissants.Click, ListBoxPainsChoco.Click, ListBoxChaussonPommes.Click
        ListBoxHoraireVien.SelectedIndex = sender.selectedindex
        ListBoxToasts.SelectedIndex = sender.selectedindex
        ListBoxCroissants.SelectedIndex = sender.selectedindex
        ListBoxBrioches.SelectedIndex = sender.selectedindex
        ListBoxPainsChoco.SelectedIndex = sender.selectedindex
        ListBoxPainsRais.SelectedIndex = sender.selectedindex
        ListBoxChaussonPommes.SelectedIndex = sender.selectedindex
    End Sub

    Private Sub ListBoxPainsRais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxPainsRais.SelectedIndexChanged

    End Sub

End Class