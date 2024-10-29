namespace proyectoIntegrador
{
    partial class PagarCuota
    {
        private System.ComponentModel.IContainer components = null;

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
            lblTipoCuota = new Label();
            rbtnCuotaMensual = new RadioButton();
            rbtnCuotaActividad = new RadioButton();
            grpFormaDePago = new GroupBox();
            grpTipoCuota = new GroupBox();
            grpFormaDePago.SuspendLayout();
            grpTipoCuota.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(146, 41);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(213, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingrese el número de documento";
            lblTitulo.Click += lblTitulo_Click_1;
            // 
            // txtNroCliente
            // 
            txtNroCliente.Location = new Point(451, 41);
            txtNroCliente.Margin = new Padding(4);
            txtNroCliente.MaxLength = 10;
            txtNroCliente.Name = "txtNroCliente";
            txtNroCliente.Size = new Size(215, 23);
            txtNroCliente.TabIndex = 1;
            // 
            // btnVerNroCliente
            // 
            btnVerNroCliente.BackColor = Color.FromArgb(233, 239, 236);
            btnVerNroCliente.Location = new Point(74, 308);
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
            btnPagar.Location = new Point(357, 308);
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
            btnComprobante.Location = new Point(630, 308);
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
            btnVolver.Location = new Point(630, 374);
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
            rbtnEfectivo.Location = new Point(6, 22);
            rbtnEfectivo.Name = "rbtnEfectivo";
            rbtnEfectivo.Size = new Size(67, 19);
            rbtnEfectivo.TabIndex = 5;
            rbtnEfectivo.TabStop = true;
            rbtnEfectivo.Text = "Efectivo";
            rbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtnTarjeta
            // 
            rbtnTarjeta.AutoSize = true;
            rbtnTarjeta.Location = new Point(6, 47);
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
            lblFormadePago.Location = new Point(146, 106);
            lblFormadePago.Name = "lblFormadePago";
            lblFormadePago.Size = new Size(87, 15);
            lblFormadePago.TabIndex = 7;
            lblFormadePago.Text = "Forma de pago";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(146, 263);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 8;
            lblMonto.Text = "Monto";
            lblMonto.Click += lblMonto_Click;
            // 
            // txtboxMonto
            // 
            txtboxMonto.Location = new Point(451, 263);
            txtboxMonto.Name = "txtboxMonto";
            txtboxMonto.Size = new Size(215, 23);
            txtboxMonto.TabIndex = 9;
            // 
            // lblTipoCuota
            // 
            lblTipoCuota.AutoSize = true;
            lblTipoCuota.Location = new Point(146, 192);
            lblTipoCuota.Name = "lblTipoCuota";
            lblTipoCuota.Size = new Size(79, 15);
            lblTipoCuota.TabIndex = 10;
            lblTipoCuota.Text = "Tipo de cuota";
            // 
            // rbtnCuotaMensual
            // 
            rbtnCuotaMensual.AutoSize = true;
            rbtnCuotaMensual.Location = new Point(6, 22);
            rbtnCuotaMensual.Name = "rbtnCuotaMensual";
            rbtnCuotaMensual.Size = new Size(105, 19);
            rbtnCuotaMensual.TabIndex = 11;
            rbtnCuotaMensual.TabStop = true;
            rbtnCuotaMensual.Text = "Cuota Mensual";
            rbtnCuotaMensual.UseVisualStyleBackColor = true;
            // 
            // rbtnCuotaActividad
            // 
            rbtnCuotaActividad.AutoSize = true;
            rbtnCuotaActividad.Location = new Point(6, 47);
            rbtnCuotaActividad.Name = "rbtnCuotaActividad";
            rbtnCuotaActividad.Size = new Size(126, 19);
            rbtnCuotaActividad.TabIndex = 12;
            rbtnCuotaActividad.TabStop = true;
            rbtnCuotaActividad.Text = "Cuota de Actividad";
            rbtnCuotaActividad.UseVisualStyleBackColor = true;
            // 
            // grpFormaDePago
            // 
            grpFormaDePago.Controls.Add(rbtnEfectivo);
            grpFormaDePago.Controls.Add(rbtnTarjeta);
            grpFormaDePago.Location = new Point(451, 84);
            grpFormaDePago.Name = "grpFormaDePago";
            grpFormaDePago.Size = new Size(215, 80);
            grpFormaDePago.TabIndex = 13;
            grpFormaDePago.TabStop = false;
            // 
            // grpTipoCuota
            // 
            grpTipoCuota.Controls.Add(rbtnCuotaMensual);
            grpTipoCuota.Controls.Add(rbtnCuotaActividad);
            grpTipoCuota.Location = new Point(451, 170);
            grpTipoCuota.Name = "grpTipoCuota";
            grpTipoCuota.Size = new Size(215, 80);
            grpTipoCuota.TabIndex = 14;
            grpTipoCuota.TabStop = false;
            // 
            // PagarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 429);
            Controls.Add(lblTitulo);
            Controls.Add(txtNroCliente);
            Controls.Add(btnVerNroCliente);
            Controls.Add(btnPagar);
            Controls.Add(btnComprobante);
            Controls.Add(btnVolver);
            Controls.Add(lblFormadePago);
            Controls.Add(lblMonto);
            Controls.Add(txtboxMonto);
            Controls.Add(lblTipoCuota);
            Controls.Add(grpFormaDePago);
            Controls.Add(grpTipoCuota);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PagarCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar Cuota";
            grpFormaDePago.ResumeLayout(false);
            grpFormaDePago.PerformLayout();
            grpTipoCuota.ResumeLayout(false);
            grpTipoCuota.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private TextBox txtNroCliente;
        private Button btnVerNroCliente;
        private Button btnPagar;
        private Button btnComprobante;
        private Button btnVolver;
        private RadioButton rbtnEfectivo;
        private RadioButton rbtnTarjeta;
        private Label lblFormadePago;
        private Label lblMonto;
        private TextBox txtboxMonto;
        private Label lblTipoCuota;
        private RadioButton rbtnCuotaMensual;
        private RadioButton rbtnCuotaActividad;
        private GroupBox grpFormaDePago;
        private GroupBox grpTipoCuota;
    }
}

