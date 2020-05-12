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

        //Falta pasarle la info del responsable seleccionado a los campos del formulario altaresponsable

        public FrmListaResponsables(List<Responsable> listaResponsables)
        {
            InitializeComponent();
            this.listaResponsables = listaResponsables;
            this.lstboxResponsables.DataSource = this.listaResponsables;
        }

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
