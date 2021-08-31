using System;

namespace LED
{
    class Program
    {
        static void PrintNumber1(string[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                Console.Write(arr[0, row]);
            }
        }
        static void PrintNumber2(string[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                Console.Write(arr[1, row]);
            }
        }
        static void PrintNumber3(string[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                Console.Write(arr[2, row]);
            }
        }

        static void Main(string[] args)
        {
            String[,] zero = {{" ", "_", " "}, {"|", " ", "|"}, {"|", "_", "|"}};
            String[,] one = {{" ", " ", " "}, {" ", " ", "|"}, {" ", " ", "|"}};
            String[,] two = {{" ", "_", " "}, {" ", "_", "|"}, {"|", "_", " "}};
            String[,] three = {{" ", "_", " "}, {" ", "_", "|"}, {" ", "_", "|"}};
            String[,] four = {{" ", " ", " "}, {"|", "_", "|"}, {" ", " ", "|"}};
            String[,] five = {{" ", "_", " "}, {"|", "_", " "}, {" ", "_", "|"}};
            String[,] six = {{" ", "_", " "}, {"|", "_", " "}, {"|", "_", "|"}};
            String[,] seven = {{" ", "_", " "}, {" ", " ", "|"}, {" ", " ", "|"}};
            String[,] eight = {{" ", "_", " "}, {"|", "_", "|"}, {"|", "_", "|"}};
            String[,] nine = {{" ", "_", " "}, {"|", "_", "|"}, {" ", " ", "|"}};

            string line = Console.ReadLine();
            char[] numbers = line.ToCharArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == '0')
                {
                    PrintNumber1(zero);
                }
                else if (numbers[i] == '1')
                {
                    PrintNumber1(one);
                }
                else if (numbers[i] == '2')
                {
                    PrintNumber1(two);
                }
                else if (numbers[i] == '3')
                {
                    PrintNumber1(three);
                }
                else if (numbers[i] == '4')
                {
                    PrintNumber1(four);
                }
                else if (numbers[i] == '5')
                {
                    PrintNumber1(five);
                }
                else if (numbers[i] == '6')
                {
                    PrintNumber1(six);
                }
                else if (numbers[i] == '7')
                {
                    PrintNumber1(seven);
                }
                else if (numbers[i] == '8')
                {
                    PrintNumber1(eight);
                }
                else if (numbers[i] == '9')
                {
                    PrintNumber1(nine);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == '0')
                {
                    PrintNumber2(zero);
                }
                else if (numbers[i] == '1')
                {
                    PrintNumber2(one);
                }
                else if (numbers[i] == '2')
                {
                    PrintNumber2(two);
                }
                else if (numbers[i] == '3')
                {
                    PrintNumber2(three);
                }
                else if (numbers[i] == '4')
                {
                    PrintNumber2(four);
                }
                else if (numbers[i] == '5')
                {
                    PrintNumber2(five);
                }
                else if (numbers[i] == '6')
                {
                    PrintNumber2(six);
                }
                else if (numbers[i] == '7')
                {
                    PrintNumber2(seven);
                }
                else if (numbers[i] == '8')
                {
                    PrintNumber2(eight);
                }
                else if (numbers[i] == '9')
                {
                    PrintNumber2(nine);
                }

            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == '0')
                {
                    PrintNumber3(zero);
                }
                else if (numbers[i] == '1')
                {
                    PrintNumber3(one);
                }
                else if (numbers[i] == '2')
                {
                    PrintNumber3(two);
                }
                else if (numbers[i] == '3')
                {
                    PrintNumber3(three);
                }
                else if (numbers[i] == '4')
                {
                    PrintNumber3(four);
                }
                else if (numbers[i] == '5')
                {
                    PrintNumber3(five);
                }
                else if (numbers[i] == '6')
                {
                    PrintNumber3(six);
                }
                else if (numbers[i] == '7')
                {
                    PrintNumber3(seven);
                }
                else if (numbers[i] == '8')
                {
                    PrintNumber3(eight);
                }
                else if (numbers[i] == '9')
                {
                    PrintNumber3(nine);
                }
            }
        }
    }
    
}
