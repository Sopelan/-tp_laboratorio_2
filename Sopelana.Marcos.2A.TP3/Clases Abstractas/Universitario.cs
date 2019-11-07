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

        public Universitario():base()
        {
            legajo = 0;
        }
        public Universitario(int legajo , string nombre, string apellido,string dni,ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendLine("LEGAJO NUMERO: " + legajo);
            return sb.ToString();
        }
        protected abstract string ParticiparEnClase();

        public static bool operator != (Universitario pg1,Universitario pg2)
        {
            return !(pg1 == pg2); ;
        }
        public static bool operator == (Universitario pg1 ,Universitario pg2)
        {
            return (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI);// falta algo
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}
