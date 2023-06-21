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
        private Task juegoTask;
        private ConexionBaseDeDatos conexionBD;
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

        /// <summary>
        /// Crea una nueva instancia de la clase Juego con los jugadores proporcionados.
        /// </summary>
        /// <param name="jugadorUno">El jugador uno.</param>
        /// <param name="jugadorDos">El jugador dos.</param>
        public Juego(Jugador jugadorUno, Jugador jugadorDos)
        {
            this.partidaCancelada = false;
            this.juegoEnCurso = false;
            this.juegoTask = null;
            this.ganador = string.Empty;
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            this.puntajeUno = 0;
            this.puntajeDos = 0;
            this.ronda = 1;
            this.cancellationTokenSource = new CancellationTokenSource();
            this.conexionBD = new ConexionBaseDeDatos();
        }

        /// <summary>
        /// Inicia el juego.
        /// </summary>
        public void IniciarJuego()
        {
            // Establece el juego como en curso y envía un mensaje de inicio de partida
            juegoEnCurso = true;

            MensajeEnviado?.Invoke("¡Comienza la partida!");

            // Ejecuta la lógica del juego en un bucle mientras el juego esté en curso
            juegoTask = Task.Run(async () =>
            {
                while (juegoEnCurso)
                {
                    JugarJuego();

                    if (ronda >= 4)
                    {
                        FinalizarJuego();
                    }
                    else
                        SiguienteRonda();

                    Thread.Sleep(2000);

                }
            });
        }
        /// <summary>
        /// Simula una ronda del juego.
        /// </summary>
        private void JugarJuego()
        {
            // Envía mensajes sobre la ronda actual y el turno del JugadorUno
            MensajeEnviado?.Invoke($"Ronda {ronda}");
            MensajeEnviado?.Invoke($"Turno de {JugadorUno.Nombre}");
            RealizarLanzamiento(JugadorUno);

            Thread.Sleep(2000);

            // Envía mensajes sobre el turno del JugadorDos
            MensajeEnviado?.Invoke($"Turno de {JugadorDos.Nombre}");
            RealizarLanzamiento(JugadorDos);
        }
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
        /// <summary>
        /// Avanza a la siguiente ronda del juego.
        /// </summary>
        private void SiguienteRonda()
        {
            ronda++;
            MensajeEnviado?.Invoke("Siguiente ronda...");
            Thread.Sleep(2000);
        }
        /// <summary>
        /// Finaliza el juego, determinando al ganador y actualizando las estadísticas de los jugadores.
        /// </summary>
        private void FinalizarJuego()
        {
            juegoEnCurso = false;

            MensajeEnviado?.Invoke("¡Fin del juego!");

            if (!partidaCancelada)
            {
                DeterminarGanador();
                PartidaFinalizada?.Invoke($"El ganador es {ganador}");
            }
            JuegoTerminado juegoTerminado = new JuegoTerminado(JugadorUno.Nombre,JugadorDos.Nombre,puntajeUno,PuntajeDos,Ganador);
            Sistema.AgregarPartidaTerminada(juegoTerminado);
            Sistema.SerializarPartidasTerminadas();
            
            FinalizarPartida();
            ModificarJugador(JugadorUno);
            ModificarJugador(JugadorDos);
        }
        /// <summary>
        /// Cancela la partida en curso.
        /// </summary>
        public void CancelarPartida()
        {
            partidaCancelada = true;
            cancellationTokenSource.Cancel();
            juegoEnCurso = false;

            Task.Run(() =>
            {
                if (juegoTask != null)
                    juegoTask.Wait();

                DeterminarGanador();

                MensajeEnviado?.Invoke($"El ganador es: {ganador}");

                FinalizarPartida();
                ModificarJugador(JugadorUno);
                ModificarJugador(JugadorDos);
                JuegoTerminado juegoTerminado = new JuegoTerminado(JugadorUno.Nombre, JugadorDos.Nombre, puntajeUno, PuntajeDos, Ganador);
                Sistema.AgregarPartidaTerminada(juegoTerminado);
                Sistema.SerializarPartidasTerminadas();

                MensajeEnviado?.Invoke("Partida cancelada.");
            });
        }
        /// <summary>
        /// Finaliza la partida .
        /// </summary>
        private void FinalizarPartida()
        {
            JugadorUno.PartidasJugadas++;
            JugadorDos.PartidasJugadas++;

            if (ganador != JugadorUno.Nombre)
                JugadorUno.PartidasPerdidas++;
            else if (ganador != JugadorDos.Nombre)
                JugadorDos.PartidasPerdidas++;
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
        /// <summary>
        /// Determina quien gana la partida
        /// </summary>
        private void DeterminarGanador()
        {
            if (PuntajeUno > PuntajeDos)
            {
                ganador = JugadorUno.Nombre;
                JugadorUno.PartidasGanadas++;
                JugadorUno.PuntajeTotal += PuntajeUno;
                JugadorDos.PuntajeTotal += PuntajeDos;
            }
            else if (PuntajeDos > PuntajeUno)
            {
                ganador = JugadorDos.Nombre;
                JugadorDos.PartidasGanadas++;
                JugadorDos.PuntajeTotal += PuntajeDos;
                JugadorUno.PuntajeTotal += PuntajeUno;
            }
            else
            {
                ganador = "Empate";
                JugadorUno.PuntajeTotal += PuntajeUno;
                JugadorDos.PuntajeTotal += PuntajeDos;
            }
        }
    }
}
