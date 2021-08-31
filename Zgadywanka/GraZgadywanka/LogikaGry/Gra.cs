using System;
using System.Collections.Generic;

namespace LogikaGry
{
    public class Gra
    {
        // Dane
        private readonly int wylosowanaLiczba; // wartość można ustawić tylko w konstruktorze (readonly)
        public int MinZakres { get; }
        public int MaxZakres { get; }

        public int? WylosowanaLiczba // Liczba całkowita albo null, możliwość występowania null, int nie może przyjmować na ogół null, int i int? to dwa rózne typy!
        {
            get
            {
                if(StatusGry != Status.Trwa)
                    return wylosowanaLiczba;

                return null;
            }
        }

        public enum Status { Trwa, Poddana, Zakonczona }
        public Status StatusGry { get; private set; }

        // Dane - Historia gry, lista ruchów

        private List<Ruch> historiaGry;
        public IReadOnlyList<Ruch> HistoriaGry => historiaGry; // przez HistoriaGry property odwołuje się do pola historiaGry

        // Konstruktory - zainicjowanie danych

        // public Gra() : this(1,100) Konstruktor domyślny - ma uruchomić konstruktor ogólny z parametrami od 1 do 100 (w C# robi się to na poziomie nagłówka) - łańcuchowanie konstruktorów 
        // {          
        // } 
        public Gra(int min = 1, int max = 100) 
        {
            if (min >= max)
                throw new ArgumentException("Min musi być mniejszy od max");

            wylosowanaLiczba = (new Random()).Next(min, max + 1); // z wyłączeniem górnej granicy
            MinZakres = min;
            MaxZakres = max;
            historiaGry = new List<Ruch>();
            StatusGry = Status.Trwa;
        }

        // Inne metody

        public Odpowiedz Ocena(int propozycja) 
        {
            if (propozycja < wylosowanaLiczba)
            {
                historiaGry.Add(new Ruch(propozycja, Odpowiedz.ZaMalo, StatusGry));
                return Odpowiedz.ZaMalo;
            }
            else if (propozycja > wylosowanaLiczba)
            {
                historiaGry.Add(new Ruch(propozycja, Odpowiedz.ZaDuzo, StatusGry));
                return Odpowiedz.ZaDuzo;
            }
            else
            {
                StatusGry = Status.Zakonczona;
                historiaGry.Add(new Ruch(propozycja, Odpowiedz.Trafiony, StatusGry));
                return Odpowiedz.Trafiony;
            }     
        }
        public enum Odpowiedz {ZaMalo = -1 , Trafiony = 0, ZaDuzo = 1}; // Enum - zbiór stałych (np. kolory), stany które się nie zmienią

        public void Poddaj()
        {
            StatusGry = Status.Poddana;
            historiaGry.Add(new Ruch(null, null, StatusGry));
        }
    }
}
