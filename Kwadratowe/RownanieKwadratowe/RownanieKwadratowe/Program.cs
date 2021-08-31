using System;


namespace RownanieKwadratowe
{
    class Program
    {
        public static void QuadraticEquation(int a, int b, int c)
        {
            System.Globalization.CultureInfo customCulture =
                (System.Globalization.CultureInfo) System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator =
                "."; // zamiana automatycznego przecinka w numerycznych wartościach na kropkę 

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            if (a == 0 && b == 0 && c == 0)
            {
                Console.Write("infinity");
            }
            else if (a != 0)
            {
                long delta = (b * b) - (4 * a * c);

                    if (delta > 0)
                    {
                        decimal deltaElement = (decimal) Math.Sqrt((long) delta);

                        decimal x1 = (-b - deltaElement) / (2 * a);
                        decimal x2 = (-b + deltaElement) / (2 * a);

                        x1 = Math.Round(x1, 2);
                        x2 = Math.Round(x2, 2);

                        string number1 = Convert.ToString(x1);
                        int length1 = number1.Substring(number1.IndexOf(".") + 1).Length;

                        string number2 = Convert.ToString(x2);
                        int length2 = number2.Substring(number2.IndexOf(".") + 1).Length;

                    if (x1 % 1 == 0)
                    {
                        Console.WriteLine("x1=" + x1 + ".00");
                    }
                    else if(length1 == 1)
                    {
                        Console.WriteLine("x1=" + x1 + "0");
                    }
                    else
                    {
                        Console.WriteLine("x1=" + x1);
                    }

                    if (length2 == 0)
                    {
                        Console.WriteLine("x2=" + x2 + ".00");
                    }
                    else if (length2 == 1)
                    {
                        Console.WriteLine("x1=" + x1 + "0");
                    }
                    else
                    {
                        Console.WriteLine("x2=" + x2);
                    }

                    }
                    else if (delta == 0)
                    {

                        decimal x = (decimal)(-b) / (decimal)(2 * a);
                        x = Math.Round(x, 2);

                        string number = Convert.ToString(x);
                        int length = number.Substring(number.IndexOf(".") + 1).Length; // ...

                        if (length == 0)
                        {
                            Console.WriteLine("x=" + x + ".00");
                        }
                        else if (length == 1)
                        {
                            Console.WriteLine("x=" + x + "0");
                        }
                        else
                        {
                            Console.WriteLine("x=" + x);

                        }
                    }
                    else if (delta < 0)
                    {
                        Console.Write("empty");
                    }
                
            }
            else if (b == 0)
            {
                Console.WriteLine("empty");
            }
            else 
            {
                decimal x = (decimal)(0 - c) / (decimal)b;
                x = Math.Round(x, 2);

                string number = Convert.ToString(x);
                int length = number.Substring(number.IndexOf(".") + 1).Length;

                if (length == 0)
                {
                    Console.WriteLine("x=" + x + ".00");
                }
                else if(length == 1)
                {
                    Console.WriteLine("x=" + x + "0");
                }
                else
                {
                    Console.WriteLine("x=" + x);
                    
                }
            }
        }

        static void Main(string[] args)
        {
            QuadraticEquation(1,3,2);
        }
    }
}
