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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int correcto = 0;
            foreach (Usuario item in Sistema.ObtenerListaDeUsuarios())
            {
                if (item.Correo == txtCorreo.Text && item.Clave == txtClave.Text)
                {
                    FrmPrincipal principal = new FrmPrincipal();
                    principal.ShowDialog();
                }
            }


        }
    }
}
