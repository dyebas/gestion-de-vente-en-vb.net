Module Module1

    Sub Main()
        Dim pdt As New LinkedList(Of produits)
        Dim ext, sel As Integer
        ext = 1
        While ext = 1
            Console.WriteLine("le menu : ")
            Console.WriteLine("1  pour ajouter un produit")
            Console.WriteLine("2  pour afficher la liste des produits")
            Console.WriteLine("3  pour supprimer un produit")
            Console.WriteLine("4  pour afficher la liste des produits par marque")
            Console.WriteLine("5  pour afficher la liste des produits par intitule")
            Console.WriteLine("6  pour rechercher un produit selon sa position - 1")
            Console.WriteLine("7  pour reaprovisionner le stock")
            Console.WriteLine("8  pour vendre un produit")
            Console.WriteLine()
            Console.WriteLine("entrez votre choix : ")
            sel = Console.ReadLine()
            Select Case (sel)
                Case 1
                    Module2.ajouterPdt(pdt)
                Case 2
                    Module2.afficherPdt(pdt)
                Case 3
                    Module2.supprimerPdt(pdt)
                Case 4
                    Module2.affichageMarque(pdt)
                Case 5
                    Module2.affichageIntitule(pdt)
                Case 6
                    Module2.rechercherPrdt(pdt)
                Case 7
                    Module2.reapprov(pdt)
                Case 8
                    Module2.vendre(pdt)
                Case Else
                    Console.WriteLine("entrey le choix entre 1 et 7")
            End Select
            Console.WriteLine("entre 0 pour sortir et 1 pour continuer")
            ext = Console.ReadLine
        End While

        Console.Read()
    End Sub
End Module
