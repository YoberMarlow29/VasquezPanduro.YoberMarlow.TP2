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
        static List<Jugador> listaDeJugadores;
        
        static Sistema() 
        {
            conexion = new ConexionBaseDeDatos();
            listaDeJugadores = new List<Jugador>();
        }
        public static void AgregarJugador(string nombre) 
        {
            Jugador jugador= new Jugador(nombre,0,0,0);
            conexion.AgregarJugador(jugador);
        }
    }
}
