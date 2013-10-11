using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
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
        static void Main(string[] args)
        {
            Console.WriteLine(Myndig(18));

            Console.ReadKey();
        }
    }
}
