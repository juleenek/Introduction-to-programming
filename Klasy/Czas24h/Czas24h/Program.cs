using System;

namespace Czas24h
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] napis = null;
            Czas24h t = null;

            // wczytanie i parsowanie napisu oznaczającego godzinę, np. 2:15:27
            napis = Console.ReadLine().Split(':');
            int[] czas = Array.ConvertAll(napis, int.Parse);
            try
            {
                t = new Czas24h(czas[0], czas[1], czas[2]);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("error");
                return;
            }

            // wczytanie liczby poleceń
            int liczbaPolecen = int.Parse(Console.ReadLine());

            for (int i = 1; i <= liczbaPolecen; i++)
            {
                // wczytanie polecenia
                napis = Console.ReadLine().Split(' ');
                string typPolecenia = napis[0];
                int liczba = int.Parse(napis[1]);

                // wykonanie polecenia na obiekcie t typu Czas24h
                try
                {
                    switch (typPolecenia)
                    {
                        case "g":
                            t.Godzina = liczba;
                            break;
                        case "m":
                            t.Minuta = liczba;
                            break;
                        case "s":
                            t.Sekunda = liczba;
                            break;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            Console.WriteLine(t);
        }
    }

    public class Czas24h
    {
        private int liczbaSekund;

        public int Sekunda
        {
            get => liczbaSekund - Godzina * 60 * 60 - Minuta * 60;
            // uzupełnij kod - zdefiniuj setters'a
            set
            {
                if (value <= 59 && value >= 0)
                {
                    liczbaSekund = value + Godzina * 60 * 60 + Minuta * 60;
                }
                else
                {
                    throw new ArgumentException("error");
                }
            }
        }

        public int Minuta
        {
            get => (liczbaSekund / 60) % 60;
            // uzupełnij kod - zdefiniuj setters'a
            set
            {
                if (value <= 59 && value >= 0)
                {
                    liczbaSekund = Sekunda + Godzina * 60 * 60 + value * 60;
                }
                else
                {
                    throw new ArgumentException("error");
                }
                
            }
        }

        public int Godzina
        {
            get => liczbaSekund / 3600;
            // uzupełnij kod - zdefiniuj setters'a
            set
            {
                if (value <= 23 && value >= 0)
                {
                    liczbaSekund = Sekunda + value * 60 * 60 + Minuta * 60;
                }
                else
                {
                    throw new ArgumentException("error");
                }
                
            }
        }

        public Czas24h(int godzina, int minuta, int sekunda)
        {
            // uzupełnij kod zgłaszając wyjątek ArgumentException
            // w sytuacji niepoprawnych danych
            if (sekunda > 59 || minuta > 59 || godzina > 23 || sekunda < 0 || minuta < 0 || godzina < 0)
            {
                throw new ArgumentException("error");
            }

            liczbaSekund = sekunda + 60 * minuta + 3600 * godzina;
            Sekunda = sekunda;
            Minuta = minuta;
            Godzina = godzina;
        }

        public override string ToString() => $"{Godzina}:{Minuta:D2}:{Sekunda:D2}";
    }
}
