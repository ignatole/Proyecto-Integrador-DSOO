using System;
using System.Windows.Forms;
using proyectoIntegrador.Datos; // Asegúrate de incluir esta línea

namespace proyectoIntegrador
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Evento para manejar el clic en el botón de inicio de sesión
        private void Button1_Click(object sender, EventArgs e)
        {
            // Obtener valores de los campos de texto
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            // Crear una instancia de la clase Usuario
            Usuario usuarioDatos = new Usuario();

            // Llamar a la función que valida las credenciales
            int resultadoLogin = usuarioDatos.Log_Usu(usuario, contraseña);

            if (resultadoLogin == 1) // Suponiendo que 1 significa éxito
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                // Aquí puedes redirigir a la siguiente ventana o realizar otras acciones
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
