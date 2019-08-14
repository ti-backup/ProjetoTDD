using System;

namespace Matematica
{
    public class Class1
    {
    }

    public class Raiz
    {
        public const string msgErroRaizValorNegativo = "Não existe solução no conjunto dos Reais.";

        public double RaizQuadrada(double entrada)
        {
            if (entrada < 0)
                throw new ArgumentOutOfRangeException("entrada", entrada, msgErroRaizValorNegativo);

            return Math.Pow(entrada, (1.0/2.0));
        }
    }

    public class Media
    {
        public double mediaAritmetica(double[] entrada)
        {
            double soma = 0;

            for (int i = 0; i < entrada.Length; i++)
            {
                soma += entrada[i];
            }

            return soma / entrada.Length;
        }
    }
}
