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
    public partial class FrmRecaudacionTotalJardin : Form
    {
        private List<Aula> listadoAulas;

        public FrmRecaudacionTotalJardin(List<Aula> listadoAulas)
        {
            InitializeComponent();
            this.listadoAulas = listadoAulas;
            CargarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCampos()
        {
            float recaudacionPorAula;
            float recaudacionTotal = 0;

            foreach(Aula aula in this.listadoAulas)
            {
                recaudacionPorAula = 0;

                foreach (Alumno alumno in aula.Alumnos)
                {
                    recaudacionPorAula = recaudacionPorAula + alumno.PrecioCuota;
                }

                recaudacionTotal = recaudacionTotal + recaudacionPorAula;
                this.lstboxRecaudacionPorAula.Items.Add(aula + " Recaudacion: $" + recaudacionPorAula);
            }

            this.txtRecaudacionTotal.Text = "$ " + recaudacionTotal;
        }
    }
}
