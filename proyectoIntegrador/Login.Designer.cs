using System;
using System.Windows.Forms;

namespace proyectoIntegrador
{
    partial class Login : Form
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
            txtUsuario = new TextBox();
            lblContra = new Label();
            txtContra = new TextBox();
            btnIngresar = new Button();
            chkMostrarContra = new CheckBox();
            picLogin = new PictureBox();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(410, 113);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(223, 27);
            txtUsuario.TabIndex = 0;
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContra.Location = new Point(264, 184);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(118, 28);
            lblContra.TabIndex = 2;
            lblContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(410, 188);
            txtContra.Margin = new Padding(3, 4, 3, 4);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(223, 27);
            txtContra.TabIndex = 3;
            txtContra.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(233, 239, 236);
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(273, 291);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(248, 64);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // chkMostrarContra
            // 
            chkMostrarContra.AutoSize = true;
            chkMostrarContra.FlatStyle = FlatStyle.Popup;
            chkMostrarContra.Location = new Point(458, 233);
            chkMostrarContra.Name = "chkMostrarContra";
            chkMostrarContra.Size = new Size(155, 24);
            chkMostrarContra.TabIndex = 5;
            chkMostrarContra.Text = "Mostrar contraseña";
            chkMostrarContra.UseVisualStyleBackColor = true;
            chkMostrarContra.CheckedChanged += chkMostrarContra_CheckedChanged;
            // 
            // picLogin
            // 
            picLogin.Location = new Point(24, 55);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(209, 240);
            picLogin.SizeMode = PictureBoxSizeMode.Zoom;
            picLogin.TabIndex = 6;
            picLogin.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(264, 109);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 28);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            ClientSize = new Size(687, 395);
            Controls.Add(lblUsuario);
            Controls.Add(picLogin);
            Controls.Add(chkMostrarContra);
            Controls.Add(btnIngresar);
            Controls.Add(txtContra);
            Controls.Add(lblContra);
            Controls.Add(txtUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
        private Label label1;
        private Label lblContra;
        private TextBox textBox2;
        private Button btnIngresar;
        private CheckBox chkMostrarContra;
        private PictureBox picLogin;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private Label lblUsuario;
    }
}
