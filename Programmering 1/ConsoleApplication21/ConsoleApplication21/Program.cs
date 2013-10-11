using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        public static int Tal(int tal1, int tal2)
        {
            return (tal1 + tal2);
        }
        static void Main(string[] args)
        {
            int summa = Tal(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(summa);
            Console.ReadKey();
        }
    }
}
