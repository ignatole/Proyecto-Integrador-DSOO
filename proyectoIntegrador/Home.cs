using System;
using System.Windows.Forms;

namespace proyectoIntegrador
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // Evento para el botón "Inscribir Cliente"
        private void btnInscribirCliente_Click(object sender, EventArgs e)
        {
            InscribirCliente nuevoFormulario = new InscribirCliente();
            nuevoFormulario.Show();
            this.Close();
        }

        // Evento para el botón "Inscribir Actividades"
        private void btnInscribirActividades_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario en desarrollo, estamos trabajando para usted.");
        }

        // Evento para el botón "Pagos"
        private void btnPagos_Click(object sender, EventArgs e)
        {
            PagarCuota nuevoFormulario = new PagarCuota();
            nuevoFormulario.Show();
            this.Close();
        }

        // Evento para el botón "Listado de Vencimientos"
        private void btnListadoVencimientos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario en desarrollo, estamos trabajando para usted.");
        }

        // Evento para el botón "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
