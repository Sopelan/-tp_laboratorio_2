using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace TP4.Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        static PaqueteDAO()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection(Properties.Settings.Default.conexion);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }
        public static bool Insertar(Paquete p)
        {
            string comando = string.Format("INSERT INTO Paquetes (direccionEntrega,trackingID,alumno)" + " VALUES ('{0}','{1}','Sopelana Marcos')", p.DireccionEntrega, p.TrackingID);
            PaqueteDAO.comando.CommandText = comando;
            conexion.Open();
            PaqueteDAO.comando.ExecuteNonQuery();
            conexion.Close();
            return true;
        }
    }
}
