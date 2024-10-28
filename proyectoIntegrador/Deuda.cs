using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proyectoIntegrador
{
    public partial class Deuda : Form
    {
        private Cliente cliente; // Instancia de Cliente

        public Deuda()
        {
            InitializeComponent();
            cliente = new Cliente(); 
            btnVerDeuda.Click += new EventHandler(btnVerDeuda_Click);
        }

        private void btnVerDeuda_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtboxNroDeDocumento.Text, out int dni))
            {
                
                var (resultado, idCliente) = cliente.BuscarNroCliente(dni);

                if (resultado == 0)
                {
                    MessageBox.Show($"No se encontró el cliente con DNI {dni}.", "Cliente No Encontrado");
                    return;
                }

                
                Pago pago = new Pago(cliente);

               
                decimal totalDeuda = pago.BuscarTotalDeudas(dni);

                if (totalDeuda > 0)
                {
                    MessageBox.Show($"El cliente con DNI {dni} tiene una deuda total de {totalDeuda:C}.", "Deuda Total");
                }
                else
                {
                    MessageBox.Show($"El cliente con DNI {dni} no tiene deudas pendientes.", "Sin Deudas");
                }
   
                List<EPago> deudas = pago.BuscarDeudas(dni);
                gridDeudaCliente.DataSource = deudas; 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error");
            }
        }
    }
}
