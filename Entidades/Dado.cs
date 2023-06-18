namespace Entidades
{
    public class Dado
    {
        private int numero;
        private Random random;
        public Dado()
        {
            this.numero = 0;
            this.random = new Random();
        }
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public void Lanzar()
        {
            this.numero = random.Next(1, 7);
        }
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
        public static int VerificarPuntuacionNumero(List<int> dados, int numero)
        {
            int contador = 0;
            for (int i = 0; i < dados.Count; i++)
            {
                if (dados[i] == numero)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}