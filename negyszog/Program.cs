using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace negyszog
{
    class Program
    {
        static void Main(string[] args)
        {
            NegyszogClass negyszog = new NegyszogClass(3.0,3.0);
            negyszog.setKerulet(negyszog.getOldal(), negyszog.getOldal2());
            negyszog.setTerulet(negyszog.getOldal(), negyszog.getOldal2());
            Console.WriteLine("{0}cm a és {1}cm b oldal hosszusagu negyzet kerulete: {2}cm, terulete{3}cm2.", negyszog.getOldal(), negyszog.getOldal2(), negyszog.getKerulet(), negyszog.getTerulet());
            Console.WriteLine(" ");
            Console.ReadKey();
        }
    }
}
