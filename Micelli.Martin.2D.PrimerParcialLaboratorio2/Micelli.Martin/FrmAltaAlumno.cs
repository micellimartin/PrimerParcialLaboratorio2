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
    public partial class FrmAltaAlumno : Form
    {
        private Alumno alumno;
        private Responsable responsable;

        //Estos campos se utilizan para verificar que el alumno a dar de alta no se encuentre ya agregado
        private List<Alumno> listaAlumnosConAula;
        private List<Alumno> listaAlumnosSinAula;

        #region Propiedades

        public Alumno Alumno
        {
            get
            {
                return this.alumno;
            }
        }

        public Responsable Responsable
        {
            get
            {
                return this.responsable;
            }
        }

        #endregion

        public FrmAltaAlumno(Responsable responsable, List<Alumno> listaAlumnosSinAula, List<Alumno> listaAlumnosConAula)
        {
            InitializeComponent();
            this.responsable = responsable;
            this.listaAlumnosSinAula = listaAlumnosSinAula;
            this.listaAlumnosConAula = listaAlumnosConAula;
        }

        //Genera un objeto alumno, previa validacion
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Atributos Persona
            bool nombreOK = false;
            bool apellidoOK = false;
            bool sexoOK = false;
            bool dniOk = false;
            int auxDni;

            //Atributos Alumno
            bool colorOk = false;
            bool legajoOk = false;
            int auxLegajo;
            bool precioCuotaOk = false;
            float auxPrecioCuota;
                       
            StringBuilder mensajeError = new StringBuilder();

            //Valido atributos Persona
            if(!(ValidacionesTexto.ValidarStringSoloLetras(this.txtNombre.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el nombre");
            }
            else
            {
                nombreOK = true;
            }

            if (!(ValidacionesTexto.ValidarStringSoloLetras(this.txtApellido.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el apellido");
            }
            else
            {
                apellidoOK = true;
            }

            if(this.cmbSexo.SelectedIndex == -1)
            {
                mensajeError.AppendLine("Debe elegir un sexo");
            }
            else
            {
                sexoOK = true;
            }

            if (!(int.TryParse(this.txtDni.Text, out auxDni)))
            {
                mensajeError.AppendLine("Ocurrio un error con el DNI");
            }
            else
            {
                dniOk = true;
            }

            //Valido atributos Alumno
            if(this.cmbColor.SelectedIndex == -1)
            {
                mensajeError.AppendLine("Debe elegir un color de sala");
            }
            else
            {
                colorOk = true;
            }

            if (!(int.TryParse(this.txtLegajo.Text, out auxLegajo)))
            {
                mensajeError.AppendLine("Ocurrio un error con el legajo");
            }
            else
            {
                legajoOk = true;
            }

            if (!(float.TryParse(this.txtPrecioCuota.Text, out auxPrecioCuota)))
            {
                mensajeError.AppendLine("Ocurrio un error con el precio de la cuota");
            }
            else
            {
                precioCuotaOk = true;
            }

            //Si se pasan todas las validaciones creo el objeto Alumno
            if (nombreOK && apellidoOK && sexoOK && dniOk && colorOk && legajoOk && precioCuotaOk)
            {
                //Atributos de la clase Persona
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                int dni = int.Parse(this.txtDni.Text);

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

                //Atributos de la clase Alumno
                EColores color = 0;

                //Indice 0 corresponde a naranja
                if (this.cmbColor.SelectedIndex == 0)
                {
                    color = EColores.Naranja;
                }

                //Indice 1 corresponde a naranja
                if (this.cmbColor.SelectedIndex == 1)
                {
                    color = EColores.Rojo;
                }

                //Indice 2 corresponde a naranja
                if (this.cmbColor.SelectedIndex == 2)
                {
                    color = EColores.Amarillo;
                }

                //Indice 3 corresponde a naranja
                if (this.cmbColor.SelectedIndex == 3)
                {
                    color = EColores.Verde;
                }

                int legajo = int.Parse(this.txtLegajo.Text);
                float precioCuota = float.Parse(this.txtPrecioCuota.Text);

                this.alumno = new Alumno(nombre, apellido, dni, femenino, precioCuota, color, legajo, this.responsable);

                //Verifico que el alumno no sea duplicado
                //2 alumnos son iguales si tienen igual numero de legajo
                bool existe = false;

                foreach (Alumno a in this.listaAlumnosSinAula)
                {
                    if (a == this.alumno)
                    {
                        existe = true;
                        break;
                    }
                }

                foreach (Alumno a in this.listaAlumnosConAula)
                {
                    if (a == this.alumno)
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("Ya hay un alumno con esa informacion dado de alta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
