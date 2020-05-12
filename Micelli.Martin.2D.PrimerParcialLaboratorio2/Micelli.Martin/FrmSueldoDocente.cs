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
    public partial class FrmSueldoDocente : Form
    {
        private List<Docente> listaDocentesSinAula;
        private List<Docente> listaDocentesConAula;

        public FrmSueldoDocente(List<Docente> listaDocentesSinAula, List<Docente> listaDocentesConAula)
        {
            InitializeComponent();
            this.listaDocentesSinAula = listaDocentesSinAula;
            this.listaDocentesConAula = listaDocentesConAula;
            CargarCamposDocentesSinAula();
            CargarCamposDocentesConAula();
            CargarCamposDocentesTodos();
        }

        private void CargarCamposDocentesSinAula()
        {
            double totalSueldos = 0;

            foreach(Docente d in this.listaDocentesSinAula)
            {
                this.lstboxSueldosDocentesSinAula.Items.Add(d.Nombre + " " + d.Apellido + " Sueldo: $" + d.Salario);
                totalSueldos = totalSueldos + d.Salario;
            }

            this.txtTotalSinAula.Text = "$ " + totalSueldos;
        }

        private void CargarCamposDocentesConAula()
        {
            double totalSueldos = 0;

            foreach (Docente d in this.listaDocentesConAula)
            {
                this.lstboxSueldosDocentesConAula.Items.Add(d.Nombre + " " + d.Apellido + " Sueldo: $" + d.Salario);
                totalSueldos = totalSueldos + d.Salario;
            }

            this.txtTotalConAula.Text = "$ " + totalSueldos;
        }

        private void CargarCamposDocentesTodos()
        {
            double totalSueldos = 0;

            foreach (Docente d in this.listaDocentesConAula)
            {
                this.lstboxSueldosTotalDocentes.Items.Add(d.Nombre + " " + d.Apellido + " Sueldo: $" + d.Salario);
                totalSueldos = totalSueldos + d.Salario;
            }

            foreach (Docente d in this.listaDocentesSinAula)
            {
                this.lstboxSueldosTotalDocentes.Items.Add(d.Nombre + " " + d.Apellido + " Sueldo: $" + d.Salario);
                totalSueldos = totalSueldos + d.Salario;
            }

            this.txtTotalTodos.Text = "$ " + totalSueldos;
        }
    }
}
