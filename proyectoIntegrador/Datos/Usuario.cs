using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace proyectoIntegrador.Datos
{
    internal class Usuario
    {
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); 
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;

                
                sqlCon.Open();
                resultado = comando.ExecuteReader(); 
                tabla.Load(resultado); 
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el login: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
