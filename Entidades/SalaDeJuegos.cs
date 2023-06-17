using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SalaDeJuegos
    {
        private int ronda;
        private string ganador;
        private Jugador jugadorUno;
        private Jugador jugadorDos;
        private Random random;
        Task tarea;
        CancellationTokenSource cancelarTask = new CancellationTokenSource();
        ConexionBaseDeDatos ado = new ConexionBaseDeDatos();
        int flag;

        public int Ronda { get => ronda; set => ronda = value; }
        public string Ganador { get => ganador; set => ganador = value; }
        public Jugador JugadorUno { get => jugadorUno; set => jugadorUno = value; }
        public Jugador JugadorDos { get => jugadorDos; set => jugadorDos = value; }
        public int Puntaje1 { get; set; }
        public int Puntaje2 { get; set; }

        public event Action<List<int>> SeTiraronDados;
        public event Action<string> MandarMensaje;
        public event EventHandler TerminoPartida;
        public event Action<SalaDeJuegos> GuardarPartida;

        public SalaDeJuegos(Jugador jugadorUno, Jugador jugadorDos) 
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            ronda = 1;
            random = new Random();
            tarea = new Task(() =>
            {
                Jugar(cancelarTask.Token);
                GuardarPartida?.Invoke(this);
            }, cancelarTask.Token);
            flag = 0;
        }

        public int ComenzarPartida()
        {
            tarea.Start();
            this.flag = 1;
            return flag;

        }
        public int CancelarPartida()
        {
            cancelarTask.Cancel();
            this.flag = -1;
            return flag;
        }
        private void Jugar(CancellationToken cancelarToken)
        {
            while (true)
            {
                MandarMensaje?.Invoke($"Se esta jugando la ronda {ronda}\n");
                Thread.Sleep(1000);
                JugarUnaRonda(jugadorUno, jugadorDos);
                string nombre1 = jugadorUno.Nombre;
                string nombre2 = jugadorDos.Nombre;

                if (ronda == 4 || cancelarToken.IsCancellationRequested)
                {
                    flag = -1;
                    break;
                }
                ronda++;
            }

            if (TerminoPartida is not null)
            {
                if (Puntaje1 > Puntaje2)
                {
                    Ganador = jugadorUno.Nombre;
                    jugadorUno.PartidasGanadas++;
                    MandarMensaje?.Invoke($"{jugadorUno.Nombre} gana la partida!\n");
                    ado.ModificarJugador(jugadorUno);
                }
                else
                {
                    if (Puntaje2 > Puntaje1)
                    {
                        Ganador = jugadorDos.Nombre;
                        jugadorUno.PartidasPerdidas++;
                        MandarMensaje?.Invoke($"{jugadorDos.Nombre} gana la partida!\n");
                        ado.ModificarJugador(JugadorUno);
                    }
                    else
                    {
                        Ganador = "Empate";
                        MandarMensaje?.Invoke("No hubo ganador...\n");
                    }
                }
                TerminoPartida(this, EventArgs.Empty);
            }
        }

        private int CalcularSumaDeLosDados(List<int> dados, out string nombreJugada)
        {
            int puntaje = 0;
            int[] mapeadoDados = Dado.MapearJugada(dados);
            nombreJugada = "Ninguna";


            if (Dado.Poker(mapeadoDados))
            {
                puntaje = 40;
                nombreJugada = "Poker";
            }
            else
            {
                if (Dado.Full(mapeadoDados))
                {
                    puntaje = 30;
                    nombreJugada = "Full";
                }
                else
                {
                    if (Dado.Escalera(dados))
                    {
                        puntaje = 20;
                        nombreJugada = "Escalera";
                    }
                    else
                    {
                        if (Dado.Generala(mapeadoDados))
                        {
                            puntaje = 50;
                            nombreJugada = "Generala";
                        }
                        else
                        {
                            puntaje = 5;
                        }
                    }
                }
            }
            return puntaje;
        }

        private void AsignarDados(List<int> listaDeDados)
        {
            for (int i = 0; i < 5; i++)
            {
                listaDeDados.Add(random.Next(1, 7));
            }
            if (SeTiraronDados is not null)
            {
                SeTiraronDados(listaDeDados);
            }
        }
        private void Mensaje(string mensaje) { }

        private void JugarUnaRonda(Jugador unJugador, Jugador otroJugador)
        {
            Action<string> miDelegado = Mensaje;
            miDelegado += Mensaje;
            miDelegado += Mensaje;

            var miVariable = miDelegado.GetInvocationList();

            List<int> dadosJugadorUno = new List<int>();
            List<int> dadosJugadorDos = new List<int>();

            AsignarDados(dadosJugadorUno);
            Thread.Sleep(1000);
            AsignarDados(dadosJugadorDos);
            Thread.Sleep(1000);

            string nombreJugada = "";
            int puntosJugadorUno = CalcularSumaDeLosDados(dadosJugadorUno, out nombreJugada);
            Puntaje1 += puntosJugadorUno;
            MandarMensaje?.Invoke($"{unJugador.Nombre} hizo la jugada: {nombreJugada} y sumo en total {puntosJugadorUno}\n");

            int puntosJugadorDos = CalcularSumaDeLosDados(dadosJugadorDos, out nombreJugada);
            Puntaje2 += puntosJugadorDos;
            MandarMensaje?.Invoke($"{otroJugador.Nombre} hizo la jugada: {nombreJugada} y sumo en total {puntosJugadorDos}\n");

            Thread.Sleep(1000);
            if (puntosJugadorUno == puntosJugadorDos)
            {
                MandarMensaje?.Invoke($"Empate!\n");
            }
            else
            {
                if (puntosJugadorUno > puntosJugadorDos)
                {
                    ganador = $"{unJugador.Nombre} gano la ronda con {puntosJugadorUno}!\n";
                }
                else
                {
                    ganador = $"{otroJugador.Nombre} gano la ronda con {puntosJugadorDos}!\n";
                }
            }
            Thread.Sleep(1000);
            MandarMensaje?.Invoke($"\nTermino la ronda...\n");
            Thread.Sleep(1000);
        }
    }
}
