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
    public partial class FrmInformacionPadres : Form
    {
        private List<Aula> listadoAulas;

        public FrmInformacionPadres(List<Aula> listadoAulas)
        {
            InitializeComponent();
            this.listadoAulas = listadoAulas;
            this.cmbAula.DataSource = listadoAulas;
        }

        private void cmbAula_SelectedValueChanged(object sender, EventArgs e)
        {
            Aula aulaSeleccionada = (Aula)this.cmbAula.SelectedItem;
            EColores colorAula = aulaSeleccionada.ColorSala;

            List<Responsable> responsablesPorAula = new List<Responsable>();
            
            foreach(Alumno a in aulaSeleccionada.Alumnos)
            {
                responsablesPorAula.Add(a.Responsable);
            }

            this.lstboxInformacionResponsables.Items.Clear();

            switch (colorAula)
            {
                case EColores.Naranja:
                    {
                        this.BackColor = System.Drawing.Color.Orange;

                        foreach (Responsable r in responsablesPorAula)
                        {
                            this.lstboxInformacionResponsables.Items.Add(r.Nombre + " " + r.Apellido + " " + " - Telefono: " + r.Telefono);
                        }
                    }
                    break;

                case EColores.Rojo:
                    {
                        this.BackColor = System.Drawing.Color.DarkRed;

                        foreach (Responsable r in responsablesPorAula)
                        {
                            this.lstboxInformacionResponsables.Items.Add(r.Nombre + " " + r.Apellido + " " + " - Telefono: " + r.Telefono);
                        }

                    }
                    break;

                case EColores.Amarillo:
                    {
                        this.BackColor = System.Drawing.Color.Gold;

                        foreach (Responsable r in responsablesPorAula)
                        {
                            this.lstboxInformacionResponsables.Items.Add(r.Nombre + " " + r.Apellido + " " + " - Telefono: " + r.Telefono);
                        }
                    }
                    break;

                case EColores.Verde:
                    {
                        this.BackColor = System.Drawing.Color.Green;

                        foreach (Responsable r in responsablesPorAula)
                        {
                            this.lstboxInformacionResponsables.Items.Add(r.Nombre + " " + r.Apellido + " " + " - Telefono: " + r.Telefono);
                        }
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
