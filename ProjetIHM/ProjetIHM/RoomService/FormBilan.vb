Imports System.IO
Public Class FormBilan

    Private Sub ListBoxTrié_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxTrié.SelectedIndexChanged

    End Sub

    Private Sub FormBilan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        Dim C As Commande
        Dim lieuH As Integer
        Dim lieuHV As Integer
        Dim raw As Integer
        raw = -1

        getCmdForHotelier()

        For i = 0 To (ListBoxTrié.Items.Count - 1)
            C = getCmde(CInt(Strings.Right(ListBoxTrié.Items(i), 3)))
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


            For k = 1 To C.nbCmde
                If k = 1 Then
                    ListBoxChambre.Items.Add(C.numCh)
                Else
                    ListBoxChambre.Items.Add("--")
                End If
                If k > 1 Then
                    ListBoxHoraire.Items.Add("--")
                End If

                ListBoxNumClient.Items.Add(k & "/" & C.nbCmde)
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

            Dim cptT, cptCr, cptBr, cptPc, cptPr, cptCp As Integer

            For j = 1 To C.nbCmde
                For Each item As String In C.cmdes(j).viennoiseries
                    If item = "Toast" Then
                        cptT = cptT + 1
                    ElseIf item = "Croissant" Then
                        cptCr = cptCr + 1
                    ElseIf item = "Brioche" Then
                        cptBr = cptBr + 1
                    ElseIf item = "Pain au Chocolat" Then
                        cptPc = cptPc + 1
                    ElseIf item = "Pain aux Raisins" Then
                        cptPr = cptPr + 1
                    ElseIf (item = "Chausson aux Pommes") Then
                        cptCp = cptCp + 1
                    End If
                Next

                If lieuHV + 15 <= C.lieu Then
                    While lieuHV + 15 <= C.lieu
                        lieuHV = lieuHV + 15
                    End While
                    ListBoxHoraireVien.Items.Add(lieuHV \ 60 & "h" & If(lieuHV Mod 60 = 0, "", lieuHV Mod 60))
                    raw = raw + 1
                    ListBoxToasts.Items.Add("0")
                    ListBoxCroissants.Items.Add("0")
                    ListBoxBrioches.Items.Add("0")
                    ListBoxPainsChoco.Items.Add("0")
                    ListBoxPainsRais.Items.Add("0")
                    ListBoxChaussonPommes.Items.Add("0")
                Else
                    ListBoxHoraireVien.Items.Add(lieuHV \ 60 & "h" & If(lieuHV Mod 60 = 0, "", lieuHV Mod 60))
                    raw = raw + 1
                    ListBoxToasts.Items.Add("0")
                    ListBoxCroissants.Items.Add("0")
                    ListBoxBrioches.Items.Add("0")
                    ListBoxPainsChoco.Items.Add("0")
                    ListBoxPainsRais.Items.Add("0")
                    ListBoxChaussonPommes.Items.Add("0")
                End If


                ListBoxToasts.Items(raw).text = cptT.ToString
                ListBoxCroissants.Items(raw).text = cptCr.ToString
                ListBoxBrioches.Items(raw).text = cptBr.ToString
                ListBoxPainsChoco.Items(raw).text = cptPc.ToString
                ListBoxPainsRais.Items(raw).text = cptPr.ToString
                ListBoxChaussonPommes.Items(raw).text = cptCp.ToString

            Next j

        Next i





    End Sub

    Sub getCmdForHotelier()
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


    Private Sub ListBoxViennoiseries_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxViennoiseries.SelectedIndexChanged, ListBoxBoissonChaude.SelectedIndexChanged, ListBoxBoissonFroide.SelectedIndexChanged, ListBoxChambre.SelectedIndexChanged, ListBoxHoraire.SelectedIndexChanged, ListBoxNumClient.SelectedIndexChanged, ListBoxSup.SelectedIndexChanged, ListBoxViennoiseries.SelectedIndexChanged
        Dim C As Commande
        PanelComplement.Visible = True
        ListBoxViennoiseries.SetSelected(sender.selectedindex, True)
        ListBoxBoissonChaude.SetSelected(sender.selectedindex, True)
        ListBoxSup.SetSelected(sender.selectedindex, True)
        ListBoxBoissonFroide.SetSelected(sender.selectedindex, True)
        ListBoxHoraire.SetSelected(sender.selectedindex, True)
        ListBoxNumClient.SetSelected(sender.selectedindex, True)
        ListBoxChambre.SetSelected(sender.selectedindex, True)

        If ListBoxNumClient.Items(sender.selectedindex)(0) = "1" Then
            C = getCmde(CInt(ListBoxChambre.SelectedItem(sender.selectedindex)))
            ListBoxVienComp.Items.AddRange(C.cmdes(0).viennoiseries)
            ListBoxSupComp.Items.AddRange(C.cmdes(0).supplements)
            ListBoxAccComp.Items.AddRange(C.cmdes(0).accodements)
        ElseIf ListBoxNumClient.Items(sender.selectedindex)(0) = "2" Then
            C = getCmde(CInt(ListBoxChambre.SelectedItem(sender.selectedItem - 1)))
            ListBoxVienComp.Items.AddRange(C.cmdes(1).viennoiseries)
            ListBoxSupComp.Items.AddRange(C.cmdes(1).supplements)
            ListBoxAccComp.Items.AddRange(C.cmdes(1).accodements)
        ElseIf ListBoxNumClient.Items(sender.selectedindex)(0) = "3" Then
            C = getCmde(CInt(ListBoxChambre.SelectedItem(sender.selectedItem - 2)))
            ListBoxVienComp.Items.AddRange(C.cmdes(2).viennoiseries)
            ListBoxSupComp.Items.AddRange(C.cmdes(2).supplements)
            ListBoxAccComp.Items.AddRange(C.cmdes(2).accodements)
        End If


    End Sub

    Private Sub ButtonRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        frmMenu.Show()
    End Sub
End Class