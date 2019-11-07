using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public class Universidad
    {
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }
        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada[i] = value; 
            }
        }

        public Universidad() { }

        public static bool Guardar(Universidad uni) { return false; }
        public Universidad Leer() { Universidad uni = new Universidad(); return uni; }
        private static string MostrarDatos(Universidad uni) { return ""; }

        public static Universidad operator +(Universidad g,EClases clases) { return g; }
        public static Universidad operator +(Universidad u,Alumno a) { return u; }
        public static Universidad operator +(Universidad u,Profesor i) { return u; }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach(Alumno j in g.alumnos)
            {
                if( j == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i); 
        }
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Jornada j in g.jornada)
            {
                if (j.Instructor == i)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Universidad u, EClases clases) { return false; }
        public static bool operator ==(Universidad u, EClases clases) { return false; }
        public override string ToString(){return ""; }


    }
}
