using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3.classes
{
    public class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int RokProdukcji { get; set; }

        private int predkosc;
        private int przebieg;
        private StanSilnika stanSilnika;

        public enum StanSilnika
        {
            Wylaczony,
            Uruchomiony,
            CheckEngine
        }

        public Samochod(string marka, string model, int rokProdukcji, int przebiegPoczatkowy)
        {
            Marka = marka;
            Model = model;
            RokProdukcji = rokProdukcji;
            przebieg = przebiegPoczatkowy;
            predkosc = 0;
            stanSilnika = StanSilnika.Wylaczony;
        }

        public int Predkosc => predkosc;

        public void UstawTempomat(int zadanaPredkosc)
        {
            if (stanSilnika == StanSilnika.Uruchomiony)
            {
                predkosc = zadanaPredkosc;
            }
        }

        public void ZwiekaszPredkosc()
        {
            if (stanSilnika == StanSilnika.Uruchomiony)
            {
                predkosc += 5;
            }
        }

        public void ZmniejszPredkosc()
        {
            if (stanSilnika == StanSilnika.Uruchomiony)
            {
                predkosc -= 5;
            }
        }

        public void UruchomSilnik()
        {
            if (stanSilnika == StanSilnika.CheckEngine)
            {
                throw new InvalidOperationException("Silnik wymaga naprawy przed uruchomieniem.");
            }
            stanSilnika = StanSilnika.Uruchomiony;
        }

        public void ZatrzymajSilnik()
        {
            stanSilnika = StanSilnika.Wylaczony;
        }

        public double PrzejechanyDystans(int dystans)
        {
            if (stanSilnika != StanSilnika.Uruchomiony)
            {
                throw new InvalidOperationException("Silnik nie jest uruchomiony.");
            }

            if (stanSilnika == StanSilnika.CheckEngine)
            {
                throw new InvalidOperationException("Silnik wymaga naprawy.");
            }

            double czas = dystans / (double)predkosc;
            przebieg += dystans;
            SprawdzStanSilnika();
            return czas;
        }

        public void NaprawSilnik()
        {
            if (stanSilnika == StanSilnika.CheckEngine)
            {
                stanSilnika = StanSilnika.Wylaczony;
            }
        }

        private void SprawdzStanSilnika()
        {
            if (przebieg % 10000 == 0)
            {
                stanSilnika = StanSilnika.CheckEngine;
            }
        }
    }
}
