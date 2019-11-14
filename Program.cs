using System;

namespace LAB4
{
   

    class Program
    {
       
        static void Main(string[] args)
        {
           
            string tekst1 = Kalkulator.WczytajLiczbe("1");
            string tekst2 = Kalkulator.WczytajLiczbe("2");
          
            
            Console.WriteLine("Wybierz operacje: ");
            string operacja = Console.ReadLine();

            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);


            switch (operacja)
            {
                case "+":
                    int wynik = Kalkulator.Dodawanie(tekst1, tekst2);
                    Console.WriteLine(wynik);
                    break;
                case "-":
                    int wynik1 = Kalkulator.Odejmowanie(liczba1, liczba2);
                    Console.WriteLine(wynik1);
                    break;
                case "*":
                    int wynik2 = Kalkulator.Mnożenie(liczba1, liczba2);
                    Console.WriteLine(wynik2);
                    break;
                case "/":
                  try
                    {
                        Console.WriteLine(Kalkulator.PoodzielZWyjatkiem(liczba1, liczba2));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Nie wolno dzielić przez 0");
                    }
                    
                  
                    /* double wynik3 = Dzielenie(liczba1, liczba2, out bool wynik4);
                    if (wynik4)
                    {
                        Console.WriteLine(wynik3);
                    }
                    else
                    {
                        Console.WriteLine("Nie wolno dzielić przez 0");
                    }
                    */
                    break;
                default:
                    Console.WriteLine("Wybrano złą operacje");
                    break;

            }
        }
    }
}
