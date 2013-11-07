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
            characters.Add(new Character() { gender = "kvinna", name = "Felicia", hometown = "Örebro", age = 17, birthday = "8 juli", email = "feliciaftw@live.se" }); //Lägger till 2 personer för att slippa göra det under tiden jag arbetar.
            characters.Add(new Character() { gender = "kvinna", name = "Karin", hometown = "Örebro", age = 32, birthday = "29 juli", email = "karin@lol.se" }); 

            while (true) //Loop så att när du skrivit in dig i listan eller öppnat de olika listorna så börjar du om.
            {
                Console.WriteLine("Välj ett val i listan.\nTryck A för att skriva in uppgifter."
                    + "\nTryck B för att skriva ut dina uppgifter.\nTryck X för att avsluta."
                    + "\nTryck C för att ändra något i en profil."
                    + "\nTryck D för att ta bort en profil."
                    + "\nTryck E för att söka efter en profil");
                string val2 = Console.ReadLine().ToLower(); 
                switch (val2)
                {
                    case "a": //De olika valen man kan göra.

                        try
                        {
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
                        }
                        catch (Exception e) //Skriver ett felmeddelande om du skriver något knas.
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "b":

                        foreach (Character p in characters) //För varje person som skrivit in sig så skrivs den ut.
                        {
                            Console.WriteLine(p + "\n");
                        }

                        break;

                    case "c":
                        Console.WriteLine("Ändra en post via index");
                        int changeindex = 0;
                        foreach (Character p in characters) //För att användaren ska se vilken profil som har vilket index så 
                        {                                   //skrivs alla profiler ut.
                            Console.WriteLine(changeindex + ":\n" + p + "\n");
                            changeindex++;
                        }

                        try
                        {
                            Console.WriteLine("Vilket index vill du ändra?"); //Detta nedanför är för att du ska kunna ändra i profilen.
                            int andIndex = int.Parse(Console.ReadLine());

                            Console.WriteLine("Kön?");
                            characters[andIndex].gender = Console.ReadLine();

                            Console.WriteLine("Namn?");
                            characters[andIndex].name = Console.ReadLine();

                            Console.WriteLine("Vart bor du?");
                            characters[andIndex].hometown = Console.ReadLine();

                            Console.WriteLine("Ålder?");
                            characters[andIndex].age = int.Parse(Console.ReadLine());

                            Console.WriteLine("När fyller du?");
                            characters[andIndex].birthday = Console.ReadLine();

                            Console.WriteLine("Vad är din e-mail?");
                            characters[andIndex].email = Console.ReadLine();

                        }
                        catch (Exception e) //Om du skriver någonting fel så kommer det komma upp ett felmeddelande.
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "d":
                        Console.WriteLine("Ta bort en post via index"); //Samma här, vi skriver ut alla i listan för att användaren
                                                                        //ska veta vad hen tar upp.
                        int removeindex = 0;
                        foreach (Character p in characters)
                        {
                            Console.WriteLine(removeindex + ":\n" + p + "\n");
                            removeindex++;
                        }

                        try
                        {
                            Console.WriteLine("Vilket index vill du ta bort?");
                            int remIndex = int.Parse(Console.ReadLine());


                            characters.Remove(characters[remIndex]); //Ta bort profilen på indexet som användaren skrev in.
                            Character.counter--; //Så att räknaren inte skriver fel.
                        }
                        catch (Exception e) //Felmeddelande kommer upp om du skriver något knas.
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;

                    case "e":

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
