using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>(); //Listan med olika karaktärer.

            while (true) //Loop så att när du skrivit in dig i listan eller öppnat de olika listorna så börjar du om.
            {
                Console.WriteLine("Välj ett val i listan.\nTryck A för att skriva in uppgifter.\nTryck B för att skriva ut dina uppgifter.\nTryck X för att avsluta.");
                string val2 = Console.ReadLine().ToLower(); 
                switch (val2)
                {
                    case "a": //De olika valen man kan göra.

                        Character c1 = new Character();
                        Console.WriteLine("Är du man eller kvinna?");
                        c1.gender = Console.ReadLine();
                        Console.WriteLine("Skriv ditt fullständiga namn.");
                        c1.name = Console.ReadLine();
                        Console.WriteLine("Vart bor du någonstans?");
                        c1.hometown = Console.ReadLine();
                        Console.WriteLine("Hur gammal är du? Skriv med siffror.");
                        c1.age = int.Parse(Console.ReadLine());
                        Console.WriteLine("När fyller du år?");
                        c1.birthday = Console.ReadLine();
                        Console.WriteLine("Skriv in din e-mail så att vi kan kontakta dig för framtida händelser.");
                        c1.email = Console.ReadLine();

                        characters.Add(c1); //Här läggs personen till i listan.
                        break;

                    case "b":

                        foreach (Character p in characters) //För varje person som skrivit in sig så skrivs den ut.
                        {
                            Console.WriteLine(p + "\n");
                        }

                        break;

                    case "x": //Programmet stängs ner.
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Du gjorde inte ett korrekt val."); //Om du skriver in något annat än A,B eller X
                        Console.Clear();
                        break;


                }
                Console.ReadKey();
            }


            

        }
    }
}
