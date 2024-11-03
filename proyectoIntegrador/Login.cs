using proyectoIntegrador.Datos; // Asegurate de incluir esta linea

namespace proyectoIntegrador
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            picLogin.Image = Image.FromFile(@"..\..\..\resources\ImagenFormLogin.png");
            this.KeyPreview = true; // Permite que el formulario capture los eventos de tecla
            this.KeyPress += new KeyPressEventHandler(Login_KeyPress);
        }

        // Evento para manejar el clic en el boton de inicio de sesion
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Obtener valores de los campos de texto
            string usuario = txtUsuario.Text;
            string contrasena = txtContra.Text;

            // Crear una instancia de la clase Usuario
            Usuario usuarioDatos = new Usuario();

            // Llamar a la funci�n que valida las credenciales
            int resultadoLogin = usuarioDatos.Log_Usu(usuario, contrasena);

            if (resultadoLogin == 1) // Suponiendo que 1 significa exito
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                // Redirigir al HomeForm
                Home homeForm = new Home();
                homeForm.Show(); // O homeForm.ShowDialog(); si deseas que sea modal

                this.Hide(); // Oculta el LoginForm, opcional
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();

            }
        }

        private void chkMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = !chkMostrarContra.Checked;
        }
    }
}
