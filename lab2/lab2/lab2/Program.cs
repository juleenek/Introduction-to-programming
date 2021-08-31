using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
            // Twój kod
            int a = dane[0]; 
            int b = dane[1]; 
            int c = dane[2]; 
            if (a < b && c > 0)  
            {
                if ((b - a) / c <= 12) 
                {
                    if ((b - a) - c > 0 || (a < 0 && (b - a) / c <= 1))
                    {
                        if ((b - a) == 1 || (b - a) == -1)
                        {
                            Console.WriteLine("empty");
                        }
                        else
                        {
                            for (int i = ++a; i < b - c; i++)
                            {
                                if (i % c == 0)
                                {
                                    Console.Write($"{i}, ");
                                }
                            }

                            for (int i = b - c; i < b; i++)
                            {
                                if (i % c == 0)
                                {
                                    Console.Write(i);
                                }
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("empty");
                    }
                }
                else if ((b - a) / c >= 10) 
                {
                    for (int i = ++a; i < (a + (3 * c)); i++)
                    {
                        if (i % c == 0)
                        {
                            Console.Write($"{i}, ");
                        }
                    }

                    Console.Write("..., ");

                    for (int i = (b - (c * 2)); i < b - c; i++)
                    {
                            if (i % c == 0)
                            {
                                Console.Write($"{i}, ");
                            }
                    }

                    for (int i = b - c; i < b; i++)
                    {
                        if (i % c == 0)
                        {
                            Console.Write(i);
                        }
                    }
                }
               
            } else if (a > b && c > 0) 
            {

                if ((a - b) / c <= 11)
                {
                    if ((a - b) - c > 0 || (b < 0 && (a - b) / c <= 1)) 
                    {
                        if ((a - b) == 1 || (a - b) == -1)
                        {
                            Console.WriteLine("empty");
                        }
                        else
                        {

                            for (int i = ++b; i < a - c; i++) 
                            {
                                if (i % c == 0)
                                {
                                    Console.Write($"{i}, ");
                                }
                            }

                            for (int i = a - c; i < a; i++)
                            {
                                if (i % c == 0) 
                                {
                                    Console.Write(i);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("empty");
                    }
                }
                else if ((a - b) / c >= 10) 
                {
                        for (int i = ++b; i < (b + (3 * c)); i++) 
                        {
                            if (i % c == 0)
                            {
                                Console.Write($"{i}, ");
                            }
                           
                        }

                        Console.Write("..., ");

                        for (int i = (a - (c * 2)); i < (a - c); i++) 
                        {
                            if (i % c == 0)
                            {
                                Console.Write($"{i}, ");
                            }
                        }

                        for (int i = a - c; i < a; i++)
                        {
                            if (i % c == 0)
                            {
                                Console.Write(i);
                            }
                        }

                } else if ((a - b) - c <= 0) 
                {
                         Console.WriteLine("empty");
                }
            } else if(a == b)
            {
                Console.WriteLine("empty");
            }
          

        }
    }
}
