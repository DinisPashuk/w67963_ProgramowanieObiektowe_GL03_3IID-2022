using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3.classes
{
    internal class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] Liczby)
        {
            this.Liczby = Liczby;
        }
        public int Suma()
        {
            int sum = 0;
            foreach (var el in  Liczby)
            {
                sum += el;
            }
            return sum;
        }
        public int SumaPodziel3() 
        {
            int sum = 0;
            foreach (var el in Liczby)
            {
                if(el % 3 == 0) { sum += el; }
            }
            return sum;
        }
        public int IleElementow()
        {
            return Liczby.Length;
        }
        public void Elementy()
        {
            foreach(var el in Liczby)
            {
                Console.WriteLine(el);
            }
        }
        public void WypishElementy(int LowIndex,int HighIndex)
        {
            LowIndex = LowIndex < 0 ? 0 : LowIndex;
            HighIndex = HighIndex > Liczby.Length ? Liczby.Length : HighIndex;
            for (var i = LowIndex; i < HighIndex; i++)
            {
                Console.WriteLine(Liczby[i]);
            }
        }
    }
}
