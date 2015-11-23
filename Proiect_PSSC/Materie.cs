using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PSSC
{
    class Materie
    {
        public String IDmaterie { get; internal set; }
        public String Denumire { get; internal set; }

        internal Materie(String idmaterie, String denumire)
        {
            idmaterie = IDmaterie;
            denumire = Denumire;
        }
    }
}
