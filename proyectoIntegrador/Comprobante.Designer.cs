namespace proyectoIntegrador
{
    partial class Comprobante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCFactura = new Button();
            btnImprimir = new Button();
            tblComprobante = new TableLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCFactura
            // 
            btnCFactura.Location = new Point(515, 363);
            btnCFactura.Name = "btnCFactura";
            btnCFactura.Size = new Size(94, 29);
            btnCFactura.TabIndex = 0;
            btnCFactura.Text = "Cancelar";
            btnCFactura.UseVisualStyleBackColor = true;
            btnCFactura.Click += btnCFactura_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(193, 358);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 38);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // tblComprobante
            // 
            tblComprobante.ColumnCount = 2;
            tblComprobante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.5667877F));
            tblComprobante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.4332123F));
            tblComprobante.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblComprobante.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblComprobante.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblComprobante.Location = new Point(128, 111);
            tblComprobante.Name = "tblComprobante";
            tblComprobante.RowCount = 5;
            tblComprobante.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2973F));
            tblComprobante.RowStyles.Add(new RowStyle(SizeType.Percent, 52.7027F));
            tblComprobante.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tblComprobante.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tblComprobante.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tblComprobante.Size = new Size(554, 196);
            tblComprobante.TabIndex = 2;
            tblComprobante.Paint += ComprobanteLoad;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(287, 45);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 3;
            label1.Text = "Comprobante de Pago";
            // 
            // Comprobante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tblComprobante);
            Controls.Add(btnImprimir);
            Controls.Add(btnCFactura);
            Name = "Comprobante";
            Text = "Factura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCFactura;
        private Button btnImprimir;
        private TableLayoutPanel tblComprobante;
        private Label label1;
    }
}