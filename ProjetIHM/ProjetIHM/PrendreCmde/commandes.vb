Imports System.IO

Module commandes
    Public Class Commande
        Public numCh As Integer = 0
        Public nom As String
        Public prenom As String
        Public lieu As Integer ' SI 0 en Salle, si 390, 6h30
        Public cmdes As List(Of DetailCommande) = New List(Of DetailCommande)
        Public annul As Boolean = False


        Sub New()
        End Sub

        Public Sub clear()
            numCh = 0
            nom = ""
            prenom = ""
            lieu = 0
            cmdes.Clear()
        End Sub

        Public Function clone() As Commande
            Dim cmd As New Commande
            cmd.numCh = numCh
            cmd.nom = nom
            cmd.prenom = prenom
            cmd.lieu = lieu

            Dim dcmd As New DetailCommande
            For Each dcmd In cmdes
                cmd.cmdes.Add(dcmd.clone())
            Next

            Return cmd
        End Function


    End Class

    Public Class DetailCommande
        Public boissonChaude As String
        Public boissonFroide As String
        Public viennoiseries As List(Of String) = New List(Of String)
        Public accodements As List(Of String) = New List(Of String)
        Public supplements As List(Of String) = New List(Of String)
        Public prix As Single


        Sub New()
        End Sub


        Public Sub clear()
            boissonChaude = ""
            boissonFroide = ""
            viennoiseries.Clear()
            accodements.Clear()
            supplements.Clear()
            prix = 0
        End Sub

        Public Function clone() As DetailCommande
            Dim dcmd As New DetailCommande
            dcmd.boissonChaude = boissonChaude
            dcmd.boissonFroide = boissonFroide
            dcmd.prix = prix

            For Each viennoi As String In viennoiseries
                dcmd.viennoiseries.Add(New String(viennoi))
            Next
            For Each acco As String In accodements
                dcmd.accodements.Add(New String(acco))
            Next
            For Each supp As String In supplements
                dcmd.supplements.Add(New String(supp))
            Next

            Return dcmd

        End Function
    End Class

    Public cmdes As New List(Of Commande)
    Public cmdeCourante As New Commande()


    Sub writeCmde(ByVal writer As StreamWriter, ByRef cmde As Commande)

        writer.WriteLine(cmde.numCh)
        writer.WriteLine(cmde.nom)
        writer.WriteLine(cmde.prenom)
        writer.WriteLine(cmde.lieu)
        writer.WriteLine(cmde.annul)
        writer.WriteLine(cmde.cmdes.Count)

        For Each c In cmde.cmdes
            writer.WriteLine(c.boissonChaude)
            writer.WriteLine(c.boissonFroide)
            writer.WriteLine(c.viennoiseries.Count)
            For Each v In c.viennoiseries
                writer.WriteLine(v)
            Next

            writer.WriteLine(c.accodements.Count)
            For Each a In c.accodements
                writer.WriteLine(a)
            Next


            writer.WriteLine(c.supplements.Count)
            For Each s In c.supplements
                writer.WriteLine(s)
            Next

            writer.WriteLine(c.prix)
        Next

    End Sub


    Public Sub engegistrerCmdeFichier()
        Dim writer As New System.IO.StreamWriter("Cmdes.txt")
        Dim cmd As Commande
        For Each cmd In commandes.cmdes
            writeCmde(writer, cmd)
        Next
        writer.Close()
    End Sub


    Sub Main()
        'Dim cmde As New Commande()
        'cmde.numCh = 216
        'cmde.nom = "Le"
        'cmde.prenom = "Victor"
        'cmde.lieu = 39
        'cmde.nbCmde = 2
        'cmde.cmdes(0) = New DetailCommande()
        'cmde.cmdes(0).boissonChaude = "Eau chaude"
        'cmde.cmdes(0).boissonFroide = "Eau froide"
        'cmde.cmdes(0).nbViennoi = 2
        'cmde.cmdes(0).viennoiseries = {"Croissant", "PainChoco"}
        'cmde.cmdes(0).nbSupplements = 2
        'cmde.cmdes(0).supplements = {"supp1", "supp2"}

        'cmde.cmdes(1) = New DetailCommande()
        'cmde.cmdes(1).boissonChaude = "Eau chaude"
        'cmde.cmdes(1).boissonFroide = "Eau froide"
        'cmde.cmdes(1).nbViennoi = 2
        'cmde.cmdes(1).viennoiseries = {"Croissant", "PainChoco"}
        'cmde.cmdes(1).nbSupplements = 2
        'cmde.cmdes(1).supplements = {"supp1", "supp2"}




    End Sub

End Module
