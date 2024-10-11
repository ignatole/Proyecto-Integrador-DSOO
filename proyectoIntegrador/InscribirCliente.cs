namespace proyectoIntegrador
{
    public partial class InscribirCliente : Form
    {
        public InscribirCliente()
        {
            InitializeComponent();
        }
        // Evento click del botón "Inscribir"
        private void btnInscribir(object sender, EventArgs e)
        {
            // Crear una instancia de ECliente y Cliente
            ECliente nuevoCliente = new ECliente();
            Cliente clienteHandler = new Cliente();

            // Asignar los valores de los TextBox a las propiedades del cliente
            try
            {
                nuevoCliente.Nombre = txtNombre.Text;
                nuevoCliente.Apellido = txtApellido.Text;
                nuevoCliente.Dni = Convert.ToInt32(txtDni.Text);
                nuevoCliente.Email = txtEmail.Text;
                nuevoCliente.Telefono = txtTelefono.Text;

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
            catch (Exception)
            {
                MessageBox.Show("Por favor ingrese un valor numérico en DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }
    }
}
