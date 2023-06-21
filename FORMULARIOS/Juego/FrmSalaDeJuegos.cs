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
        Juego salaDeJuegos;

        public FrmSalaDeJuegos(Jugador jugador1, Jugador jugador2)
        {
            InitializeComponent();
            salaDeJuegos = new Juego(jugador1, jugador2);
            salaDeJuegos.PartidaFinalizada += MostrarGanador;
            salaDeJuegos.MensajeEnviado += MensajeEnviado;
        }
        private void FrmSalaDeJuegos_Load(object sender, EventArgs e)
        {
            btnCancelarPartida.Enabled = false;
        }
        private void btnLanzar_Click(object sender, EventArgs e)
        {
            btnIniciarPartida.Enabled = false;
            btnCancelarPartida.Enabled = true;
            salaDeJuegos.IniciarJuego();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            salaDeJuegos?.CancelarPartida();
            btnIniciarPartida.Enabled = false;
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
        private void MostrarGanador(string ganador)
        {
            if (richTabla.InvokeRequired)
            {
                richTabla.Invoke((MethodInvoker)delegate
                {
                    richTabla.AppendText(ganador + Environment.NewLine);
                });
            }
            else
            {
                richTabla.AppendText(ganador + Environment.NewLine);
            }
        }
    }
}
