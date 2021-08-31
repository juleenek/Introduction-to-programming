using System;
using System.Collections.Generic;
using System.Text;

namespace LogikaGry
{
    public class Ruch
    {
        public int? Propozycja { get; }
        public Gra.Odpowiedz? Wynik { get;  } // Gra.Odpowiedz to typ danych
        public DateTime Czas { get; }
        public Gra.Status StatusGry { get; }

        // Konstruktor 

        public Ruch(int? propozycja, Gra.Odpowiedz? wynik, Gra.Status statusGry)
        {
            Propozycja = propozycja;
            Wynik = wynik;
            Czas = DateTime.Now;
            StatusGry = statusGry;
        }
    }
}
