using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP4.Entidades;
namespace TP4.TestUnitarios
{
    [TestClass]
    public class TestClassMismaTrackingID
    {
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void TestMethodMismaTrackingID()
        {
            Correo correo = new Correo();
            Paquete paquete = new Paquete("dasd", "23123");
            Paquete paquete2 = new Paquete("saddsda", "23123");
            correo += paquete;
            correo += paquete2;
            Assert.Fail();
        }
    }
}
