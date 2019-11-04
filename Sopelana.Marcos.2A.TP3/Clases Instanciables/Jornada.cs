using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        List<Alumno> Alumnos { get; set; }
        Universidad.EClases Clase { get; set; }
        Profesor Instructor { get; set; }

        private Jornada() { }
        public Jornada(Universidad.EClases clase , Profesor instructor) { }

        public static bool Guardar(Jornada jornada) { return false; }
        public string Leer() { return ""; }

        public static Jornada operator +(Jornada j,Alumno a) { return j; }
        public static bool operator !=(Jornada j , Alumno a) { return false; }
        public static bool operator ==(Jornada j, Alumno a) { return false; }

        public override string ToString() {return "";}

    }
}
