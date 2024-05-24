using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class DCategoria
    {
        public string Listar_cat (string valor)
        {
            SqlDataReader resultado;
            DataTable tabla= new DataTable();
            SqlConnection con = Conexion.getInstancia().creaConexion();

            try
            {
                con=Conexion.getInstancia().creaConexion ();
                SqlCommand cmd = new SqlCommand("sp_Listar_cat", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@texto", sqlDbType.NVarChar).Value = valor;
                con.Open();
                resultado=cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

            }
            catch (Exception ex)
            {

                con=null;
                throw ex;
            }
            finally
            { 
                
            }
        }
    }
}
