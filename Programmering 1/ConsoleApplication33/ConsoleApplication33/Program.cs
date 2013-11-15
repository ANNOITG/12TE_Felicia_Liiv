using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static int Fibonacci(int f) 
        {
            if (f <= 2 ) // Om f är mindre eller lika med tre så kommer talet returna 1.
            {
                return 1;
            }
            else
            {
                return Fibonacci (f - 1) + Fibonacci (f - 2 ); //Annars så kommer man returna f - 1 + f - 2. 
            }
                    
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(10)); // Skriv ut Fibonacci 10.
            Console.ReadKey();
        }
    }
}
