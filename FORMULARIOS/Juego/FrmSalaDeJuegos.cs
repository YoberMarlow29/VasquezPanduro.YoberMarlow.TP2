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
        Jugador jugador1;
        Jugador jugador2;

        public FrmSalaDeJuegos()
        {
            InitializeComponent();
            // Crear jugadores
            jugador1 = new Jugador("Messi", 0, 0, 0);
            jugador2 = new Jugador("Ronaldo", 0, 0, 0);

            // Crear sala de juegos
            salaDeJuegos = new SalaDeJuegos(jugador1, jugador2);

        }
        private void FrmSalaDeJuegos_Load(object sender, EventArgs e)
        {

        }
        private void btnLanzar_Click(object sender, EventArgs e)
        {
            // Suscribir al evento MensajeEnviado para mostrar los mensajes en el RichTextBox
            salaDeJuegos.MensajeEnviado += MensajeEnviado;

            // Deshabilitar el botón "Iniciar partida" y habilitar el botón "Cancelar partida"
            btnIniciarPartida.Enabled = false;
            btnCancelarPartida.Enabled = true;

            // Iniciar el juego en un hilo separado para no bloquear la interfaz de usuario
            Task.Run(() => salaDeJuegos.IniciarJuego());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cancelar la partida
            salaDeJuegos?.CancelarPartida();

            btnIniciarPartida.Enabled = true;
            btnCancelarPartida.Enabled = false;
        }

        private void MensajeEnviado(string mensaje)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.AppendText(mensaje + Environment.NewLine);
                });
            }
            else
            {
                richTextBox1.AppendText(mensaje + Environment.NewLine);
            }
        }


    }
}
