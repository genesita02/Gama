using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private string Base;
            private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion cn = null;


        private Conexion() 
        {
            this.Base ="ferreteria_2";
            this.Servidor = "CHERRYY-E5440";
            this.Usuario ="";
            this.Clave ="";
        }
        public SqlConnection creaConexion()
        {
            SqlConnection cadena = new SqlConnection();

            try
            {
                cadena.ConnectionString = "Sever="+this.Servidor+";Database="+ this.Base+
                    ";User Id ="+this.Usuario+";password="+this.Clave;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }
        public static Conexion getInstancia()
        {
            if (cn == null)
            {
                cn =  new Conexion();
            }
            return cn;
        }
    }

}
