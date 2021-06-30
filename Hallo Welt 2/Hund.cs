using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hallo_Welt_2
{
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
