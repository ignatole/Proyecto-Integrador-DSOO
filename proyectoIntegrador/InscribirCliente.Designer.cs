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
            dtpFechaNac = new DateTimePicker();
            lblFechaNac = new Label();
            grpDatosContacto = new GroupBox();
            lblSexo = new Label();
            rbtnMasculino = new RadioButton();
            rbtnFemenino = new RadioButton();
            rbtnOtro = new RadioButton();
            grpDatosPersonales.SuspendLayout();
            grpDatosContacto.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(9, 59);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(9, 104);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(9, 147);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(7, 59);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(7, 104);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(77, 51);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(77, 96);
            txtApellido.Margin = new Padding(4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(204, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(77, 139);
            txtDNI.Margin = new Padding(4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(204, 23);
            txtDNI.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(68, 51);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(68, 96);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 9;
            // 
            // buttonInscribir
            // 
            buttonInscribir.Location = new Point(396, 349);
            buttonInscribir.Margin = new Padding(4);
            buttonInscribir.Name = "buttonInscribir";
            buttonInscribir.Size = new Size(88, 26);
            buttonInscribir.TabIndex = 10;
            buttonInscribir.Text = "Inscribir";
            buttonInscribir.UseVisualStyleBackColor = true;
            buttonInscribir.Click += btnInscribir;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(492, 349);
            buttonLimpiar.Margin = new Padding(4);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(88, 26);
            buttonLimpiar.TabIndex = 11;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += btnLimpiar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(588, 349);
            buttonCancelar.Margin = new Padding(4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(88, 26);
            buttonCancelar.TabIndex = 12;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += btnCancelar_Click;
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(rbtnOtro);
            grpDatosPersonales.Controls.Add(rbtnFemenino);
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
            grpDatosPersonales.Location = new Point(35, 12);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(313, 309);
            grpDatosPersonales.TabIndex = 13;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos personales";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(181, 186);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(100, 23);
            dtpFechaNac.TabIndex = 8;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(9, 192);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(117, 15);
            lblFechaNac.TabIndex = 9;
            lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // grpDatosContacto
            // 
            grpDatosContacto.Controls.Add(lblTelefono);
            grpDatosContacto.Controls.Add(lblEmail);
            grpDatosContacto.Controls.Add(txtTelefono);
            grpDatosContacto.Controls.Add(txtEmail);
            grpDatosContacto.Location = new Point(384, 179);
            grpDatosContacto.Name = "grpDatosContacto";
            grpDatosContacto.Size = new Size(292, 142);
            grpDatosContacto.TabIndex = 14;
            grpDatosContacto.TabStop = false;
            grpDatosContacto.Text = "Datos de contacto";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(9, 222);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(31, 15);
            lblSexo.TabIndex = 10;
            lblSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(101, 227);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(80, 19);
            rbtnMasculino.TabIndex = 11;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(101, 252);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(78, 19);
            rbtnFemenino.TabIndex = 12;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnOtro
            // 
            rbtnOtro.AutoSize = true;
            rbtnOtro.Location = new Point(101, 277);
            rbtnOtro.Name = "rbtnOtro";
            rbtnOtro.Size = new Size(49, 19);
            rbtnOtro.TabIndex = 13;
            rbtnOtro.TabStop = true;
            rbtnOtro.Text = "Otro";
            rbtnOtro.UseVisualStyleBackColor = true;
            // 
            // InscribirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(713, 396);
            Controls.Add(grpDatosContacto);
            Controls.Add(grpDatosPersonales);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonInscribir);
            Margin = new Padding(4);
            Name = "InscribirCliente";
            RightToLeft = RightToLeft.No;
            Text = "Formulario de Inscripción";
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            grpDatosContacto.ResumeLayout(false);
            grpDatosContacto.PerformLayout();
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
    }
}
