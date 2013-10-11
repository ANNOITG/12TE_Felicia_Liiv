using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        public static double moms(double pris, double momsProcent)
        {

            momsProcent = (momsProcent / 100) + 1;
            double medMoms = pris * momsProcent;

            return medMoms;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(moms(100, 34));

            Console.ReadKey();
        }
    }
}
