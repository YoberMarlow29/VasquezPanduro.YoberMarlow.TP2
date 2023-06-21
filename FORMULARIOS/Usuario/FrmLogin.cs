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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtClave.PasswordChar = '*';
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int correcto = 0;
            foreach (Usuario item in Sistema.ObtenerListaDeUsuarios())
            {
                if (item.Correo == txtCorreo.Text && item.Clave == txtClave.Text)
                {
                    correcto = 1;
                    FrmMenu principal = new FrmMenu();
                    principal.NombreUsuario = item.Nombre;
                    principal.CorreoUsuario = item.Correo;
                    principal.ShowDialog();
                    this.Hide();
                }
            }
            if (correcto == 0)
            {
                MessageBox.Show("correo o contraseña erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
