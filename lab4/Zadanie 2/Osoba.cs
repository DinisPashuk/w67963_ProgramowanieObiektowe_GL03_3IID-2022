using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Zadanie_2
{
    public abstract class Osoba
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public string Pesel { get; private set; }

        public void SetFirstName(string imie) => Imie = imie;
        public void SetLastName(string nazwisko) => Nazwisko = nazwisko;
        public void SetPesel(string pesel) => Pesel = pesel;

        public int GetAge()
        {
            int year = int.Parse(Pesel.Substring(0, 2));
            int month = int.Parse(Pesel.Substring(2, 2));
            year = month > 20 ? 2000 + year : 1900 + year;
            DateTime birthDate = new DateTime(year, month % 20, int.Parse(Pesel.Substring(4, 2)));
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate > DateTime.Today.AddYears(-age)) age--;
            return age;
        }

        public string GetGender() => (int.Parse(Pesel.Substring(9, 1)) % 2 == 0) ? "Kobieta" : "Mężczyzna";

        public abstract string GetEducationInfo();
        public string GetFullName() => $"{Imie} {Nazwisko}";
        public abstract bool CanGoAloneToHome();
    }
}
