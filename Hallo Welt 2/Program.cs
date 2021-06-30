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
                Console.WriteLine("\nDu bist alt genug. Das Haustierprogramm stellt dir verschiedene Hund und Katzen vor.\nEntscheide dich für eins dieser Tiere:\n- Hund\n- Katze\n");
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
                                Console.WriteLine(dog1.Name + " ist eine " + dog1.Geschlecht + ".");
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

                        dog2.Name = "Sina";
                        {
                            Console.WriteLine("\nDer Hund heißt " + dog2.Name + ".");
                        }
                        dog2.Geschlecht = "Hündin";
                        {
                            if (dog2.Geschlecht == "Rüde")
                            {
                                Console.WriteLine(dog2.Name + " ist ein " + dog2.Geschlecht + ".");
                            }
                            if (dog2.Geschlecht == "Hündin")
                            {
                                Console.WriteLine(dog2.Name + " ist eine " + dog2.Geschlecht + ".");
                            }
                        }
                        dog2.Rasse = "Golden Retriever";
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

                        dog3.Name = "Bello";
                        {
                            Console.WriteLine("\nDer Hund heißt " + dog3.Name + ".");
                        }
                        dog3.Geschlecht = "Rüde";
                        {
                            if (dog3.Geschlecht == "Rüde")
                            {
                                Console.WriteLine(dog3.Name + " ist ein " + dog3.Geschlecht + ".");
                            }
                            if (dog3.Geschlecht == "Hündin")
                            {
                                Console.WriteLine(dog3.Name + " ist eine " + dog3.Geschlecht + ".");
                            }
                        }
                        dog3.Rasse = "Dackel";
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

                        Console.WriteLine("\nMöchtest du einen der Hunde streicheln?");
                        string petDogReq = Console.ReadLine();

                        switch (petDogReq)
                        {
                            case "Nein":
                                Console.WriteLine("Sehr schade. Damit ist das Programm beendet.\nBis zum nächsten Mal und einen Schönen Tag!");
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;
                            case "Ja":
                                Console.WriteLine("Sehr gerne.\nWelchen Hund möchtest du streicheln?\nWähle aus:\n- Hund 1\n- Hund 2\n- Hund 3");
                                break;
                        }
                        
                        string petDog = Console.ReadLine();

                        switch (petDog)
                        {
                            case "Hund 1":
                                Console.WriteLine(dog1.Name + ":");
                                dog1.Bellen();
                                Console.WriteLine(dog1.Name + "scheint dich nicht zu mögen.");
                                Console.ReadKey();
                                break;
                            case "Hund 2":
                                Console.WriteLine(dog2.Name + ":");
                                dog2.Schlecken();
                                Console.WriteLine(dog2.Name + "scheint dich zu mögen.");
                                Console.ReadKey();
                                break;
                            case "Hund 3":
                                Console.WriteLine(dog3.Name + ":");
                                dog3.Knurren();
                                dog3.Bewegen();
                                Console.WriteLine(dog3.Name + "scheint Angst zu haben.");
                                Console.ReadKey();
                                break;
                        }
                        Console.WriteLine("\nDamit ist das Programm beendet.");
                        Console.ReadKey();
                    }
                    break;

                //Code Auswahl: Katze
                case "Katze":
                    {
                        //Vorstellung Katze

                        Katze cat1 = new Katze();

                        cat1.Name = "Rolf";
                        {
                            Console.WriteLine("\nDie Katze heißt " + cat1.Name + ".");
                        }
                        cat1.Geschlecht = "Kater";
                        {
                            if (cat1.Geschlecht == "Kater")
                            {
                                Console.WriteLine(cat1.Name + " ist ein " + cat1.Geschlecht + ".");
                            }
                            if (cat1.Geschlecht == "Katze")
                            {
                                Console.WriteLine(cat1.Name + " ist eine " + cat1.Geschlecht + ".");
                            }
                        }
                        cat1.Rasse = "Siam";
                        {
                            switch (cat1.Rasse)
                            {
                                case "Siamkatze":
                                    cat1.Fellfarbe = "Weiß";
                                    break;
                                case "Perserkatze":
                                    cat1.Fellfarbe = "Gold gestreift";
                                    break;
                                case "Bengalkatze":
                                    cat1.Fellfarbe = "Getigert";
                                    break;
                                default:
                                    Console.WriteLine("Ungültige Rasse!");
                                    break;
                            }
                            Console.WriteLine(cat1.Name + " ist ein " + cat1.Rasse + " und das Fell ist " + cat1.Fellfarbe + ".");
                        }
                        Console.ReadKey();

                        Console.WriteLine("\nMöchtest du die nächste Katze kennenlernen? Ja oder Nein?");
                        string nextCat = Console.ReadLine();

                        switch (nextCat)
                        {
                            case "Nein":
                                Console.WriteLine("Sehr schade. Dann bis zum nächsten Mal! Schönen Tag!");
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;
                            case "Ja":
                                Console.WriteLine("Sehr schön, dann ist hier die nächste Katze:");
                                break;
                        }

                        //Vorstellung Katze 2

                        Katze cat2 = new Katze();

                        cat2.Name = "Lucky";
                        {
                            Console.WriteLine("\nDie Katze heißt " + cat2.Name + ".");
                        }
                        cat2.Geschlecht = "Katze";
                        {
                            if (cat2.Geschlecht == "Kater")
                            {
                                Console.WriteLine(cat2.Name + " ist ein " + cat2.Geschlecht + ".");
                            }
                            if (cat2.Geschlecht == "Katze")
                            {
                                Console.WriteLine(cat2.Name + " ist eine " + cat2.Geschlecht + ".");
                            }
                        }
                        cat2.Rasse = "Perserkatze";
                        {
                            switch (cat2.Rasse)
                            {
                                case "Siamkatze":
                                    cat2.Fellfarbe = "Weiß";
                                    break;
                                case "Perserkatze":
                                    cat2.Fellfarbe = "Gold gestreift";
                                    break;
                                case "Bengalkatze":
                                    cat2.Fellfarbe = "Getigert";
                                    break;
                                default:
                                    Console.WriteLine("Ungültige Rasse!");
                                    break;
                            }
                            Console.WriteLine(cat2.Name + " ist ein " + cat2.Rasse + " und das Fell ist " + cat2.Fellfarbe + ".");
                        }
                        Console.ReadKey();

                        Console.WriteLine("\nMöchtest du die nächste Katze kennenlernen? Ja oder Nein?");
                        string nextCat1 = Console.ReadLine();

                        switch (nextCat1)
                        {
                            case "Nein":
                                Console.WriteLine("Sehr schade. Dann bis zum nächsten Mal! Schönen Tag!");
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;
                            case "Ja":
                                Console.WriteLine("Sehr schön, dann ist hier die nächste Katze:");
                                break;
                        }

                        // Vorstellung Katze 3

                        Katze cat3 = new Katze();

                        cat3.Name = "Bello";
                        {
                            Console.WriteLine("\nDie Katze heißt " + cat3.Name + ".");
                        }
                        cat3.Geschlecht = "Kater";
                        {
                            if (cat3.Geschlecht == "Kater")
                            {
                                Console.WriteLine(cat3.Name + " ist ein " + cat3.Geschlecht + ".");
                            }
                            if (cat3.Geschlecht == "Katze")
                            {
                                Console.WriteLine(cat3.Name + " ist eine " + cat3.Geschlecht + ".");
                            }
                        }
                        cat3.Rasse = "Bengalkatze";
                        {
                            switch (cat3.Rasse)
                            {
                                case "Siamkatze":
                                    cat3.Fellfarbe = "Weiß";
                                    break;
                                case "Perserkatze":
                                    cat3.Fellfarbe = "Gold gestreift";
                                    break;
                                case "Bengalkatze":
                                    cat3.Fellfarbe = "Getigert";
                                    break;
                                default:
                                    Console.WriteLine("Ungültige Rasse!");
                                    break;
                            }
                            Console.WriteLine(cat3.Name + " ist ein " + cat3.Rasse + " und das Fell ist " + cat3.Fellfarbe + ".");
                        }
                        Console.ReadKey();

                        Console.WriteLine("\nMöchtest du eine der Katzen streicheln?");
                        string petCatReq = Console.ReadLine();

                        switch (petCatReq)
                        {
                            case "Nein":
                                Console.WriteLine("Sehr schade. Damit ist das Programm beendet.\nBis zum nächsten Mal und einen Schönen Tag!");
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;
                            case "Ja":
                                Console.WriteLine("Sehr gerne.\nWelche Katze möchtest du streicheln?\nWähle aus:\n- Katze 1\n- Katze 2\n- Katze 3");
                                break;
                        }

                        string petCat = Console.ReadLine();

                        switch (petCat)
                        {
                            case "Katze 1":
                                Console.WriteLine(cat1.Name + ":");
                                cat1.Fauchen();
                                Console.WriteLine(cat1.Name + "scheint dich nicht zu mögen.");
                                Console.ReadKey();
                                break;
                            case "Katze 2":
                                Console.WriteLine(cat2.Name + ":");
                                cat2.Miauen();
                                Console.WriteLine(cat2.Name + "scheint dich zu mögen.");
                                Console.ReadKey();
                                break;
                            case "Katze 3":
                                Console.WriteLine(cat3.Name + ":");
                                cat3.Schnurren();
                                Console.WriteLine(cat3.Name + "scheint dich sehr zu mögen.");
                                Console.ReadKey();
                                break;
                        }
                        Console.WriteLine("\nDamit ist das Programm beendet.");
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }
}
