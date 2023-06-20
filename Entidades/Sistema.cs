using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sistema
    {
        static ConexionBaseDeDatos conexion;      
        static Sistema() 
        {
            conexion = new ConexionBaseDeDatos();
        }
        public static void AgregarJugador(Jugador jugador) 
        {
            conexion.AgregarJugador(jugador);
        }
        public static void AgregarUsuario(Usuario usuario) 
        {
            conexion.Agregarsuarios(usuario);
        }
        public static string ObtenerJugadorMasPartidas(List<Jugador> jugadores)
        {
            Jugador jugadorMasPartidas = null;
            int maxPartidasJugadas = -1;

            foreach (Jugador jugador in jugadores)
            {
                if (jugador.PartidasJugadas > maxPartidasJugadas)
                {
                    maxPartidasJugadas = jugador.PartidasJugadas;
                    jugadorMasPartidas = jugador;
                }
            }

            return jugadorMasPartidas != null ? jugadorMasPartidas.Nombre : "N/A";
        }

        public static string ObtenerJugadorMasGanadas(List<Jugador> jugadores)
        {
            Jugador jugadorMasGanadas = null;
            int maxPartidasGanadas = -1;

            foreach (Jugador jugador in jugadores)
            {
                if (jugador.PartidasGanadas > maxPartidasGanadas)
                {
                    maxPartidasGanadas = jugador.PartidasGanadas;
                    jugadorMasGanadas = jugador;
                }
            }

            return jugadorMasGanadas != null ? jugadorMasGanadas.Nombre : "N/A";
        }

        public static string ObtenerJugadorMasPerdidas(List<Jugador> jugadores)
        {
            Jugador jugadorMasPerdidas = null;
            int maxPartidasPerdidas = -1;

            foreach (Jugador jugador in jugadores)
            {
                if (jugador.PartidasPerdidas > maxPartidasPerdidas)
                {
                    maxPartidasPerdidas = jugador.PartidasPerdidas;
                    jugadorMasPerdidas = jugador;
                }
            }

            return jugadorMasPerdidas != null ? jugadorMasPerdidas.Nombre : "N/A";
        }
    }
}
