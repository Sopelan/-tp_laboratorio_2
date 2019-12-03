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
    public class Xml<T> : IArchivo<T> where T : class
    {
        public bool Guardar(string archivo, T datos)
        {
          try
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(new StreamWriter(archivo));
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(xmlTextWriter , datos);
                xmlTextWriter.Close();
                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlTextReader xmlTextReader = new XmlTextReader(archivo);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                datos = (T)xmlSerializer.Deserialize(xmlTextReader);
                xmlTextReader.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                datos = default;
                return false;
            }
        }
    }
}
