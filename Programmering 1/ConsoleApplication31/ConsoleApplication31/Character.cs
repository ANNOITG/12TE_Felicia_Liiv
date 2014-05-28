using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Character : IComparable
    {
        public static int counter { get; set; } //Räknaren som räknar hur många personer som skrivit in sig i listan.

        public Character()
        {
            counter++; 
        }

        public string gender { get; set; } //Här är varje objekt som personen kommer svara på.
        public string name { get; set; }
        public string hometown { get; set; }
        public int age { get; set; }
        public string birthday { get; set; }
        public string email { get; set; }

        public int CompareTo(object characters)
        { 
            if (this.age == ((Character)characters).age)
            {
                return 0;
            }
            else if (this.age.CompareTo(((Character)characters).age) <1)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        public override string ToString() //Här är det som skrivs ut när minst en person skrivit in sig.
        {
            return "\nGender: " + gender + "\nName: " + name + 
                "\nHometown: " + hometown + "\nAge: " + age + "\nBirthday: " + birthday + "\nEmail: " + email;
        }
    }
}
