using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Validaciones;

namespace Micelli.Martin
{
    public partial class FrmBuscadorDeAlumno : Form
    {
        private List<Alumno> listaAlumnosSinAula;
        private List<Alumno> listaAlumnosConaAula;

        public FrmBuscadorDeAlumno(List<Alumno> listaAlumnosSinAula, List<Alumno> listaAlumnosConaAula)
        {
            InitializeComponent();
            this.listaAlumnosSinAula = listaAlumnosSinAula;
            this.listaAlumnosConaAula = listaAlumnosConaAula;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.lstboxInformacionAlumno.Items.Clear();

            string apellido = this.txtApellido.Text.ToLower();
            bool existe = false;
            //Hago una lista porque pueden haber varios alumnos con el mismo apellido
            List<Alumno> encontrados = new List<Alumno>();

            foreach(Alumno a in this.listaAlumnosSinAula)
            {
                if(apellido == a.Apellido.ToLower())
                {
                    encontrados.Add(a);
                    existe = true;
                }
            }

            foreach (Alumno a in this.listaAlumnosConaAula)
            {
                if (apellido == a.Apellido.ToLower())
                {
                    encontrados.Add(a);
                    existe = true;
                }
            }

            if(existe)
            {
                MessageBox.Show("¡Alumnos encontrados con ese apellido!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                foreach(Alumno a in encontrados)
                {
                    this.lstboxInformacionAlumno.Items.Add(a);
                }

            }
            else
            {
                MessageBox.Show("No existen alumnos con ese apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
