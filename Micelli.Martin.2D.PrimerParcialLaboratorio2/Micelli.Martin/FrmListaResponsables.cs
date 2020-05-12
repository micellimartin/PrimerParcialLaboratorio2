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
    public partial class FrmListaResponsables : Form
    {
        private List<Responsable> listaResponsables;
        private Responsable responsable;

        public Responsable Responsable
        {
            get
            {
                return this.responsable;
            }
        }

        public FrmListaResponsables(List<Responsable> listaResponsables)
        {
            InitializeComponent();
            this.listaResponsables = listaResponsables;
            this.lstboxResponsables.DataSource = this.listaResponsables;
        }

        //Permite elegir un responsable de la lista con un doble click, que luego se usara para generar un objeto Alumno
        private void lstboxResponsables_DoubleClick(object sender, EventArgs e)
        {
            if (!(lstboxResponsables.SelectedItem is null))
            {
                string responsable = this.lstboxResponsables.SelectedItem.ToString();

                foreach(Responsable r in this.listaResponsables)
                {
                    if(responsable == r.ToString())
                    {
                        this.responsable = r;
                        break;
                    }
                }

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
