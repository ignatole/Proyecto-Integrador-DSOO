using proyectoIntegrador.Datos; 

namespace proyectoIntegrador
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            picLogin.Image = Image.FromFile(@"..\..\..\resources\ImagenFormLogin.png");
            this.KeyPreview = true; 
            this.KeyPress += new KeyPressEventHandler(Login_KeyPress);
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContra.Text;

            Usuario usuarioDatos = new();

            int resultadoLogin = usuarioDatos.Log_Usu(usuario, contrasena);

            if (resultadoLogin == 1)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                Home homeForm = new Home();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void Login_KeyPress(object? sender, KeyPressEventArgs e)
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

        private void Login_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
