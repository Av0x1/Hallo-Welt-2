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
            Console.Title = "Haustierprogramm";

            Console.WriteLine("Guten Tag, ich bin das Haustierprogramm. Mit wem kommuniziere ich?");

            string userName = Console.ReadLine();
            Console.WriteLine(userName + "? Das ist aber ein schöner Name. Bist du denn männlich oder weiblich?");
            string userGeschlecht = Console.ReadLine();

            switch (userGeschlecht)
            {
                case "Männlich":
                        Console.WriteLine("Du bist also ein Mann? Sehr interessant. Wie alt bist du denn?");
                        Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "Weiblich":
                        Console.WriteLine("Du bist also eine Frau? Sehr interessant. Wie alt bist du denn?");
                        Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                        Console.WriteLine("Du bist also Divers? Sehr interessant. Wie alt bist du denn?");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }
            string reqAlter = Console.ReadLine();
            int numAlter = int.Parse(reqAlter);

            if(numAlter < 18)
            {
                Console.WriteLine("Es tut mir leid. Du bist zu jung um dieses Programm nutzen zu dürfen. Dieses Programm ist ab 18 Jahren.");
            }
            if(numAlter >= 18)
            {
                Console.WriteLine("Du bist alt genug. Das Haustierprogramm ermöglicht es dir ein beliebiges Haustier zu konfigurieren. Entscheide dich für eins dieser Tiere: Hund, Katze, Hamster oder Schildkröte.");
            }
            else
            {
                Console.WriteLine("Alter ist ungültig. Das Programm wird jetzt beendet.");
                Console.ReadKey();
            }


            string userInput = Console.ReadLine();

            //Code Auswahl: Hund

            switch (userInput)
            {
                case "Hund":
                    {
                        Hund dog2 = new Hund();

                        dog2.Name = "Coco";
                        {
                            Console.WriteLine("Der Hund heißt " + dog2.Name + ".");
                        }
                        dog2.Geschlecht = "Rüde";
                        {
                            if (dog2.Geschlecht == "Rüde")
                            {
                                Console.WriteLine(dog2.Name + " ist ein " + dog2.Geschlecht + ".");
                            }
                            else
                            {
                                Console.WriteLine(dog2.Name + " ist ein Weibchen.");
                            }
                        }
                        dog2.Rasse = "Husky";
                        {
                            switch(dog2.Rasse)
                            {
                                case "Golden Retriever":
                                    dog2.Fellfarbe = "Gold";
                                    break;
                                case "Husky":
                                    dog2.Fellfarbe = "Weiß und Schwarz";
                                    break;
                                case "Dackel":
                                    dog2.Fellfarbe = "Braun";
                                    break;
                                case "Rottweiler":
                                    dog2.Fellfarbe = "Schwarz";
                                    break;
                                case "Chihuahua":
                                    dog2.Fellfarbe = "Hellbraun";
                                    break;
                                default:
                                        Console.WriteLine("Ungültige Rasse!");
                                    break;
                            }
                            Console.WriteLine(dog2.Name + " ist ein " + dog2.Rasse + " und das Fell ist " + dog2.Fellfarbe + ".");
                        }
                        Console.ReadKey();

                        Console.WriteLine("Möchtest du den nächsten Hund kennenlernen? Ja oder Nein?");
                        string nextDog = Console.ReadLine();

                        switch(nextDog)
                        {
                            case "Nein":
                                Console.WriteLine("Sehr schade. Dann bis zum nächsten Mal! Schönen Tag!");
                                Console.ReadKey();
                                break;
                            case "Ja":
                                Console.WriteLine("Sehr schön, dann ist hier der nächste Hund:");
                                break;
                        }

                        Hund dog1 = new Hund();

                        dog1.Name = "Coco";
                        {
                            Console.WriteLine("Der Hund heißt " + dog1.Name + ".");
                        }
                        dog1.Geschlecht = "Rüde";
                        {
                            if (dog1.Geschlecht == "Rüde")
                            {
                                Console.WriteLine(dog1.Name + " ist ein " + dog1.Geschlecht + ".");
                            }
                            else
                            {
                                Console.WriteLine(dog1.Name + " ist ein Weibchen.");
                            }
                        }
                        dog1.Rasse = "Husky";
                        {
                            switch (dog1.Rasse)
                            {
                                case "Golden Retriever":
                                    dog1.Fellfarbe = "Gold";
                                    break;
                                case "Husky":
                                    dog1.Fellfarbe = "Weiß und Schwarz";
                                    break;
                                case "Dackel":
                                    dog1.Fellfarbe = "Braun";
                                    break;
                                case "Rottweiler":
                                    dog1.Fellfarbe = "Schwarz";
                                    break;
                                case "Chihuahua":
                                    dog1.Fellfarbe = "Hellbraun";
                                    break;
                                default:
                                    Console.WriteLine("Ungültige Rasse!");
                                    break;
                            }
                            Console.WriteLine(dog1.Name + " ist ein " + dog1.Rasse + " und das Fell ist " + dog1.Fellfarbe + ".");
                        }
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }

    class Tier
    {
        //Eigenschaften

        public string Geschlecht { get; set; }

        public string Alter { get; set; }

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
