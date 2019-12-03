using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Excepciones;
namespace Archivos
{
    public class Texto : IArchivo<string> 
    {
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(archivo);
                streamWriter.Write(datos);
                streamWriter.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Leer ( string archivo,out string datos)
        {
            try
            {
                StreamReader streamReader = new StreamReader(archivo);
                datos = streamReader.ReadToEnd();
                streamReader.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                datos = "";
                return false;
            }
        }
    }
}
