using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SalaDeJuegos
    {
        public delegate void Action(int numero);
        public event Action Eliminar;

        private List<Jugador> jugadores;
        private bool hayGanador;
        private Jugador ganador;
        private int numero;
        private Dado[] dados;
        private int rondas;

        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public bool HayGanador { get => hayGanador; set => hayGanador = value; }
        public Jugador Ganador { get => ganador; set => ganador = value; }
        public int Numero { get => numero; set => numero = value; }
        public Dado[] Dados { get => dados; set => dados = value; }
        public int Rondas { get => rondas; set => rondas = value; }

        public SalaDeJuegos()
        {
            this.rondas = 0;
            this.jugadores = new List<Jugador>();
            this.hayGanador = false;
            this.dados = new Dado[5];
            for (int i = 0; i < 5; i++)
            {
                dados[i] = new Dado();
            }
        }
        public void InvocarEliminacion()
        {
            if (this.Eliminar is not null)
            {
                this.Eliminar.Invoke(this.Numero);
            }
        }

        public static SalaDeJuegos operator +(SalaDeJuegos partida, Jugador jugador)
        {
            if (partida is not null && jugador is not null)
            {
                partida.jugadores.Add(jugador);
            }

            return partida;
        }
    }
}
