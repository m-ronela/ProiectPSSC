using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PSSC
{
    class Profesor
    {
        public String IDprofesor { get; internal set; }
        public String Nume { get; internal set; }
        public String IDmaterie { get; internal set; }
        public String IDfacultate { get; internal set; }

        internal Profesor(String idprofesor, String nume, String idmaterie, String idfacultate)
        {
            idprofesor = IDprofesor;

        }
    }
}
