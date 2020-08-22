using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeroLetra.Controllers;

namespace UnitTestNumeroaLetra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            LiteralController test = new LiteralController();
            int numero = 6;
            string esperado = "SEIS 0/100";

            //Act
            string resultado = test.Literalget(numero);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
