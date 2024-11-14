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
            btnVolver = new Button();
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
            chkAptoFisico = new CheckBox();
            lblAptoFisico = new Label();
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
            lblNombre.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(11, 83);
            lblNombre.Margin = new Padding(6, 0, 6, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(11, 146);
            lblApellido.Margin = new Padding(6, 0, 6, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 21);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(11, 205);
            lblDNI.Margin = new Padding(6, 0, 6, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(39, 21);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(16, 41);
            lblTelefono.Margin = new Padding(6, 0, 6, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 21);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(19, 84);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(170, 72);
            txtNombre.Margin = new Padding(6, 5, 6, 5);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(262, 28);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(170, 139);
            txtApellido.Margin = new Padding(6, 5, 6, 5);
            txtApellido.MaxLength = 100;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(262, 28);
            txtApellido.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(170, 198);
            txtDNI.Margin = new Padding(6, 5, 6, 5);
            txtDNI.MaxLength = 20;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(262, 28);
            txtDNI.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(109, 35);
            txtTelefono.Margin = new Padding(6, 5, 6, 5);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(256, 28);
            txtTelefono.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 79);
            txtEmail.Margin = new Padding(6, 5, 6, 5);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 28);
            txtEmail.TabIndex = 9;
            // 
            // buttonInscribir
            // 
            buttonInscribir.BackColor = Color.FromArgb(233, 239, 236);
            buttonInscribir.Location = new Point(215, 504);
            buttonInscribir.Margin = new Padding(6, 5, 6, 5);
            buttonInscribir.Name = "buttonInscribir";
            buttonInscribir.Size = new Size(114, 37);
            buttonInscribir.TabIndex = 0;
            buttonInscribir.Text = "Inscribir";
            buttonInscribir.UseVisualStyleBackColor = false;
            buttonInscribir.Click += btnInscribir;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.FromArgb(233, 239, 236);
            buttonLimpiar.Location = new Point(447, 504);
            buttonLimpiar.Margin = new Padding(6, 5, 6, 5);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(114, 37);
            buttonLimpiar.TabIndex = 1;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(233, 239, 236);
            btnVolver.Location = new Point(686, 504);
            btnVolver.Margin = new Padding(6, 5, 6, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(114, 37);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnCancelar_Click;
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
            grpDatosPersonales.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpDatosPersonales.Location = new Point(45, 16);
            grpDatosPersonales.Margin = new Padding(3, 5, 3, 5);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Padding = new Padding(3, 5, 3, 5);
            grpDatosPersonales.Size = new Size(462, 433);
            grpDatosPersonales.TabIndex = 0;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos personales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(60, 314);
            label5.Name = "label5";
            label5.Size = new Size(15, 19);
            label5.TabIndex = 19;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(207, 268);
            label6.Name = "label6";
            label6.Size = new Size(15, 19);
            label6.TabIndex = 20;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(90, 150);
            label7.Name = "label7";
            label7.Size = new Size(15, 19);
            label7.TabIndex = 21;
            label7.Text = "*";
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(90, 88);
            label1.Name = "label1";
            label1.Size = new Size(15, 19);
            label1.TabIndex = 15;
            label1.Text = "*";
            // 
            // rbtnOtro
            // 
            rbtnOtro.AutoSize = true;
            rbtnOtro.Location = new Point(129, 387);
            rbtnOtro.Margin = new Padding(3, 5, 3, 5);
            rbtnOtro.Name = "rbtnOtro";
            rbtnOtro.Size = new Size(64, 25);
            rbtnOtro.TabIndex = 7;
            rbtnOtro.TabStop = true;
            rbtnOtro.Text = "Otro";
            rbtnOtro.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(129, 352);
            rbtnFemenino.Margin = new Padding(3, 5, 3, 5);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(103, 25);
            rbtnFemenino.TabIndex = 6;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(60, 206);
            label2.Name = "label2";
            label2.Size = new Size(15, 19);
            label2.TabIndex = 16;
            label2.Text = "*";
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(129, 318);
            rbtnMasculino.Margin = new Padding(3, 5, 3, 5);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(104, 25);
            rbtnMasculino.TabIndex = 5;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            rbtnMasculino.CheckedChanged += rbtnMasculino_CheckedChanged;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(11, 310);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(45, 21);
            lblSexo.TabIndex = 10;
            lblSexo.Text = "Sexo";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(11, 268);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(163, 21);
            lblFechaNac.TabIndex = 9;
            lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(304, 264);
            dtpFechaNac.Margin = new Padding(3, 5, 3, 5);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(128, 28);
            dtpFechaNac.TabIndex = 4;
            // 
            // grpDatosContacto
            // 
            grpDatosContacto.Controls.Add(chkAptoFisico);
            grpDatosContacto.Controls.Add(lblAptoFisico);
            grpDatosContacto.Controls.Add(label3);
            grpDatosContacto.Controls.Add(label4);
            grpDatosContacto.Controls.Add(lblTelefono);
            grpDatosContacto.Controls.Add(lblEmail);
            grpDatosContacto.Controls.Add(txtTelefono);
            grpDatosContacto.Controls.Add(txtEmail);
            grpDatosContacto.Location = new Point(547, 251);
            grpDatosContacto.Margin = new Padding(3, 5, 3, 5);
            grpDatosContacto.Name = "grpDatosContacto";
            grpDatosContacto.Padding = new Padding(3, 5, 3, 5);
            grpDatosContacto.Size = new Size(394, 198);
            grpDatosContacto.TabIndex = 14;
            grpDatosContacto.TabStop = false;
            grpDatosContacto.Text = "Datos de contacto";
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(189, 135);
            chkAptoFisico.Margin = new Padding(3, 5, 3, 5);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(18, 17);
            chkAptoFisico.TabIndex = 2;
            chkAptoFisico.UseVisualStyleBackColor = true;
            chkAptoFisico.CheckedChanged += chkAptoFisico_CheckedChanged;
            // 
            // lblAptoFisico
            // 
            lblAptoFisico.AutoSize = true;
            lblAptoFisico.Location = new Point(19, 131);
            lblAptoFisico.Name = "lblAptoFisico";
            lblAptoFisico.Size = new Size(164, 21);
            lblAptoFisico.TabIndex = 19;
            lblAptoFisico.Text = "Presenta apto fisico?";
            lblAptoFisico.Click += label8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(84, 35);
            label3.Name = "label3";
            label3.Size = new Size(15, 19);
            label3.TabIndex = 0;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(66, 79);
            label4.Name = "label4";
            label4.Size = new Size(15, 19);
            label4.TabIndex = 1;
            label4.Text = "*";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImagenFormInscripcion;
            pictureBox1.InitialImage = Properties.Resources.ImagenFormInscripcion;
            pictureBox1.Location = new Point(566, 34);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // InscribirCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(999, 589);
            Controls.Add(pictureBox1);
            Controls.Add(grpDatosContacto);
            Controls.Add(grpDatosPersonales);
            Controls.Add(btnVolver);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonInscribir);
            Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
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
        private System.Windows.Forms.Button btnVolver;
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
        private Label lblAptoFisico;
        private CheckBox chkAptoFisico;
    }
}
