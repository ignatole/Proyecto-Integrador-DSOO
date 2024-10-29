using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoIntegrador
{
    public partial class PagarCuota : Form
    {
        public PagarCuota()
        {
            InitializeComponent();
        }
        private void btnVerDeuda_Click(object sender, EventArgs e)
        {
            Deuda verDeudaForm = new Deuda();
            verDeudaForm.ShowDialog();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            int dniCliente = int.Parse(txtNroCliente.Text); 

            Cliente clienteService = new Cliente();

            var (resultado, idCliente) = clienteService.BuscarNroCliente(dniCliente);

            if (resultado == 1)
            {

                decimal monto = decimal.Parse(txtboxMonto.Text); 
                string medioPago = rbtnEfectivo.Checked ? "Efectivo" : "Tarjeta";
                bool tipoCuota = rbtnCuotaMensual.Checked; 

                ECuota cuota = new ECuota
                {
                    IdCliente = idCliente,
                    FechaPago = DateTime.Now,
                    MedioPago = medioPago,
                    Monto = monto,
                    TipoCuota = tipoCuota
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
            // Lógica para mostrar comprobante
            MessageBox.Show("Mostrando comprobante.");
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
