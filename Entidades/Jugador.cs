using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        public delegate Dado[] delegadoTirada(SalaDeJuegos nuevaPartida);
        public event delegadoTirada tirada;
        private int id;
        private string nombre;
        private int puntuacionTotal;
        private int turnos;
        private int[] puntuaciones;
        private Dado[] dadosLanzados;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PuntuacionTotal { get => puntuacionTotal; set => puntuacionTotal = value; }
        public int Turnos { get => turnos; set => turnos = value; }
        public int[] Puntuaciones { get => puntuaciones; set => puntuaciones = value; }
        public Jugador()
        {
            this.nombre = "";
            this.puntuacionTotal = 0;
            this.puntuaciones = new int[11];
        }
        public Jugador(string nombre) : this()
        {
            if (nombre is not null)
            {
                this.nombre = nombre;
            }
        }
        public Jugador(string nombre, int puntuacion, int turnos) : this(nombre)
        {
            this.puntuacionTotal = puntuacion;
            this.turnos = turnos;
        }
        private void CompararPuntuaciones(int[] puntuacionTiradaReciente, int[] puntuacionDelJugador)
        {
            int indexMayorPuntuacion = -1;
            int puntuacion = 0;
            bool tienePuntos = true;

            while (tienePuntos)
            {
                indexMayorPuntuacion = CalcularPuntuacionMaxima(puntuacionTiradaReciente, out puntuacion);
                if (indexMayorPuntuacion == 9)
                {
                    if (puntuacionDelJugador[indexMayorPuntuacion] > 0)
                    {
                        puntuacionDelJugador[10] = 100;
                    }
                }

                if (puntuacionDelJugador[indexMayorPuntuacion] == 0)
                {
                    puntuacionDelJugador[indexMayorPuntuacion] = puntuacion;
                    tienePuntos = false;
                }
                else
                {
                    if (puntuacion == 0)
                    {
                        break;
                    }
                    tienePuntos = true;
                    puntuacionTiradaReciente[indexMayorPuntuacion] = 0;
                }
            }
        }
        private int CalcularPuntuacionMaxima(int[] puntuacionTiradaReciente, out int numero)
        {
            int indexMayorPuntuacion = -1;
            int puntuacion = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    indexMayorPuntuacion = i;
                    puntuacion = puntuacionTiradaReciente[i];
                }
                if (puntuacionTiradaReciente[i] > puntuacion)
                {
                    indexMayorPuntuacion = i;
                    puntuacion = puntuacionTiradaReciente[i];
                }
            }
            numero = puntuacion;
            return indexMayorPuntuacion;
        }
        private int[] ContarPuntuacion(Dado[] dadosJugados)
        {
            int[] puntuacion = new int[11];
            int numero;
            if (Dado.Generala(dadosJugados))
            {
                puntuacion[9] = 50;
            }
            if (Dado.Escalera(dadosJugados))
            {
                puntuacion[6] = 20;
            }
            if (Dado.Poker(dadosJugados))
            {
                puntuacion[8] = 40;
            }
            if (Dado.Full(dadosJugados))
            {
                puntuacion[7] = 30;
            }

            for (int i = 1; i < 7; i++)
            {
                numero = Dado.VerificarPuntuacionNumero(dadosJugados, i);
                puntuacion[i - 1] = numero * i;
            }

            return puntuacion;
        }
        public static Jugador VerificarGanador(Jugador jugador1, Jugador jugador2)
        {
            Jugador ganador = new Jugador("fue empate");
            jugador1.puntuacionTotal = 0;
            jugador2.puntuacionTotal = 0;
            for (int i = 0; i < 11; i++)
            {
                jugador1.puntuacionTotal += jugador1.puntuaciones[i];
                jugador2.puntuacionTotal += jugador2.puntuaciones[i];
            }
            if (jugador1.puntuacionTotal > jugador2.puntuacionTotal)
            {
                ganador = jugador1;
            }
            else if (jugador2.puntuacionTotal > jugador1.puntuacionTotal)
            {
                ganador = jugador2;
            }
            return ganador;
        }
        public void JugarTurno(SalaDeJuegos partida)
        {
            Dado[] aux = new Dado[5];

            if (this.tirada is not null)
            {
                this.dadosLanzados = this.tirada.Invoke(partida);
            }

            int[] puntuacion = new int[11];
            puntuacion = ContarPuntuacion(dadosLanzados);
            CompararPuntuaciones(puntuacion, this.puntuaciones);
        }

    }
}
