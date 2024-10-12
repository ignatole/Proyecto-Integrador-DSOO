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
            txtUsuario.Location = new Point(326, 80);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(196, 23);
            txtUsuario.TabIndex = 0;
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Location = new Point(245, 141);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(67, 15);
            lblContra.TabIndex = 2;
            lblContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(326, 136);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(196, 23);
            txtContra.TabIndex = 3;
            txtContra.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(245, 205);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(217, 48);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // chkMostrarContra
            // 
            chkMostrarContra.AutoSize = true;
            chkMostrarContra.FlatStyle = FlatStyle.Popup;
            chkMostrarContra.Location = new Point(385, 170);
            chkMostrarContra.Margin = new Padding(3, 2, 3, 2);
            chkMostrarContra.Name = "chkMostrarContra";
            chkMostrarContra.Size = new Size(126, 19);
            chkMostrarContra.TabIndex = 5;
            chkMostrarContra.Text = "Mostrar contraseña";
            chkMostrarContra.UseVisualStyleBackColor = true;
            chkMostrarContra.CheckedChanged += chkMostrarContra_CheckedChanged;
            // 
            // picLogin
            // 
            picLogin.Location = new Point(21, 41);
            picLogin.Margin = new Padding(3, 2, 3, 2);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(183, 180);
            picLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogin.TabIndex = 6;
            picLogin.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(245, 82);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 296);
            Controls.Add(lblUsuario);
            Controls.Add(picLogin);
            Controls.Add(chkMostrarContra);
            Controls.Add(btnIngresar);
            Controls.Add(txtContra);
            Controls.Add(lblContra);
            Controls.Add(txtUsuario);
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
