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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }
        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            btnCrearCuenta.Enabled = false;
            btnIngresar.Enabled = false;
        }
        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            if (Sistema.ProbarConexionABaseDeDatos())
            {
                MessageBox.Show("Conexion con exito");
                btnCrearCuenta.Enabled = true;
                btnIngresar.Enabled = true;
            }
            else
            {
                MessageBox.Show("hubo un error");
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frm = new FrmCrearUsuario();
            frm.ShowDialog();
        }
    }
}
