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
    public partial class FrmEstadisticas : Form
    {
        List<Jugador> listaDeJugadores;
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            listaDeJugadores = Sistema.ObtenerListaDeJugadores();
            lblJugadorMasPartidas.Text = Sistema.ObtenerJugadorMasPartidas(listaDeJugadores);
            lblJugadorMasPartidasGanadas.Text = Sistema.ObtenerJugadorMasGanadas(listaDeJugadores);
            lblJugadorPartidasMasPerdidas.Text = Sistema.ObtenerJugadorMasPerdidas(listaDeJugadores);
            listaDeJugadores = Sistema.ObtenerListaDeJugadores();

            List<Jugador> jugadoresPorVictorias = listaDeJugadores.OrderByDescending(j => j.PartidasGanadas).ToList();
            UpdateDataGridVictorias(dgtMasVictorias, jugadoresPorVictorias);

            List<Jugador> jugadoresPorPuntaje = listaDeJugadores.OrderByDescending(j => j.PuntajeTotal).ToList();
            UpdateDataGridPuntaje(dgtMasPuntos, jugadoresPorPuntaje);
        }
        private void UpdateDataGridVictorias(DataGridView dataGridView, List<Jugador> jugadores)
        {
            if (jugadores.Count > 0)
            {
                dataGridView.DataSource = jugadores;
                dataGridView.Columns["Id"].Visible = false;
                dataGridView.Columns["PartidasJugadas"].Visible = false;
                dataGridView.Columns["PartidasPerdidas"].Visible = false;
                dataGridView.Columns["PuntajeTotal"].Visible = false;
                dataGridView.Columns["Nombre"].HeaderText = "Nombre del Jugador";
                dataGridView.Columns["PartidasGanadas"].HeaderText = "PartidasGanadas";

                dataGridView.Visible = true;
            }
            else
            {
                dataGridView.Visible = false;
            }
        }
        private void UpdateDataGridPuntaje(DataGridView dataGridView, List<Jugador> jugadores)
        {
            if (jugadores.Count > 0)
            {
                dataGridView.DataSource = jugadores;
                dataGridView.Columns["Id"].Visible = false;
                dataGridView.Columns["PartidasJugadas"].Visible = false;
                dataGridView.Columns["PartidasGanadas"].Visible = false;
                dataGridView.Columns["PartidasPerdidas"].Visible = false;
                dataGridView.Columns["Nombre"].HeaderText = "Nombre del Jugador";
                dataGridView.Columns["PuntajeTotal"].HeaderText = "Puntaje Total";

                dataGridView.Visible = true;
            }
            else
            {
                dataGridView.Visible = false;
            }
        }
    }
}
