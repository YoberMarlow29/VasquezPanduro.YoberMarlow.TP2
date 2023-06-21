namespace Entidades
{
    /// <summary>
    /// Representa un dado utilizado en un juego.
    /// </summary>
    public class Dado
    {
        private int numero;
        private Random random;

        /// <summary>
        /// Crea una nueva instancia de la clase Dado.
        /// </summary>
        public Dado()
        {
            this.numero = 0;
            this.random = new Random();
        }


        public int Numero { get => numero; set => numero = value; }
        public Random Random { get => random; set => random = value; }


        /// <summary>
        /// Lanza el dado y genera un número aleatorio entre 1 y 6.
        /// </summary>
        public void Lanzar()
        {
            this.numero = random.Next(1, 7);
        }
        /// <summary>
        /// Verifica si se ha obtenido una Generala.
        /// </summary>
        /// <param name="mapeoDados">Un arreglo que representa el mapeo de los resultados obtenidos en los dados.</param>
        /// <returns>
        ///   <c>true</c> si se ha obtenido una Generala; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool Generala(int[] mapeoDados)
        {
            bool esGenerala = false;

            for (int i = 0; i < 6; i++)
            {
                if (mapeoDados[i] == 5)
                {
                    esGenerala = true;
                    break;
                }
            }

            return esGenerala;
        }
        /// <summary>
        /// Verifica si se ha obtenido una Escalera.
        /// </summary>
        /// <param name="dados">Una lista de los valores obtenidos en los dados.</param>
        /// <returns>
        ///   <c>true</c> si se ha obtenido una Escalera; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool Escalera(List<int> dados)
        {
            bool esEscalera = false;
            if (dados[0] != dados[1] &&
                 dados[0] != dados[2] &&
                 dados[0] != dados[3] &&
                 dados[0] != dados[4])
            {
                if (dados[1] != dados[2] &&
                    dados[1] != dados[3] &&
                    dados[1] != dados[4])
                {
                    if (dados[2] != dados[3] &&
                        dados[2] != dados[4])
                    {
                        if (dados[3] != dados[4])
                        {
                            esEscalera = true;
                        }
                    }
                }

            }
            return esEscalera;
        }
        /// <summary>
        /// Verifica si se ha obtenido un Poker.
        /// </summary>
        /// <param name="mapeoDados">Un arreglo que representa el mapeo de los resultados obtenidos en los dados.</param>
        /// <returns>
        ///   <c>true</c> si se ha obtenido un Poker; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool Poker(int[] mapeoDados)
        {
            bool esPoker = false;

            for (int i = 0; i < 6; i++)
            {
                if (mapeoDados[i] == 4)
                {
                    esPoker = true;
                    break;
                }
            }

            return esPoker;
        }
        /// <summary>
        /// Verifica si se ha obtenido un Full.
        /// </summary>
        /// <param name="mapeoDados">Un arreglo que representa el mapeo de los resultados obtenidos en los dados.</param>
        /// <returns>
        ///   <c>true</c> si se ha obtenido un Full; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool Full(int[] mapeoDados)
        {
            bool esFull = false;
            bool flag1 = false;
            bool flag2 = false;

            for (int i = 0; i < 6; i++)
            {
                if (mapeoDados[i] == 3)
                {
                    flag1 = true;
                }
                else
                {
                    if (mapeoDados[i] == 2)
                    {
                        flag2 = true;
                    }
                }
            }
            if (flag1 == true && flag2 == true)
            {
                esFull = true;
            }
            return esFull;
        }
    }
}