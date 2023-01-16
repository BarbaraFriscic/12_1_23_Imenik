using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_23_Imenik
{
    internal class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
