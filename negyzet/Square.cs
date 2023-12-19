using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyzet
{
    public class Square
    {
        public double Oldal { get; set; }
        public double Magas { get; set; }

        public Square(double oldal)
        {
            Oldal = oldal;
            Magas = 0;
        }

        public double Atmero() { return Math.Sqrt(2 * Math.Pow(Oldal, 2)); }

        public double Kerulet() { return 4 * Oldal; }

        public double Terulet() { return Math.Pow(Oldal, 2); }

        public double OszlopTerfogat()
        {
            if (Magas <= 0)
            {
                // Dobunk 1 kivételt
                throw new ArgumentException("A magasságnak 0-nál nagyobbnak kell lennie");
            }
            return Terulet() * Magas;
        }

    }
}
