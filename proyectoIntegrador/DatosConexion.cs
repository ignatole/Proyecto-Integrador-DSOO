using proyectoIntegrador.Datos;

namespace proyectoIntegrador
{
    public partial class DatosConexion : Form
    {
        public DatosConexion()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Conexion conexion = Conexion.getInstancia();
            conexion.Servidor = txtHost.Text;
            conexion.BaseDatos = txtDb.Text;
            conexion.Usuario = txtUsuario.Text;
            conexion.Clave = txtPass.Text;
            conexion.Puerto = txtPuerto.Text;
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}