using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public Alumno() { }
        public Alumno(int id , string nombre , string apellido ,string dni , ENacionalidad nacionalidad ,Universidad.EClases claseQueToma) { }
        public Alumno(int id, string nombre,string apellido,string dni , ENacionalidad nacionalidad , Universidad.EClases claseQueToma,EEstadoCuenta estadoCuenta) { }

        protected override string MostrarDatos() { return ""; }
        protected override string ParticiparEnClase() { return ""; }

        public static bool operator != (Alumno a , Universidad.EClases clase) { return false; }
        public static bool operator == (Alumno a , Universidad.EClases clase) { return false; }

        public override string ToString(){return "";}

    }
}
