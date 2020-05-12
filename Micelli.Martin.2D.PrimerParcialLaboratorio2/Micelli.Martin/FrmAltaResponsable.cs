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
    public partial class FrmAltaResponsable : Form
    {
        private Responsable responsable;
        private Alumno alumno;

        //Estos campos se utilizan para verificar que el alumno y el responsable a dar de alta no se encuentren ya agregados
        private List<Responsable> listaResponables;
        private List<Alumno> listaAlumnosConAula;
        private List<Alumno> listaAlumnosSinAula;

        #region Propiedades

        public Responsable Responsable
        {
            get
            {
                return this.responsable;
            }
        }

        public Alumno Alumno
        {
            get
            {
                return this.alumno;
            }
        }

        #endregion

        public FrmAltaResponsable(List<Responsable> ListaResponables, List<Alumno> ListaAlumnosSinAula, List<Alumno> ListaAlumnosConAula)
        {
            InitializeComponent();
            this.listaResponables = ListaResponables;
            this.listaAlumnosSinAula = ListaAlumnosSinAula;
            this.listaAlumnosConAula = ListaAlumnosConAula;
        }

        //Genera un responsable, previa validacion
        private void btnAgregarNuevoResponsable_Click(object sender, EventArgs e)
        {
            //Auxiliares de validacion

            bool nombreOK = false;
            bool apellidoOK = false;
            bool sexoOK = false;
            bool dniOk = false;
            int auxDni;

            bool parentescoOk = false;
            bool numeroTelefonoOk = false;
            int auxNumeroTelefono;

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

            if (this.cmbSexo.SelectedIndex == -1)
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

            if (this.cmbParentesco.SelectedIndex == -1)
            {
                mensajeError.AppendLine("Debe elegir un tipo de parentesco");
            }
            else
            {
                parentescoOk = true;
            }

            if (!(int.TryParse(this.txtNumeroTelefono.Text, out auxNumeroTelefono)))
            {
                mensajeError.AppendLine("Ocurrio un error con el telefono");
            }
            else
            {
                numeroTelefonoOk = true;
            }

            //Si se pasan todas las validaciones creo el objeto Responsable
            if (nombreOK && apellidoOK && dniOk && sexoOK && parentescoOk && numeroTelefonoOk)
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

                //Atributos de la clase Responsable
                eParentesco parentesco = 0;

                //Indice 0 corresponde a Madre
                if (this.cmbParentesco.SelectedIndex == 0)
                {
                    parentesco = eParentesco.Madre;
                }

                //Indice 1 corresponde a Padre
                if (this.cmbParentesco.SelectedIndex == 1)
                {
                    parentesco = eParentesco.Padre;
                }

                //Indice 2 corresponde a Tia
                if (this.cmbParentesco.SelectedIndex == 2)
                {
                    parentesco = eParentesco.Tia;
                }

                //Indice 3 corresponde a Tio
                if (this.cmbParentesco.SelectedIndex == 3)
                {
                    parentesco = eParentesco.Tio;
                }

                //Indice 4 corresponde a Abuela
                if (this.cmbParentesco.SelectedIndex == 4)
                {
                    parentesco = eParentesco.Abuela;
                }

                //Indice 5 corresponde a Abuelo
                if (this.cmbParentesco.SelectedIndex == 5)
                {
                    parentesco = eParentesco.Abuelo;
                }

                //Indice 6 corresponde a Otro
                if (this.cmbParentesco.SelectedIndex == 6)
                {
                    parentesco = eParentesco.Otro;
                }

                string numeroTelefono = this.txtNumeroTelefono.Text;

                this.responsable = new Responsable(nombre, apellido, dni, femenino, parentesco, numeroTelefono);

                //Verifico que el responsable no sea duplicado
                bool existe = false;

                foreach (Responsable r in this.listaResponables)
                {
                    if (r.ToString() == this.responsable.ToString())
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("Ya hay un responsable con esa informacion dado de alta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    //Genero el formulario para dar de alta un alumno y le paso el responsable
                    FrmAltaAlumno f = new FrmAltaAlumno(this.responsable, this.listaAlumnosSinAula, this.listaAlumnosConAula);
                    f.ShowDialog();

                    //Si tuvo exito en generar el alumno, lo obtengo por medio de una propiedad y cuando este formulario concluya
                    //el formualiro principal obtiene el alumno y el responsable que quedaron almacenados en este formulario
                    if (f.DialogResult == DialogResult.OK)
                    {
                        this.alumno = f.Alumno;
                        DialogResult = DialogResult.OK;
                    }
                }              
            }
            else
            {
                MessageBox.Show(mensajeError.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        //Evento que permite asociar un responsable ya existente a un nuevo alumno
        private void btnUsarResponsableExistente_Click(object sender, EventArgs e)
        {
            FrmListaResponsables fr = new FrmListaResponsables(this.listaResponables);
            fr.ShowDialog();

            if(fr.DialogResult == DialogResult.OK)
            {
                this.responsable = fr.Responsable;

                //Genero el formulario para dar de alta un alumno y le paso el responsable
                FrmAltaAlumno f = new FrmAltaAlumno(this.responsable, this.listaAlumnosSinAula, this.listaAlumnosConAula);
                f.ShowDialog();

                //Si tuvo exito en generar el alumno, lo obtengo por medio de una propiedad y cuando este formulario concluya
                //el formualiro principal obtiene el alumno y el responsable que quedaron almacenados en este formulario
                if (f.DialogResult == DialogResult.OK)
                {
                    this.alumno = f.Alumno;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
