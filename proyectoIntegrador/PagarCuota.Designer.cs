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
            btnLimpiar = new Button();
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
            cmbCantidadCuotas = new ComboBox();
            lblCantidadDeCuotas = new Label();
            grpFormaDePago.SuspendLayout();
            grpTipoCuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantAct).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(105, 60);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(255, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingrese el número de documento";
            // 
            // txtNroCliente
            // 
            txtNroCliente.Location = new Point(441, 58);
            txtNroCliente.Margin = new Padding(5, 5, 5, 5);
            txtNroCliente.MaxLength = 20;
            txtNroCliente.Name = "txtNroCliente";
            txtNroCliente.Size = new Size(275, 28);
            txtNroCliente.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(233, 239, 236);
            btnLimpiar.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(105, 466);
            btnLimpiar.Margin = new Padding(5, 5, 5, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(205, 59);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(233, 239, 236);
            btnPagar.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.Location = new Point(441, 466);
            btnPagar.Margin = new Padding(5, 5, 5, 5);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(205, 59);
            btnPagar.TabIndex = 8;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.BackColor = Color.FromArgb(233, 239, 236);
            btnComprobante.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprobante.Location = new Point(777, 466);
            btnComprobante.Margin = new Padding(5, 5, 5, 5);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(217, 59);
            btnComprobante.TabIndex = 9;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = false;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(233, 239, 236);
            btnVolver.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(441, 580);
            btnVolver.Margin = new Padding(5, 5, 5, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(217, 59);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // rbtnEfectivo
            // 
            rbtnEfectivo.AutoSize = true;
            rbtnEfectivo.Location = new Point(8, 30);
            rbtnEfectivo.Margin = new Padding(4);
            rbtnEfectivo.Name = "rbtnEfectivo";
            rbtnEfectivo.Size = new Size(90, 25);
            rbtnEfectivo.TabIndex = 0;
            rbtnEfectivo.TabStop = true;
            rbtnEfectivo.Text = "Efectivo";
            rbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtnTarjeta
            // 
            rbtnTarjeta.AutoSize = true;
            rbtnTarjeta.Location = new Point(8, 66);
            rbtnTarjeta.Margin = new Padding(4);
            rbtnTarjeta.Name = "rbtnTarjeta";
            rbtnTarjeta.Size = new Size(85, 25);
            rbtnTarjeta.TabIndex = 1;
            rbtnTarjeta.TabStop = true;
            rbtnTarjeta.Text = "Tarjeta";
            rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblFormadePago
            // 
            lblFormadePago.AutoSize = true;
            lblFormadePago.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFormadePago.Location = new Point(178, 148);
            lblFormadePago.Margin = new Padding(4, 0, 4, 0);
            lblFormadePago.Name = "lblFormadePago";
            lblFormadePago.Size = new Size(121, 21);
            lblFormadePago.TabIndex = 7;
            lblFormadePago.Text = "Forma de pago";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonto.Location = new Point(188, 387);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(56, 21);
            lblMonto.TabIndex = 8;
            lblMonto.Text = "Monto";
            // 
            // txtboxMonto
            // 
            txtboxMonto.Location = new Point(441, 382);
            txtboxMonto.Margin = new Padding(4);
            txtboxMonto.MaxLength = 10;
            txtboxMonto.Name = "txtboxMonto";
            txtboxMonto.Size = new Size(275, 28);
            txtboxMonto.TabIndex = 5;
            // 
            // lblTipoCuota
            // 
            lblTipoCuota.AutoSize = true;
            lblTipoCuota.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoCuota.Location = new Point(178, 268);
            lblTipoCuota.Margin = new Padding(4, 0, 4, 0);
            lblTipoCuota.Name = "lblTipoCuota";
            lblTipoCuota.Size = new Size(111, 21);
            lblTipoCuota.TabIndex = 10;
            lblTipoCuota.Text = "Tipo de cuota";
            // 
            // rbtnCuotaMensual
            // 
            rbtnCuotaMensual.AutoSize = true;
            rbtnCuotaMensual.Location = new Point(8, 30);
            rbtnCuotaMensual.Margin = new Padding(4);
            rbtnCuotaMensual.Name = "rbtnCuotaMensual";
            rbtnCuotaMensual.Size = new Size(140, 25);
            rbtnCuotaMensual.TabIndex = 11;
            rbtnCuotaMensual.TabStop = true;
            rbtnCuotaMensual.Text = "Cuota Mensual";
            rbtnCuotaMensual.UseVisualStyleBackColor = true;
            // 
            // rbtnCuotaActividad
            // 
            rbtnCuotaActividad.AutoSize = true;
            rbtnCuotaActividad.Location = new Point(8, 66);
            rbtnCuotaActividad.Margin = new Padding(4);
            rbtnCuotaActividad.Name = "rbtnCuotaActividad";
            rbtnCuotaActividad.Size = new Size(170, 25);
            rbtnCuotaActividad.TabIndex = 12;
            rbtnCuotaActividad.TabStop = true;
            rbtnCuotaActividad.Text = "Cuota de Actividad";
            rbtnCuotaActividad.UseVisualStyleBackColor = true;
            // 
            // grpFormaDePago
            // 
            grpFormaDePago.Controls.Add(rbtnEfectivo);
            grpFormaDePago.Controls.Add(rbtnTarjeta);
            grpFormaDePago.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpFormaDePago.Location = new Point(441, 118);
            grpFormaDePago.Margin = new Padding(4);
            grpFormaDePago.Name = "grpFormaDePago";
            grpFormaDePago.Padding = new Padding(4);
            grpFormaDePago.Size = new Size(287, 112);
            grpFormaDePago.TabIndex = 1;
            grpFormaDePago.TabStop = false;
            // 
            // grpTipoCuota
            // 
            grpTipoCuota.Controls.Add(rbtnCuotaMensual);
            grpTipoCuota.Controls.Add(rbtnCuotaActividad);
            grpTipoCuota.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpTipoCuota.Location = new Point(441, 248);
            grpTipoCuota.Margin = new Padding(4);
            grpTipoCuota.Name = "grpTipoCuota";
            grpTipoCuota.Padding = new Padding(4);
            grpTipoCuota.Size = new Size(302, 112);
            grpTipoCuota.TabIndex = 4;
            grpTipoCuota.TabStop = false;
            // 
            // nudCantAct
            // 
            nudCantAct.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nudCantAct.Location = new Point(803, 300);
            nudCantAct.Margin = new Padding(5, 4, 5, 4);
            nudCantAct.Name = "nudCantAct";
            nudCantAct.Size = new Size(62, 28);
            nudCantAct.TabIndex = 15;
            // 
            // cmbCantidadCuotas
            // 
            cmbCantidadCuotas.FormattingEnabled = true;
            cmbCantidadCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cmbCantidadCuotas.Location = new Point(777, 184);
            cmbCantidadCuotas.Margin = new Padding(4);
            cmbCantidadCuotas.Name = "cmbCantidadCuotas";
            cmbCantidadCuotas.Size = new Size(139, 29);
            cmbCantidadCuotas.TabIndex = 3;
            // 
            // lblCantidadDeCuotas
            // 
            lblCantidadDeCuotas.AutoSize = true;
            lblCantidadDeCuotas.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadDeCuotas.Location = new Point(777, 159);
            lblCantidadDeCuotas.Margin = new Padding(4, 0, 4, 0);
            lblCantidadDeCuotas.Name = "lblCantidadDeCuotas";
            lblCantidadDeCuotas.Size = new Size(152, 21);
            lblCantidadDeCuotas.TabIndex = 2;
            lblCantidadDeCuotas.Text = "Cantidad de cuotas";
            // 
            // PagarCuota
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            ClientSize = new Size(1119, 722);
            Controls.Add(lblCantidadDeCuotas);
            Controls.Add(cmbCantidadCuotas);
            Controls.Add(nudCantAct);
            Controls.Add(lblTitulo);
            Controls.Add(txtNroCliente);
            Controls.Add(btnLimpiar);
            Controls.Add(btnPagar);
            Controls.Add(btnComprobante);
            Controls.Add(btnVolver);
            Controls.Add(lblFormadePago);
            Controls.Add(lblMonto);
            Controls.Add(txtboxMonto);
            Controls.Add(lblTipoCuota);
            Controls.Add(grpFormaDePago);
            Controls.Add(grpTipoCuota);
            Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 5, 5, 5);
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
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private TextBox txtNroCliente;
        private Button btnLimpiar;
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
        private ComboBox cmbCantidadCuotas;
        private Label lblCantidadDeCuotas;
    }
}

