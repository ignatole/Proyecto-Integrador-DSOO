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
            // Lógica para realizar el pago
            MessageBox.Show("Proceso de pago iniciado.");
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
    }
}
