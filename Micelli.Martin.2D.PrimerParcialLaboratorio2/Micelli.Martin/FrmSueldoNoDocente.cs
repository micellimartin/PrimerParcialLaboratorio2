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
    public partial class FrmSueldoNoDocente : Form
    {
        private List<Administrativo> listaNoDocentes;

        public FrmSueldoNoDocente(List<Administrativo> listaNoDocentes)
        {
            InitializeComponent();
            this.listaNoDocentes = listaNoDocentes;
            CargarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarCampos()
        {
            double acumulador = 0;

            foreach(Administrativo a in this.listaNoDocentes)
            {
                this.lstboxInformacionNoDocente.Items.Add(a.Nombre + " " + a.Apellido + " " + " - Sueldo: $" + a.Salario);
                acumulador = acumulador + a.Salario;
            }

            this.txtGastoTotalSueldos.Text = "$ " + acumulador;
        }
    }
}
