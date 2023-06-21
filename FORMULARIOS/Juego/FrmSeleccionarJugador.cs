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

        public FrmSeleccionarJugador()
        {
            InitializeComponent();
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
                cmb_JugadorUno.DataSource = Sistema.ObtenerListaDeJugadores();
                cmb_JugadorDos.DataSource = Sistema.ObtenerListaDeJugadores();
            }
            catch (Exception ex)
            {
                this.labelError.Text = $"Sucedio un error";
                this.labelError.Visible = true;
            }
        }
        private void MostrarError(string msj)
        {
            this.labelError.Visible = true;
            this.labelError.Text = msj;
        }
        private void btnCrearPartida_Click(object sender, EventArgs e)
        {

            if (cmb_JugadorUno.SelectedItem.Equals(cmb_JugadorDos.SelectedItem))
            {
                MostrarError("Los jugadores no pueden ser iguales");
            }
            else
            {
                Jugador jugador1 = (Jugador)cmb_JugadorUno.SelectedItem;
                Jugador jugador2 = (Jugador)cmb_JugadorDos.SelectedItem;
                FrmSalaDeJuegos frmSala = new FrmSalaDeJuegos(jugador1, jugador2);
                frmSala.Show();
            }

        }
    }
}
