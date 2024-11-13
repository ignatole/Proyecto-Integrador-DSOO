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
            lblCantidadDeCuotas.Visible = false;
            btnComprobante.Visible = false;
        }
        private void NudCantAct_ValueChanged(object? sender, EventArgs e)
        {
            txtboxMonto.Text = (nudCantAct.Value * 1000).ToString();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ResetCampos();
        }
        private void RadioButtonTarjeta_CheckedChanged(object? sender, EventArgs e) {
            if (rbtnTarjeta.Checked)
            {
                cmbCantidadCuotas.Visible = true;
                lblCantidadDeCuotas.Visible = true;
            }
            else
            {
                cmbCantidadCuotas.Visible = false;
                lblCantidadDeCuotas.Visible = false;
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
            if (!int.TryParse(txtNroCliente.Text, out int dniCliente))
            {
                MessageBox.Show("Por favor, ingresa un número de cliente válido.");
                return;
            }

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

                if (!rbtnCuotaMensual.Checked && !rbtnCuotaActividad.Checked)
                {
                    MessageBox.Show("Debe seleccionar un tipo de cuota (Mensual o Por Actividad)");
                    return;
                }

                if (!decimal.TryParse(txtboxMonto.Text, out decimal monto))
                {
                    MessageBox.Show("Por favor, ingresa un monto válido.");
                    return;
                }

                string medioPago = rbtnEfectivo.Checked ? "Efectivo" : "Tarjeta";
                bool tipoCuota = rbtnCuotaMensual.Checked;

                int plazoCuota = 1; // Valor predeterminado en caso de que no aplique el plazo de cuota

                if (rbtnTarjeta.Checked)
                {
                    if (!int.TryParse(cmbCantidadCuotas.Text, out plazoCuota))
                    {
                        MessageBox.Show("Por favor, selecciona una cantidad de cuotas válida.");
                        return;
                    }
                }
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
                if (rbtnCuotaActividad.Checked)
                {
                    Credito credito = new();
                    credito.CargarCreditos(new ECredito { IdCliente = idCliente, CantCreditos = (int)nudCantAct.Value });
                }

                MessageBox.Show("Pago registrado exitosamente.");
                btnComprobante.Visible = true;
            }
            else
            {
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
