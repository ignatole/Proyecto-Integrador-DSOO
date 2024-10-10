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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtContra = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(443, 195);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 198);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 279);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(443, 272);
            txtContra.Margin = new Padding(3, 4, 3, 4);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(114, 27);
            txtContra.TabIndex = 3;
            txtContra.UseSystemPasswordChar = true;
            txtContra.TextChanged += txtContra_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(443, 393);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(86, 31);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += BtnIngresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 600);
            Controls.Add(btnIngresar);
            Controls.Add(txtContra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox txtContra;
        private Button btnIngresar;
    }
}
