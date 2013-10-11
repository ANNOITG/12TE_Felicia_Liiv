using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        public static double Moms(double pris)
        { 
            return (pris * 1.25);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett pris på din vara");
            double nyttpris = Moms(double.Parse(Console.ReadLine()));
            Console.WriteLine("Priset med moms blir: " + nyttpris);
            Console.ReadKey();

        }
    }
}
