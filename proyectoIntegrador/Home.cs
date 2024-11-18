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

        private void btnInscribirCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new InscribirCliente());
        }

        private void btnInscribirActividades_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new InscribirActividad());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new PagarCuota());
        }

        private void btnListadoVencimientos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new ListadoVencimiento());
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            AbrirFormularioSecundario(new MostrarCarnet());
        }

        private void Home_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
