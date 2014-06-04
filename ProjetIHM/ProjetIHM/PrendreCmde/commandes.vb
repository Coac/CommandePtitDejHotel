Imports System.IO

Module commandes

    Structure Commande
        Public numCh As Integer
        <VBFixedString(30)> Public nom As String
        <VBFixedString(30)> Public prenom As String
        Public lieu As Integer ' SI 0 en Salle, si 390, 6h30
        <VBFixedArray(3)> Public cmdes() As DetailCommande
        Public nbCmde As Integer
        Public annul As Boolean
    End Structure


    Public Sub clearCommande(ByRef cmd As Commande)
        cmd.numCh = 0
        cmd.nom = ""
        cmd.prenom = ""
        cmd.lieu = 0
        cmd.nbCmde = 0
        ReDim cmd.cmdes(3)
    End Sub


    Structure DetailCommande
        <VBFixedString(30)> Public boissonChaude As String
        <VBFixedString(30)> Public boissonFroide As String
        <VBFixedArray(2)> <VBFixedString(30)> Public viennoiseries() As String
        <VBFixedArray(3)> <VBFixedString(30)> Public accodements() As String
        <VBFixedArray(9)> <VBFixedString(30)> Public supplements() As String
        Public prix As Single

    End Structure



    Public Sub clearDetailCommande(ByRef dCmd As DetailCommande)
        dCmd.boissonChaude = ""
        dCmd.boissonFroide = ""
        ReDim dCmd.viennoiseries(0)
        ReDim dCmd.accodements(0)
        ReDim dCmd.supplements(0)
        dCmd.prix = 0
    End Sub


    Public cmdeCourante As Commande


    Sub writeCmde(ByRef cmde As Commande)
        Dim FileNum As Integer = FreeFile()
        Dim cmdeLength As Integer
        cmdeLength = Len(cmde) + Len(cmde.cmdes(0)) * 4 + 2
        FileOpen(FileNum, "cmde.dat", OpenMode.Random, , , cmdeLength)
        FilePut(FileNum, cmde, cmde.numCh)
        FileClose(FileNum)

    End Sub

    Function getCmde(ByVal numCh As Integer) As Commande


        Dim FileNum As Integer = FreeFile()
        Dim cmdeLength As Integer
        Dim temp As Commande
        ReDim temp.cmdes(3)
        For i = 0 To 3
            temp.cmdes(i) = New DetailCommande()
        Next
        cmdeLength = Len(temp) + Len(temp.cmdes(0)) * 4 + 2

        FileOpen(FileNum, "cmde.dat", OpenMode.Random, , , cmdeLength)
        Dim c As Commande
        Try
            FileGet(FileNum, c, numCh)
        Catch

        End Try

        FileClose(FileNum)
        Return c



    End Function



    Sub Main()
        

    End Sub

End Module
