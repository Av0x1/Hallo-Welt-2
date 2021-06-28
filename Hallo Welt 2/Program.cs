using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hallo_Welt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund dog = new Hund();

            dog.Name = "Coco";
            {
                Console.WriteLine("Der Hund heißt " + dog.Name + ".");
            }
            dog.Geschlecht = "Rüde";
            {
                Console.WriteLine(dog.Name + " ist ein " + dog.Geschlecht + ".");
            }
            dog.Bellen();
            dog.Bewegen();


            Console.ReadKey();
        }
    }

    class Tier
    {
        //Eigenschaften

        public string Geschlecht { get; set; }

        //Methoden

        public void Bewegen()
        {
            Console.WriteLine("Bewegen...");
        }

    }

    class Hund : Tier
    {
        //Eigenschaften

        public string Name { get; set; }
        public string Rasse { get; set; }

        //Methoden

        public void Bellen()
        {
            Console.WriteLine("Bellen...");
        }
        public void Schlecken()
        {
            Console.WriteLine("Schlecken...");
        }
    }
}
