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
    public partial class FrmSalaDeJuegos : Form
    {
        SalaDeJuegos salaDeJuegos;

        public FrmSalaDeJuegos(Jugador jugador1, Jugador jugador2)
        {
            InitializeComponent();
            salaDeJuegos = new SalaDeJuegos(jugador1, jugador2);
        }
        private void FrmSalaDeJuegos_Load(object sender, EventArgs e)
        {

        }
        private void btnLanzar_Click(object sender, EventArgs e)
        {
            salaDeJuegos.MensajeEnviado += MensajeEnviado;

            btnIniciarPartida.Enabled = false;
            btnCancelarPartida.Enabled = true;

            Task.Run(() => salaDeJuegos.IniciarJuego());
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            salaDeJuegos?.CancelarPartida();

            btnIniciarPartida.Enabled = true;
            btnCancelarPartida.Enabled = false;
        }
        private void MensajeEnviado(string mensaje)
        {
            if (richTabla.InvokeRequired)
            {
                richTabla.Invoke((MethodInvoker)delegate
                {
                    richTabla.AppendText(mensaje + Environment.NewLine);
                });
            }
            else
            {
                richTabla.AppendText(mensaje + Environment.NewLine);
            }
        }
    }
}
