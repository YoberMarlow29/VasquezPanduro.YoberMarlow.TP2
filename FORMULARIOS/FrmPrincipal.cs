using Entidades;
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
        ConexionBaseDeDatos ado = new ConexionBaseDeDatos();

        public FrmPrincipal()
        {
            InitializeComponent();

        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {


        }
        private void btnCrearPartida_Click(object sender, EventArgs e)
        {
            FrmSeleccionarJugador frmJuegos = new FrmSeleccionarJugador();
            frmJuegos.ShowDialog();
        }

        private void btnCrearJugador_Click(object sender, EventArgs e)
        {
            FrmCrearJugador frmCrearJugador = new FrmCrearJugador();
            frmCrearJugador.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial();
            frmHistorial.ShowDialog();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.ShowDialog();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            if (ado.ProbarConexion())
                MessageBox.Show("Conexion con exito");
            else
                MessageBox.Show("hubo un error");
        }
    }
}
