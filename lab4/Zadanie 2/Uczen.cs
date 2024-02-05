using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Zadanie_2
{
    public class Uczen : Osoba
    {
        public string Szkola { get; private set; }
        public bool MozeSamWracacDoDomu { get; private set; }

        public void SetSchool(string szkola) => Szkola = szkola;
        public void ChangeSchool(string nowaSzkola) => Szkola = nowaSzkola;
        public void SetCanGoHomeAlone(bool moze) => MozeSamWracacDoDomu = moze;

        public override string GetEducationInfo() => $"Szkoła: {Szkola}";

        public override bool CanGoAloneToHome()
        {
            if (GetAge() >= 12 || MozeSamWracacDoDomu) return true;
            return false;
        }

        public string Info()
        {
            return CanGoAloneToHome() ? "Może sam wracać do domu." : "Nie może sam wracać do domu.";
        }
    }
}
