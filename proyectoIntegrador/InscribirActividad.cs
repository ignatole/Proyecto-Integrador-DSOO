using MySql.Data.MySqlClient;
using proyectoIntegrador.Datos;
using System.Data;

namespace proyectoIntegrador
{
    public partial class InscribirActividad : Form
    {
        public InscribirActividad()
        {
            InitializeComponent();
            CargarActividades();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            int dniCliente = int.Parse(txtDNI.Text);

            Cliente clienteService = new();

            var (resultado, idCliente) = clienteService.BuscarNroCliente(dniCliente);

            if (resultado == 1)
            {
                if (cmbActividades.SelectedItem != null)
                {
                    int idActividad = (cmbActividades.SelectedItem as dynamic).Value;
                    EActividad actividad = new()
                    {
                        IdCliente = idCliente,
                        IdActividad = idActividad
                    };
                    Actividad actividadService = new();
                    int result = actividadService.RegistrarActividad(actividad);
                    switch (result)
                    {
                        case 1:
                            MessageBox.Show("Inscripción realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetCampos();
                            break;
                        case 0:
                            MessageBox.Show("No hay suficientes créditos disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2:
                            MessageBox.Show("No hay suficientes cupos disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            MessageBox.Show("Resultado desconocido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una actividad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Cliente no encontrado. Verifique el número de documento.");
            }
            CargarActividades();
        }

        private void CargarActividades()
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM actividad";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvActividades.DataSource = dt;
                    cmbActividades.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        cmbActividades.Items.Add(new { Text = row["nombre"].ToString(), Value = row["id_actividad"] });
                    }
                    cmbActividades.DisplayMember = "Text";
                    cmbActividades.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar actividades: " + ex.Message);
                }
            }
        }
        private void ResetCampos()
        {
            txtDNI.Text = "";
            cmbActividades.SelectedIndex = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Home formPrevio = new Home();
            this.Close();
            formPrevio.Show();
        }

        private void dgvActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
