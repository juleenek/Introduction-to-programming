using System;
using System.Collections.Generic;
using System.Text;
using LogikaGry;

namespace GraConsoleApp
{
    public class Kontroler // Musi wiedzieć z kim współpracuje, dostęp do Gry i Widoku
    {
        private Gra gra;
        private Widok widok;

        public Kontroler() // Zainicjowanie swoich pól, inicjuje obiekty w sposób domyślny 
        {
            gra = new Gra();
            widok = new Widok();
        }

        public void Rozgrywka() // Nowa gra
        {
            widok.CzyscEkran();
            // ToDo: obsługa zakresu do losowania
            gra = new Gra(1, 100);
            do
            {
                int propozycja;
                try
                {
                    propozycja = widok.WczytajLiczbe();
                }
                catch (PrzerwanieWprowadzenieException)
                {
                    break;
                }

                switch (gra.Ocena(propozycja))
                {
                    case Gra.Odpowiedz.ZaDuzo:
                        widok.WypiszKomunikatZaDuzo(); break;
                    case Gra.Odpowiedz.ZaMalo:
                        widok.WypiszKomunikatZaMalo(); break;
                    case Gra.Odpowiedz.Trafiony:
                        widok.WypiszKomunikatZaTrafiony(); break;
                }
            }
            while (gra.StatusGry == Gra.Status.Trwa);
            // Wypisz statystyki gry
            // Wypisz historię
        }

        public void Run()
        {
            widok.CzyscEkran();
            widok.WypiszOpisGry();
            while (widok.ChceszKontyuowac())
            {
                Rozgrywka();
            }
        }
    }
}
