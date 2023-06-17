using Entidades;
namespace GeneralaTestUnitario
{
    [TestClass]
    public class TestDado
    {
        [TestMethod]
        public void ComprobarJugadaGenerala()
        {
            //arrange
            int[] dados = new int[6];
            dados[0] = 5;
            dados[1] = 0;
            dados[2] = 0;
            dados[3] = 0;
            dados[4] = 0;
            dados[5] = 0;
            //act
            bool esGenerala = Dado.Generala(dados);
            //Assert
            Assert.IsTrue(esGenerala);
        }
        [TestMethod]
        public void ComprobarJugadaPoker()
        {
            //arrange
            int[] dados = new int[6];
            dados[0] = 4;
            dados[1] = 0;
            dados[2] = 1;
            dados[3] = 0;
            dados[4] = 0;
            dados[5] = 0;
            //act
            bool esPoker = Dado.Poker(dados);
            //Assert
            Assert.IsTrue(esPoker);
        }
        [TestMethod]
        public void ComprobarJugadaFull()
        {
            //arrange
            int[] dados = new int[6];
            dados[0] = 0;
            dados[1] = 0;
            dados[2] = 0;
            dados[3] = 0;
            dados[4] = 3;
            dados[5] = 2;
            //act
            bool esFull = Dado.Full(dados);
            //Assert
            Assert.IsTrue(esFull);
        }
        [TestMethod]
        public void ComprobarJugadaEscalera() 
        {
            //arrange
            List<int> dados = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                dados.Add(i + 1);
            }
            //act
            bool esEscalera = Dado.Escalera(dados);
            //Assert
            Assert.IsTrue(esEscalera);
        }
    }
}