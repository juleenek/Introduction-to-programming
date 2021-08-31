using System;

namespace Tablica_postrzępiona
{
    class Program
    {
        static char[][] ReadJaggedArrayFromStdInput()
        {
            int inputRows = Convert.ToInt32(Console.ReadLine());
            string inputString;

            char[][] arr = new char[inputRows][];

            if (inputRows < 10)
            {
                for (int i = 0; i < inputRows; i++)
                {
                    inputString = Console.ReadLine();
                    char[] arrayElement = Array.ConvertAll<string, char>(inputString.Split(" "), char.Parse);

                    arr[i] = arrayElement;
                }
            }

            return arr;
        }

        static void PrintJaggedArrayToStdOutput(char[][] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write(tab[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        static char[][] TransposeJaggedArray(char[][] tab)
        {
            int rowsNumber = 0;

            // int rowsNumber = tab.Max(x => x.Length);

            foreach (char[] rows in tab)
            {
                if (rows.Length > rowsNumber)
                {
                    rowsNumber = rows.Length;
                }
            }
            int columsNumber = tab.Length;

            char[][] result = new char[rowsNumber][];

            for (int i = 0; i < rowsNumber; i++)  // !!!
            {
                result[i] = new char[tab.Length]; // dla każdego wiesza result, przepisywana jest tablica o długości, długości tablicy tab (ilości tablic jakich posiada)
            }

            for (int row = 0; row < rowsNumber; row++)
            {
                for (int col = 0; col < tab.Length; col++)
                {
                    try
                    {
                        result[row][col] = tab[col][row];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        result[row][col] = ' ';
                    }
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            char[][] jagged = ReadJaggedArrayFromStdInput();

            PrintJaggedArrayToStdOutput(jagged);

            jagged = TransposeJaggedArray(jagged);

            Console.WriteLine();

            PrintJaggedArrayToStdOutput(jagged);
        }
    }
}
