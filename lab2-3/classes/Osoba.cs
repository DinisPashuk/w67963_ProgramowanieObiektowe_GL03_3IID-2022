using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3.classes
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private DateTime dataUrodzenia;
        private Samohod samochod; 

        public string ImieINazwisko => $"{imie} {nazwisko}";

        public Osoba(string imie, string nazwisko, DateTime dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.samochod = null; 
        }

        public bool CzyPelnoletnia()
        {
            return (DateTime.Now - this.dataUrodzenia).TotalDays / 365.25 >= 18;
        }

        public void ZmienNazwisko(string noweNazwisko)
        {
            this.nazwisko = noweNazwisko;
        }

        public void UstawSamochod(Samohod samochod)
        {
            this.samochod = samochod;
        }

        public string InformacjaOSamochodzie()
        {
            if (this.samochod == null)
                return $"{ImieINazwisko} nie posiada samochodu.";
            else
                return $"{ImieINazwisko} posiada samochód: {samochod}";
        }
    }
    public class Samohod
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public Samohod(string marka, string model)
        {
            Marka = marka;
            Model = model;
        }

        public override string ToString()
        {
            return $"{Marka} {Model}";
        }
    }
}   
        
    
