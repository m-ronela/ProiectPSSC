using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PSSC
{
    class Facultate
    {
        public String IDfacultate { get; internal set; }
        public String NumeFacultate { get; internal set; }

        internal Facultate(String idFacultate, String Numefacultate)
        {
            idFacultate = IDfacultate;
            Numefacultate = NumeFacultate;
        }
    }
}
