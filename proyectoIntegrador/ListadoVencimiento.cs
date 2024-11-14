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
    public partial class ListadoVencimiento : Form
    {
        private Cuota cuota; 

        public ListadoVencimiento()
        {
            InitializeComponent();
            cuota = new Cuota();
            this.FormClosing += CargarVencimientos_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTituloVencimientos.Text += DateTime.Now.ToString("dd/MM/yyyy");
            CargarVencimientos(); 
        }

        private void CargarVencimientos()
        {
            var cuotasVencidas = cuota.ObtenerCuotasVencidas(); 

            gridVencimientos.Rows.Clear();

            foreach (var cuotaVencida in cuotasVencidas)
            {
                gridVencimientos.Rows.Add(
                    cuotaVencida.IdCliente,
                    cuotaVencida.NombreCompleto,
                    cuotaVencida.Dni,
                    cuotaVencida.FechaVencimiento
                );
            }
        }
        private void CargarVencimientos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form home = Application.OpenForms["Home"];
            if (home != null)
            {
                home.Show();
            }
        }

        private void gridVencimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
