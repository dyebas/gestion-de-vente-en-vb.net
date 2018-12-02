Imports System.Collections.Generic
Imports System.Collections
Structure produits
    Dim quantite As Integer
    Dim intitule, marque, code As String
    Dim prix As Double
End Structure
Module Module2
    Enum MARQUE As Integer
        DELL
        TOSHIBA
        SAMSUNG
        HP
    End Enum
    Enum INTITULE As Integer
        IMPRIMANTE
        PC
        CLAVIER
        SOURIS
    End Enum
    Sub ajouterPdt(ByVal prodt As LinkedList(Of produits))
        Dim po As produits
        Console.WriteLine("---------------Ajouter un produit------------------ ")
        Console.WriteLine("donner le code : ")
        po.code = Console.ReadLine()
        Console.WriteLine("donner le prix : ")
        po.prix = Console.ReadLine()
        Console.WriteLine("donner le Marque : ")
        Dim m As String = Console.ReadLine
        While (m <> MARQUE.HP.ToString) And (m <> MARQUE.TOSHIBA.ToString) And (m <> MARQUE.SAMSUNG.ToString) And (m <> MARQUE.DELL.ToString)
            Console.WriteLine("Cette marque n existe pas donner une nouvelle marque")
            m = Console.ReadLine
        End While
        po.marque = m
        Console.WriteLine("donner l intitule : ")
        Dim q As String = Console.ReadLine()
        While (q <> INTITULE.CLAVIER.ToString) And (q <> INTITULE.IMPRIMANTE.ToString) And (q <> INTITULE.PC.ToString) And (q <> INTITULE.SOURIS.ToString)
            Console.WriteLine("Cette intitule n existe pas donner une nouvelle marque")
            q = Console.ReadLine
        End While
        po.intitule = q

        Console.WriteLine("donner la quantite du produit : ")
        po.quantite = Console.ReadLine()

        'Console.WriteLine("la quantite : {0}", po.quantite)
        prodt.AddFirst(po)

    End Sub
    Sub afficherPdt(ByVal prodt As LinkedList(Of produits))
        For i = 0 To prodt.Count - 1
            Console.WriteLine(" Produit {0} : {1}   {2}   {3}   {4} DH {5}", i + 1, prodt(i).code, prodt(i).marque, prodt(i).intitule, prodt(i).prix, prodt(i).quantite)
        Next
    End Sub
    Sub supprimerPdt(ByVal prodt As LinkedList(Of produits))
        Dim p As Integer

        Console.WriteLine("donner la position du produit a supprimer : ")
        p = Console.ReadLine()
        For i = 0 To prodt.Count - 1
            If i = p Then
                prodt.Remove(prodt(p))
            End If
        Next

    End Sub
    Sub rechercherPrdt(ByVal prodt As LinkedList(Of produits))
        Dim p As Integer

        Console.WriteLine("donner la position du produit rechercher : ")
        p = Console.ReadLine()
        For i = 0 To prodt.Count - 1
            If i = p Then
                Console.WriteLine(" Produit {0} : {1}   {2}   {3}   {4} DH", i + 1, prodt(i).code, prodt(i).marque, prodt(i).intitule, prodt(i).prix)
            End If
        Next
    End Sub
    Sub affichageMarque(ByVal prodt As LinkedList(Of produits))
        Dim m As String
        Console.WriteLine("donner la marque des produits que vous voulez afficher : ")
        m = Console.ReadLine()
        If (m = MARQUE.HP.ToString) Or (m = MARQUE.TOSHIBA.ToString) Or (m = MARQUE.SAMSUNG.ToString) Or (m = MARQUE.DELL.ToString) Then
            For i = 0 To prodt.Count - 1
                If prodt(i).marque = m Then
                    Console.WriteLine(" Produit {0} : {1}   {2}   {3}   {4} DH", i + 1, prodt(i).code, prodt(i).marque, prodt(i).intitule, prodt(i).prix)
                End If
            Next
        Else
            Console.WriteLine("la marque n'existe pas ")
        End If
    End Sub
    Sub affichageIntitule(ByVal prodt As LinkedList(Of produits))
        Dim q As String
        Console.WriteLine("donner l'intitule des produits que vous voulez afficher : ")
        q = Console.ReadLine()
        If (q = INTITULE.PC.ToString) Or (q = INTITULE.CLAVIER.ToString) Or (q = INTITULE.IMPRIMANTE.ToString) Or (q = INTITULE.SOURIS.ToString) Then
            For i = 0 To prodt.Count - 1
                If prodt(i).marque = q Then
                    Console.WriteLine(" Produit {0} : {1}   {2}   {3}   {4} DH", i + 1, prodt(i).code, prodt(i).marque, prodt(i).intitule, prodt(i).prix)
                End If
            Next
        Else
            Console.WriteLine("l'intitule n'existe pas ")
        End If
    End Sub
    Sub reapprov(ByVal prodt As LinkedList(Of produits))
        Dim po As produits
        Console.WriteLine("---------------Reapprovisionner le stock------------------ ")
        Console.WriteLine("donner le code : ")
        po.code = Console.ReadLine()
        Console.WriteLine("donner le prix : ")
        po.prix = Console.ReadLine()
        Console.WriteLine("donner le Marque : ")
        Dim m As String = Console.ReadLine
        While (m <> MARQUE.HP.ToString) And (m <> MARQUE.TOSHIBA.ToString) And (m <> MARQUE.SAMSUNG.ToString) And (m <> MARQUE.DELL.ToString)
            Console.WriteLine("Cette marque n existe pas donner une nouvelle marque")
            m = Console.ReadLine
        End While
        po.marque = m
        Console.WriteLine("donner l intitule : ")
        Dim q As String = Console.ReadLine()
        While (q <> INTITULE.CLAVIER.ToString) And (q <> INTITULE.IMPRIMANTE.ToString) And (q <> INTITULE.PC.ToString) And (q <> INTITULE.SOURIS.ToString)
            Console.WriteLine("Cette intitule n existe pas donner une nouvelle marque")
            q = Console.ReadLine
        End While
        po.intitule = q

        For i = 0 To prodt.Count - 1
            If (po.intitule = prodt(i).intitule) And (po.marque = prodt(i).marque) And (po.prix = prodt(i).prix) Then
                po.quantite = prodt(i).quantite + 1
                prodt.Remove(prodt(i))
            End If
        Next

        'Console.WriteLine("la quantite : {0}", po.quantite)
        prodt.AddFirst(po)

    End Sub
    Sub vendre(ByVal prodt As LinkedList(Of produits))
        Dim po As produits
        Console.WriteLine("---------------Vendre un produit------------------ ")
        Console.WriteLine("donner le code du produit a vendre : ")
        po.code = Console.ReadLine()
        Console.WriteLine("donner le prix du produit a vendre : ")
        po.prix = Console.ReadLine()
        Console.WriteLine("donner le Marque du produit a vendre : ")
        Dim m As String = Console.ReadLine
        While (m <> MARQUE.HP.ToString) And (m <> MARQUE.TOSHIBA.ToString) And (m <> MARQUE.SAMSUNG.ToString) And (m <> MARQUE.DELL.ToString)
            Console.WriteLine("Cette marque n existe pas donner une nouvelle marque")
            m = Console.ReadLine
        End While
        po.marque = m
        Console.WriteLine("donner l intitule du produit a vendre : ")
        Dim q As String = Console.ReadLine()
        While (q <> INTITULE.CLAVIER.ToString) And (q <> INTITULE.IMPRIMANTE.ToString) And (q <> INTITULE.PC.ToString) And (q <> INTITULE.SOURIS.ToString)
            Console.WriteLine("Cette intitule n existe pas donner une nouvelle marque")
            q = Console.ReadLine
        End While
        po.intitule = q

        Console.WriteLine("donner la quantite produit a vendre : ")
        po.quantite = Console.ReadLine()

        For i = 0 To prodt.Count - 1
            If (po.intitule = prodt(i).intitule) And (po.marque = prodt(i).marque) And (po.prix = prodt(i).prix) Then
                If (prodt(i).quantite = 0) Then
                    Console.WriteLine("le stock est vide pensez a le realimenter")
                ElseIf (prodt(i).quantite = 1) Then
                    prodt.Remove(prodt(i))
                ElseIf (prodt(i).quantite > 1) Then
                    po.quantite = prodt(i).quantite - po.quantite
                    prodt.AddFirst(po)
                    prodt.Remove(prodt(i))
                End If
            End If
        Next

        'Console.WriteLine("la quantite : {0}", po.quantite)
    End Sub
End Module
