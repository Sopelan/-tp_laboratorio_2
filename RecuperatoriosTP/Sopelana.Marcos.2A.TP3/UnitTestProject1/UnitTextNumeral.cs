using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;
using EntidadesAbstractas;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTextNumeral
    {
        [TestMethod]
        public void TestNumeral()
        {
            Alumno alumno = new Alumno(2, "marcos", "sopelana", "42942389", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
            Assert.AreEqual(42942389, alumno.DNI);
        }
    }
}
