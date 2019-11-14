using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4
{
    public class Kalkulator
    {
        public static string WczytajLiczbe(string licznik)
        {
            Console.WriteLine("Podaj liczbę " + licznik + ": ");
            string tekst = Console.ReadLine();
            return tekst;
        }
        public static int Dodawanie(int liczba1, int liczba2)
        {
            return liczba1 + liczba2;
        }
        public static int Odejmowanie(int liczba1, int liczba2)
        {
            return liczba1 - liczba2;
        }
        public static int Mnożenie(int liczba1, int liczba2)
        {
            return liczba1 * liczba2;
        }
        public static double Dzielenie(int liczba1, int liczba2, out bool powodzenie)
        {
            if (liczba2 == 0)
            {
                powodzenie = false;
                return 0;
            }
            powodzenie = true;
            return (double)liczba1 / liczba2;
        }
        public static double PoodzielZWyjatkiem(int liczba1, int liczba2)
        {
            if (liczba2 == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)liczba1 / liczba2;
        }
        public static int Dodawanie(string x, string y)
        {
            int tekst1 = Convert.ToInt32(x);
            int tekst2 = Convert.ToInt32(y);
            return Dodawanie(tekst1, tekst2);
        }
    }
}
