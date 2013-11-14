using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> unsorted = new List<Character>(); //Listan med personer. Denna lista skapas när programmet startar.

            unsorted.Add(new Character() { gender = "kvinna", name = "Felicia", age = 17, birthday = "8 Juli", hometown = "Örebro", email= "felicia.liiv@elev.it-gymnasiet.se" });           //Lägger till 3 osorterade objekt i listan så vi slipper göra det runtime.
            unsorted.Add(new Character() { gender = "man", name = "Magnus", age = 32, birthday = "3 Mars", hometown = "Stockholm", email = "magnus@lol.se" });
            unsorted.Add(new Character() { gender = "kvinna" , name = "Lisa" , age = 41, birthday = "29 December", hometown = "Malmö", email = "lisa@roflcopter.com" });//-----------------------------------------------------------

            // Print the unsorted array
            for (int i = 0; i < unsorted.Count(); i++) //Length fungerar inte i en lista, byter därför ut det emot Count.
            {
                Console.WriteLine(unsorted[i] + " ");
            }

            Console.WriteLine();

            // Sort the array
            Quicksort(unsorted, 0, unsorted.Count() - 1); // -||-

            // Print the sorted array
            for (int i = 0; i < unsorted.Count; i++) // -||-
            {
                Console.WriteLine(unsorted[i] + " ");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        public static void Quicksort(List<Character> elements, int left, int right) //Ändrar datatypen till List<Character> för att det ska sortera sakerna i listan.
        {
            int i = left, j = right;
            Character pivot = elements[(left + right) / 2]; // -||-

            while (i <= j)
            {
                while (elements[i].age.CompareTo(pivot.age) < 0) //Skriver in age för att den ska jämföra ålder, och inget annat.
                {
                    i++;
                }

                while (elements[j].age.CompareTo(pivot.age) > 0) // -||-
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    Character tmp = elements[i]; // Ändrar till Character
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
