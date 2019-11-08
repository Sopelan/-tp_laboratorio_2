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
                XmlSerializer xml = new XmlSerializer(typeof(T));
                TextWriter streamWriter = new StreamWriter(archivo);
                xml.Serialize(streamWriter, datos);
                streamWriter.Close();
                return true;
            }

            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                TextReader textReader = new StreamReader(archivo);
                datos = (T)xml.Deserialize(textReader);
                Console.WriteLine(this.ToString());
                textReader.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
