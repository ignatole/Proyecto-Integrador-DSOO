﻿using MySql.Data.MySqlClient;
using System.Data;

namespace proyectoIntegrador.Datos
{
    internal class Usuario
    {
        public int Log_Usu(string L_Usu, string P_Usu)
        {
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            int loginResultado = 0; // Variable para almacenar el resultado del login

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };

                // Agregar parámetros
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;

                // Crear un parámetro de salida para recibir el resultado del login
                MySqlParameter paramResultado = new MySqlParameter
                {
                    ParameterName = "@resultado",
                    MySqlDbType = MySqlDbType.Int32,
                    Direction = ParameterDirection.Output
                };
                comando.Parameters.Add(paramResultado);

                sqlCon.Open();
                comando.ExecuteNonQuery();

                // Obtener el resultado del login
                loginResultado = Convert.ToInt32(paramResultado.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return loginResultado; // Devolver el resultado del login
        }
    }
}
