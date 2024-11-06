using proyectoIntegrador.Transacciones;

namespace proyectoIntegrador
{
    public partial class PagarCuota : Form
    {
        private int _idPago;
        public PagarCuota()
        {
            InitializeComponent();
            rbtnCuotaActividad.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbtnCuotaMensual.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            nudCantAct.Visible = false;
            nudCantAct.Minimum = 0;
            nudCantAct.ValueChanged += new EventHandler(NudCantAct_ValueChanged);
            cmbCantidadCuotas.Visible = false;
            rbtnTarjeta.CheckedChanged += new EventHandler(RadioButtonTarjeta_CheckedChanged);
            //btnComprobante.Enabled = false;
        }
        private void NudCantAct_ValueChanged(object? sender, EventArgs e)
        {
            txtboxMonto.Text = (nudCantAct.Value * 1000).ToString();
        }
        private void btnVerDeuda_Click(object sender, EventArgs e)
        {
            Deuda verDeudaForm = new Deuda();
            verDeudaForm.ShowDialog();
        }
        private void RadioButtonTarjeta_CheckedChanged(object? sender, EventArgs e) {
            if (rbtnTarjeta.Checked)
            {
                cmbCantidadCuotas.Visible = true;
            }
            else
            {
                cmbCantidadCuotas.Visible = false;
            }
        }
        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbtnCuotaActividad.Checked)
            {
                nudCantAct.Visible = true;
                txtboxMonto.ReadOnly = true;
                txtboxMonto.Text = (nudCantAct.Value * 1000).ToString();
            }
            else
            {
                nudCantAct.Visible = false;
                txtboxMonto.ReadOnly = false;
                txtboxMonto.Clear();
            }
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            int dniCliente = int.Parse(txtNroCliente.Text);

            Cliente clienteService = new();

            var (resultado, idCliente) = clienteService.BuscarNroCliente(dniCliente);

            if (resultado == 1)
            {
                if (rbtnCuotaActividad.Checked && nudCantAct.Value == 0)
                {
                    MessageBox.Show("Debe registrar el pago de al menos un crédito");
                    return;
                }
                if (string.IsNullOrEmpty(txtboxMonto.Text))
                {
                    MessageBox.Show("Debe ingresar un monto");
                    return;
                }
                if (!rbtnEfectivo.Checked && !rbtnTarjeta.Checked)
                {
                    MessageBox.Show("Debe seleccionar un medio de pago");
                    return;
                }
                if (rbtnCuotaActividad.Checked)
                {
                    ECredito credito = new()
                    {
                        IdCliente = idCliente,
                        CantCreditos = (int)nudCantAct.Value
                    };
                    Credito creditoService = new();
                    creditoService.CargarCreditos(credito);
                }
                decimal monto = decimal.Parse(txtboxMonto.Text);
                string medioPago = rbtnEfectivo.Checked ? "Efectivo" : "Tarjeta";
                bool tipoCuota = rbtnCuotaMensual.Checked;
                int plazoCuota = int.Parse(cmbCantidadCuotas.Text);

                ECuota cuota = new()
                {
                    IdCliente = idCliente,
                    FechaPago = DateTime.Now,
                    MedioPago = medioPago,
                    Monto = monto,
                    TipoCuota = tipoCuota,
                    PlazoCuota = plazoCuota
                };

                Cuota cuotaService = new Cuota();

                cuotaService.RegistrarCuota(cuota);

                MessageBox.Show("Pago registrado exitosamente.");
            }
            else
            {
                // Mensaje de error si no se encuentra el cliente
                MessageBox.Show("Cliente no encontrado. Verifique el número de documento.");
            }

            ResetCampos();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            // solo dar acceso al boton si el pago se realizo 

            //abre el comprobante con los datos del pago actual
            Comprobante comprobante = new Comprobante(_idPago);
            comprobante.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Home formPrevio = new Home();
            this.Close();
            formPrevio.Show();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtNroCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click_1(object sender, EventArgs e)
        {

        }
        private void ResetCampos()
        {
            txtNroCliente.Text = string.Empty;
            txtboxMonto.Text = string.Empty;
            rbtnEfectivo.Checked = false;
            rbtnTarjeta.Checked = false;
            rbtnCuotaMensual.Checked = false;
            rbtnCuotaActividad.Checked = false;
        }

    }
}
