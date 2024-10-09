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
            // Aquí puedes agregar el código para inscribir un cliente
            MessageBox.Show("Inscribir Cliente");
        }

        // Evento para el botón "Inscribir Actividades"
        private void btnInscribirActividades_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar el código para inscribir actividades
            MessageBox.Show("Inscribir Actividades");
        }

        // Evento para el botón "Pagos"
        private void btnPagos_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar el código para realizar pagos
            MessageBox.Show("Pagos");
        }

        // Evento para el botón "Listado de Vencimientos"
        private void btnListadoVencimientos_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar el código para mostrar el listado de vencimientos
            MessageBox.Show("Listado de Vencimientos");
        }

        // Evento para el botón "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar el código para salir de la aplicación
            this.Close();
        }
    }
}
