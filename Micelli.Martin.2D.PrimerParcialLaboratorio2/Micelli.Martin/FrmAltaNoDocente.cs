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
    public partial class FrmAltaNoDocente : Form
    {
        private Administrativo administrativo;

        //Este campo se utilizan para verificar que el docente a dar de alta no se encuentre ya agregado
        private List<Administrativo> listadoAdministrativos = new List<Administrativo>();

        public Administrativo Administrativo
        {
            get
            {
                return this.administrativo;
            }
        }

        public FrmAltaNoDocente(List<Administrativo> listadoAdministrativos)
        {
            InitializeComponent();
            this.listadoAdministrativos = listadoAdministrativos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool nombreOK = false;
            bool apellidoOK = false;
            bool sexoOK = false;
            bool cargoOk = false;
            bool horarioLaboralOK = false;
            bool dniOk = false;
            int auxDni;

            StringBuilder mensajeError = new StringBuilder();

            if (!(ValidacionesTexto.ValidarStringSoloLetras(this.txtNombre.Text)))
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

            if (!(int.TryParse(this.txtDNI.Text, out auxDni)))
            {
                mensajeError.AppendLine("Ocurrio un error con el DNI");
            }
            else
            {
                dniOk = true;
            }

            if ((this.cmbCargo.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un cargo");
            }
            else
            {
                cargoOk = true;
            }

            //Si se pasan todas las validaciones creo el objeto Administrativo
            if (nombreOK && apellidoOK && sexoOK && dniOk && horarioLaboralOK && cargoOk)
            {
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                int dni = int.Parse(this.txtDNI.Text);

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

                ECargo cargo = 0;

                //Indice 0 corresponde a porteria
                if(this.cmbCargo.SelectedIndex == 0)
                {
                    cargo = ECargo.Porteria;
                }

                //Indice 1 corresponde a cocina
                if (this.cmbCargo.SelectedIndex == 1)
                {
                    cargo = ECargo.Cocina;
                }

                //Indice 2 corresponde a secretaria
                if (this.cmbCargo.SelectedIndex == 2)
                {
                    cargo = ECargo.Secretaria;
                }

                //Indice 3 corresponde a tesoreria
                if (this.cmbCargo.SelectedIndex == 3)
                {
                    cargo = ECargo.Tesoreria;
                }

                //Indice 4 corresponde a direccion
                if (this.cmbCargo.SelectedIndex == 4)
                {
                    cargo = ECargo.Direccion;
                }

                this.administrativo = new Administrativo(nombre, apellido, dni, femenino, horarioEntrada, horarioSalida, cargo);

                //Verifico que el no docente no sea duplicado
                bool existe = false;

                foreach (Administrativo a in this.listadoAdministrativos)
                {
                    if (a.ToString() == this.administrativo.ToString())
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("Ya hay un no docente con esa informacion dado de alta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
