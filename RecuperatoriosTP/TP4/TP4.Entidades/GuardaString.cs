using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TP4.Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto , string archivo)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivo + ".txt",true);
                streamWriter.Write(texto);
                streamWriter.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
