using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        public static string Hello(string message1, string message2)
        {
            return message1 + message2;
        }

        static void Main(string[] args)
        {
            string hej = Hello("123", "456");

            Console.WriteLine(hej);
            Console.ReadKey();
        }
    }
}
