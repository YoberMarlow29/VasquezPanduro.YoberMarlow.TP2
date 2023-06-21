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
    public partial class FrmMenu : Form
    {
        private Form activarForm = null;
        private string nombreUsuario;
        private string correoUsuario;
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set
            {
                nombreUsuario = value;
                lblNombreUsuario.Text = value;
            }
        }

        public string CorreoUsuario
        {
            get { return correoUsuario; }
            set
            {
                correoUsuario = value;
                lblCorreoUsuario.Text = value;
            }
        }

        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (activarForm != null)
                activarForm.Close();
            activarForm = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(formularioHijo);
            panelFormularioHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
        private void btnCrearPartidas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmSeleccionarJugador());

        }

        private void btnCrearJugadores_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmCrearJugador());

        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmEstadisticas());

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmHistorial());

        }


    }
}
