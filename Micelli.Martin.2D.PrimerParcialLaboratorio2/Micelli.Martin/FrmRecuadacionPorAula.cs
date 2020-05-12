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
    public partial class FrmRecuadacionPorAula : Form
    {
        private List<Aula> listadoAulas;

        public FrmRecuadacionPorAula(List<Aula> listadoAulas)
        {
            InitializeComponent();
            this.listadoAulas = listadoAulas;
            this.cmbAula.DataSource = listadoAulas;
        }
       
        private void cmbAula_SelectedValueChanged(object sender, EventArgs e)
        {
            Aula aulaSeleccionada = (Aula)this.cmbAula.SelectedItem;
            EColores colorAula = aulaSeleccionada.ColorSala;
            this.lstboxCuotaPorAlumno.Items.Clear();
            float recaudacionTotal = 0;

            switch (colorAula)
            {
                case EColores.Naranja:
                    {
                        this.BackColor = System.Drawing.Color.Orange;

                        foreach (Alumno a in aulaSeleccionada.Alumnos)
                        {
                            this.lstboxCuotaPorAlumno.Items.Add(a.Nombre + " " + a.Apellido + " " + " - Valor cuota: $" + a.PrecioCuota);
                            recaudacionTotal = recaudacionTotal + a.PrecioCuota;
                        }

                        this.txtGastoTotalSueldos.Text = "$ " + recaudacionTotal;
                    }
                    break;

                case EColores.Rojo:
                    {
                        this.BackColor = System.Drawing.Color.DarkRed;

                        foreach (Alumno a in aulaSeleccionada.Alumnos)
                        {
                            this.lstboxCuotaPorAlumno.Items.Add(a.Nombre + " " + a.Apellido + " " + " - Valor cuota: $" + a.PrecioCuota);
                            recaudacionTotal = recaudacionTotal + a.PrecioCuota;
                        }

                        this.txtGastoTotalSueldos.Text = "$ " + recaudacionTotal;

                    }
                    break;

                case EColores.Amarillo:
                    {
                        this.BackColor = System.Drawing.Color.Gold;

                        foreach (Alumno a in aulaSeleccionada.Alumnos)
                        {
                            this.lstboxCuotaPorAlumno.Items.Add(a.Nombre + " " + a.Apellido + " " + " - Valor cuota: $" + a.PrecioCuota);
                            recaudacionTotal = recaudacionTotal + a.PrecioCuota;
                        }

                        this.txtGastoTotalSueldos.Text = "$ " + recaudacionTotal;
                    }
                    break;

                case EColores.Verde:
                    {
                        this.BackColor = System.Drawing.Color.Green;

                        foreach (Alumno a in aulaSeleccionada.Alumnos)
                        {
                            this.lstboxCuotaPorAlumno.Items.Add(a.Nombre + " " + a.Apellido + " " + " - Valor cuota: $" + a.PrecioCuota);
                            recaudacionTotal = recaudacionTotal + a.PrecioCuota;
                        }

                        this.txtGastoTotalSueldos.Text = "$ " + recaudacionTotal;
                    }
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
