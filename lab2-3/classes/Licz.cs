using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3.classes
{
    class Licz
    {
        private double wartosc;
        public Licz(double wartosc)
        {
            this.wartosc = wartosc;
        }
        public void Dodaj(double wartoscDoDodania)
        {
            wartosc += wartoscDoDodania;
        }


        public void Odejmij(double wartoscDoOdjecia)
        {
            wartosc -= wartoscDoOdjecia;
        }

        public void WypiszStan()
        {
            Console.WriteLine($"Wartość: {wartosc}");
        }
    }
}
