using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace negyszog
{
    class NegyszogClass
    {
        private double oldal,oldal2, kerulet, terulet;
        //Konstruktor
        public NegyszogClass(double a,double b) {
            this.oldal = a;
            this.oldal2 = b;
        }
        public void setKerulet(double a,double b)
        {
            this.kerulet = 2*(a+b);
        }
        public void setTerulet(double a,double b)
        {
            this.terulet = a*b;
        }
        public double getKerulet()
        {
            return this.kerulet;
        }
        public double getTerulet()
        {
            return this.terulet;
        }
        public double getOldal()
        {
            return this.oldal;
        }
        public double getOldal2()
        {
            return this.oldal2;
        }
    }
}
