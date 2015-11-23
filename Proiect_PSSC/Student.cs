using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PSSC
{
    class Student
    {
        public String NrMatricol { get; internal set; }
        public String Nume{ get; internal set; }
        public String Prenume { get; internal set; }
        public String CNP { get; internal set; }
        public String Facultate { get; internal set; }
        public String An { get; internal set; }
        public String IDmaterie { get; internal set; }

        internal Student(String nr, String nume, String prenume, String cnp, String facultate, String an, String idmaterie)
        {
            nr = NrMatricol;
            nume = Nume;
            prenume = Prenume;
            cnp = CNP;
            facultate = Facultate;
            an = An;
            idmaterie = IDmaterie;
        }

    }
}
