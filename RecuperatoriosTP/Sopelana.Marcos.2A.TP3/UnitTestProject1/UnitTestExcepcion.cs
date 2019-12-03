using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Instanciables;
using EntidadesAbstractas;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestExcepcion
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniInvalidoException()
        {
            Alumno alumno = new Alumno(2, "marcos", "sopelana", "asddsadadasdsa", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalidaException()
        {
            Alumno alumno = new Alumno(2, "marcos", "sopelana", "90000009", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
            Assert.Fail();
        }

    }
}
