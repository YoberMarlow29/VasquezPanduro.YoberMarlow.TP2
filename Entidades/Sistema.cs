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
        private static List<JuegoTerminado> partidasTerminadasjson;
        private static List<JuegoTerminado> partidasTerminadasXml;
        private static ArchivosJson<List<JuegoTerminado>> archivosJson;
        private static ArchivosXml<List<JuegoTerminado>> archivosXml;
        private static List<Usuario> listaDeUsuarios; 
        static Sistema()
        {
            conexion = new ConexionBaseDeDatos();
            partidasTerminadasjson = new List<JuegoTerminado>();
            partidasTerminadasXml = new List<JuegoTerminado>();
            archivosJson = new ArchivosJson<List<JuegoTerminado>>();
            archivosXml = new ArchivosXml<List<JuegoTerminado>>();
            listaDeUsuarios = new List<Usuario>();
            Inicializar();

        }   
        
        public static void Inicializar()
        {
            partidasTerminadasjson = archivosJson.Deserializar();
            partidasTerminadasXml = archivosXml.Deserializar();

        }

        public static void SerializarPartidasTerminadas()
        {
            archivosJson.Serializar(partidasTerminadasjson);
            archivosXml.Serializar(partidasTerminadasXml);
        }

        public static void AgregarPartidaTerminada(JuegoTerminado partidaTerminada)
        {
            partidasTerminadasjson.Add(partidaTerminada);
            partidasTerminadasXml.Add(partidaTerminada);
        }
        public static List<JuegoTerminado> ObtenerHistorialJson() 
        {
            return partidasTerminadasjson = archivosJson.Deserializar();
        }
        public static List<JuegoTerminado> ObtenerHistorialXml()
        {
            return partidasTerminadasXml = archivosXml.Deserializar();
        }
        public static List<Usuario> ObtenerListaDeUsuarios()
        {
            return conexion.ObtenerListaDeUsuarios();
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
