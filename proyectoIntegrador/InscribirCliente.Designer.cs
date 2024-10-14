namespace proyectoIntegrador
{
    partial class InscribirCliente
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            buttonInscribir = new Button();
            buttonLimpiar = new Button();
            buttonCancelar = new Button();
            grpDatosPersonales = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            rbtnOtro = new RadioButton();
            rbtnFemenino = new RadioButton();
            label2 = new Label();
            rbtnMasculino = new RadioButton();
            lblSexo = new Label();
            lblFechaNac = new Label();
            dtpFechaNac = new DateTimePicker();
            grpDatosContacto = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            grpDatosPersonales.SuspendLayout();
            grpDatosContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(9, 59);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(9, 104);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 19);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(9, 147);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(33, 19);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(7, 59);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(15, 101);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 52);
            txtNombre.Margin = new Padding(4, 4, 4, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 25);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(132, 99);
            txtApellido.Margin = new Padding(4, 4, 4, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(204, 25);
            txtApellido.TabIndex = 6;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(132, 142);
            txtDNI.Margin = new Padding(4, 4, 4, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(204, 25);
            txtDNI.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(86, 55);
            txtTelefono.Margin = new Padding(4, 4, 4, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(86, 96);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 9;
            // 
            // buttonInscribir
            // 
            buttonInscribir.BackColor = Color.FromArgb(233, 239, 236);
            buttonInscribir.Location = new Point(167, 360);
            buttonInscribir.Margin = new Padding(4, 4, 4, 4);
            buttonInscribir.Name = "buttonInscribir";
            buttonInscribir.Size = new Size(88, 26);
            buttonInscribir.TabIndex = 10;
            buttonInscribir.Text = "Inscribir";
            buttonInscribir.UseVisualStyleBackColor = false;
            buttonInscribir.Click += btnInscribir;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.FromArgb(233, 239, 236);
            buttonLimpiar.Location = new Point(347, 360);
            buttonLimpiar.Margin = new Padding(4, 4, 4, 4);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(88, 26);
            buttonLimpiar.TabIndex = 11;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += btnLimpiar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(233, 239, 236);
            buttonCancelar.Location = new Point(534, 360);
            buttonCancelar.Margin = new Padding(4, 4, 4, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(88, 26);
            buttonCancelar.TabIndex = 12;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += btnCancelar_Click;
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(label5);
            grpDatosPersonales.Controls.Add(label6);
            grpDatosPersonales.Controls.Add(label7);
            grpDatosPersonales.Controls.Add(label1);
            grpDatosPersonales.Controls.Add(rbtnOtro);
            grpDatosPersonales.Controls.Add(rbtnFemenino);
            grpDatosPersonales.Controls.Add(label2);
            grpDatosPersonales.Controls.Add(rbtnMasculino);
            grpDatosPersonales.Controls.Add(lblSexo);
            grpDatosPersonales.Controls.Add(lblFechaNac);
            grpDatosPersonales.Controls.Add(dtpFechaNac);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Controls.Add(lblApellido);
            grpDatosPersonales.Controls.Add(txtApellido);
            grpDatosPersonales.Controls.Add(txtNombre);
            grpDatosPersonales.Controls.Add(lblDNI);
            grpDatosPersonales.Controls.Add(txtDNI);
            grpDatosPersonales.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpDatosPersonales.Location = new Point(35, 12);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(360, 309);
            grpDatosPersonales.TabIndex = 13;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos personales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(46, 224);
            label5.Name = "label5";
            label5.Size = new Size(12, 13);
            label5.TabIndex = 19;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(161, 192);
            label6.Name = "label6";
            label6.Size = new Size(12, 13);
            label6.TabIndex = 20;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(70, 107);
            label7.Name = "label7";
            label7.Size = new Size(12, 13);
            label7.TabIndex = 21;
            label7.Text = "*";
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(70, 62);
            label1.Name = "label1";
            label1.Size = new Size(12, 13);
            label1.TabIndex = 15;
            label1.Text = "*";
            // 
            // rbtnOtro
            // 
            rbtnOtro.AutoSize = true;
            rbtnOtro.Location = new Point(101, 277);
            rbtnOtro.Name = "rbtnOtro";
            rbtnOtro.Size = new Size(56, 23);
            rbtnOtro.TabIndex = 13;
            rbtnOtro.TabStop = true;
            rbtnOtro.Text = "Otro";
            rbtnOtro.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(101, 252);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(87, 23);
            rbtnFemenino.TabIndex = 12;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(46, 148);
            label2.Name = "label2";
            label2.Size = new Size(12, 13);
            label2.TabIndex = 16;
            label2.Text = "*";
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(101, 227);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(89, 23);
            rbtnMasculino.TabIndex = 11;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(9, 222);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(37, 19);
            lblSexo.TabIndex = 10;
            lblSexo.Text = "Sexo";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(9, 192);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(134, 19);
            lblFechaNac.TabIndex = 9;
            lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(236, 188);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(100, 25);
            dtpFechaNac.TabIndex = 8;
            // 
            // grpDatosContacto
            // 
            grpDatosContacto.Controls.Add(label3);
            grpDatosContacto.Controls.Add(label4);
            grpDatosContacto.Controls.Add(lblTelefono);
            grpDatosContacto.Controls.Add(lblEmail);
            grpDatosContacto.Controls.Add(txtTelefono);
            grpDatosContacto.Controls.Add(txtEmail);
            grpDatosContacto.Location = new Point(425, 179);
            grpDatosContacto.Name = "grpDatosContacto";
            grpDatosContacto.Size = new Size(306, 142);
            grpDatosContacto.TabIndex = 14;
            grpDatosContacto.TabStop = false;
            grpDatosContacto.Text = "Datos de contacto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(66, 56);
            label3.Name = "label3";
            label3.Size = new Size(12, 13);
            label3.TabIndex = 17;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(52, 100);
            label4.Name = "label4";
            label4.Size = new Size(12, 13);
            label4.TabIndex = 18;
            label4.Text = "*";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImagenFormInscripcion;
            pictureBox1.InitialImage = Properties.Resources.ImagenFormInscripcion;
            pictureBox1.Location = new Point(440, 24);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // InscribirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(777, 421);
            Controls.Add(pictureBox1);
            Controls.Add(grpDatosContacto);
            Controls.Add(grpDatosPersonales);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonInscribir);
            Margin = new Padding(4, 4, 4, 4);
            Name = "InscribirCliente";
            RightToLeft = RightToLeft.No;
            Text = "Formulario de Inscripción";
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            grpDatosContacto.ResumeLayout(false);
            grpDatosContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button buttonInscribir;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCancelar;
        private GroupBox grpDatosPersonales;
        private Label lblFechaNac;
        private DateTimePicker dtpFechaNac;
        private GroupBox grpDatosContacto;
        private Label lblSexo;
        private RadioButton rbtnOtro;
        private RadioButton rbtnFemenino;
        private RadioButton rbtnMasculino;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
