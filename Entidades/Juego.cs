using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Representa un juego entre dos jugadores.
    /// </summary>
    public class Juego
    {
        private string ganador;
        private Jugador jugadorUno;
        private Jugador jugadorDos;
        private int puntajeUno;
        private int puntajeDos;
        private int ronda;
        private bool partidaCancelada;
        private bool juegoEnCurso;
        private CancellationTokenSource cancellationTokenSource;
        public delegate void MensajeEnviadoEventHandler(string mensaje);
        public delegate void PartidaFinalizadaEventHandler(string ganador);
        public event MensajeEnviadoEventHandler MensajeEnviado;
        public event PartidaFinalizadaEventHandler PartidaFinalizada;



        public int Ronda { get => ronda; set => ronda = value; }
        public string Ganador { get => ganador; set => ganador = value; }
        public Jugador JugadorUno { get => jugadorUno; set => jugadorUno = value; }
        public Jugador JugadorDos { get => jugadorDos; set => jugadorDos = value; }
        public int PuntajeUno { get => puntajeUno; set => puntajeUno = value; }
        public int PuntajeDos { get => puntajeDos; set => puntajeDos = value; }
        public bool PartidaCancelada { get => partidaCancelada; set => partidaCancelada = value; }
        public bool JuegoEnCurso { get => juegoEnCurso; set => juegoEnCurso = value; }
        public CancellationTokenSource CancellationTokenSource { get => cancellationTokenSource; set => cancellationTokenSource = value; }

        /// <summary>
        /// Crea una nueva instancia de la clase Juego con los jugadores proporcionados.
        /// </summary>
        /// <param name="jugadorUno">El jugador uno.</param>
        /// <param name="jugadorDos">El jugador dos.</param>
        public Juego(Jugador jugadorUno, Jugador jugadorDos)
        {
            this.partidaCancelada = false;
            this.juegoEnCurso = false;
            this.ganador = string.Empty;
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            this.puntajeUno = 0;
            this.puntajeDos = 0;
            this.ronda = 1;
            this.cancellationTokenSource = new CancellationTokenSource();
        }
        public void IniciarPartida()
        {
            juegoEnCurso = true;
            MensajeEnviado?.Invoke("¡Comienza la partida!");
            Task simulacion = Task.Run(() => IniciarJuego(this.CancellationTokenSource.Token));
        }
        public void IniciarJuego(CancellationToken cancellation)
        {
            int maxRondas = 4;

            MensajeEnviado?.Invoke("¡Comienza la partida!");

            while (juegoEnCurso)
            {
                if (!cancellation.IsCancellationRequested && ronda<=maxRondas)
                {
                    JugarJuego();
                    SiguienteRonda();
                }
                else 
                {
                    MensajeEnviado?.Invoke("¡Fin De la partida!");
                    partidaCancelada = true;
                    FinalizarPartidaYDeterminarGanador();
                    break;
                }
            }
            if (!partidaCancelada)
            {
                MensajeEnviado?.Invoke("¡Fin De la partida!");
                FinalizarPartidaYDeterminarGanador();
            }
        }
        public void CancelarJugada() 
        {

            this.CancellationTokenSource.Cancel();
            MensajeEnviado?.Invoke("Partida cancelada.");


        }
        /// <summary>
        /// Simula una ronda del juego.
        /// </summary>
        private void JugarJuego()
        {

            MensajeEnviado?.Invoke($"Ronda {ronda}");
            MensajeEnviado?.Invoke($"Turno de {JugadorUno.Nombre}");
            RealizarLanzamiento(JugadorUno);

            Thread.Sleep(1000);

            MensajeEnviado?.Invoke($"Turno de {JugadorDos.Nombre}");
            RealizarLanzamiento(JugadorDos);

            Thread.Sleep(1000);
        }
        #region
        /// <summary>
        /// Realiza el lanzamiento de los dados para un jugador específico y calcula el puntaje obtenido.
        /// </summary>
        /// <param name="jugador">El jugador que realiza el lanzamiento.</param>
        private void RealizarLanzamiento(Jugador jugador)
        {
            int[] mapeoDados = new int[6];
            List<int> dados = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Dado dado = new Dado();
                dado.Lanzar();
                int numero = dado.Numero;
                dados.Add(numero);
                mapeoDados[numero - 1]++;
            }

            MensajeEnviado?.Invoke($"Dados de {jugador.Nombre}: {string.Join(", ", dados)}");

            int puntaje = CalcularPuntaje(mapeoDados, dados);
            MensajeEnviado?.Invoke($"Puntaje de {jugador.Nombre}, con {puntaje} puntos.");
            // Actualiza el puntaje del jugador si es mayor que cero
            if (puntaje > 0)
            {
                if (jugador == JugadorUno)
                    PuntajeUno += puntaje;
                else if (jugador == JugadorDos)
                    PuntajeDos += puntaje;
            }
        }
        /// <summary>
        /// Calcula el puntaje obtenido a partir del mapeo de los dados y los valores de los dados.
        /// </summary>
        /// <param name="mapeoDados">El mapeo de los dados obtenidos.</param>
        /// <param name="dados">La lista de valores de los dados obtenidos.</param>
        /// <returns>El puntaje obtenido.</returns>
        private int CalcularPuntaje(int[] mapeoDados, List<int> dados)
        {
            int puntaje = 0;

            if (Dado.Generala(mapeoDados))
            {
                puntaje = 50;
                MensajeEnviado?.Invoke("¡Generala!");
            }
            else if (Dado.Poker(mapeoDados))
            {
                puntaje = 40;
                MensajeEnviado?.Invoke("¡Poker!");
            }
            else if (Dado.Full(mapeoDados))
            {
                puntaje = 30;
                MensajeEnviado?.Invoke("¡Full!");
            }
            else if (Dado.Escalera(dados))
            {
                puntaje = 20;
                MensajeEnviado?.Invoke("¡Escalera!");
            }
            else
            {
                int numeroMasRepetido = 0;
                int cantidadMasRepetido = 0;

                for (int i = 0; i < mapeoDados.Length; i++)
                {
                    if (mapeoDados[i] > cantidadMasRepetido)
                    {
                        cantidadMasRepetido = mapeoDados[i];
                        numeroMasRepetido = i + 1;
                    }
                }
                // Calcula el puntaje basado en el número más repetido

                puntaje = numeroMasRepetido * cantidadMasRepetido;
            }

            return puntaje;
        }
        #endregion
        /// <summary>
        /// Avanza a la siguiente ronda del juego.
        /// </summary>
        private void SiguienteRonda()
        {
            ronda++;
            MensajeEnviado?.Invoke("Siguiente ronda...");
            Thread.Sleep(2000);
        }
        private void FinalizarPartidaYDeterminarGanador()
        {

            JugadorUno.PartidasJugadas++;
            JugadorDos.PartidasJugadas++;

            if (PuntajeUno > PuntajeDos)
            {
                ganador = JugadorUno.Nombre;
                JugadorUno.PartidasGanadas++;
                JugadorDos.PartidasPerdidas++;
                JugadorUno.PuntajeTotal += PuntajeUno;
                JugadorDos.PuntajeTotal += PuntajeDos;
            }
            else if (PuntajeDos > PuntajeUno)
            {
                ganador = JugadorDos.Nombre;
                JugadorDos.PartidasGanadas++;
                JugadorUno.PartidasPerdidas++;
                JugadorDos.PuntajeTotal += PuntajeDos;
                JugadorUno.PuntajeTotal += PuntajeUno;
            }
            else
            {
                ganador = "Empate";
                JugadorUno.PuntajeTotal += PuntajeUno;
                JugadorDos.PuntajeTotal += PuntajeDos;
            }

            MensajeEnviado?.Invoke($"El ganador es {ganador}");

            ModificarJugador(JugadorUno);
            ModificarJugador(JugadorDos);
            GuardarDatosEnArchivos();
        }
        public void GuardarDatosEnArchivos()
        {
            JuegoTerminado juegoTerminado = new JuegoTerminado(JugadorUno.Nombre, JugadorDos.Nombre, puntajeUno, PuntajeDos, Ganador);
            Sistema.AgregarPartidaTerminada(juegoTerminado);
            Sistema.SerializarPartidasTerminadas();
        }
        /// <summary>
        /// Modifica el jugador en la base de datos
        /// </summary>
        /// <param name="jugador"></param>
        private void ModificarJugador(Jugador jugador)
        {
            bool exito = Sistema.ModificarJugador(jugador);

            if (exito)
            {
                MensajeEnviado?.Invoke($"Se ha modificado el jugador {jugador.Nombre} en la base de datos.");
            }
            else
            {
                MensajeEnviado?.Invoke($"No se pudo modificar el jugador {jugador.Nombre} en la base de datos.");
            }
        }
    }
}
