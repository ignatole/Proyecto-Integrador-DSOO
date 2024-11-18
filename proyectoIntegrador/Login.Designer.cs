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
            txtUsuario.Location = new Point(461, 119);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.MaxLength = 30;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 28);
            txtUsuario.TabIndex = 0;
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContra.Location = new Point(297, 193);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(124, 24);
            lblContra.TabIndex = 2;
            lblContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(461, 197);
            txtContra.Margin = new Padding(3, 4, 3, 4);
            txtContra.MaxLength = 15;
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(250, 28);
            txtContra.TabIndex = 3;
            txtContra.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(233, 239, 236);
            btnIngresar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(307, 306);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(279, 67);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // chkMostrarContra
            // 
            chkMostrarContra.AutoSize = true;
            chkMostrarContra.FlatStyle = FlatStyle.Popup;
            chkMostrarContra.Location = new Point(515, 245);
            chkMostrarContra.Name = "chkMostrarContra";
            chkMostrarContra.Size = new Size(173, 25);
            chkMostrarContra.TabIndex = 5;
            chkMostrarContra.Text = "Mostrar contraseña";
            chkMostrarContra.UseVisualStyleBackColor = true;
            chkMostrarContra.CheckedChanged += chkMostrarContra_CheckedChanged;
            // 
            // picLogin
            // 
            picLogin.Location = new Point(27, 58);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(235, 252);
            picLogin.SizeMode = PictureBoxSizeMode.Zoom;
            picLogin.TabIndex = 6;
            picLogin.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(297, 114);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(87, 24);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            ClientSize = new Size(773, 415);
            Controls.Add(lblUsuario);
            Controls.Add(picLogin);
            Controls.Add(chkMostrarContra);
            Controls.Add(btnIngresar);
            Controls.Add(txtContra);
            Controls.Add(lblContra);
            Controls.Add(txtUsuario);
            Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblContra;
        private Button btnIngresar;
        private CheckBox chkMostrarContra;
        private PictureBox picLogin;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private Label lblUsuario;
    }
}
