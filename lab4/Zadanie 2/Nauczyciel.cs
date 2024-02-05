using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Zadanie_2
{
    public class Nauczyciel : Uczen
    {
        public string TytulNaukowy { get; set; }
        public List<Uczen> PodwladniUczniowie { get; set; } = new List<Uczen>();

        public void WhichStudentCanGoHomeAlone()
        {
            foreach (var uczen in PodwladniUczniowie.Where(u => u.CanGoAloneToHome()))
            {
                Console.WriteLine($"{uczen.GetFullName()} - {uczen.GetGender()} – Może iść sam do domu");
            }
        }

        public void PrintInfo(DateTime date)
        {
            string dayOfWeek = date.ToString("dddd");
            Console.WriteLine($"{Szkola} Dnia: {dayOfWeek}");
            Console.WriteLine($"Nauczyciel: {TytulNaukowy} {GetFullName()}");
            Console.WriteLine("Lista studentów:");
            int lp = 1;
            foreach (var uczen in PodwladniUczniowie)
            {
                string verdict = uczen.CanGoAloneToHome() ? "Może iść sam do domu" : "Nie może iść sam do domu";
                string reasoning = uczen.Info();
                Console.WriteLine($"{lp}. {uczen.GetFullName()} - {uczen.GetGender()} – {verdict} {reasoning}");
                lp++;
            }
        }

    }
}
