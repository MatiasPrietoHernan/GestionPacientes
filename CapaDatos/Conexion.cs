using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GestionPacientes.CapaDatos
{
    internal class Conexion : IDisposable
    {
        private SQLiteConnection Connection;
        private readonly string conexion = "Data Source=gestionpacientes.db;Version=3;";


        public Conexion()
        {
            Connection = new SQLiteConnection(conexion);
        }

        public void Open()
        {
            if(Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();
                Console.WriteLine("Conexion abierta como tu cola");
            }
        }

        public void Close()
        {
            if(Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
                Console.WriteLine("Conexion cerrada como ella");
            }
        }

        public void Dispose()
        {
            Close();
            Connection.Dispose();
        }

        public SQLiteConnection ObtenerConexion()
        {
            return Connection;
        }

    }
}
