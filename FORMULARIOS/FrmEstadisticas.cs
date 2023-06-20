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
        ConexionBaseDeDatos conexion;
        List<Jugador> listaDeJugadores;
        public FrmEstadisticas()
        {
            InitializeComponent();
            conexion = new ConexionBaseDeDatos();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            listaDeJugadores = conexion.ObtenerListaDeJugadores();
            lblJugadorMasPartidas.Text = Sistema.ObtenerJugadorMasPartidas(listaDeJugadores);
            lblJugadorMasPartidasGanadas.Text = Sistema.ObtenerJugadorMasGanadas(listaDeJugadores);
            lblJugadorPartidasMasPerdidas.Text = Sistema.ObtenerJugadorMasPerdidas(listaDeJugadores);
            UpdateDataGrid(dtgListaDeJugadores);
        }
        private void UpdateDataGrid(DataGridView datagridListaJugadores) 
        {
            if (conexion.ObtenerListaDeJugadores().Count > 0)
            {
                datagridListaJugadores.DataSource = conexion.ObtenerListaDeJugadores();
                datagridListaJugadores.Visible = true;
            }
            else
            {
                datagridListaJugadores.Visible = false;
            }
        }
    }
}
