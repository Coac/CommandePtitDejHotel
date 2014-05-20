Imports System.IO

Module commandes
    Public Class Commande
        Public numCh As Integer
        Public nom As String
        Public prenom As String
        Public lieu As Integer ' SI 0 en Salle, si 390, 6h30
        Public nbCmde As Integer
        Public cmdes(3) As DetailCommande


        Sub New()
        End Sub


    End Class

    Public Class DetailCommande
        Public boissonChaude As String
        Public boissonFroide As String
        Public nbViennoi As Integer
        Public viennoiseries() As String
        Public nbAccodements As Integer
        Public accodements() As String
        Public nbSupplements As Integer
        Public supplements() As String
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
        writer.WriteLine(cmde.nbCmde)
        writer.WriteLine("hello")

        Dim i As Integer
        For i = 0 To cmde.nbCmde - 1
            writer.WriteLine(cmde.cmdes(i).boissonChaude)
            writer.WriteLine(cmde.cmdes(i).boissonFroide)
            writer.WriteLine(cmde.cmdes(i).nbViennoi)
            Dim str As String = ""
            For j = 0 To cmde.cmdes(i).nbViennoi - 1
                str += cmde.cmdes(i).viennoiseries(j) & " "
            Next
            writer.WriteLine(str)

            writer.WriteLine(cmde.cmdes(i).nbAccodements)
            str = ""
            For j = 0 To cmde.cmdes(i).nbAccodements - 1
                str += cmde.cmdes(i).Accodements(j) & " "
            Next
            writer.WriteLine(str)


            writer.WriteLine(cmde.cmdes(i).nbSupplements)
            str = ""
            For j = 0 To cmde.cmdes(i).nbSupplements - 1
                str += cmde.cmdes(i).supplements(j) & " "
            Next
            writer.WriteLine(str)

            writer.WriteLine(cmde.cmdes(i).prix)
        Next

    End Sub


    Sub Main()
        Dim cmde As New Commande()
        cmde.numCh = 216
        cmde.nom = "Le"
        cmde.prenom = "Victor"
        cmde.lieu = 39
        cmde.nbCmde = 2
        cmde.cmdes(0) = New DetailCommande()
        cmde.cmdes(0).boissonChaude = "Eau chaude"
        cmde.cmdes(0).boissonFroide = "Eau froide"
        cmde.cmdes(0).nbViennoi = 2
        cmde.cmdes(0).viennoiseries = {"Croissant", "PainChoco"}
        cmde.cmdes(0).nbSupplements = 2
        cmde.cmdes(0).supplements = {"supp1", "supp2"}

        cmde.cmdes(1) = New DetailCommande()
        cmde.cmdes(1).boissonChaude = "Eau chaude"
        cmde.cmdes(1).boissonFroide = "Eau froide"
        cmde.cmdes(1).nbViennoi = 2
        cmde.cmdes(1).viennoiseries = {"Croissant", "PainChoco"}
        cmde.cmdes(1).nbSupplements = 2
        cmde.cmdes(1).supplements = {"supp1", "supp2"}


        Dim writer As New StreamWriter("Cmdes.txt")
        writeCmde(writer, cmde)
        writer.Close()

    End Sub

End Module
