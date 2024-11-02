namespace proyectoIntegrador
{
    public partial class InscribirActividad : Form
    {
        public InscribirActividad()
        {
            InitializeComponent();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            int dniCliente = int.Parse(txtDNI.Text);

            Cliente clienteService = new();

            var (resultado, idCliente) = clienteService.BuscarNroCliente(dniCliente);

            if (resultado == 1)
            {
                int idActividad = (cmbActividades.SelectedItem as dynamic).Value;
                EActividad actividad = new()
                {
                    IdCliente = idCliente,
                    IdActividad = idActividad
                };
                Actividad actividadService = new();
                int result = actividadService.RegistrarActividad(actividad);
                switch (result)
                {
                    case 1:
                        MessageBox.Show("Inscripción realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetCampos();
                        break;
                    case 0:
                        MessageBox.Show("No hay suficientes créditos disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("No hay suficientes cupos disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Resultado desconocido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else
            {
                // Mensaje de error si no se encuentra el cliente
                MessageBox.Show("Cliente no encontrado. Verifique el número de documento.");
            }
        }
        private void ResetCampos()
        {
            txtDNI.Text = "";
            cmbActividades.SelectedIndex = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Home formPrevio = new Home();
            this.Close();
            formPrevio.Show();
        }
    }
}
