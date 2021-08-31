using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LogikaGry; 

namespace TestProjectGra
{
    // Test > Analyze Code Coverage for all Tests - analiza pokrycia kodu z testami, czy ca�y kod zosta� obj�ty w testach (rozszerzona wersja VS)
    // Showe Code Coverage Coloring - pod�wietlenie w kodzie, kt�re fragmenty nie zosta�y obj�te w te
    // Test > Run all Tests - uruchomienie test�w 

    [TestClass] // Adnotacje/atrybuty - metainformacje, informacje dodatkowe po to by inne �rodowisko (np. frameworki) wiedzia�o, do czego konstrukcja ma s�u�y�
    public class UnitTest1
    {
        [TestMethod]
        public void KonstruktorBezargumentowy_MinZakresNa1()
        {
            // AAA - arrange-act-assert (zaaran�uj, zadzia�aj, zweryfikuj)

            // Arrange
            int oczekiwanyMinZakres = 1;

            // Act 
            var gra = new Gra(); // Kontruktor domy�lny

            // Asssert
            Assert.AreEqual(oczekiwanyMinZakres, gra.MinZakres); // Klasa Assert - grupa procedur kt�re weryfikuj� prawdziwo�� pewnych zdarze�
        }
        [TestMethod]
        public void KonstruktorBezargumentowy_MaxZakresNa100()
        {
            // Arrange
            int oczekiwanyMaxZakres = 100;

            // Act 
            var gra = new Gra(); 

            // Asssert
            Assert.AreEqual(oczekiwanyMaxZakres, gra.MaxZakres); 
        }
        [DataTestMethod]
        [DataRow(10,50)] //DataRow(min, max)
        [DataRow(-10, 50)]
        [DataRow(1, 100)]
        [DataRow(int.MinValue, int.MaxValue)]
        public void KonstruktorDwuargumentowy_MinZakres_i_MaxZakresPoprawne(int min, int max) 
        {
            // Arrange
            int oczekiwanyMinZakres = min;
            int oczekiwanyMaxZakres = max;

            // Act 
            var gra = new Gra(min, max);

            // Asssert
            Assert.AreEqual(oczekiwanyMinZakres, gra.MinZakres);
            Assert.AreEqual(oczekiwanyMaxZakres, gra.MaxZakres);
        }

        // Test czy pojawi si� wyj�tek
        [DataTestMethod]
        [DataRow(50, 10)]
        [DataRow(50, 50)]
        [ExpectedException(typeof(ArgumentException))] // Oczekujemy zg�oszenia wyj�tku
        public void KonstruktorDwuargumentowy_MinZakres_i_MaxZakresNiepoprawne(int min, int max)
        {
            // Act 
            var gra = new Gra(min, max);
        }
    }
}
