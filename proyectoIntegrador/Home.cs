namespace proyectoIntegrador
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.FormClosing += Home_FormClosing;
        }
        private void AbrirFormularioSecundario(Form formularioSecundario)
        {
            formularioSecundario.Owner = this;
            formularioSecundario.Show();
            this.Hide();
        }

        // Evento para el botón "Inscribir Cliente"
        private void btnInscribirCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new InscribirCliente());
        }

        // Evento para el botón "Inscribir Actividades"
        private void btnInscribirActividades_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new InscribirActividad());
        }

        // Evento para el botón "Pagos"
        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new PagarCuota());
        }

        // Evento para el botón "Listado de Vencimientos"
        private void btnListadoVencimientos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new ListadoVencimiento());
        }

        // Evento para el botón "Carnet
        private void btnCarnet_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new MostrarCarnet());
        }

        // Evento para el botón "Salir"
        private void Home_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
