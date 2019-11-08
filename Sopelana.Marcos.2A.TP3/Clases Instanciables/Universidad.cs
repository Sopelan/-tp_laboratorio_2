using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
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

        public Universidad()
        {
            alumnos = new List<Alumno>();
            profesores = new List<Profesor>();
            jornada = new List<Jornada>();
        }

        public static bool Guardar(Universidad uni)
        { 
            Xml<Universidad> guardar = new Xml<Universidad>();
            return  guardar.Guardar(@"C:\Users\sopelan1\Desktop\tp_laboratorio_2\Sopelana.Marcos.2A.TP3\2017-TP3-Archivos\archivos.xml", uni);
        }
        public static Universidad Leer()
        {
            Xml<Universidad> leer = new Xml<Universidad>();
            leer.Leer(@"C:\Users\sopelan1\Desktop\tp_laboratorio_2\Sopelana.Marcos.2A.TP3\2017-TP3-Archivos\Universidad.xml", out Universidad universidad);
            return universidad;
        }
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");
            foreach (Jornada j in uni.jornada)
            {
                sb.AppendLine(j.ToString());
            }
            return sb.ToString();
        }

        public static Universidad operator +(Universidad g,EClases clases)
        {
            Profesor profesor = g == clases;
            Jornada jornada = new Jornada(clases, profesor);
            foreach(Alumno a in g.alumnos)
            {
                if(jornada == a )
                {
                    jornada += a;
                }
            }
            if (!object.Equals(jornada.Instructor, null))
             g.jornada.Add(jornada);
            return g;
        }
        public static Universidad operator +(Universidad u,Alumno a)
        {
            if (u != a)
                u.alumnos.Add(a);
            else
            {
                throw new AlumnoRepetidoException();
            }
            return u;
        }
        public static Universidad operator +(Universidad u,Profesor i)
        {
            if (u != i)
                u.profesores.Add(i);
            return u;
        }
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
        public static Profesor operator !=(Universidad u, EClases clases)
        {
            foreach (Profesor profesor in u.profesores)
            {
                if (profesor != clases)
                    return profesor;
            }
            return null;
        }
        public static Profesor operator ==(Universidad u, EClases clases)
        {
            foreach (Profesor profesor in u.profesores)
            {
                if (profesor == clases)
                    return profesor;
                    
            }
            throw new SinProfesorException();
        }
        public override string ToString()
        {
            return MostrarDatos(this);
        }


    }
}
