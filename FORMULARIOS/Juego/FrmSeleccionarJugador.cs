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
    public partial class FrmSeleccionarJugador : Form
    {
        ConexionBaseDeDatos ado;
        public FrmSeleccionarJugador()
        {
            InitializeComponent();
            ado = new ConexionBaseDeDatos();
        }   
        private void FrmSeleccionarJugador_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
            ObtenerJugadores();
        }
        private void ObtenerJugadores()
        {
            try 
            { 
                cboJugador1.DataSource = ado.ObtenerListaDeJugadores();
                cboJugador2.DataSource = ado.ObtenerListaDeJugadores();
            }
            catch(Exception ex) 
            {
                this.labelError.Text = $"Sucedio un error";
                this.labelError.Visible = true;
            }
        }


    }
}
