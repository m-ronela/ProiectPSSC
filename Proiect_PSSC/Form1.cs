using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PSSC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddData_Click(object sender, EventArgs e)
        {
            String[] facultati = { "AC", "ETC", "EE", "ET", "MTP" };
            String[] materii = { "Algebra", "MS", "FIE", "LD", "PC" };
            String[] profesori = { "Daianu", "Golet", "Bere", "Negrea", "Dragan" };

            DataRow facultateRow = store.Facultate.NewRow();
            DataRow materieRow = store.Materie.NewRow();
            DataRow profesorRow = store.Profesor.NewRow();

            for(int i=0; i<5; i++)
            {
                facultateRow = store.Facultate.NewRow();
                facultateRow["IDfacultate"] = (i + 1).ToString();
                facultateRow["NumeFacultate"] = facultati[i];
                store.Facultate.Rows.Add(facultateRow);
            }

            for(int i=0; i<5; i++)
            {
                materieRow = store.Materie.NewRow();
                materieRow["IDmaterie"] = (i + 1).ToString();
                materieRow["Denumire"] = materii[i];
                store.Materie.Rows.Add(materieRow);
            }

            for(int i=0; i<5; i++)
            {
                profesorRow = store.Profesor.NewRow();
                profesorRow["IDprofesor"] = (i + 1).ToString();
                profesorRow["Nume"] = profesori[i];
                profesorRow["IDmaterie"] = (i + 1).ToString();
                profesorRow["IDfacultate"] = (i + 1).ToString();
            }

            //store.Facultate.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow studentRow = store.Student.NewRow();
            studentRow()
        }
    }
}
