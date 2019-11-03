using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Alumno
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public Alumno() { }
    }
}
