using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace GestionPacientes.CapaDatos
{
    internal class LoginDatos
    {
        private readonly Conexion conexion;

        public LoginDatos()
        {
            conexion = new Conexion();
        }

       
    }
}
