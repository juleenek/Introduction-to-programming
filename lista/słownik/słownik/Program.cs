using System;
using System.Collections.Generic;

namespace słownik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animalsList = new Dictionary<string, int>();
            animalsList.Add("kot", 4);
            animalsList.Add("pies", 4);
            animalsList.Add("kura", 2);
            animalsList.Add("wąż", 0);
            animalsList.Add("papuga", 2);

            foreach (var a in animalsList)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("--------------");

            Console.WriteLine(animalsList.ContainsKey("kot")); // Czy jest taki klucz
            Console.WriteLine(animalsList.ContainsKey("krowa"));

            Console.WriteLine("--------------");

            Console.WriteLine(animalsList.ContainsValue(6));

            Console.WriteLine("--------------");

            animalsList.Add("pająk", 6);

            foreach (var a in animalsList)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("--------------");

            animalsList["pająk"] = 8;

            foreach (var a in animalsList)
            {
                Console.WriteLine(a);
            }


        }
    }
}
