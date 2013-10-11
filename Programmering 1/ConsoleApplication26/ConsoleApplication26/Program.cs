using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        public static bool Myndig(int alder)
        {
            if (alder < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static double ToPercentage(double förändringsfaktor)
        {
            förändringsfaktor = förändringsfaktor * 100;
            return förändringsfaktor;
        }
        public static double Moms(double pris, double momsProcent)
        {

            momsProcent = (momsProcent / 100) + 1;
            double medMoms = pris * momsProcent;

            return medMoms;
        }
        public static double Moms(double pris)
        {
            return (pris * 1.25);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett alternativ genom att trycka respektive tangent:");
            Console.WriteLine("[M]oms uträkning");
            Console.WriteLine("[P]rocent uträkning till moms");
            Console.WriteLine("[F]örändringsfaktor till procent");
            Console.WriteLine("[Å]lderårsgräns i Sverige");
            Console.WriteLine("[Q]uit");

            string inm1 = Console.ReadLine();

            if (inm1.ToLower() == "m")
            {
                Console.WriteLine("Skriv in ett pris på din vara");
                double nyttpris = Moms(double.Parse(Console.ReadLine()));
                Console.WriteLine("Priset med moms blir: " + nyttpris);
                Console.ReadKey();
            }
            else if (inm1.ToLower() == "p")
            {
                Console.WriteLine("Om priset är 100 utan moms är priset med moms: " + Moms(100, 34));

                Console.ReadKey();
            }
            else if (inm1.ToLower() == "f")
            {
                Console.WriteLine("Skriv in din förändringsfaktor, så gör vi om det till procent!");
            double inm = double.Parse(Console.ReadLine());
            Console.WriteLine("Det blir: " + ToPercentage(inm) + "%!");
            Console.ReadKey();
            }
            else if (inm1.ToLower() == "å")
            {
                int ålder = int.Parse(Console.ReadLine());
                Console.WriteLine(Myndig(ålder));

                Console.ReadKey();
            }
            else if (inm1.ToLower() == "q")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Det där är inte en utav alternativen.");
            }
        }
    }
}
