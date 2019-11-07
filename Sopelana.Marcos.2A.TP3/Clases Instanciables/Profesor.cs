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

        static Profesor()
        {
            random = new Random();
        }
        public Profesor() : base()
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            this._randowCLases();
        }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            this._randowCLases();
        }

        private void _randowCLases()
        {
            for (int i = 0; i < 2; i++)
            {
                int option = random.Next(1, 4);
                switch (option)
                {
                    case 1:
                        clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
                        break;
                    case 2:
                        clasesDelDia.Enqueue(Universidad.EClases.Legislacion);
                        break;
                    case 3:
                        clasesDelDia.Enqueue(Universidad.EClases.Programacion);
                        break;
                    case 4:
                        clasesDelDia.Enqueue(Universidad.EClases.SPD);
                        break;
                }
            }

        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(this.ParticiparEnClase());
            return sb.ToString();
        }
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA:");
            for (int i = 0; i < clasesDelDia.Count; i++)
            {
                sb.AppendLine(clasesDelDia.ElementAt(i).ToString());
            }
            return sb.ToString();
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases clases in i.clasesDelDia)
            {
                if (clases == clase)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }



    }
}
