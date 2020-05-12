using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;
using Entidades;

namespace Micelli.Martin
{
    public partial class FrmAltaDocente : Form
    {
        private Docente docente;

        //Estos campos se utilizan para verificar que el docente a dar de alta no se encuentre ya agregado
        private List<Docente> listaDocentesSinAula;
        private List<Docente> listaDocentesConAula;

        public Docente Docente
        {
            get
            {
                return this.docente;
            }
        }

        public FrmAltaDocente(List<Docente> listaDocentesSinAula, List<Docente> listaDocentesConAula)
        {
            InitializeComponent();
            this.listaDocentesSinAula = listaDocentesSinAula;
            this.listaDocentesConAula = listaDocentesConAula;
        }

        //Genera un objeto docente, previa validacion
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Auxiliares de validacion
            bool nombreOK = false;
            bool apellidoOK = false;
            bool sexoOK = false;           
            bool horarioLaboralOK = false;
            bool honorariosPorHoraOK = false;
            double auxHonorarios;
            bool dniOk = false;
            int auxDni;

            StringBuilder mensajeError = new StringBuilder();

            if(!(ValidacionesTexto.ValidarStringSoloLetras(this.txtNombre.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el nombre");
            }
            else
            {
                nombreOK = true;
            }

            if(!(ValidacionesTexto.ValidarStringSoloLetras(this.txtApellido.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el apellido");
            }
            else
            {
                apellidoOK = true;
            }

            if ((this.cmbHorarioLaboral.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un horario laboral");
            }
            else
            {
                horarioLaboralOK = true;
            }

            if ((this.cmbSexo.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un sexo");
            }
            else
            {
                sexoOK = true;
            }

            if(!(int.TryParse(this.txtDNI.Text, out auxDni)))
            {
                mensajeError.AppendLine("Ocurrio un error con el DNI");
            }
            else
            {
                dniOk = true;
            }

            if (!(double.TryParse(this.txtHonorarios.Text, out auxHonorarios)))
            {
                mensajeError.AppendLine("Ocurrio un error con los honorarios");
            }
            else
            {
                honorariosPorHoraOK = true;
            }

            //Si se pasan todas las validaciones creo el objeto Docente
            if (nombreOK && apellidoOK && sexoOK && dniOk && horarioLaboralOK && honorariosPorHoraOK)
            {              
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                int dni = int.Parse(this.txtDNI.Text);
                double valorHora = double.Parse(this.txtHonorarios.Text);

                bool femenino = false;

                //Indice 0 corresponde a masculino
                if (this.cmbSexo.SelectedIndex == 0)
                {
                    femenino = false;
                }

                //Indice 1 corresponde a femenino
                if (this.cmbSexo.SelectedIndex == 1)
                {
                    femenino = true;
                }

                DateTime horarioEntrada = new DateTime();
                DateTime horarioSalida = new DateTime();

                //Indice 0 correspondo a turno mañana
                if (this.cmbHorarioLaboral.SelectedIndex == 0)
                {
                    horarioEntrada = horarioEntrada.AddHours(8);
                    horarioSalida = horarioSalida.AddHours(13);
                }

                //Indice 1 corresponde a turno tarde
                if (this.cmbHorarioLaboral.SelectedIndex == 1)
                {
                    horarioEntrada = horarioEntrada.AddHours(14);
                    horarioSalida = horarioSalida.AddHours(19);
                }

                this.docente = new Docente(nombre, apellido,  dni, femenino, horarioEntrada, horarioSalida, valorHora);

                //Verifico que el docente no sea duplicado
                bool existe = false;

                foreach(Docente d in this.listaDocentesSinAula)
                {
                    if(d.ToString() == this.docente.ToString())
                    {
                        existe = true;
                        break;
                    }
                }

                foreach (Docente d in this.listaDocentesConAula)
                {
                    if (d.ToString() == this.docente.ToString())
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("Ya hay un docente con esa informacion dado de alta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show(mensajeError.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
