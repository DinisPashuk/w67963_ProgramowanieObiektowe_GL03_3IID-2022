using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Sprawdź parzystość liczby");
                Console.WriteLine("2 - Wypisz parzyste liczby do N");
                Console.WriteLine("3 - Oblicz silnię liczby");
                Console.WriteLine("4 - Gra zgadnij liczbę");
                Console.WriteLine("5 - Przeliczanie jednostek");
                Console.WriteLine("Wybierz opcję:");

                int wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        Parzystosc();
                        break;
                    case 2:
                        LiczbyParzyste();
                        break;
                    case 3:
                        Silnia();
                        break;
                    case 4:
                        Gra();
                        break;
                    case 5:
                        Jednostki();
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór");
                        break;
                }
            }

        }
        private static void Parzystosc()
        {
            Console.WriteLine("Podaj liczbe:");
            int liczba = Convert.ToInt32(Console.ReadLine());
            if (liczba % 2 == 0)
            {
                Console.WriteLine("liczba parzysta");
            }
            else
            {
                Console.WriteLine("liczba nie parzysta");
            }
        }
        private static void LiczbyParzyste()
        {
            Console.WriteLine("Podaj liczbe:");
            int liczba = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= liczba; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i); }
            }
        }
        private static void Silnia()
        {
            Console.WriteLine("Podaj liczbe:");
            int liczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Silnia liczby {liczba} wynosi: {Silnia(liczba)}");
            static long Silnia(int n)
            {
                if (n <= 1) return 1;
                else return n * Silnia(n - 1);
            }
        }
        private static void Gra()
        {
            Random random = new Random();
            int liczbaDoZgadniecia = random.Next(1, 101);
            int proba = 0;
            int strzal = 0;

            Console.WriteLine("Zgadnij liczbę od 1 do 100");

            while (strzal != liczbaDoZgadniecia)
            {
                Console.WriteLine("Podaj liczbę:");
                strzal = Convert.ToInt32(Console.ReadLine());
                proba++;

                if (strzal < liczbaDoZgadniecia) Console.WriteLine("Za mało!");
                else if (strzal > liczbaDoZgadniecia) Console.WriteLine("Za dużo!");
            }

            Console.WriteLine($"Gratulacje! Zgadłeś liczbę w {proba} próbach.");
        }
        private static void Jednostki()
        {
            Console.WriteLine("1 - Celsiusz na Fahrenheita");
            Console.WriteLine("2 - Metry na centymetry");
            Console.WriteLine("Wybierz opcję:");
            int wybor = Convert.ToInt32(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Podaj temperaturę w stopniach Celsiusza:");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = CelsiusNaFahrenheit(celsius);
                    Console.WriteLine($"{celsius} stopni C = {fahrenheit} stopni F");
                    break;
                case 2:
                    Console.WriteLine("Podaj długość w metrach:");
                    double metry = Convert.ToDouble(Console.ReadLine());
                    double centymetry = MetryNaCentymetry(metry);
                    Console.WriteLine($"{metry} m = {centymetry} cm");
                    break;
            }
            static double CelsiusNaFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            static double MetryNaCentymetry(double metry)
            {
                return metry * 100;
            }
        }
    }
}

