using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
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

        public JuegoTerminado()
        {
            this.jugadorUno = "";
            this.jugadorDos = "";
            this.puntajeJugadorUno = 0;
            this.puntajeJugadorDos = 0;
            this.ganador = "";
        }
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
