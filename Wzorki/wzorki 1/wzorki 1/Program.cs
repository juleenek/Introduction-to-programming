using System;

namespace wzorki_1
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();
        public static void Prostokat(int n, int m)
        {
            for (int i = 0; i < n; i++) // górny bok 
            {
                Star();
            }
            NewLine();

            for (int j = 1; j < m - 1; j++) // następne rzędy bez dolnego boku
            {
                Star();
                for (int i = 1; i < n - 1; i++)
                    Space();

                StarLn();
            }

            for (int i = 0; i < n; i++) // dolny bok
            {
                Star();
            }
            NewLine();
        }
        static void Main(string[] args)
        {
            Prostokat(8,3);
        }
    }
}
