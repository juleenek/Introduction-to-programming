using System;
using System.Collections.Generic;
using System.Linq;

namespace Trojkat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę o podanie trzech boków trójkąta, wartości oddzielone spacją");
            string bokiWpisane = Console.ReadLine();
            List<int> boki = new List<int>(bokiWpisane.Split(' ').Select(int.Parse).ToList());
            Console.WriteLine();

            Trojkat t; // null, utworzenie zmiennej po to aby zapamiętać referencje do utworzonego obiektu, "link" do obiektu, zmienna referencyjna
            t = new Trojkat(boki[0], boki[1], boki[2]); // Fizyczne utworzenie obiektu w pamięci sterty typu Trojkat, uruchomienie konstruktora
            Console.WriteLine(t);

        }
    }
}
