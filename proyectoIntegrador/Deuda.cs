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
        { }
    }
}
