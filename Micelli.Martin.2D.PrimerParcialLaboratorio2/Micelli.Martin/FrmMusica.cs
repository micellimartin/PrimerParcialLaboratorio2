using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Micelli.Martin
{
    public partial class FrmMusica : Form
    {
        private SoundPlayer sPlayer;

        public FrmMusica()
        {
            InitializeComponent();
        }

        private void btnOneStop_Click(object sender, EventArgs e)
        {
            //Se reproducira un archivo de audio al clickear el boton
            //El archivo de audio a reproducir esta guardado en la propiedad Recursos del proyecto Micelli.Martin
            this.sPlayer = new SoundPlayer(Micelli.Martin.Properties.Resources.onestop);
            sPlayer.Play();
        }

        private void btnFlourish_Click(object sender, EventArgs e)
        {
            this.sPlayer = new SoundPlayer(Micelli.Martin.Properties.Resources.flourish);
            sPlayer.Play();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMusica_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Hace que la musica se detenga cuando se cierra el formulario
            this.sPlayer.Stop();
        }        
    }
}
