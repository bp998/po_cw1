using System;

namespace Lab8_Bartosz_Potyrała
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ulamek liczba1 = new Ulamek(3,4);
            Ulamek liczba2 = new Ulamek(1,2);

            Console.WriteLine("liczba1 = " + liczba1.ToString());
            Console.WriteLine("liczba2 = " + liczba2.ToString());


            Ulamek mnozenie = liczba1 * liczba2;
            Ulamek dzielenie = liczba1 / liczba2;
            Ulamek dodawanie = liczba1 + liczba2;
            Ulamek odejmowanie = liczba1 - liczba2;

            Console.WriteLine("wynik mnozenia = " + mnozenie.ToString());
            Console.WriteLine("wynik dzielenia = " + dzielenie.ToString());
            Console.WriteLine("wynik dodawanie = " + dodawanie.ToString());
            Console.WriteLine("wynik odejmowanie = " + odejmowanie.ToString());
        }
    }
}
