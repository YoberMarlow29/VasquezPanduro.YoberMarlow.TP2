using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIOS
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrearPartida_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearJugador_Click(object sender, EventArgs e)
        {
            FrmCrearJugador frmCrearJugador = new FrmCrearJugador();
            frmCrearJugador.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

        }
    }
}
