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
    public partial class FrmCrearUsuario : Form
    {
        public FrmCrearUsuario()
        {
            InitializeComponent();
        }

        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Usuario nuevoUsuario = new Usuario(txtApellido.Text, txtNombre.Text, txtCorreo.Text, txtClave.Text);
                Sistema.AgregarUsuario(nuevoUsuario);
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                txtClave.Text = "";
                this.Close();

            }
            catch (Exception ex)
            {
                this.labelError.Text = $"       {ex.Message}";
                this.labelError.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
