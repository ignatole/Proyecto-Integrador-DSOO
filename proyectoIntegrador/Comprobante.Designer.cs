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
            btnCFactura.BackColor = Color.FromArgb(233, 239, 236);
            btnCFactura.Location = new Point(579, 381);
            btnCFactura.Name = "btnCFactura";
            btnCFactura.Size = new Size(106, 30);
            btnCFactura.TabIndex = 0;
            btnCFactura.Text = "Cancelar";
            btnCFactura.UseVisualStyleBackColor = false;
            btnCFactura.Click += btnCFactura_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(233, 239, 236);
            btnImprimir.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(217, 376);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(106, 40);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // tblComprobante
            // 
            tblComprobante.ColumnCount = 2;
            tblComprobante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.00642F));
            tblComprobante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.99358F));
            tblComprobante.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tblComprobante.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tblComprobante.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tblComprobante.Location = new Point(144, 117);
            tblComprobante.Name = "tblComprobante";
            tblComprobante.RowCount = 5;
            tblComprobante.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2973F));
            tblComprobante.RowStyles.Add(new RowStyle(SizeType.Percent, 52.7027F));
            tblComprobante.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tblComprobante.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tblComprobante.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tblComprobante.Size = new Size(623, 206);
            tblComprobante.TabIndex = 2;
            tblComprobante.Paint += ComprobanteLoad;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(345, 47);
            label1.Name = "label1";
            label1.Size = new Size(208, 24);
            label1.TabIndex = 3;
            label1.Text = "Comprobante de Pago";
            // 
            // Comprobante
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            ClientSize = new Size(900, 472);
            Controls.Add(label1);
            Controls.Add(tblComprobante);
            Controls.Add(btnImprimir);
            Controls.Add(btnCFactura);
            Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
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