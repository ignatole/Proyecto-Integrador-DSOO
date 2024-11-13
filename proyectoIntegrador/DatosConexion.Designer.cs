namespace proyectoIntegrador
{
    partial class DatosConexion
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
            lblServidor = new Label();
            lblDb = new Label();
            lblUsuario = new Label();
            lblPass = new Label();
            txtHost = new TextBox();
            txtDb = new TextBox();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnConfirmar = new Button();
            lblTitulo = new Label();
            lblPuerto = new Label();
            txtPuerto = new TextBox();
            SuspendLayout();
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Location = new Point(97, 55);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(50, 15);
            lblServidor.TabIndex = 0;
            lblServidor.Text = "Servidor";
            // 
            // lblDb
            // 
            lblDb.AutoSize = true;
            lblDb.Location = new Point(97, 130);
            lblDb.Name = "lblDb";
            lblDb.Size = new Size(69, 15);
            lblDb.TabIndex = 1;
            lblDb.Text = "Nombre DB";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(97, 169);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(97, 209);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(67, 15);
            lblPass.TabIndex = 3;
            lblPass.Text = "Contraseña";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(192, 47);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(100, 23);
            txtHost.TabIndex = 4;
            // 
            // txtDb
            // 
            txtDb.Location = new Point(192, 122);
            txtDb.Name = "txtDb";
            txtDb.Size = new Size(100, 23);
            txtDb.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(192, 161);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(192, 201);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(117, 251);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(155, 41);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(100, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 25);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Datos para conexión";
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Location = new Point(97, 93);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(42, 15);
            lblPuerto.TabIndex = 10;
            lblPuerto.Text = "Puerto";
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(192, 85);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(100, 23);
            txtPuerto.TabIndex = 11;
            // 
            // DatosConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 304);
            Controls.Add(txtPuerto);
            Controls.Add(lblPuerto);
            Controls.Add(lblTitulo);
            Controls.Add(btnConfirmar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(txtDb);
            Controls.Add(txtHost);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            Controls.Add(lblDb);
            Controls.Add(lblServidor);
            Name = "DatosConexion";
            Text = "DatosConexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServidor;
        private Label lblDb;
        private Label lblUsuario;
        private Label lblPass;
        private TextBox txtHost;
        private TextBox txtDb;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnConfirmar;
        private Label lblTitulo;
        private Label lblPuerto;
        private TextBox txtPuerto;
    }
}