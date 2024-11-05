using MySql.Data.MySqlClient;
using proyectoIntegrador.Datos;
using proyectoIntegrador.Transacciones;
using System.Data;


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
                        command.Parameters.AddWithValue("c_plazo_cuota", cuota.PlazoCuota);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar cuota: " + ex.Message);
                }
            }
        }
        public DataTable RecuperarDatosCuota(int idPago)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();

            try
            {
                conexion.Open();
                string query = @"SELECT CONCAT(cl.nombre, ' ', cl.apellido) AS 'Nombre Completo',
                                    c.Monto, c.fecha_Pago, c.medio_pago, c.tipo_cuota, c.id_pago                                    
                                    FROM  cuota c
                                    JOIN cliente cl ON cl.id_cliente = c.id_cliente
                                    WHERE c.id_pago = LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_pago", idPago); // Asignar el valor del parámetro

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable); // Rellenar el DataTable con los resultados
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se encontraron datos, este catch es de cuotas " + ex.Message);
            }


            return dataTable; // Devolver el DataTable
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
