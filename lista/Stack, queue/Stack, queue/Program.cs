using System;
using System.Collections.Generic;

namespace Stack__queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stos = new Stack<string>();
            Queue<string> kolejka = new Queue<string>();

            stos.Push("1");
            stos.Push("2");
            stos.Push("3");
            stos.Push("4");

            foreach (var s in stos)
            {
                Console.WriteLine(s);
            }

            kolejka.Enqueue("a");
            kolejka.Enqueue("b");
            kolejka.Enqueue("c");
            kolejka.Enqueue("d");

            foreach (var k in kolejka)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("-------------------");

            kolejka.Enqueue(stos.Peek());
            stos.Pop();

            kolejka.Enqueue(stos.Peek());
            stos.Pop();

            foreach (var k in kolejka)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("-------------------");

            Console.WriteLine(stos.Peek());
            Console.WriteLine(kolejka.Peek());

            Console.WriteLine("-------------------");

            kolejka.Enqueue("e");
            kolejka.Enqueue("e");

            foreach (var k in kolejka)
            {
                Console.WriteLine(k);
            }

        }
    }
}
