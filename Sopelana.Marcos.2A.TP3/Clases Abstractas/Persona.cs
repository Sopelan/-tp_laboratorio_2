using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace EntidadesAbstractas
{
    public abstract class Persona 
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        private string apellido;
        private int dni;
        private ENacionalidad eNacionalidad;
        private string nombre;

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = ValidarNombreApellido(value);
            }
        }
        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                dni = ValidarDni(eNacionalidad,value);
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return eNacionalidad;
            }
            set
            {
                eNacionalidad = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = ValidarNombreApellido(value);
            }
        }
        public string StringToDNI
        {
            set
            {
                dni = ValidarDni(eNacionalidad,value);
            }
        }

        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.dni = 0;
        }
        public Persona(string nombre,string apellido,ENacionalidad nacionalidad):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        public Persona(string nombre,string apellido,int dni,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }
        public Persona(string nombre,string apellido,string dni,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }
        
        private int ValidarDni(ENacionalidad nacionalidad,int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino)
            {
                if(dato >=  1 && dato <= 89999999)
                {
                    if(dato >= 10000000)
                    {
                        return dato;
                    }
                    else
                    {
                        DniInvalidoException dniInvalidoException = new DniInvalidoException();
                        Console.WriteLine(dniInvalidoException.Message);
                    }
                }
                else
                {
                    NacionalidadInvalidaException nacionalidades = new NacionalidadInvalidaException();
                    Console.WriteLine(nacionalidades.Message);
                }
            }
            else
            {
                if(dato >= 90000000 && dato <= 99999999)
                {
                    return dato;
                }
                else
                {
                    NacionalidadInvalidaException nacionalidades = new NacionalidadInvalidaException();
                    Console.WriteLine(nacionalidades.Message);
                }
            }
            return 0;
        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            return ValidarDni(nacionalidad, Convert.ToInt32(dato));
        }
        private string ValidarNombreApellido(string dato)
        {
            foreach (char c in dato)
            {
                if (char.IsLetter(c))
                {
                }
                else
                    return "";
            }
            return dato;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE COMPLETO: "+ this.Apellido + ", " + this.Nombre);
            sb.AppendLine("NACIONALIDAD " + this.Nacionalidad);
            return sb.ToString();
        }

    }
}
