using MySql.Data.MySqlClient;
using proyectoIntegrador.Datos;
using System;
using System.Data;

namespace proyectoIntegrador
{
    internal class Cliente
    {
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
                        comando.Parameters.AddWithValue("@AptoFisico", cliente.AptoFisico ? 1 : 0);

                        // Parámetro de salida
                        MySqlParameter rtaParam = new MySqlParameter("@rta", MySqlDbType.Int32);
                        rtaParam.Direction = ParameterDirection.Output;
                        comando.Parameters.Add(rtaParam);

                        // Ejecutamos el comando
                        comando.ExecuteNonQuery();

                        // Obtenemos el valor del parámetro de salida
                        resultado = Convert.ToInt32(rtaParam.Value);
                    }

                    if (resultado == 1)
                    {
                        using (MySqlCommand getIdCommand = new MySqlCommand("SELECT LAST_INSERT_ID();", sqlCon))
                        {
                            id_cliente = Convert.ToInt32(getIdCommand.ExecuteScalar());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    resultado = 0;
                }
            }

            return (resultado, id_cliente);
        }

        // Método para buscar el número de cliente por DNI
        public (int resultado, int idCliente) BuscarNroCliente(int dni)
        {
            int resultado = 0;
            int id_cliente = 0;

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open(); 

                    using (MySqlCommand comando = new MySqlCommand("SELECT id_cliente FROM cliente WHERE dni = @Dni", sqlCon))
                    {
                        comando.Parameters.AddWithValue("@Dni", dni);
                        var id = comando.ExecuteScalar(); 

                        if (id != null)
                        {
                            id_cliente = Convert.ToInt32(id);
                            resultado = 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    resultado = 0; 
                }
            }

            return (resultado, id_cliente); 
        }
    }
}
