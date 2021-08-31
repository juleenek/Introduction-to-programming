using System;

namespace x
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();

        static void LiteraX(int n)
        {
            if (n < 3)
            {
                throw new ArgumentException("zbyt mały rozmiar");
            }
            if (n % 2 == 0)
            {
                n = n + 1;
            }

            //górna połówka
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Space();
                }

                Star();

                for (int j = 0; j < n - 2 - 2 * i; j++)
                {
                    Space();
                }

                StarLn();
            }

            //gwiazdka po środku

            for (int i = 0; i <= n - 1; i++) 
            {
                if (i != n / 2)
                {
                    Space();
                }
                else
                {
                    Star();
                }
            }

            SpaceLn();

            //dolna połówka

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < (n / 2) - i - 1 ; j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < i * 2 + 1  ; j++)
                {
                    Space();
                }
                StarLn();

            }


        }
        static void Main(string[] args)
        {
            LiteraX(15);
        }
    }
}
