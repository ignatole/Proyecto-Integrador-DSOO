using MySql.Data.MySqlClient;

namespace proyectoIntegrador.Datos
{
    public class Conexion
    {
        // declaramos las variables
        private string? baseDatos;
        private string? servidor;
        private string? puerto;
        private string? usuario;
        private string? clave;
        private static Conexion? con = null;

        private Conexion() { }
        public string BaseDatos { set => baseDatos = value; }
        public string Servidor { set => servidor = value; }
        public string Puerto { set => puerto = value; }
        public string Usuario { set => usuario = value; }
        public string Clave { set => clave = value; }


        public MySqlConnection? CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new();
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                MessageBox.Show("Error:" + ex.Message); 
            }
            return cadena;
        }

        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con; 
        }
    }
}
