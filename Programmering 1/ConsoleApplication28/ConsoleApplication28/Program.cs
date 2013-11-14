using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        public static string[,] spelplan = new string[10, 10]; //Arrayen som skapar spelplanen.

        public static void Välkommen() //Välkomstmeddelande och instruktioner
        {
            Console.WriteLine("Hej och välkommen till Sänka Skepp 2013 v.2.0.1! Min version utav sänka skepp \n går ut på att du"
                                + " kommer få din motståndares spelplan. Du får välja koordinater som du tror har skepp på sig och"
                                + " få poäng över hur många turer du behöver för \n att sänka alla dina motståndares skepp. Det blir"
                                + " alltså lite ensidigt, men det är lika roligt för det! '#' står för ogissad ruta, 'O' står för miss"
                                + " och \n 'X' står för träff. Kan du spela sänka skepp eller behöver"
                                + " du instruktioner?");
            string inm1 = Console.ReadLine();

            if (inm1.ToLower() == "ja") //Om användaren vet hur man spelar sänka skepp kan användaren välja att skippa instruktionerna.
            {
                Console.WriteLine("Okej! Du gör såhär att: du får din spelplan där du har olika koodrinater i på de olika hörnen"
                                   + " Du får gissa på en koordinat där du börjar horisontellt och sedan lodrätt. Träffar du ett"
                                   + " skepp så får du ett X och missar du får du ett O. \n Du fortsätter så tills du träffat alla skepp.");
            }
            else
            {
                Console.WriteLine("Du är ingen NOOB!! Bra!! Då kör vi!");
            }

        }

        public static void Spelplan() //Ger arrayen värden.
        {
            for (int y = 0; y < 10; y++) //Ger värde åt att alla rutor så att de blir tomma. (ogissade rutor.)
            {
                for (int x = 0; x < 10; x++)
                {
                    spelplan[x, y] = "#";
                }
            }
            spelplan[0, 1] = "*"; //Platserna där en stjärna finns. (Detta överskrivs dock med #(ogissade rutor) för att
            spelplan[0, 2] = "*"; // spelet ska kunna fungera
            spelplan[0, 3] = "*";
            spelplan[3, 4] = "*";
            spelplan[4, 4] = "*";
            spelplan[5, 4] = "*";
            spelplan[6, 4] = "*";
            spelplan[7, 4] = "*";
            spelplan[3, 8] = "*";
            spelplan[4, 8] = "*";
            spelplan[5, 8] = "*";


            Draw(); //rita ut spelplanen.
        }        

        public static void Draw() //Ritar ut spelplanen för användaren. 
        {
            Console.WriteLine("\n================Sänka Skepp================");
            Console.WriteLine("  | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |");
            Console.WriteLine("-------------------------------------------");
            for (int y = 0; y < 10; y++)
            {

                Console.Write( y + " | ");
                for (int x = 0; x < 10; x++)
                {
                    if (spelplan[x, y] == "*")
                    {

                        Console.Write("#" + " | ");
                    }
                    else
                    {
                        Console.Write(spelplan[x, y] + " | ");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------");
            }
        }


        public static bool Skjuta() //koden för att användaren ska kunna gissa på spelplanen.
        {
            int x; //x-koordinat
            int y; //y-koordinat

            while (true)
            {
                Console.WriteLine("Skriv en koordinat mellan 0 och 9!");
                try //Try-catchen är för att göra spelet med mindre buggar. Om användaren skriver med bokstäver alternativt
                {  // en siffra som inte är mellan 0 och 9 så kommer programmet skriva ut ett error.
                    x = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Du skrev något tokigt... försök igen.");
                }
            }

            Console.WriteLine("Skriv en till koordinat mellan 0 och 9!"); 
            while (true)
            {
                try //Kolla tidigare try-catch.
                {
                    y = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Det blev något tokigt i det du skrev, försök igen!");
                }
            }

            if (spelplan[x, y] == "*")
            {
                spelplan[x, y] = "X"; //Om stället som användaren gissar på har en stjärna skrivs ett X ut. och returnerar som sant.
                return true;

            }
            else
            {
                spelplan[x, y] = "O"; //Annars skrivs ett O ut. Och returnerar som falskt.
                return false;
            }


        }


        public static bool leftOvers()
        {
            
            foreach (string stars in spelplan) //Om det finns stjärnor kvar på spelplanen så returneras det som sant, annars falskt.
            {                              // det är så att jag senare kan breaka spelet när det inte finns några stjärnor kvar.
                if (stars == "*") 
                    return true;
            }

            return false;
        } //Om det finns stjärnor kvar.

        static void Main(string[] args)
        {

            Välkommen();
            Spelplan();
            
            for (int poang = 99; poang < 100; poang--) //For satsen är för poäng-systemet.
            {
                Skjuta();
                Draw();
                Console.WriteLine("Du har nu " + poang + " poäng");
                if (leftOvers() == false)
                {
                    Console.WriteLine("Grattis! Du klarade spelet med " + poang);
                    break;
                }

            }
            

            Console.ReadKey();
        }
    }
}
