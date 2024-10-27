using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static carinfo.fourwheeler;

namespace carinfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car Car = new car("Toyota Corolla", 2020, 5, 6, 4, 1800, "Leather");
            Car.getIInteriorDesign();
            Console.ReadKey();

        }
    }
}
