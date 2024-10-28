namespace proyectoIntegrador
{
    partial class PagarCuota
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

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            txtNroCliente = new TextBox();
            btnVerNroCliente = new Button();
            btnPagar = new Button();
            btnComprobante = new Button();
            btnVolver = new Button();
            rbtnEfectivo = new RadioButton();
            rbtnTarjeta = new RadioButton();
            lblFormadePago = new Label();
            lblMonto = new Label();
            txtboxMonto = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(156, 67);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(182, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingrese el número de cliente";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // txtNroCliente
            // 
            txtNroCliente.Location = new Point(445, 63);
            txtNroCliente.Margin = new Padding(4);
            txtNroCliente.MaxLength = 10;
            txtNroCliente.Name = "txtNroCliente";
            txtNroCliente.Size = new Size(215, 23);
            txtNroCliente.TabIndex = 1;
            txtNroCliente.TextChanged += txtNroCliente_TextChanged;
            // 
            // btnVerNroCliente
            // 
            btnVerNroCliente.BackColor = Color.FromArgb(233, 239, 236);
            btnVerNroCliente.Location = new Point(84, 240);
            btnVerNroCliente.Margin = new Padding(4);
            btnVerNroCliente.Name = "btnVerNroCliente";
            btnVerNroCliente.Size = new Size(159, 42);
            btnVerNroCliente.TabIndex = 1;
            btnVerNroCliente.Text = "Ver deuda";
            btnVerNroCliente.UseVisualStyleBackColor = false;
            btnVerNroCliente.Click += btnVerDeuda_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(233, 239, 236);
            btnPagar.Location = new Point(353, 240);
            btnPagar.Margin = new Padding(4);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(159, 42);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.BackColor = Color.FromArgb(233, 239, 236);
            btnComprobante.Location = new Point(630, 240);
            btnComprobante.Margin = new Padding(4);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(169, 42);
            btnComprobante.TabIndex = 3;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = false;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(233, 239, 236);
            btnVolver.Location = new Point(630, 336);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(169, 42);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // rbtnEfectivo
            // 
            rbtnEfectivo.AutoSize = true;
            rbtnEfectivo.Location = new Point(445, 108);
            rbtnEfectivo.Name = "rbtnEfectivo";
            rbtnEfectivo.Size = new Size(67, 19);
            rbtnEfectivo.TabIndex = 5;
            rbtnEfectivo.TabStop = true;
            rbtnEfectivo.Text = "Efectivo";
            rbtnEfectivo.UseVisualStyleBackColor = true;
            rbtnEfectivo.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbtnTarjeta
            // 
            rbtnTarjeta.AutoSize = true;
            rbtnTarjeta.Location = new Point(601, 108);
            rbtnTarjeta.Name = "rbtnTarjeta";
            rbtnTarjeta.Size = new Size(59, 19);
            rbtnTarjeta.TabIndex = 6;
            rbtnTarjeta.TabStop = true;
            rbtnTarjeta.Text = "Tarjeta";
            rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblFormadePago
            // 
            lblFormadePago.AutoSize = true;
            lblFormadePago.Location = new Point(156, 108);
            lblFormadePago.Name = "lblFormadePago";
            lblFormadePago.Size = new Size(87, 15);
            lblFormadePago.TabIndex = 7;
            lblFormadePago.Text = "Forma de pago";
            lblFormadePago.Click += label1_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(156, 146);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 8;
            lblMonto.Text = "Monto";
            // 
            // txtboxMonto
            // 
            txtboxMonto.Location = new Point(445, 146);
            txtboxMonto.Name = "txtboxMonto";
            txtboxMonto.Size = new Size(215, 23);
            txtboxMonto.TabIndex = 9;
            // 
            // PagarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            ClientSize = new Size(836, 391);
            Controls.Add(txtboxMonto);
            Controls.Add(lblMonto);
            Controls.Add(lblFormadePago);
            Controls.Add(rbtnTarjeta);
            Controls.Add(rbtnEfectivo);
            Controls.Add(lblTitulo);
            Controls.Add(txtNroCliente);
            Controls.Add(btnVerNroCliente);
            Controls.Add(btnPagar);
            Controls.Add(btnComprobante);
            Controls.Add(btnVolver);
            Margin = new Padding(4);
            Name = "PagarCuota";
            RightToLeft = RightToLeft.No;
            Text = "Pagos";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNroCliente;
        private System.Windows.Forms.Button btnVerNroCliente;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.Button btnVolver;
        private RadioButton rbtnEfectivo;
        private RadioButton rbtnTarjeta;
        private Label lblFormadePago;
        private Label lblMonto;
        private TextBox txtboxMonto;
    }
    #region Windows Form Designer generated code
    #endregion
}


