using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 
using proyectoIntegrador.Datos;

namespace proyectoIntegrador
{
    internal class Cuota
    {
        public void RegistrarCuota(ECuota cuota)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    using (MySqlCommand command = new MySqlCommand("RegistrarCuota", sqlCon))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("c_id_cliente", cuota.IdCliente);
                        command.Parameters.AddWithValue("c_fecha_pago", cuota.FechaPago);
                        command.Parameters.AddWithValue("c_medio_pago", cuota.MedioPago);
                        command.Parameters.AddWithValue("c_monto", cuota.Monto);
                        command.Parameters.AddWithValue("c_tipo_cuota", cuota.TipoCuota ? 1 : 0);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar cuota: " + ex.Message);
                }
            }
        }
        public List<(int IdCliente, string NombreCompleto, int Dni, string FechaVencimiento)> ObtenerCuotasVencidas()
        {
            List<(int IdCliente, string NombreCompleto, int Dni, string FechaVencimiento)> cuotasVencidas = new List<(int, string, int, string)>();

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM listado_de_vencimientos ORDER BY `Nro de socio` ASC", sqlCon))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var cuota = (
                                    IdCliente: reader.GetInt32("Nro de socio"),
                                    NombreCompleto: reader.GetString("Nombre completo"),
                                    Dni: reader.GetInt32("dni"),
                                    FechaVencimiento: reader.GetString("Fecha de Vencimiento")
                                );
                                cuotasVencidas.Add(cuota);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener cuotas vencidas: " + ex.Message);
                }
            }

            return cuotasVencidas;
        }
    }
}
