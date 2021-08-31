using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LogikaGry; 

namespace TestProjectGra
{
    // Test > Analyze Code Coverage for all Tests - analiza pokrycia kodu z testami, czy ca³y kod zosta³ objêty w testach (rozszerzona wersja VS)
    // Showe Code Coverage Coloring - podœwietlenie w kodzie, które fragmenty nie zosta³y objête w te
    // Test > Run all Tests - uruchomienie testów 

    [TestClass] // Adnotacje/atrybuty - metainformacje, informacje dodatkowe po to by inne œrodowisko (np. frameworki) wiedzia³o, do czego konstrukcja ma s³u¿yæ
    public class UnitTest1
    {
        [TestMethod]
        public void KonstruktorBezargumentowy_MinZakresNa1()
        {
            // AAA - arrange-act-assert (zaaran¿uj, zadzia³aj, zweryfikuj)

            // Arrange
            int oczekiwanyMinZakres = 1;

            // Act 
            var gra = new Gra(); // Kontruktor domyœlny

            // Asssert
            Assert.AreEqual(oczekiwanyMinZakres, gra.MinZakres); // Klasa Assert - grupa procedur które weryfikuj¹ prawdziwoœæ pewnych zdarzeñ
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

        // Test czy pojawi siê wyj¹tek
        [DataTestMethod]
        [DataRow(50, 10)]
        [DataRow(50, 50)]
        [ExpectedException(typeof(ArgumentException))] // Oczekujemy zg³oszenia wyj¹tku
        public void KonstruktorDwuargumentowy_MinZakres_i_MaxZakresNiepoprawne(int min, int max)
        {
            // Act 
            var gra = new Gra(min, max);
        }
    }
}
