using System;
using System.Collections.Generic;
using System.Text;

namespace Trojkat
{
    class Trojkat
    {
        // Dane 

        /* public double A - cała ta funkcjonalność została przeniesiona do konstruktora
        {
            get => a; // get => a, wyrzuć a
            private set  // read-only, nie można zmodyfikować z zewnątrz
            {
                if (value < 0) 
                    throw new ArgumentException("Ujemne wartości są niedopuszczlne");

                a = Math.Round(value, 4); // Przygotowanie do dalszego przetwarzania, selektywność 
            }
        } */

        public const int precyzja = 4; // const - stała
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        // Konstrukcja, rolą konstruktora jest zainicjowanie, przypisanie wartości (można automatycznie wygenerować przez ikonke śrubokrętu)

        public Trojkat(double a = 1, double b = 1, double c = 1) // Skorzystanie z konstruktora jest publiczne, konstruktor przyjmie trzy liczby
        {
            if (a < 0 || b < 0 || c < 0) throw new ArgumentException("Ujemne wartości są niedopuszczlne");

            if (a + b < c || a + c < b || b + c < a)

                throw new ArgumentException("Niespełniony warunek trójkąta");

            A = Math.Round(a, precyzja); // Zainicjowanie wszystkich składników 
            B = Math.Round(b, precyzja);
            C = Math.Round(c, precyzja);

            // C = Math.Round(c, 4); - bardzo zła praktyka umieszczanie tutaj liczby 4, lepiej gdzieś wyeksponować tą wartość żeby przy zmianie zmienić ją tylko w jednym miejscu


        }

        // Tekstowa reprezentacja - obiekt zamień na string

        public override string ToString()
        {         
            if(IsRownoboczny == true)
            {
                return $"Trójkat(a={A}, b={B}, c={C})\nObwód trojkąta: {Obwod}\nPole trojkąta: {Pole}\nTrójkąt jest równoboczny";
            } else if(IsRozwartokatny == true)
            {
                return $"Trójkat(a={A}, b={B}, c={C})\nObwód trojkąta: {Obwod}\nPole trojkąta: {Pole}\nTrójkąt jest rozwartokątny";
            }
            else if(IsProstokatny == true)
            {
                return $"Trójkat(a={A}, b={B}, c={C})\nObwód trojkąta: {Obwod}\nPole trojkąta: {Pole}\nTrójkąt jest prostokątny";
            }
            else if(IsOstrokatny == true)
            {
                return $"Trójkat(a={A}, b={B}, c={C})\nObwód trojkąta: {Obwod}\nPole trojkąta: {Pole}\nTrójkąt jest ostrokątny";
            }
            else
            {
                return $"Trójkat(a={A}, b={B}, c={C})\nObwód trojkąta: {Obwod}\nPole trojkąta: {Pole}";
            }
        }

        // Bardziej skomplikowana w klamry
        

        // Zachowanie (Tutaj obliczenie obwodu, pola itp.) 

        public double ObliczObwod() => Math.Round(A + B + C, precyzja); // Funkcja
        public double Obwod => Math.Round(A + B + C, precyzja); // => jako get, wszystko jest jako property

        public double Pole => Math.Round((double)Math.Sqrt((double)(A + B + C) * (A+B-C) * (A-B+C) * (-A+B+C)) / 4, precyzja);// => throw new NotImplementedException(); - NotImplementedException - nie zostało zdefiniowane przez programistę

        public bool IsRownoboczny => (A == B && B == C); // Do property bool używamy nazwy IsNazwa
        public bool IsRozwartokatny => ((C * C) > (A * A) + (B * B));
        public bool IsProstokatny => ((C * C) == (A * A) + (B * B));
        public bool IsOstrokatny => ((C * C) < (A * A) + (B * B));

    }
}
