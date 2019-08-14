using Matematica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatematicaTestes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RaizQuadradaBasicaTeste()
        {
            Raiz r = new Raiz();
            double esperado = 2.0;
            double entrada = esperado * esperado;
            double resultadoReal = r.RaizQuadrada(entrada);

            Assert.AreEqual(esperado, resultadoReal, esperado / 100);
        }

        [TestMethod]
        public void RaizQuadradaBasicaTeste02()
        {
            Raiz r = new Raiz();
            double esperado = 3.0;
            double entrada = esperado * esperado;
            double resultadoReal = r.RaizQuadrada(entrada);

            Assert.AreEqual(esperado, resultadoReal, esperado / 100);
        }

        [TestMethod]
        public void RaizQuadraNumeroMenorQueZero()
        {
            Raiz r = new Raiz();
            double entrada = -9.0;

            try
            {
                r.RaizQuadrada(entrada);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Raiz.msgErroRaizValorNegativo);
                return;
            }
            Assert.Fail("O método não lançou a exceção esperada.");
        }

        [TestMethod]
        public void MediaAritmetica()
        {
            Media m = new Media();
            double esperado = 5.0;
            double[] entrada = {5.0, 4.0, 6.0 };
            double mediaReal = m.mediaAritmetica(entrada);

            Assert.AreEqual(esperado, mediaReal, delta: 0.1);
        }

        [TestMethod]
        public void MediaAritmeticaVetorVazio()
        {
            Media m = new Media();
            double esperado = 0.0;
            double[] entrada = new double[6];
            double mediaReal = m.mediaAritmetica(entrada);

            Assert.AreEqual(esperado, mediaReal, 0.1);
        }
    }
}
