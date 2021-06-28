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
                if (dog.Geschlecht == "Rüde")
                {
                    Console.WriteLine(dog.Name + " ist ein " + dog.Geschlecht + ".");
                }
                else
                {
                    Console.WriteLine(dog.Name + " ist ein Weibchen.");
                }
            }
            dog.Rasse = "Husky";
            {
                switch(dog.Rasse)
                {
                    case "Golden Retriever":
                        dog.Fellfarbe = "Gold";
                        break;
                    case "Husky":
                        dog.Fellfarbe = "Weiß und Schwarz";
                        break;
                    case "Dachs":
                        dog.Fellfarbe = "Braun";
                        break;
                    case  "Rottweiler":
                        dog.Fellfarbe = "Schwarz";
                        break;
                    case "Chihuahua":
                        dog.Fellfarbe = "Hellbraun";
                        break;
                    default:
                        {
                            Console.WriteLine("Ungültige Rasse!");
                        }
                        break;
                }

                Console.WriteLine(dog.Name + " ist ein " + dog.Rasse + " und das Fell ist " + dog.Fellfarbe + ".");
            }

            dog.Bellen();
            dog.Bewegen();
            dog.Schlecken();


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
        public string Fellfarbe { get; set; }

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
