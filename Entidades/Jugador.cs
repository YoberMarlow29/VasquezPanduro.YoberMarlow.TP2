using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Representa a un jugador en el juego.
    /// </summary>
    public class Jugador
    {
        private int id;
        private string nombre;
        private int partidasJugadas;
        private int partidasGanadas;
        private int partidasPerdidas;
        private int puntajeTotal;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PartidasJugadas { get => partidasJugadas; set => partidasJugadas = value; }
        public int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        public int PartidasPerdidas { get => partidasPerdidas; set => partidasPerdidas = value; }
        public int PuntajeTotal { get => puntajeTotal; set => puntajeTotal = value; }

        /// <summary>
        /// Crea una instancia de la clase Jugador con valores predeterminados.
        /// </summary>
        public Jugador()
        {            
            this.nombre = "";
            this.partidasGanadas = 0;
            this.partidasJugadas = 0;
            this.partidasPerdidas = 0;
            this.puntajeTotal= 0;
        }
        /// <summary>
        /// Crea una instancia de la clase Jugador con los valores proporcionados.
        /// </summary>
        /// <param name="nombre">El nombre del jugador.</param>
        /// <param name="partidasJugadas">El número de partidas jugadas por el jugador.</param>
        /// <param name="partidasGanadas">El número de partidas ganadas por el jugador.</param>
        /// <param name="partidasPerdidas">El número de partidas perdidas por el jugador.</param>
        /// <param name="puntajeTotal">El puntaje total del jugador.</param>
        /// <exception cref="System.Exception">Se produce si ya existe un jugador con el mismo nombre.</exception>
        public Jugador(string nombre,int partidasJugadas,int partidasGanadas,int partidasPerdidas,int puntajeTotal) : this()
        {
            if (ExisteMismoNombre(nombre))
            {
                throw new Exception("Ya existe un jugador con el mismo nombre.");

            }
            else 
            {
                ValidarCampoString(nombre, out this.nombre);
                this.partidasJugadas = partidasJugadas;
                this.partidasGanadas = partidasGanadas;
                this.partidasPerdidas = partidasPerdidas;
                this.puntajeTotal = puntajeTotal;
            }

        }
        /// <summary>
        /// Valida un campo de tipo string y lo asigna a una variable de instancia.
        /// </summary>
        /// <param name="campo">El campo a validar.</param>
        /// <param name="campoValidado">Variable donde se almacenará el campo validado.</param>
        /// <exception cref="System.Exception">Se produce si el campo es nulo o vacío.</exception>
        private void ValidarCampoString(string campo, out string campoValidado)
        {
            if (string.IsNullOrEmpty(campo))
            {
                throw new Exception("Ingresar un valor válido.");
            }
            campoValidado = campo;
        }
        public override bool Equals(object obj)
        {
            Jugador jugador = obj as Jugador;
            return jugador is not null && GetHashCode() == jugador.Id;
        }
        public override string ToString()
        {
            return this.Nombre;
        }
        public override int GetHashCode()
        {
            return this.id;
        }
        /// <summary>
        /// Verifica si existe otro jugador con el mismo nombre.
        /// </summary>
        /// <param name="nombre">El nombre a verificar.</param>
        /// <returns>
        ///   <c>true</c> si existe otro jugador con el mismo nombre; de lo contrario, <c>false</c>.
        /// </returns>
        private bool ExisteMismoNombre(string nombre) 
        {
            foreach (Jugador jugador in Sistema.ObtenerListaDeJugadores())
            {
                if (jugador.ToString() == nombre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
