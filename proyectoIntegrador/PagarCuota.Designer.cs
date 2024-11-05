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
            nudCantAct = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            grpFormaDePago.SuspendLayout();
            grpTipoCuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantAct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(167, 55);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(266, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingrese el número de documento";
            lblTitulo.Click += lblTitulo_Click_1;
            // 
            // txtNroCliente
            // 
            txtNroCliente.Location = new Point(515, 55);
            txtNroCliente.Margin = new Padding(5);
            txtNroCliente.MaxLength = 10;
            txtNroCliente.Name = "txtNroCliente";
            txtNroCliente.Size = new Size(245, 27);
            txtNroCliente.TabIndex = 1;
            // 
            // btnVerNroCliente
            // 
            btnVerNroCliente.BackColor = Color.FromArgb(233, 239, 236);
            btnVerNroCliente.Location = new Point(85, 411);
            btnVerNroCliente.Margin = new Padding(5);
            btnVerNroCliente.Name = "btnVerNroCliente";
            btnVerNroCliente.Size = new Size(182, 56);
            btnVerNroCliente.TabIndex = 1;
            btnVerNroCliente.Text = "Ver deuda";
            btnVerNroCliente.UseVisualStyleBackColor = false;
            btnVerNroCliente.Click += btnVerDeuda_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(233, 239, 236);
            btnPagar.Location = new Point(408, 411);
            btnPagar.Margin = new Padding(5);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(182, 56);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.BackColor = Color.FromArgb(233, 239, 236);
            btnComprobante.Location = new Point(720, 411);
            btnComprobante.Margin = new Padding(5);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(193, 56);
            btnComprobante.TabIndex = 3;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = false;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(233, 239, 236);
            btnVolver.Location = new Point(720, 499);
            btnVolver.Margin = new Padding(5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(193, 56);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // rbtnEfectivo
            // 
            rbtnEfectivo.AutoSize = true;
            rbtnEfectivo.Location = new Point(7, 29);
            rbtnEfectivo.Margin = new Padding(3, 4, 3, 4);
            rbtnEfectivo.Name = "rbtnEfectivo";
            rbtnEfectivo.Size = new Size(83, 24);
            rbtnEfectivo.TabIndex = 5;
            rbtnEfectivo.TabStop = true;
            rbtnEfectivo.Text = "Efectivo";
            rbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtnTarjeta
            // 
            rbtnTarjeta.AutoSize = true;
            rbtnTarjeta.Location = new Point(7, 63);
            rbtnTarjeta.Margin = new Padding(3, 4, 3, 4);
            rbtnTarjeta.Name = "rbtnTarjeta";
            rbtnTarjeta.Size = new Size(74, 24);
            rbtnTarjeta.TabIndex = 6;
            rbtnTarjeta.TabStop = true;
            rbtnTarjeta.Text = "Tarjeta";
            rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblFormadePago
            // 
            lblFormadePago.AutoSize = true;
            lblFormadePago.Location = new Point(167, 141);
            lblFormadePago.Name = "lblFormadePago";
            lblFormadePago.Size = new Size(111, 20);
            lblFormadePago.TabIndex = 7;
            lblFormadePago.Text = "Forma de pago";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(167, 351);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(53, 20);
            lblMonto.TabIndex = 8;
            lblMonto.Text = "Monto";
            lblMonto.Click += lblMonto_Click;
            // 
            // txtboxMonto
            // 
            txtboxMonto.Location = new Point(515, 351);
            txtboxMonto.Margin = new Padding(3, 4, 3, 4);
            txtboxMonto.Name = "txtboxMonto";
            txtboxMonto.Size = new Size(245, 27);
            txtboxMonto.TabIndex = 9;
            // 
            // lblTipoCuota
            // 
            lblTipoCuota.AutoSize = true;
            lblTipoCuota.Location = new Point(167, 256);
            lblTipoCuota.Name = "lblTipoCuota";
            lblTipoCuota.Size = new Size(101, 20);
            lblTipoCuota.TabIndex = 10;
            lblTipoCuota.Text = "Tipo de cuota";
            // 
            // rbtnCuotaMensual
            // 
            rbtnCuotaMensual.AutoSize = true;
            rbtnCuotaMensual.Location = new Point(7, 29);
            rbtnCuotaMensual.Margin = new Padding(3, 4, 3, 4);
            rbtnCuotaMensual.Name = "rbtnCuotaMensual";
            rbtnCuotaMensual.Size = new Size(128, 24);
            rbtnCuotaMensual.TabIndex = 11;
            rbtnCuotaMensual.TabStop = true;
            rbtnCuotaMensual.Text = "Cuota Mensual";
            rbtnCuotaMensual.UseVisualStyleBackColor = true;
            // 
            // rbtnCuotaActividad
            // 
            rbtnCuotaActividad.AutoSize = true;
            rbtnCuotaActividad.Location = new Point(7, 63);
            rbtnCuotaActividad.Margin = new Padding(3, 4, 3, 4);
            rbtnCuotaActividad.Name = "rbtnCuotaActividad";
            rbtnCuotaActividad.Size = new Size(157, 24);
            rbtnCuotaActividad.TabIndex = 12;
            rbtnCuotaActividad.TabStop = true;
            rbtnCuotaActividad.Text = "Cuota de Actividad";
            rbtnCuotaActividad.UseVisualStyleBackColor = true;
            // 
            // grpFormaDePago
            // 
            grpFormaDePago.Controls.Add(rbtnEfectivo);
            grpFormaDePago.Controls.Add(rbtnTarjeta);
            grpFormaDePago.Location = new Point(515, 112);
            grpFormaDePago.Margin = new Padding(3, 4, 3, 4);
            grpFormaDePago.Name = "grpFormaDePago";
            grpFormaDePago.Padding = new Padding(3, 4, 3, 4);
            grpFormaDePago.Size = new Size(246, 107);
            grpFormaDePago.TabIndex = 13;
            grpFormaDePago.TabStop = false;
            // 
            // grpTipoCuota
            // 
            grpTipoCuota.Controls.Add(rbtnCuotaMensual);
            grpTipoCuota.Controls.Add(rbtnCuotaActividad);
            grpTipoCuota.Location = new Point(515, 227);
            grpTipoCuota.Margin = new Padding(3, 4, 3, 4);
            grpTipoCuota.Name = "grpTipoCuota";
            grpTipoCuota.Padding = new Padding(3, 4, 3, 4);
            grpTipoCuota.Size = new Size(246, 107);
            grpTipoCuota.TabIndex = 14;
            grpTipoCuota.TabStop = false;
            // 
            // nudCantAct
            // 
            nudCantAct.Location = new Point(781, 289);
            nudCantAct.Margin = new Padding(3, 4, 3, 4);
            nudCantAct.Name = "nudCantAct";
            nudCantAct.Size = new Size(40, 27);
            nudCantAct.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Location = new Point(781, 175);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(40, 27);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // PagarCuota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 572);
            Controls.Add(numericUpDown1);
            Controls.Add(nudCantAct);
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
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PagarCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar Cuota";
            grpFormaDePago.ResumeLayout(false);
            grpFormaDePago.PerformLayout();
            grpTipoCuota.ResumeLayout(false);
            grpTipoCuota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantAct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private NumericUpDown nudCantAct;
        private NumericUpDown numericUpDown1;
    }
}

