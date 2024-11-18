using MySql.Data.MySqlClient;
using proyectoIntegrador.Datos;

namespace proyectoIntegrador
{
    public partial class DatosConexion : Form
    {
        public DatosConexion()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Conexion conexion = Conexion.getInstancia();
            conexion.Servidor = txtHost.Text;
            conexion.BaseDatos = txtDb.Text;
            conexion.Usuario = txtUsuario.Text;
            conexion.Clave = txtPass.Text;
            conexion.Puerto = txtPuerto.Text;
            if (PruebaDeConexion(conexion))
            {
                Login login = new();
                login.Show();
                this.Hide();
            }
        }
        private bool PruebaDeConexion(Conexion conexion)
        {
            MySqlConnection? sqlCon = new();
            try
            {
                sqlCon = conexion.CrearConexion();
                sqlCon.Open();
                MessageBox.Show("Conexión exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible crear la conexion, revise los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}