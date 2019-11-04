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

        public List<Alumno> Alumnos { get; set; }
        public List<Profesor> Instructores { get; set; }
        public List<Jornada> Jornadas { get; set; }
        public Jornada this[int i] { get { Jornada jornada = new Jornada(EClases.SPD,new Profesor()) ; return jornada; } set { } }

        public Universidad() { }

        public static bool Guardar(Universidad uni) { return false; }
        public Universidad Leer() { Universidad uni = new Universidad(); return uni; }
        private static string MostrarDatos(Universidad uni) { return ""; }

        public static Universidad operator +(Universidad g,EClases clases) { return g; }
        public static Universidad operator +(Universidad u,Alumno a) { return u; }
        public static Universidad operator +(Universidad u,Profesor i) { return u; }
        public static bool operator !=(Universidad g, Alumno a) { return false; }
        public static bool operator ==(Universidad g, Alumno a) { return false; }
        public static bool operator !=(Universidad g, Profesor i) { return false; }
        public static bool operator ==(Universidad g, Profesor i) { return false; }
        public static bool operator !=(Universidad u, EClases clases) { return false; }
        public static bool operator ==(Universidad u, EClases clases) { return false; }
        public override string ToString(){return ""; }


    }
}
