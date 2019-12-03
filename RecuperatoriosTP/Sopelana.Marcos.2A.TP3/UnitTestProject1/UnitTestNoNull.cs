using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;
using EntidadesAbstractas;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestNoNull
    {
        [TestMethod]
        public void TestNoNull()
        {
            Profesor profesor = new Profesor(2,"silvina","dprrego","27143234",Persona.ENacionalidad.Argentino);
            Assert.AreNotEqual(null, profesor);
        }
    }
}
