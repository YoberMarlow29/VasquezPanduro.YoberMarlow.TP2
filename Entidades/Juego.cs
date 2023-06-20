using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
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
        private CancellationToken cancellationToken;
        private Task juegoTask;
        private ConexionBaseDeDatos conexionBD;
        public event Action<string> MensajeEnviado;


        public int Ronda { get => ronda; set => ronda = value; }
        public string Ganador { get => ganador; set => ganador = value; }
        public Jugador JugadorUno { get => jugadorUno; set => jugadorUno = value; }
        public Jugador JugadorDos { get => jugadorDos; set => jugadorDos = value; }
        public int PuntajeUno { get => puntajeUno; set => puntajeUno = value; }
        public int PuntajeDos { get => puntajeDos; set => puntajeDos = value; }
        public bool PartidaCancelada { get => partidaCancelada; set => partidaCancelada = value; }
        public bool JuegoEnCurso { get => juegoEnCurso; set => juegoEnCurso = value; }

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
            this.cancellationToken = cancellationTokenSource.Token;
            this.conexionBD = new ConexionBaseDeDatos();
        }

        public void IniciarJuego()
        {
            juegoEnCurso = true;
            MensajeEnviado?.Invoke("¡Comienza la partida!");

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

                    if (cancellationToken.IsCancellationRequested)
                        break;
                }
            });
        }

        private void JugarJuego()
        {
            MensajeEnviado?.Invoke($"Ronda {ronda}");
            MensajeEnviado?.Invoke($"Turno de {JugadorUno.Nombre}");
            RealizarLanzamiento(JugadorUno);

            Thread.Sleep(2000);

            MensajeEnviado?.Invoke($"Turno de {JugadorDos.Nombre}");
            RealizarLanzamiento(JugadorDos);
        }

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

            if (puntaje > 0)
            {
                if (jugador == JugadorUno)
                    PuntajeUno += puntaje;
                else if (jugador == JugadorDos)
                    PuntajeDos += puntaje;
            }
        }

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

                puntaje = numeroMasRepetido * cantidadMasRepetido;
            }

            return puntaje;
        }

        private void SiguienteRonda()
        {
            ronda++;
            MensajeEnviado?.Invoke("Siguiente ronda...");
            Thread.Sleep(2000);
        }

        private void FinalizarJuego()
        {
            juegoEnCurso = false;

            MensajeEnviado?.Invoke("¡Fin del juego!");

            if (!partidaCancelada)
            {
                DeterminarGanador();
                MensajeEnviado?.Invoke($"El ganador es: {ganador}");
            }
            JuegoTerminado juegoTerminado = new JuegoTerminado(JugadorUno.Nombre,JugadorDos.Nombre,puntajeUno,PuntajeDos,Ganador);
            Sistema.AgregarPartidaTerminada(juegoTerminado);
            Sistema.SerializarPartidasTerminadas();
            
            FinalizarPartida();
            ModificarJugador(JugadorUno);
            ModificarJugador(JugadorDos);
        }

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
        private void FinalizarPartida()
        {
            JugadorUno.PartidasJugadas++;
            JugadorDos.PartidasJugadas++;

            if (ganador != JugadorUno.Nombre)
                JugadorUno.PartidasPerdidas++;
            else if (ganador != JugadorDos.Nombre)
                JugadorDos.PartidasPerdidas++;
        }
        private void ModificarJugador(Jugador jugador)
        {
            bool exito = conexionBD.ModificarJugador(jugador);

            if (exito)
            {
                MensajeEnviado?.Invoke($"Se ha modificado el jugador {jugador.Nombre} en la base de datos.");
            }
            else
            {
                MensajeEnviado?.Invoke($"No se pudo modificar el jugador {jugador.Nombre} en la base de datos.");
            }
        }
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
