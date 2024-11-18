using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Drawing.Printing;

namespace proyectoIntegrador
{
    public partial class Comprobante : Form
    {
        private int _idPago;
        private bool _cargado = false;

        public Comprobante(int id_Pago)
        {
            InitializeComponent();
            _idPago = id_Pago;
            this.Load += ComprobanteLoad;
        }

        private void ComprobanteLoad(object? sender, EventArgs e)
        {
            if (!_cargado)
            {
                CargarDatosDBase();
                _cargado = true;
            }
        }

        private void CargarDatosDBase()
        {
            Cuota cuota = new Cuota();
            DataTable datosCuota = cuota.RecuperarDatosCuota(_idPago);

            if (datosCuota.Rows.Count > 0)
            {
                tblComprobante.Controls.Clear();
                tblComprobante.RowCount = 6;
                DataRow row = datosCuota.Rows[0];

                tblComprobante.Controls.Add(new Label() { Text = "Factura N° " }, 0, 0);
                tblComprobante.Controls.Add(new Label() { Text = $"{row["id_pago"]}" }, 1, 0);
                tblComprobante.Controls.Add(new Label() { Text = "Cliente" }, 0, 1);
                tblComprobante.Controls.Add(new Label() { Text = $"{row["Nombre Completo"]}" }, 1, 1);
                tblComprobante.Controls.Add(new Label() { Text = "Total" }, 0, 2);
                tblComprobante.Controls.Add(new Label() { Text = row["Monto"].ToString() }, 1, 2);
                tblComprobante.Controls.Add(new Label() { Text = "Fecha" }, 0, 3);
                tblComprobante.Controls.Add(new Label() { Text = Convert.ToDateTime(row["fecha_Pago"]).ToShortDateString() }, 1, 3);
                tblComprobante.Controls.Add(new Label() { Text = "Medio de pago", AutoSize = true }, 0, 4);
                tblComprobante.Controls.Add(new Label() { Text = row["medio_pago"].ToString() }, 1, 4);
                tblComprobante.Controls.Add(new Label() { Text = "Tipo de Membresía", AutoSize = true }, 0, 5);
                tblComprobante.Controls.Add(new Label() { Text = (bool)row["tipo_cuota"] ? "Mensual" : "Actividad" }, 1, 5);
            }
            else
            {
                MessageBox.Show("No se encontraron datos");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string nombreAutoArchivo = $"FacturaN0001-000000{tblComprobante.GetControlFromPosition(1, 0).Text}.pdf";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Guardar comprobante",
                FileName = nombreAutoArchivo
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                var documento = new Document();
                var writer = PdfWriter.GetInstance(documento, new FileStream(filePath, FileMode.Create));
                documento.Open();
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                var title = new Paragraph("Comprobante de Pago - Club Deportivo", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                documento.Add(title);
                documento.Add(new Paragraph("\n"));
                var contentFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                documento.Add(new Paragraph($"Factura N°: 0001-000000{tblComprobante.GetControlFromPosition(1, 0).Text}", contentFont));
                documento.Add(new Paragraph($"Cliente: {tblComprobante.GetControlFromPosition(1, 1).Text}", contentFont));
                documento.Add(new Paragraph($"Total: {tblComprobante.GetControlFromPosition(1, 2).Text}", contentFont));
                documento.Add(new Paragraph($"Fecha: {tblComprobante.GetControlFromPosition(1, 3).Text}", contentFont));
                documento.Add(new Paragraph($"Medio de pago: {tblComprobante.GetControlFromPosition(1, 4).Text}", contentFont));
                documento.Add(new Paragraph($"Tipo de Membresía: {tblComprobante.GetControlFromPosition(1, 5).Text}", contentFont));
                var footerFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                var footer = new Paragraph("Gracias por su preferencia. Club Deportivo.", footerFont);
                footer.Alignment = Element.ALIGN_CENTER;
                documento.Add(new Paragraph("\n"));
                documento.Add(footer);
                documento.Close();
                writer.Close();
                MessageBox.Show($"PDF generado exitosamente {saveFileDialog.FileName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error : " + ex.Message);
                }
            }
        }

        private void btnCFactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
