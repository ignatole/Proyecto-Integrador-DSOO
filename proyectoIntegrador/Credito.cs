using MySql.Data.MySqlClient;
using proyectoIntegrador.Datos;

namespace proyectoIntegrador
{
    internal class Credito
    {
        public void CargarCreditos(ECredito credito)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    using (MySqlCommand command = new MySqlCommand("ComprarCreditos", sqlCon))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("c_id_cliente", credito.IdCliente);
                        command.Parameters.AddWithValue("cantidad", credito.CantCreditos);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar compra de credito: " + ex.Message);
                }
            }
        }
    }
}
