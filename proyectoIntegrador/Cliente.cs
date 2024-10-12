using MySql.Data.MySqlClient;
using proyectoIntegrador.Datos;
using System;
using System.Data;

namespace proyectoIntegrador
{
    internal class Cliente
    {
        // Método para insertar un cliente
        public (int resultado, int idCliente) InsertarCliente(ECliente cliente)
        {
            int resultado;
            int id_cliente = 0; // Variable para almacenar el ID del cliente insertado

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
                        comando.Parameters.AddWithValue("@FecNac", cliente.FechaNac);
                        comando.Parameters.AddWithValue("@Sexo", cliente.Sexo);

                        // Parámetro de salida
                        MySqlParameter rtaParam = new MySqlParameter("@rta", MySqlDbType.Int32);
                        rtaParam.Direction = ParameterDirection.Output;
                        comando.Parameters.Add(rtaParam);

                        // Ejecutamos el comando
                        comando.ExecuteNonQuery();

                        // Obtenemos el valor del parámetro de salida
                        resultado = Convert.ToInt32(rtaParam.Value);
                    }

                    // Si la inserción fue exitosa, obtenemos el nuevo ID
                    if (resultado == 1)
                    {
                        // Comando para obtener el último ID insertado
                        using (MySqlCommand getIdCommand = new MySqlCommand("SELECT LAST_INSERT_ID();", sqlCon))
                        {
                            id_cliente = Convert.ToInt32(getIdCommand.ExecuteScalar());
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores (opcional)
                    Console.WriteLine("Error: " + ex.Message);
                    resultado = 0; // Un valor que indique un error
                }
            }

            return (resultado, id_cliente); // Retorna el resultado y el ID del cliente
        }
    }
}
