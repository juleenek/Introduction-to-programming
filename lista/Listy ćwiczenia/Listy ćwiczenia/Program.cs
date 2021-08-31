using System;
using System.Collections.Generic;

namespace Listy_ćwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zwierzeta = new List<string> {"kot", "pies", "koń", "szczur", "ryba", "delfin", "pszczoła"};
            
           /* foreach(var x in zwierzeta)
            {
               Console.WriteLine(x);
            } */

            zwierzeta.RemoveAt(1); // usuwanie drugi element
            zwierzeta.RemoveAt(zwierzeta.Count - 1); // usuwanie ostatni element

            /*foreach (var x in zwierzeta)
            {
                Console.WriteLine(x);
            }*/

            zwierzeta.Insert(zwierzeta.Count, "mucha"); // dodawanie ostatni element

            /*foreach (var x in zwierzeta)
            {
                Console.WriteLine(x);
            }*/

            zwierzeta.Insert(0 , "gazela"); // dodawanie do pierwszej komórki 

            /*foreach (var x in zwierzeta)
            {
                Console.WriteLine(x);
            }*/

            zwierzeta.RemoveAll(x => x == "gazela"); // usuwanie "gazel"

            /*foreach (var x in zwierzeta)
            {
                Console.WriteLine(x);
            }*/

            Console.WriteLine(zwierzeta.Exists(x => x == "mucha")); // czy jest taka wartość

            zwierzeta.Reverse(); // odwraca elementy

            /*foreach (var x in zwierzeta)
            {
                Console.WriteLine(x);
            }*/

            zwierzeta.Sort(); // sortowanie elementów

            foreach (var x in zwierzeta)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(zwierzeta.IndexOf("mucha")); // indeks "muchy"

            zwierzeta.Insert(2, "zebra");

            zwierzeta.Sort((s1, s2) => s1.Length - s2.Length); // sortowanie ze względu na długość wyrazów

            /*foreach (var x in zwierzeta)
            {
                Console.WriteLine(x);
            }*/

            zwierzeta.Sort((x, y) => y.CompareTo(x)); // sortowanie malejące

            foreach (var x in zwierzeta)
            {
                Console.WriteLine(x);
            }
        }
    }
}
