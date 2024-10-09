using MySql.Data.MySqlClient;
using proyectoIntegrador.Datos;
using System;
using System.Data;

namespace proyectoIntegrador
{
    internal class Cliente
    {
        // Método para insertar un cliente
        public int InsertarCliente(E_Cliente cliente)
        {
            int resultado;

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open(); // Abrimos la conexión

                    using (MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        // Añadimos los parámetros del procedimiento
                        comando.Parameters.AddWithValue("@Nom", cliente.Nombre);
                        comando.Parameters.AddWithValue("@Ape", cliente.Apellido);
                        comando.Parameters.AddWithValue("@Doc", cliente.Dni);
                        comando.Parameters.AddWithValue("@Email", cliente.Email);
                        comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);

                        // Parámetro de salida
                        MySqlParameter rtaParam = new MySqlParameter("@rta", MySqlDbType.Int32);
                        rtaParam.Direction = ParameterDirection.Output;
                        comando.Parameters.Add(rtaParam);

                        // Ejecutamos el comando
                        comando.ExecuteNonQuery();

                        // Obtenemos el valor del parámetro de salida
                        resultado = Convert.ToInt32(rtaParam.Value);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores (opcional)
                    Console.WriteLine("Error: " + ex.Message);
                    resultado = -1; // Un valor que indique un error
                }
            }

            return resultado; // Retorna 1 si la inserción fue exitosa, 0 si no
        }
    }
}
