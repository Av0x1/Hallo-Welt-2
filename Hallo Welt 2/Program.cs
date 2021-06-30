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

            Console.WriteLine("Guten Tag, ich bin das Haustierprogramm.\nMit wem kommuniziere ich?");

            string userName = Console.ReadLine();
            Console.WriteLine("\n" + userName + "? Das ist aber ein schöner Name.\nBist du denn männlich oder weiblich oder ein anderes Geschlecht??");
            string userGeschlecht = Console.ReadLine();

            switch (userGeschlecht)
            {
                case "Männlich":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDu bist also ein Mann? Sehr interessant.\nWie alt bist du denn?");
                    break;
                case "Weiblich":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nDu bist also eine Frau? Sehr interessant.\nWie alt bist du denn?");
                    break;
                default:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nDu bist also Divers? Sehr interessant.\nWie alt bist du denn?");
                    break;
            }
            string reqAlter = Console.ReadLine();
            int numAlter = int.Parse(reqAlter);

            if(numAlter < 18)
            {
                Console.WriteLine("\nEs tut mir leid. Du bist zu jung um dieses Programm nutzen zu dürfen. Dieses Programm ist ab 18 Jahren.\n");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if(numAlter >= 18)
            {
                Console.WriteLine("\nDu bist alt genug. Das Haustierprogramm ermöglicht es dir ein beliebiges Haustier zu konfigurieren.\nEntscheide dich für eins dieser Tiere:\n- Hund\n- Katze\n- Schildkröte\n");
            }
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                //Code Auswahl: Hund
                case "Hund":
                    {
                        //Vorstellung Hund 1

                        Hund dog1 = new Hund();

                        dog1.Name = "Coco";
                        {
                            Console.WriteLine("\nDer Hund heißt " + dog1.Name + ".");
                        }
                        dog1.Geschlecht = "Rüde";
                        {
                            if (dog1.Geschlecht == "Rüde")
                            {
                                Console.WriteLine(dog1.Name + " ist ein " + dog1.Geschlecht + ".");
                            }
                            if (dog1.Geschlecht == "Hündin")
                            {
                                Console.WriteLine(dog1.Name + " ist ein Weibchen.");
                            }
                        }
                        dog1.Rasse = "Husky";
                        {
                            switch(dog1.Rasse)
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

                        Console.WriteLine("\nMöchtest du den nächsten Hund kennenlernen? Ja oder Nein?");
                        string nextDog = Console.ReadLine();

                        switch(nextDog)
                        {
                            case "Nein":
                                Console.WriteLine("Sehr schade. Dann bis zum nächsten Mal! Schönen Tag!");
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;
                            case "Ja":
                                Console.WriteLine("Sehr schön, dann ist hier der nächste Hund:");
                                break;
                        }

                        //Vorstellung Hund 2

                        Hund dog2 = new Hund();

                        dog2.Name = "Rudi";
                        {
                            Console.WriteLine("Der Hund heißt " + dog2.Name + ".");
                        }
                        dog2.Geschlecht = "Hündin";
                        {
                            if (dog2.Geschlecht == "Rüde")
                            {
                                Console.WriteLine(dog2.Name + " ist ein " + dog2.Geschlecht + ".");
                            }
                            if (dog2.Geschlecht == "Hündin")
                            {
                                Console.WriteLine(dog2.Name + " ist ein Weibchen.");
                            }
                        }
                        dog2.Rasse = "Husky";
                        {
                            switch (dog2.Rasse)
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

                        Console.WriteLine("\nMöchtest du den nächsten Hund kennenlernen? Ja oder Nein?");
                        string nextDog1 = Console.ReadLine();

                        switch (nextDog1)
                        {
                            case "Nein":
                                Console.WriteLine("Sehr schade. Dann bis zum nächsten Mal! Schönen Tag!");
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;
                            case "Ja":
                                Console.WriteLine("Sehr schön, dann ist hier der nächste Hund:");
                                break;
                        }

                        // Vorstellung Hund 3

                        Hund dog3 = new Hund();

                        dog3.Name = "Rudi";
                        {
                            Console.WriteLine("Der Hund heißt " + dog3.Name + ".");
                        }
                        dog3.Geschlecht = "Hündin";
                        {
                            if (dog3.Geschlecht == "Rüde")
                            {
                                Console.WriteLine(dog3.Name + " ist ein " + dog3.Geschlecht + ".");
                            }
                            if (dog3.Geschlecht == "Hündin")
                            {
                                Console.WriteLine(dog3.Name + " ist ein Weibchen.");
                            }
                        }
                        dog3.Rasse = "Husky";
                        {
                            switch (dog3.Rasse)
                            {
                                case "Golden Retriever":
                                    dog3.Fellfarbe = "Gold";
                                    break;
                                case "Husky":
                                    dog3.Fellfarbe = "Weiß und Schwarz";
                                    break;
                                case "Dackel":
                                    dog3.Fellfarbe = "Braun";
                                    break;
                                case "Rottweiler":
                                    dog3.Fellfarbe = "Schwarz";
                                    break;
                                case "Chihuahua":
                                    dog3.Fellfarbe = "Hellbraun";
                                    break;
                                default:
                                    Console.WriteLine("Ungültige Rasse!");
                                    break;
                            }
                            Console.WriteLine(dog3.Name + " ist ein " + dog3.Rasse + " und das Fell ist " + dog3.Fellfarbe + ".");
                        }
                        Console.ReadKey();

                        Console.WriteLine("\nMöchtest du den nächsten Hund kennenlernen? Ja oder Nein?");
                        string nextDog2 = Console.ReadLine();

                        switch (nextDog1)
                        {
                            case "Nein":
                                Console.WriteLine("Sehr schade. Dann bis zum nächsten Mal! Schönen Tag!");
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;
                            case "Ja":
                                Console.WriteLine("Sehr schön, dann ist hier der nächste Hund:");
                                break;
                        }



                    }
                    break;
            }
        }
    }
}
