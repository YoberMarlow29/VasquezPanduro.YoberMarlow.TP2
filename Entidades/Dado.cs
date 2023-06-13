namespace Entidades
{
    public class Dado
    {
        private int numeroDeDado;

        public int NumeroDeDado { get => numeroDeDado; set => numeroDeDado = value; }

        public Dado() 
        {
            this.numeroDeDado=0;
        }

        public void LanzarDado(Random R)
        {
            this.numeroDeDado = R.Next(1, 7);
        }
        public static bool Generala(Dado[] dados)
        {
            bool esGenerala = false;
            int contador = 1;
            for (int i = 1; i < 5; i++)
            {
                if ((dados[i]).NumeroDeDado == (dados[0]).NumeroDeDado)
                {
                    contador++;
                }
            }
            if (contador == 5)
            {
                esGenerala = true;
            }
            return esGenerala;
        }
        public static bool Escalera(Dado[] dados)
        {
            bool esEscalera = false;
            if (dados[0].NumeroDeDado != dados[1].NumeroDeDado &&
                 dados[0].NumeroDeDado != dados[2].NumeroDeDado &&
                 dados[0].NumeroDeDado != dados[3].NumeroDeDado &&
                 dados[0].NumeroDeDado != dados[4].NumeroDeDado )
            {
                if (dados[1].NumeroDeDado != dados[2].NumeroDeDado &&
                    dados[1].NumeroDeDado != dados[3].NumeroDeDado &&
                    dados[1].NumeroDeDado != dados[4].NumeroDeDado )
                {
                    if (dados[2].NumeroDeDado != dados[3].NumeroDeDado &&
                        dados[2].NumeroDeDado != dados[4].NumeroDeDado )
                    {
                        if (dados[3].NumeroDeDado != dados[4].NumeroDeDado )
                        {
                            
                                esEscalera = true;
                            
                        }
                    }
                }

            }
            return esEscalera;
        }
        public static bool Poker(Dado[] dados)
        {
            bool esPoker = false;
            int[] numeros = new int[7];
            int i = 0;
            int poker = 0;
            int numero4 = 0;
            int posicion = 0;
            for (i = 0; i < dados.Length; i++)
            {
                if (dados[i].NumeroDeDado == 1)
                {
                    numeros[1]++;
                }
                if (dados[i].NumeroDeDado == 2)
                {
                    numeros[2]++;
                }
                if (dados[i].NumeroDeDado == 3)
                {
                    numeros[3]++;
                }
                if (dados[i].NumeroDeDado == 4)
                {
                    numeros[4]++;
                }
                if (dados[i].NumeroDeDado == 5)
                {
                    numeros[5]++;
                }
                if (dados[i].NumeroDeDado == 6)
                {
                    numeros[6]++;
                }
            }
            for (i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 4)
                {
                    poker++;
                    numero4 = i;
                }
            }
            for (i = 0; i < dados.Length; i++)
            {
                if (dados[i].NumeroDeDado != numero4)
                {
                    posicion = i;
                }
            }
            if (poker == 1)
            {
                esPoker = true;
            }
            return esPoker;
        }
        public static bool Full(Dado[] dados)
        {
            bool esFull = false;
            int[] numeros = new int[7];
            int i = 0;
            int numerocon3 = 0;
            int numerocon2 = 0;
            for (i = 0; i < dados.Length; i++)
            {
                if (dados[i].NumeroDeDado == 1)
                {
                    numeros[1]++;
                }
                if (dados[i].NumeroDeDado == 2)
                {
                    numeros[2]++;
                }
                if (dados[i].NumeroDeDado == 3)
                {
                    numeros[3]++;
                }
                if (dados[i].NumeroDeDado == 4)
                {
                    numeros[4]++;
                }
                if (dados[i].NumeroDeDado == 5)
                {
                    numeros[5]++;
                }
                if (dados[i].NumeroDeDado == 6)
                {
                    numeros[6]++;
                }
            }
            for (i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 3)
                {
                    numerocon3 = i;
                }
            }
            if (numerocon3 > 0)
            {
                for (i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == 2)
                    {
                        numerocon2 = i;
                    }
                }
            }
            if (numerocon3 > 0 && numerocon2 > 0)
            {
                esFull = true;
            }
            return esFull;
        }
        public static int VerificarPuntuacionNumero(Dado[] dados, int numero)
        {
            int contador = 0;
            for (int i = 0; i < dados.Length; i++)
            {
                if (dados[i].NumeroDeDado == numero)
                {
                    contador++;
                }
            }
            return contador;
        }

    }
}