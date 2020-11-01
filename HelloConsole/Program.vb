Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim resultat As Integer
        Dim calc As New Calculatrice()

        resultat = calc.Additionner(2, 7)
        Console.WriteLine($"Résultat : {resultat}")

    End Sub
End Module
