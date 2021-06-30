using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hallo_Welt_2
{
    class Katze : Tier
    {
        //Eigenschaften

        public string Name { get; set; }
        public string Rasse { get; set; }
        public string Fellfarbe { get; set; }

        //Methoden

        public void Miauen()
        {
            Console.WriteLine("Miaut!");
        }
        public void Fauchen()
        {
            Console.WriteLine("Faucht!");
        }
        public void Schnurren()
        {
            Console.WriteLine("Schnurrt!");
        }
    }
}
