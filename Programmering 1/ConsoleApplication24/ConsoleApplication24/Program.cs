using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        public static double ToPercentage(double förändringsfaktor)
        {
            förändringsfaktor = förändringsfaktor * 100;
            return förändringsfaktor;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din förändringsfaktor, så gör vi om det till procent!");
            double inm = double.Parse(Console.ReadLine());
            Console.WriteLine("Det blir: " + ToPercentage(inm) + "%!");
            Console.ReadKey();
        }
    }
}
