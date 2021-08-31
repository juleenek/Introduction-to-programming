using System;
using System.Collections.Generic;
using System.Text;
// using - przestrzeń nazwe z których chcemy korzystać 
// using - odwołuje się do klasy która w tej przestrzeni nazw jest używana, przygład ponieżej
using static System.Console; // Nie używać nadmiernie i nieświadomie


namespace GraConsoleApp
{
    public class PrzerwanieWprowadzenieException : Exception
    {

    }
    public class Widok
    {
        public const char znakZakonczenia = 'X';
        public readonly static string tekstRozpoczecia = $"Podaj liczbę (lub {znakZakonczenia} aby zakończyć grę):";

        public void CzyscEkran() => Clear(); // Console.Clear();

        public void WypiszOpisGry()
        {
            WriteLine("Niech program wylosuje liczbę, a ty odgadnij ją!");
        }
        public void WypiszKomunikatZaMalo()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Za mało");
            ResetColor();
        }
        public void WypiszKomunikatZaDuzo()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Za dużo");
            ResetColor();
        }
        public void WypiszKomunikatZaTrafiony()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Trafiony!");
            ResetColor();
        }

        public bool ChceszKontyuowac()
        {
            Write("Czy chcesz kontynuować? (napisz 't' jako tak lub 'n' jako nie)");
            char odp = ReadKey().KeyChar;
            WriteLine();

            return (odp == 't' || odp == 'T'); // 't' / 'T' jako true, każdy inny - false
        }

        // Wczytuje liczbę całkowitą lub gdy x to zgłasza wyjątek

        public int WczytajLiczbe()
        {
            int wynik = 0;

            while (true)
            {
                Write(tekstRozpoczecia);
                try
                {
                    string napis = ReadLine().Trim().ToUpper(); // Trim(); obcinanie ze spacji
                    if (napis.Length > 0 && napis[0].Equals(znakZakonczenia))
                        throw new PrzerwanieWprowadzenieException();

                    wynik = Convert.ToInt32(napis);
                    break;
                }
                catch (PrzerwanieWprowadzenieException e)
                {
                    WriteLine($"Naciśnięto {znakZakonczenia}. Przerywam.");
                    throw e; // podaj dalej
                }
                catch (FormatException)
                {
                    WriteLine("Wprowadzony tekst nie przypomina liczby całkowitej. Spróbuj jeszcze raz.");
                    continue;
                }
                catch (OverflowException)
                {
                    WriteLine("Przesadzone, za duża licza. Spróbuj jeszcze raz.");
                    continue;
                }
                catch (Exception)
                {
                    WriteLine("Nieznany błąd. Spróbuj jeszcze raz.");
                    continue;
                }
            }
            return wynik;
        }
    }
}
