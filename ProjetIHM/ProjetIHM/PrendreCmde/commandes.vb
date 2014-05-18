Module commandes
    Structure Commande
        Dim numCh As Integer
        Dim nom As String
        Dim prenom As String
        Dim lieu As String
        Dim cmdes() As DetailCommande

    End Structure

    Structure DetailCommande
        Dim boissonChaude As String
        Dim boissonFroide As String
        Dim viennoiseries() As String
        Dim supplements() As String
    End Structure


    Sub Main()
        'Test fichier
        Dim numFichier As Integer
        numFichier = FreeFile()
        FileOpen(numFichier, "Cmdes.txt", OpenMode.Output)

        WriteLine(numFichier, "Prout")
        WriteLine(numFichier, "Prout")
        WriteLine(numFichier, "Prout")

        FileClose(numFichier)
        FileOpen(numFichier, "Cmdes.txt", OpenMode.Input)
        Dim str As String = ""
        Input(numFichier, str)

        FileClose(numFichier)
    End Sub

End Module
