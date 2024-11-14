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
            lblServidor.Location = new Point(125, 77);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(70, 21);
            lblServidor.TabIndex = 0;
            lblServidor.Text = "Servidor";
            // 
            // lblDb
            // 
            lblDb.AutoSize = true;
            lblDb.Location = new Point(125, 182);
            lblDb.Name = "lblDb";
            lblDb.Size = new Size(95, 21);
            lblDb.TabIndex = 2;
            lblDb.Text = "Nombre DB";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(125, 236);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 21);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(125, 293);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(94, 21);
            lblPass.TabIndex = 4;
            lblPass.Text = "Contraseña";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(246, 66);
            txtHost.Margin = new Padding(3, 5, 3, 5);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(128, 28);
            txtHost.TabIndex = 0;
            // 
            // txtDb
            // 
            txtDb.Location = new Point(246, 172);
            txtDb.Margin = new Padding(3, 5, 3, 5);
            txtDb.Name = "txtDb";
            txtDb.Size = new Size(128, 28);
            txtDb.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(246, 226);
            txtUsuario.Margin = new Padding(3, 5, 3, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(128, 28);
            txtUsuario.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(246, 281);
            txtPass.Margin = new Padding(3, 5, 3, 5);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(128, 28);
            txtPass.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(233, 239, 236);
            btnConfirmar.Location = new Point(151, 352);
            btnConfirmar.Margin = new Padding(3, 5, 3, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(199, 58);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(151, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(231, 29);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Datos para conexión";
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Location = new Point(125, 131);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(58, 21);
            lblPuerto.TabIndex = 1;
            lblPuerto.Text = "Puerto";
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(246, 119);
            txtPuerto.Margin = new Padding(3, 5, 3, 5);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(128, 28);
            txtPuerto.TabIndex = 1;
            // 
            // DatosConexion
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            ClientSize = new Size(528, 425);
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
            Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 5, 3, 5);
            Name = "DatosConexion";
            RightToLeftLayout = true;
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