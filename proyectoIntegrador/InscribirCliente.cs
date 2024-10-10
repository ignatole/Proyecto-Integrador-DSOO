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
    public partial class InscribirCliente : Form
    {
        public InscribirCliente()
        {
            InitializeComponent();
        }
        // Evento click del botón "Inscribir"
        private void buttonInscribir_Click(object sender, EventArgs e)
        {
            // Crear una instancia de ECliente y Cliente
            ECliente nuevoCliente = new ECliente();
            Cliente clienteHandler = new Cliente();

            // Asignar los valores de los TextBox a las propiedades del cliente
            nuevoCliente.Nombre = textBoxNombre.Text;
            nuevoCliente.Apellido = textBoxApellido.Text;
            nuevoCliente.Dni = Convert.ToInt32(textBoxDni.Text);
            nuevoCliente.Email = textBoxEmail.Text;
            nuevoCliente.Telefono = textBoxTelefono.Text;

            // Llamar al método para insertar el cliente
            int resultado = clienteHandler.InsertarCliente(nuevoCliente);

            // Verificar el resultado y mostrar un mensaje
            if (resultado == 1)
            {
                MessageBox.Show("Cliente inscripto con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El cliente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento click del botón "Limpiar"
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos de texto
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDni.Text = "";
            textBoxTelefono.Text = "";
            textBoxEmail.Text = "";
        }

        // Evento click del botón "Cancelar"
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual y abrir el anterior
            Home formPrevio = new Home();
            this.Close(); // Cerrar el formulario actual
            formPrevio.Show(); // Mostrar el formulario 
        }
    }
}
