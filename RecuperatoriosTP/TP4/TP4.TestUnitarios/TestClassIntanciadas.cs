using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP4.Entidades;
namespace TP4.TestUnitarios
{
    [TestClass]
    public class TestClassIntanciadas
    {
        [TestMethod]
        public void TestMethodIntanciada()
        {
            Correo correo = new Correo();
            Assert.AreNotEqual(null, correo.Paquetes);
        }
    }
}
