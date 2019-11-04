using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        public int legajo;

        public Universitario() { }
        public Universitario(int legajo , string nombre, string apellido,string dni,ENacionalidad nacionalidad) { }

        protected virtual string MostrarDatos() { return ""; }
        protected abstract string ParticiparEnClase();

        public static bool operator != (Universitario pg1,Universitario pg2) { return false; }
        public static bool operator == (Universitario pg1 ,Universitario pg2) { return false; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}
