namespace proyectoIntegrador
{
    public partial class InscribirCliente : Form
    {
        public InscribirCliente()
        {
            InitializeComponent();
            this.FormClosing += InscribirCliente_FormClosing;
        }
        // Evento click del botón "Inscribir"
        private void btnInscribir(object sender, EventArgs e)
        {
            // Crear una instancia de ECliente y Cliente
            ECliente nuevoCliente = new ECliente();
            Cliente clienteHandler = new Cliente();

            // Asignar los valores de los TextBox a las propiedades del cliente
            if (ValidarCampos())
            {
                nuevoCliente.Nombre = txtNombre.Text;
                nuevoCliente.Apellido = txtApellido.Text;
                nuevoCliente.Dni = Convert.ToInt32(txtDNI.Text);
                nuevoCliente.Email = txtEmail.Text;
                nuevoCliente.Telefono = txtTelefono.Text;
                nuevoCliente.FechaNac = dtpFechaNac.Value;
                string sexo = "";
                if (rbtnMasculino.Checked)
                {
                    sexo = "Masculino";
                }
                else if (rbtnFemenino.Checked)
                {
                    sexo = "Femenino";
                }
                else if (rbtnOtro.Checked)
                {
                    sexo = "Otro";
                }
                nuevoCliente.Sexo = sexo;
                nuevoCliente.AptoFisico = chkAptoFisico.Checked ? true : false;

                // Llamar al método para insertar el cliente
                var (resultado, id_cliente) = clienteHandler.InsertarCliente(nuevoCliente);

                // Verificar el resultado y mostrar un mensaje
                if (resultado == 1)
                {
                    MessageBox.Show($"Cliente creado con éxito. ID del cliente: {id_cliente}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("El cliente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Evento click del botón "Limpiar"
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos de texto
            LimpiarCampos();
        }

        // Evento click del botón "Cancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual y abrir el anterior
            Home formPrevio = new Home();
            this.Close(); // Cerrar el formulario actual
            formPrevio.Show(); // Mostrar el formulario 
        }
        private bool ValidarCampos()
        {
            ResetLabels();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblNombre.ForeColor = Color.Red;
                MessageBox.Show("El campo Nombre debe ser llenado.");
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                lblApellido.ForeColor = Color.Red;
                MessageBox.Show("El campo Apellido debe ser llenado.");
                txtApellido.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                lblDNI.ForeColor = Color.Red;
                MessageBox.Show("El campo DNI debe ser llenado.");
                txtDNI.Focus();
                return false;
            }
            if (!int.TryParse(txtDNI.Text, out _))
            {
                lblDNI.ForeColor = Color.Red;
                MessageBox.Show("El campo DNI debe contener solo valores numéricos.");
                txtDNI.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                lblTelefono.ForeColor = Color.Red;
                MessageBox.Show("El campo Teléfono debe ser llenado.");
                txtTelefono.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("El campo Email debe ser llenado.");
                txtEmail.Focus();
                return false;
            }
            if (dtpFechaNac.Value > DateTime.Now)
            {
                lblFechaNac.ForeColor = Color.Red;
                MessageBox.Show("La fecha de nacimiento no puede ser una fecha futura.");
                dtpFechaNac.Focus();
                return false;
            }
            if (!rbtnMasculino.Checked && !rbtnFemenino.Checked && !rbtnOtro.Checked)
            {
                lblSexo.ForeColor = Color.Red;
                MessageBox.Show("Debe seleccionar un sexo.");
                lblSexo.Focus();
                return false;
            }
            return true;
        }
        private void ResetLabels()
        {
            lblNombre.Text = "Nombre";
            lblNombre.ForeColor = SystemColors.ControlText;
            lblApellido.Text = "Apellido";
            lblApellido.ForeColor = SystemColors.ControlText;
            lblDNI.Text = "DNI";
            lblDNI.ForeColor = SystemColors.ControlText;
            lblTelefono.Text = "Teléfono";
            lblTelefono.ForeColor = SystemColors.ControlText;
            lblEmail.Text = "Email";
            lblEmail.ForeColor = SystemColors.ControlText;
            lblFechaNac.Text = "Fecha de Nacimiento";
            lblFechaNac.ForeColor = SystemColors.ControlText;
            lblSexo.Text = "Sexo";
            lblSexo.ForeColor = SystemColors.ControlText;
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
            rbtnOtro.Checked = false;
            dtpFechaNac.Value = DateTime.Now;
            chkAptoFisico.Checked = false;
        }

        private void InscribirCliente_FormClosing(object sender, FormClosingEventArgs e)
        {

            Form home = Application.OpenForms["Home"];
            if (home != null)
            {
                home.Show();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void chkAptoFisico_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
