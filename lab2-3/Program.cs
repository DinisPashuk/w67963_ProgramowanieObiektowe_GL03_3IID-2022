using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_3.classes;

namespace lab2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zad1();
            //Zad2();
            //Zad3();
            Zad4();
        }
        static void Zad1()
        {
            Licz licz1 = new Licz(10);
            licz1.Dodaj(5);
            licz1.Odejmij(3);
            licz1.WypiszStan();
        }
        static void Zad2()
        {
            Sumator sum1 = new Sumator([1,2,3,4,5,6]);
            Console.WriteLine(sum1.Suma());
            Console.WriteLine(sum1.SumaPodziel3());
            Console.WriteLine(sum1.IleElementow());
            sum1.Elementy();
            sum1.WypishElementy(-2, 4);
        }
        static void Zad3()
        {
            Samochod BMW = new Samochod("BMW", "M5", 2018, 0);

            try
            {
                BMW.UruchomSilnik();
                BMW.UstawTempomat(100);
                BMW.ZwiekaszPredkosc();
                
                double czas = BMW.PrzejechanyDystans(200); 
                Console.WriteLine($"Czas potrzebny na pokonanie dystansu: {czas} godzin.");

                BMW.ZatrzymajSilnik();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }
        static void Zad4()
        {
            Samohod samochodOsoby = new Samohod("Ford", "Focus");

           
            Osoba osoba = new Osoba("Anna", "Nowak", new DateTime(2003, 4, 15));
            osoba.UstawSamochod(samochodOsoby);

           
            bool czyPelnoletnia = osoba.CzyPelnoletnia();
            Console.WriteLine($"{osoba.ImieINazwisko} jest " + (czyPelnoletnia ? "pełnoletnia" : "niepełnoletnia"));

            
            osoba.ZmienNazwisko("Kowalska");
            Console.WriteLine($"Nowe nazwisko: {osoba.ImieINazwisko}");

        
            Console.WriteLine(osoba.InformacjaOSamochodzie());
        }
    }
}
