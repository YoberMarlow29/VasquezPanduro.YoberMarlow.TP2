using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase estática que representa el sistema del juego.
    /// </summary>
    public static class Sistema
    {
        static ConexionBaseDeDatos conexion;
        private static List<JuegoTerminado> partidasTerminadasjson;
        private static List<JuegoTerminado> partidasTerminadasXml;
        private static ArchivosJson<List<JuegoTerminado>> archivosJson;
        private static ArchivosXml<List<JuegoTerminado>> archivosXml;

        /// <summary>
        /// Constructor estático de la clase Sistema.
        /// </summary>
        static Sistema()
        {
            conexion = new ConexionBaseDeDatos();
            partidasTerminadasjson = new List<JuegoTerminado>();
            partidasTerminadasXml = new List<JuegoTerminado>();
            archivosJson = new ArchivosJson<List<JuegoTerminado>>();
            archivosXml = new ArchivosXml<List<JuegoTerminado>>();
            //Inicializar();

        }

        /// <summary>
        /// Prueba la conexión a la base de datos.
        /// </summary>
        /// <returns>True si la conexión es exitosa, False en caso contrario.</returns>
        public static bool ProbarConexionABaseDeDatos() 
        {
            return conexion.ProbarConexion();
        }

        /// <summary>
        /// Inicializa el sistema cargando los datos desde los archivos Json y Xml.
        /// </summary>
        public static void Inicializar()
        {
            partidasTerminadasjson = archivosJson.Deserializar();
            partidasTerminadasXml = archivosXml.Deserializar();

        }

        /// <summary>
        /// Serializa las partidas terminadas en los archivos Xml y Json.
        /// </summary>
        public static void SerializarPartidasTerminadas()
        {
            archivosJson.Serializar(partidasTerminadasjson);
            archivosXml.Serializar(partidasTerminadasXml);
        }
        /// <summary>
        /// Agrega una partida terminada a la lista de partidas terminadas.
        /// </summary>
        /// <param name="partidaTerminada">La partida terminada a agregar.</param>
        public static void AgregarPartidaTerminada(JuegoTerminado partidaTerminada)
        {
            partidasTerminadasjson.Add(partidaTerminada);                     
            partidasTerminadasXml.Add(partidaTerminada);
        }

        /// <summary>
        /// Obtiene el historial de partidas en formato JSON.
        /// </summary>
        /// <returns>La lista de partidas terminadas en formato JSON.</returns>
        public static List<JuegoTerminado> ObtenerHistorialJson() 
        {
            return partidasTerminadasjson = archivosJson.Deserializar();
        }

        /// <summary>
        /// Obtiene el historial de partidas en formato XML.
        /// </summary>
        /// <returns>La lista de partidas terminadas en formato XML.</returns>
        public static List<JuegoTerminado> ObtenerHistorialXml()
        {
            return partidasTerminadasXml = archivosXml.Deserializar();
        }
        /// <summary>
        /// Obtiene la lista de usuarios almacenados en la base de datos.
        /// </summary>
        /// <returns>La lista de usuarios almacenados en la base de datos.</returns>
        public static List<Usuario> ObtenerListaDeUsuarios()
        {
            return conexion.ObtenerListaDeUsuarios();
        }

        /// <summary>
        /// Obtiene la lista de jugadores almacenados en la base de datos.
        /// </summary>
        /// <returns>La lista de jugadores almacenados en la base de datos.</returns>
        public static List<Jugador> ObtenerListaDeJugadores() 
        {
            return conexion.ObtenerListaDeJugadores();
        }

        /// <summary>
        /// Agrega un jugador a la base de datos.
        /// </summary>
        /// <param name="jugador">El jugador a agregar.</param>
        public static void AgregarJugador(Jugador jugador)
        {
            conexion.AgregarJugador(jugador);
        }

        /// <summary>
        /// Agrega un usuario a la base de datos.
        /// </summary>
        /// <param name="usuario">El usuario a agregar.</param>
        public static void AgregarUsuario(Usuario usuario)
        {
            conexion.Agregarsuarios(usuario);
        }

        /// <summary>
        /// Modifica un jugador en la base de datos.
        /// </summary>
        /// <param name="jugador">El jugador a modificar.</param>
        /// <returns>True si la modificación fue exitosa, False en caso contrario.</returns>
        public static bool ModificarJugador(Jugador jugador) 
        {
           bool result = false; 
            if (conexion.ModificarJugador(jugador))
                result = true;
            return result;
        }

        /// <summary>
        /// Obtiene el nombre del jugador con más partidas jugadas.
        /// </summary>
        /// <param name="jugadores">La lista de jugadores.</param>
        /// <returns>El nombre del jugador con más partidas jugadas.</returns>
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

        /// <summary>
        /// Obtiene el nombre del jugador con más partidas ganadas.
        /// </summary>
        /// <param name="jugadores">La lista de jugadores.</param>
        /// <returns>El nombre del jugador con más partidas ganadas.</returns>
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

        /// <summary>
        /// Obtiene el nombre del jugador con más partidas perdidas.
        /// </summary>
        /// <param name="jugadores">La lista de jugadores.</param>
        /// <returns>El nombre del jugador con más partidas perdidas.</returns>
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
