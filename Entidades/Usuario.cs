using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string correo;
        private string clave;
        private int partidasGanadas;
        private int partidasPerdidas;
        private int partidasJugadas;
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
        public int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        public int PartidasPerdidas { get => partidasPerdidas; set => partidasPerdidas = value; }
        public int PartidasJugadas { get => partidasJugadas; set => partidasJugadas = value; }
        public Usuario() 
        {
            this.nombre = "";
            this.apellido = "";
            this.correo = "";
            this.clave = "";
            this.partidasGanadas = 0;
            this.partidasPerdidas = 0;
            this.partidasJugadas = 0;
        }
        public Usuario(string nombre, string apellido, string correo, string clave, int partidasGanadas, int partidasPerdidas, int partidasJugadas):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.clave = clave;
            this.partidasGanadas = partidasGanadas;
            this.partidasPerdidas = partidasPerdidas;
            this.partidasJugadas = partidasJugadas;
        }
        public Usuario(int id, string nombre, string apellido, string correo, string clave, int partidasGanadas, int partidasPerdidas, int partidasJugadas):this(nombre,apellido,correo,clave,partidasGanadas,partidasPerdidas,partidasJugadas)
        {
            this.id = id;
        }

        public bool ComprobarClave(string clave)
        {
            return clave == this.clave;
        }

    }
}
