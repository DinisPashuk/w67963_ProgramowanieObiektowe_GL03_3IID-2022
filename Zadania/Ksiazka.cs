using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public class Ksiazka
    {
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int RokWydania { get; set; }

        public Ksiazka(string tytul, string autor, int rokWydania)
        {
            Tytul = tytul;
            Autor = autor;
            RokWydania = rokWydania;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Tytuł: {Tytul}, Autor: {Autor}, Rok Wydania: {RokWydania}");
        }
    }
}