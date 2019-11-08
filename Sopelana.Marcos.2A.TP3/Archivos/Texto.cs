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
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    writer.WriteLine(datos);
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        public bool Leer ( string archivo,out string datos)
        {
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    datos = "";
                    datos = reader.ReadToEnd();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
