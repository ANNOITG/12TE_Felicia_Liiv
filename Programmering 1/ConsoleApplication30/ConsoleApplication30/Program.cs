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
            characters.Add(new Character() { gender = "kvinna", name = "Felicia", hometown = "Örebro", age = 17, birthday = "8 juli", email = "feliciaftw@live.com" }); //Lägger till 3 personer för att slippa göra det under tiden jag arbetar.
            characters.Add(new Character() { gender = "kvinna", name = "Karin", hometown = "Örebro", age = 32, birthday = "29 juli", email = "karin@rofl.net" }); 
            characters.Add(new Character() { gender = "kvinna", name = "Lisa", hometown = "Örebro", age = 32, birthday = "19 juni", email = "lisa@lol.se" });

            //Console.WriteLine("Vilken email vill du ta fram?");
            //string email = Console.ReadLine();
            //Character character = characters.Single(p => p.email == email);



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
                        Console.WriteLine(Character.counter);
                        foreach (Character p in characters) //För varje person som skrivit in sig så skrivs den ut.
                        {
                            Console.WriteLine(p + "\n");
                        }

                        break;

                    case "c":
                        Console.WriteLine("Ändra en post via index");

                        foreach (Character p in characters) //För att användaren ska se vilken profil som har vilket index så 
                        {                                   //skrivs alla profiler ut.
                            Console.WriteLine(p + "\n");
                        }

                        try
                        {
                            Console.WriteLine("Vilken email vill du ta fram?"); //Igenom att söka på e-mail så kan du ändra
                            string andraEmail = Console.ReadLine();             //i en profil.
                            Character andraCharacter = characters.Single(p => p.email == andraEmail);

                            Console.WriteLine("Kön?");
                            andraCharacter.gender = Console.ReadLine();

                            Console.WriteLine("Namn?");
                            andraCharacter.name = Console.ReadLine();

                            Console.WriteLine("Vart bor du?");
                            andraCharacter.hometown = Console.ReadLine();

                            Console.WriteLine("Ålder?");
                            andraCharacter.age = int.Parse(Console.ReadLine());

                            Console.WriteLine("När fyller du?");
                            andraCharacter.birthday = Console.ReadLine();

                            Console.WriteLine("Vad är din e-mail?");
                            andraCharacter.email = Console.ReadLine();

                        }
                        catch (Exception e) //Om du skriver någonting fel så kommer det komma upp ett felmeddelande.
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "d":
                        Console.WriteLine("Ta bort en post via index"); //Samma här, vi skriver ut alla i listan för att användaren
                                                                        //ska veta vad hen tar upp.

                        foreach (Character p in characters)
                        {
                            Console.WriteLine(p + "\n");
                        }

                        try
                        {
                            Console.WriteLine("Vilken email vill du ta fram?"); //Igenom att söka på e-mail så kan du ta bort
                            string deleteEmail = Console.ReadLine();             //i en profil.
                            Character deleteCharacter = characters.Single(p => p.email == deleteEmail);


                            characters.Remove(deleteCharacter); //Ta bort profilen på indexet som användaren skrev in.
                            Character.counter--; //Så att räknaren inte skriver fel.
                        }
                        catch (Exception e) //Felmeddelande kommer upp om du skriver något knas.
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;

                    case "e":

                        Console.WriteLine("Skriv in sökord: ");
                        string sokOrd = Console.ReadLine();

                        var sokRes = from res in characters
                                     where res.gender.Contains(sokOrd)
                                        || res.name.Contains(sokOrd)
                                        || res.hometown.Contains(sokOrd)
                                        || res.age.ToString().Contains(sokOrd)
                                        || res.birthday.Contains(sokOrd)
                                        || res.email.Contains(sokOrd)
                                     select res;

                        foreach (Character p in sokRes)
                        {
                            Console.WriteLine(p);
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
