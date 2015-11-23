using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PSSC
{
    class Nota
    {
        public String IDmatrie { get; internal set; }
        public String Rezultat { get; internal set; }

        internal Nota(String idmaterie, String rez)
        {
            idmaterie = IDmatrie;
            rez = Rezultat;
        }
    }
}
