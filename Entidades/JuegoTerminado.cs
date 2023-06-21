using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Representa un juego terminado entre dos jugadores.
    /// </summary>
    public class JuegoTerminado
    {
        private string jugadorUno;
        private string jugadorDos;
        private int puntajeJugadorUno;
        private int puntajeJugadorDos;
        private string ganador;
        public string JugadorUno { get => jugadorUno; set => jugadorUno = value; }
        public string JugadorDos { get => jugadorDos; set => jugadorDos = value; }
        public int PuntajeJugadorUno { get => puntajeJugadorUno; set => puntajeJugadorUno = value; }
        public int PuntajeJugadorDos { get => puntajeJugadorDos; set => puntajeJugadorDos = value; }
        public string Ganador { get => ganador; set => ganador = value; }
        /// <summary>
        /// Crea una nueva instancia de la clase JuegoTerminado con valores predeterminados.
        /// </summary>
        public JuegoTerminado()
        {
            this.jugadorUno = "";
            this.jugadorDos = "";
            this.puntajeJugadorUno = 0;
            this.puntajeJugadorDos = 0;
            this.ganador = "";
        }
        /// <summary>
        /// Crea una nueva instancia de la clase JuegoTerminado con los valores proporcionados.
        /// </summary>
        /// <param name="jugadorUno">El nombre del jugador uno.</param>
        /// <param name="jugadorDos">El nombre del jugador dos.</param>
        /// <param name="puntajeJugadorUno">El puntaje del jugador uno.</param>
        /// <param name="puntajeJugadorDos">El puntaje del jugador dos.</param>
        /// <param name="ganador">El nombre del ganador del juego.</param>
        public JuegoTerminado(string jugadorUno, string jugadorDos, int puntajeJugadorUno, int puntajeJugadorDos, string ganador):this()
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            this.puntajeJugadorUno = puntajeJugadorUno;
            this.puntajeJugadorDos = puntajeJugadorDos;
            this.ganador = ganador;
        }
    }
}
