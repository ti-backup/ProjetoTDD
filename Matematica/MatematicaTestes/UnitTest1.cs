using Matematica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
