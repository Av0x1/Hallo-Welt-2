using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hallo_Welt_2
{
    class Tier
    {
        //Eigenschaften

        public string Geschlecht { get; set; }

        public string Alter { get; set; }

        //Methoden

        public void Bewegen()
        {
            Console.WriteLine("Rennt weg!");
        }

    }
}
