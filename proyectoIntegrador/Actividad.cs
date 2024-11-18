using MySql.Data.MySqlClient;
using proyectoIntegrador.Datos;
using System.Data;

namespace proyectoIntegrador
{
    internal class Actividad
    {
        public int RegistrarActividad(EActividad actividad)
        {
            int resultado;
            using (MySqlConnection? sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    using (MySqlCommand command = new MySqlCommand("RegistrarActividad", sqlCon))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("c_id_cliente", actividad.IdCliente);
                        command.Parameters.AddWithValue("c_id_actividad", actividad.IdActividad);
                        MySqlParameter rtaParam = new MySqlParameter("@rta", MySqlDbType.Int32);
                        rtaParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(rtaParam);
                        command.ExecuteNonQuery();
                        resultado = Convert.ToInt32(rtaParam.Value);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar cuota: " + ex.Message);
                    resultado = 3;
                }
            }
            return resultado;
        }
    }
}
