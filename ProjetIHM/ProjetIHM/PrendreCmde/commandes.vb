Imports System.IO

Module commandes
    Public Class Commande
        Public numCh As Integer = 0
        Public nom As String
        Public prenom As String
        Public lieu As Integer ' SI 0 en Salle, si 390, 6h30
        Public cmdes As List(Of DetailCommande) = New List(Of DetailCommande)


        Sub New()
            cmdes.Add(New DetailCommande())
        End Sub


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


    End Class

    Public cmdes() As Commande
    Public cmdeCourante As New Commande()


    Sub writeCmde(ByVal writer As StreamWriter, ByRef cmde As Commande)

        writer.WriteLine(cmde.numCh)
        writer.WriteLine(cmde.nom)
        writer.WriteLine(cmde.prenom)
        writer.WriteLine(cmde.lieu)
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
