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
    public partial class FrmPartida : Form
    {
        public event EventHandler<string> enviarMensaje;
        public int codigoPartida;
        public FrmPartida(int valor)
        {
            InitializeComponent();
            codigoPartida = valor;
        }

        private void FrmPartida_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensaje = "formulario partida, numero: "+codigoPartida+"reportandose";
            enviarMensaje?.Invoke(this, mensaje);

        }
    }
}
