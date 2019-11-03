using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Universitario : Persona
    {
        public int legajo;

        public Universitario() { }
        public Universitario(int legajo , string nombre, string apellido,string dni,ENacionalidad nacionalidad) { }

        private string MostrarDatos() { return ""; }
        private string ParticiparEnClase() { return ""; }

        public static bool operator != (Universitario pg1,Universitario pg2) { return false; }
        public static bool operator == (Universitario pg1 ,Universitario pg2) { return false; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}
