using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                alumnos = value;
            }
        }
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
    

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase , Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto() ;
            return texto.Guardar(@"C:\Users\sopelan1\Desktop\tp_laboratorio_2\Sopelana.Marcos.2A.TP3\2017-TP3-Archivos\archivo.txt", jornada.ToString());
        }

        public static string Leer()
        {
            Texto texto = new Texto();
            texto.Leer(@"C:\Users\sopelan1\Desktop\tp_laboratorio_2\Sopelana.Marcos.2A.TP3\2017-TP3-Archivos\Jornada.txt", out string text  );
            return text;
        }

        public static Jornada operator +(Jornada j,Alumno a)
        {
            bool flag = false;
            for (int i = 0; i < j.alumnos.Count;i++)
            {
                if (j.alumnos[i] == a)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
                j.alumnos.Add(a);
            

            return j;
        }
        public static bool operator !=(Jornada j , Alumno a)
        {
            return !(j == a);
        }
        public static bool operator ==(Jornada j, Alumno a)
        {
            return (a == j.Clase);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CLASE DE " + this.clase + " POR ");
            sb.AppendLine(this.instructor.ToString());
            sb.AppendLine("ALUMNOS:");
            foreach(Alumno a in this.alumnos)
            {
                sb.AppendLine(a.ToString());
            }
            sb.AppendLine("<------------------------------------------------>");
            return sb.ToString();
        }

    }
}
