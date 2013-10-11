using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        public static void Hello(string message)
        {
            Console.WriteLine("Hej du skrev: " + message);
        }

        static void Main(string[] args)
        {
            string inm = Console.ReadLine();
            Hello(inm);
            Console.ReadKey();
        }
    }
}
