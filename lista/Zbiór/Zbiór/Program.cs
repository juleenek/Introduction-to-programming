using System;
using System.Collections.Generic;

namespace Zbiór
{
    class Program
    {
        static void DisplaySet<T>(ISet<T> set)
        {
            foreach (var i in set)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int> {1, 3, 5, 2, 7, 8};
            HashSet<int> b = new HashSet<int> {2, 1, 5, 3, 9, 6};

            List<int> aList = new List<int>(a);
            List<int> bList = new List<int>(b);
            List<int> cList = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                cList.Add(aList[i] + bList[i]);
            }

            cList.Sort((c1, c2) => c2.CompareTo(c1)); // sortowanie malejące listy
            HashSet<int> c = new HashSet<int>(cList);
            
            DisplaySet(c);

            int sum = 0;
            double srednia = 0;

            foreach (var cl in cList)
            {
                sum += cl;
            }

            srednia = (double)sum / cList.Count;

            Console.WriteLine($"\nŚrednia: {srednia}\n");


            a.Overlaps(b); // wspólne elementy kolekcji

            Console.WriteLine("---------");

            DisplaySet(a);  

            Console.WriteLine("---------");

            HashSet<int> d = new HashSet<int> {6, 9};

            a.UnionWith(b);
            a.IntersectWith(d);
            DisplaySet(a);
        }
    }
}
