Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace HelloConsole.Test
    <TestClass>
    Public Class CalculatriceTest
        <TestMethod>
        Sub TestAdditionner()
            Dim calc As New Calculatrice()
            dim resultat = calc.Additionner(7, 5)
            Assert.AreEqual(12, resultat)
        End Sub
    End Class
End Namespace

