using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Korclass kor1 = new Korclass(3.0);
            kor1.setKerulet(kor1.getSugar());
            kor1.setTerulet();
            Console.WriteLine("A {0}km sugaru kor kerulete: {1}km2, területe {2}km2", kor1.getSugar(),kor1.getKerulet(),kor1.getTerulet());

            Console.WriteLine(" ");
        }
    }
}
