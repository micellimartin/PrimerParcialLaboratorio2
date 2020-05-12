using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Micelli.Martin
{
    public partial class FrmVideos : Form
    {
        public FrmVideos()
        {
            InitializeComponent();
        }

        private void btnTiburoncito_Click(object sender, EventArgs e)
        {
            this.wmpReproductorDeVideo.URL = "https://examenprog.000webhostapp.com/Tiburoncito.mp4";
        }
      
        private void btnSilbar_Click(object sender, EventArgs e)
        {
            this.wmpReproductorDeVideo.URL = "https://examenprog.000webhostapp.com/Silbar.mp4";
        }

        private void btnBloopers_Click(object sender, EventArgs e)
        {
            this.wmpReproductorDeVideo.URL = "https://examenprog.000webhostapp.com/BloopersTS2.mp4";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.wmpReproductorDeVideo.close();
            this.Close();
        }
    }
}
