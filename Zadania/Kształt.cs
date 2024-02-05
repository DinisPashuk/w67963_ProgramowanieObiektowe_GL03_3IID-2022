using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public abstract class Kształt
    {
        public double X { get; set; }
        public double Y { get; set; }

        public abstract double ObliczPole();
        public abstract double ObliczObwód();
    }

    public class Prostokąt : Kształt
    {
        public double Szerokość { get; set; }
        public double Wysokość { get; set; }

        public Prostokąt(double x, double y, double szerokość, double wysokość)
        {
            X = x;
            Y = y;
            Szerokość = szerokość;
            Wysokość = wysokość;
        }

        public override double ObliczPole() => Szerokość * Wysokość;

        public override double ObliczObwód() => 2 * (Szerokość + Wysokość);
    }

    public class Trójkąt : Kształt
    {
        public double Podstawa { get; set; }
        public double Wysokość { get; set; }
        public double BokA { get; set; }
        public double BokB { get; set; }
        public double BokC { get; set; }

        public Trójkąt(double x, double y, double podstawa, double wysokość, double bokA, double bokB, double bokC)
        {
            X = x;
            Y = y;
            Podstawa = podstawa;
            Wysokość = wysokość;
            BokA = bokA;
            BokB = bokB;
            BokC = bokC;
        }

        public override double ObliczPole() => (Podstawa * Wysokość) / 2;

        public override double ObliczObwód() => BokA + BokB + BokC;
    }

    public class Koło : Kształt
    {
        public double Promień { get; set; }

        public Koło(double x, double y, double promień)
        {
            X = x;
            Y = y;
            Promień = promień;
        }

        public override double ObliczPole() => Math.PI * Promień * Promień;

        public override double ObliczObwód() => 2 * Math.PI * Promień;
    }
}
