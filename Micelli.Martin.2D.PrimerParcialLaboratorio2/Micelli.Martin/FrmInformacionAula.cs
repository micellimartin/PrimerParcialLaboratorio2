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
    public partial class FrmInformacionAula : Form
    {
        private Aula aula;

        public FrmInformacionAula(Aula aula)
        {
            InitializeComponent();
            this.aula = aula;
            EstablecerColorAula();

            this.txtColor.Text = this.aula.ColorSala.ToString();
            this.txtProfesor.Text = this.aula.Docente.ToString();
            this.txtTurno.Text = this.aula.Turno.ToString();
            this.lstboxAlumnosEnSala.DataSource = this.aula.Alumnos;
        }

        //Estable el BackColor segun el color del aula
        public void EstablecerColorAula()
        {
            EColores color = this.aula.ColorSala;

            switch (color)
            {
                case EColores.Naranja:
                    {
                        this.BackColor = System.Drawing.Color.Orange;
                    }
                    break;

                case EColores.Rojo:
                    {
                        this.BackColor = System.Drawing.Color.DarkRed;
                    }
                    break;

                case EColores.Amarillo:
                    {
                        this.BackColor = System.Drawing.Color.Gold;
                    }
                    break;

                case EColores.Verde:
                    {
                        this.BackColor = System.Drawing.Color.Green;                       
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
