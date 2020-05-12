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
    public partial class FrmAltaAula : Form
    {
        //No creo propiedades de estos campos porque reciben las listas del formulario principal, como las Lists son objetos, se pasan por referencia
        //Entonces si se modifican aca, se modifican tambien el formulario principal
        private List<Alumno> listadoAlumnosSinAula = new List<Alumno>();
        private List<Docente> listadoDocentesSinAula = new List<Docente>();

        private List<Alumno> listadoAlumnosConAula = new List<Alumno>();
        private List<Docente> listadoDocentesConAula = new List<Docente>();

        private Aula aula;

        public Aula Aula
        {
            get
            {
                return this.aula;
            }
        }

        public FrmAltaAula(List<Alumno> listadoAlumnosSinAula, List<Alumno> listadoAlumnosConAula, List<Docente> listadoDocentesSinAula, List<Docente> listadoDocentesConAula)
        {
            InitializeComponent();

            this.listadoAlumnosSinAula = listadoAlumnosSinAula;
            this.listadoAlumnosConAula = listadoAlumnosConAula;
            this.listadoDocentesSinAula = listadoDocentesSinAula;
            this.listadoDocentesConAula = listadoDocentesConAula;

            //Habilita el drag and drop en las listboxs
            this.lstboxAlumnosSinSala.AllowDrop = true;
            this.lstboxAlumnosEnSala.AllowDrop = true;
        }

        //Cambia el color de fondo del formulario y ademas cambia los alumnos sin aula que se muestran en la listbox
        private void cmbColor_SelectedValueChanged(object sender, EventArgs e)
        {
            int colorSeleccionado = this.cmbColor.SelectedIndex;

            //Evito que se agreguen alumnos de distintos colores de sala a la misma aula
            this.lstboxAlumnosEnSala.Items.Clear();
            this.lstboxAlumnosSinSala.Items.Clear();                    

            switch (colorSeleccionado)
            {
                case 0:
                    {
                        this.BackColor = System.Drawing.Color.Orange;
                                              
                        foreach(Alumno a in this.listadoAlumnosSinAula)
                        {
                            if(a.ColorSala == EColores.Naranja)
                            {
                                this.lstboxAlumnosSinSala.Items.Add(a.ToString());
                            }
                        }
                    }
                    break;

                case 1:
                    {
                        this.BackColor = System.Drawing.Color.DarkRed;

                        foreach (Alumno a in this.listadoAlumnosSinAula)
                        {
                            if (a.ColorSala == EColores.Rojo)
                            {
                                this.lstboxAlumnosSinSala.Items.Add(a.ToString());
                            }
                        }

                    }
                    break;

                case 2:
                    {
                        this.BackColor = System.Drawing.Color.Gold;

                        foreach (Alumno a in this.listadoAlumnosSinAula)
                        {
                            if (a.ColorSala == EColores.Amarillo)
                            {
                                this.lstboxAlumnosSinSala.Items.Add(a.ToString());
                            }
                        }
                    }
                    break;

                case 3:
                    {
                        this.BackColor = System.Drawing.Color.Green;

                        foreach (Alumno a in this.listadoAlumnosSinAula)
                        {
                            if (a.ColorSala == EColores.Verde)
                            {
                                this.lstboxAlumnosSinSala.Items.Add(a.ToString());
                            }
                        }
                    }
                    break;                
            }
        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Docente> auxDocentesMañana = new List<Docente>();
            List<Docente> auxDocentesTarde = new List<Docente>();

            //Variables auxiliares que se usan para determinar el turno del docente
            DateTime horarioEntradaMañana = new DateTime();
            DateTime horarioEntradaTarde = new DateTime();

            horarioEntradaMañana = horarioEntradaMañana.AddHours(8);
            horarioEntradaTarde = horarioEntradaTarde.AddHours(14);

            //Indice 0 corresponde a turno mañana
            if (this.cmbTurno.SelectedIndex == 0)
            {
                this.cmbProfesor.Enabled = true;
                             
                foreach (Docente d in this.listadoDocentesSinAula)
                {
                    if (d.HoraEntrada == horarioEntradaMañana)
                    {
                        auxDocentesMañana.Add(d);
                    }
                }

                this.cmbProfesor.DataSource = auxDocentesMañana;
            }

            //Indice 1 corresponde a turno tarde
            if (this.cmbTurno.SelectedIndex == 1)
            {
                this.cmbProfesor.Enabled = true;

                foreach (Docente d in this.listadoDocentesSinAula)
                {
                    if (d.HoraEntrada == horarioEntradaTarde)
                    {
                        auxDocentesTarde.Add(d);
                    }
                }

                this.cmbProfesor.DataSource = auxDocentesTarde;
            }
        }

        #region Drag and drop
        //Estos manejadores de eventos permiten mover alumnos de una listbox a la otra

        private void lstboxAlumnosSinSala_MouseDown(object sender, MouseEventArgs e)
        {
            //Primero valido que no se pueda arrastrar una fila vacia de la listbox de alumnos sin sala
            if(!(lstboxAlumnosSinSala.SelectedItem is null))
            {
                //Al seleccionar un item de la listbox de alumnos sin aula lo pasa a string y lo copia
                this.lstboxAlumnosSinSala.DoDragDrop(lstboxAlumnosSinSala.SelectedItem.ToString(), DragDropEffects.Copy);
            }
        }

        private void lstboxAlumnosEnSala_DragEnter(object sender, DragEventArgs e)
        {
            //Valida que al dropear algo en la listbox de alumnos en sala solo se agrege si es texto
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }  
        }

        //Entra en aula, sale de sin aula
        private void lstboxAlumnosEnSala_DragDrop(object sender, DragEventArgs e)
        {
            //Agrego el alumno pasado a string a la listbox alumnos en sala
            lstboxAlumnosEnSala.Items.Add(e.Data.GetData(DataFormats.Text));

            //Remuevo el alumno pasado a string de la listbox alumnos sin sala
            lstboxAlumnosSinSala.Items.Remove(e.Data.GetData(DataFormats.Text));
        }

        #endregion

        private void btnGuardarAula_Click(object sender, EventArgs e)
        {
            bool ColorOK = false;
            bool TurnoOK = false;
            bool ProfesorOK = false;
            bool ListaAlumnosMinCantOK = false;
            bool ListaAlumnosMaxCantOk = false;

            StringBuilder mensajeError = new StringBuilder();

            if ((this.cmbColor.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un color");
            }
            else
            {
                ColorOK = true;
            }

            if ((this.cmbTurno.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un turno");
            }
            else
            {
                TurnoOK = true;
            }

            if ((this.cmbProfesor.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un profesor");
            }
            else
            {
                ProfesorOK = true;
            }

            if(this.lstboxAlumnosEnSala.Items.Count <5)
            {
                mensajeError.AppendLine("El aula debe tener por lo menos 5 alumnos");
            }
            else
            {
                ListaAlumnosMinCantOK = true;
            }

            if (this.lstboxAlumnosEnSala.Items.Count > 30)
            {
                mensajeError.AppendLine("El aula no puede tener mas de 30 alumnos");
            }
            else
            {
                ListaAlumnosMaxCantOk = true;
            }

            //Si se pasan todas las validaciones creo el objeto Aula
            if (ColorOK && TurnoOK && ProfesorOK && ListaAlumnosMinCantOK && ListaAlumnosMaxCantOk)
            {
                DialogResult confirmacion = MessageBox.Show("¿Desea dar de alta un aula con la informacion seleccionada?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.OK)
                {
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

                    Eturno turno = 0;

                    if (this.cmbTurno.SelectedIndex == 0)
                    {
                        turno = Eturno.mañana;
                    }

                    if (this.cmbTurno.SelectedIndex == 1)
                    {
                        turno = Eturno.tarde;
                    }

                    Docente docente = null;
                    string auxDocente = this.cmbProfesor.SelectedItem.ToString();

                    foreach (Docente d in this.listadoDocentesSinAula)
                    {
                        if (d.ToString() == auxDocente)
                        {
                            docente = d;
                            break;
                        }
                    }

                    this.aula = new Aula(color, turno, docente);
                    this.aula.Alumnos = new List<Alumno>();

                    List<Alumno> listaAlumnos = new List<Alumno>();

                    int cantAlumnosAgregados = 0;

                    foreach (string alumnoTexto in this.lstboxAlumnosEnSala.Items)
                    {
                        foreach (Alumno alumnoObjeto in this.listadoAlumnosSinAula)
                        {
                            if (alumnoTexto == alumnoObjeto.ToString())
                            {
                                if (aula + alumnoObjeto)
                                {
                                    cantAlumnosAgregados++;
                                    //listaAlumnos.Add(alumnoObjeto);
                                }
                            }
                        }
                    }

                    //aula.Alumnos = listaAlumnos;

                    //Remuevo los alumnos asignados al aula nueva de la lista de alumnos sin aula y los agrego a la lista de alumnos con aula

                    foreach (Alumno a in this.aula.Alumnos)
                    {
                        this.listadoAlumnosSinAula.Remove(a);
                        this.listadoAlumnosConAula.Add(a);
                    }

                    //Remuevo al docente asignado al aula nueva de la lista de docentes sin aula y lo agregoa a la lista de docentes con aula

                    this.listadoDocentesSinAula.Remove(aula.Docente);
                    this.listadoDocentesConAula.Add(aula.Docente);

                    DialogResult = DialogResult.OK;
                }                               
            }
            else
            {
                MessageBox.Show(mensajeError.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }                          
        }

        private void lstboxAlumnosEnSala_DoubleClick(object sender, EventArgs e)
        {
            if (!(lstboxAlumnosEnSala.SelectedItem is null))
            {
                string alumno = this.lstboxAlumnosEnSala.SelectedItem.ToString();
                this.lstboxAlumnosEnSala.Items.Remove(alumno);
                this.lstboxAlumnosSinSala.Items.Add(alumno);
            }
        }

        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("Arrastre los alumnos para asignarlos a la sala");
            mensaje.AppendLine("Haga doble click en un alumno para removerlo de la sala");

            MessageBox.Show(mensaje.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
