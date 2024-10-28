using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using proyectoIntegrador.Datos;

namespace proyectoIntegrador
{
    internal class Pago
    {
        private Cliente cliente; 

        public Pago(Cliente cliente)
        {
            this.cliente = cliente; 
        }

        public decimal BuscarTotalDeudas(int dni)
        {
            var (resultado, idSocio) = cliente.BuscarNroCliente(dni); 
            if (resultado == 0)
            {
                Console.WriteLine("No se encontró el cliente con el DNI proporcionado.");
                return 0; 
            }

            decimal totalDeuda = 0;

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();
                string query = @"SELECT SUM(monto) 
                                 FROM pago 
                                 WHERE id_socio = @id_socio AND pagada = 0"; 

                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@id_socio", idSocio);
                    var result = cmd.ExecuteScalar();

                    // Si el resultado no es nulo, convertimos a decimal
                    if (result != DBNull.Value)
                    {
                        totalDeuda = Convert.ToDecimal(result);
                    }
                }
            }

            return totalDeuda; 
        }

        // Método para obtener el listado de deudas por DNI
        public List<EPago> BuscarDeudas(int dni)
        {
            List<EPago> deudas = new List<EPago>();
            var (resultado, idSocio) = cliente.BuscarNroCliente(dni); 

            if (resultado == 0)
            {
                Console.WriteLine("No se encontró el cliente con el DNI proporcionado.");
                return deudas; // Retorna lista vacía
            }

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();
                string query = @"SELECT id_pago, id_socio, fecha_cuota, fecha_vencimiento, pagada, medio_pago, monto
                                 FROM pago
                                 WHERE id_socio = @id_socio AND pagada = 0";

                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@id_socio", idSocio);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EPago deuda = new EPago
                            {
                                Id_pago = reader.GetInt32(0),
                                Id_socio = reader.GetInt32(1),
                                Fecha_cuota = reader.GetDateTime(2),
                                Fecha_vencimiento = reader.GetDateTime(3),
                                Pagada = reader.GetBoolean(4),
                                Medio_pago = reader.IsDBNull(5) ? null : reader.GetString(5),
                                Monto = reader.GetDecimal(6) 
                            };
                            deudas.Add(deuda); 
                        }
                    }
                }
            }

            return deudas; 
        }
    }
}
