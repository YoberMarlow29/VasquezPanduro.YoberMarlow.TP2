using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralaTestUnitario
{
    [TestClass]
    public class TestJuego
    {
        [TestMethod]
        public void IniciarJuego_JuegoEnCursoEsTrueYSeGeneraMensajeDeInicioDePartida()
        {
            // Arrange
            Jugador jugadorUno = new Jugador("Jugador 1",0,0,0,0);
            Jugador jugadorDos = new Jugador("Jugador 2", 0, 0, 0, 0);
            Juego juego = new Juego(jugadorUno, jugadorDos);
            bool juegoEnCurso = false;
            string mensajeGenerado = "";

            juego.MensajeEnviado += (mensaje) =>
            {
                mensajeGenerado = mensaje;
            };

            // Act
            juego.IniciarJuego();
            juegoEnCurso = juego.JuegoEnCurso;

            // Assert
            Assert.IsTrue(juegoEnCurso);
            Assert.AreEqual("¡Comienza la partida!", mensajeGenerado);
        }

    }
}
