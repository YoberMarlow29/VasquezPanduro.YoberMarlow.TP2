using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int id;
        private string nombre;
        private int partidasJugadas;
        private int partidasGanadas;
        private int partidasPerdidas;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PartidasJugadas { get => partidasJugadas; set => partidasJugadas = value; }
        public int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        public int PartidasPerdidas { get => partidasPerdidas; set => partidasPerdidas = value; }

        public Jugador()
        {
            this.nombre = "";
            this.partidasGanadas = 0;
            this.partidasJugadas = 0;
            this.partidasPerdidas = 0;
        }
        public Jugador(string nombre,int partidasJugadas,int partidasGanadas,int partidasPerdidas) : this()
        {
            ValidarCampoString(nombre, out this.nombre);
            this.partidasJugadas = partidasJugadas;
            this.partidasGanadas= partidasGanadas;
            this.partidasPerdidas = partidasPerdidas;
        }
        public Jugador(int id,string nombre, int partidasJugadas, int partidasGanadas, int partidasPerdidas) : this(nombre,partidasJugadas,partidasGanadas,partidasPerdidas)
        {
            this.id = 0;
        }
        private void ValidarCampoString(string campo, out string campoValidado)
        {
            if (string.IsNullOrEmpty(campo))
            {
                throw new Exception("Ingresar un valor válido.");
            }
            campoValidado = campo;
        }

    }
}
