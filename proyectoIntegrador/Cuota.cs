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
    }
}
