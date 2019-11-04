using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        static Profesor () { }
        public Profesor () { }
        public Profesor (int id , string nombre,string apellido,string dni,ENacionalidad nacionalidad) { }

        private void _randowCLases() {  }
        protected override string MostrarDatos() { return ""; }
        protected override string ParticiparEnClase() { return ""; }

        public static bool operator !=(Profesor i,Universidad.EClases clase) { return false; }
        public static bool operator ==(Profesor i,Universidad.EClases clase) { return false; }

        public override string ToString(){ return ""; }

    }
}
