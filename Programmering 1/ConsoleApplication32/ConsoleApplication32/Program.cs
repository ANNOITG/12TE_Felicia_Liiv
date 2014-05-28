using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
       // 5!/3! = 5*4
       // 5! = 5*4*3*2*1 = 120

        public static long Fakultet(long tal)
        {
            if (tal > 1)
            {
                return tal * Fakultet(tal - 1);
            }
            else
            {
                return 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Fakultet(20));
            Console.ReadKey();
        }
    }
}
