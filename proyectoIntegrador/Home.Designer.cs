using System;
using System.Windows.Forms;

namespace proyectoIntegrador
{
    partial class Home : Form
    {
        /// <summary>
        /// Variable que controla si los componentes se han desinfectado.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpia los recursos que esté utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos se deben eliminar; de lo contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Requerido por el Diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            btnInscribirCliente = new Button();
            btnInscribirActividades = new Button();
            btnPagos = new Button();
            btnListadoVencimientos = new Button();
            btnSalir = new Button();
            lblTitulo = new Label();
            btnCarnet = new Button();
            SuspendLayout();
            // 
            // btnInscribirCliente
            // 
            btnInscribirCliente.BackColor = Color.FromArgb(233, 239, 236);
            btnInscribirCliente.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribirCliente.Location = new Point(100, 160);
            btnInscribirCliente.Margin = new Padding(6, 5, 6, 5);
            btnInscribirCliente.Name = "btnInscribirCliente";
            btnInscribirCliente.Size = new Size(316, 98);
            btnInscribirCliente.TabIndex = 0;
            btnInscribirCliente.Text = "Inscribir Cliente";
            btnInscribirCliente.UseVisualStyleBackColor = false;
            btnInscribirCliente.Click += btnInscribirCliente_Click;
            // 
            // btnInscribirActividades
            // 
            btnInscribirActividades.BackColor = Color.FromArgb(233, 239, 236);
            btnInscribirActividades.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribirActividades.Location = new Point(540, 160);
            btnInscribirActividades.Margin = new Padding(6, 5, 6, 5);
            btnInscribirActividades.Name = "btnInscribirActividades";
            btnInscribirActividades.Size = new Size(314, 98);
            btnInscribirActividades.TabIndex = 3;
            btnInscribirActividades.Text = "Inscribir Actividades";
            btnInscribirActividades.UseVisualStyleBackColor = false;
            btnInscribirActividades.Click += btnInscribirActividades_Click;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.FromArgb(233, 239, 236);
            btnPagos.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagos.Location = new Point(100, 320);
            btnPagos.Margin = new Padding(6, 5, 6, 5);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(316, 105);
            btnPagos.TabIndex = 1;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnListadoVencimientos
            // 
            btnListadoVencimientos.BackColor = Color.FromArgb(233, 239, 236);
            btnListadoVencimientos.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListadoVencimientos.Location = new Point(540, 320);
            btnListadoVencimientos.Margin = new Padding(6, 5, 6, 5);
            btnListadoVencimientos.Name = "btnListadoVencimientos";
            btnListadoVencimientos.Size = new Size(314, 105);
            btnListadoVencimientos.TabIndex = 4;
            btnListadoVencimientos.Text = "Listado de Vencimientos";
            btnListadoVencimientos.UseVisualStyleBackColor = false;
            btnListadoVencimientos.Click += btnListadoVencimientos_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(233, 239, 236);
            btnSalir.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(554, 496);
            btnSalir.Margin = new Padding(6, 5, 6, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(300, 64);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(322, 47);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(302, 31);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Bienvenido al Sistema";
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = Color.FromArgb(233, 239, 236);
            btnCarnet.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarnet.Location = new Point(100, 496);
            btnCarnet.Margin = new Padding(6, 5, 6, 5);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(316, 64);
            btnCarnet.TabIndex = 2;
            btnCarnet.Text = "Carnet";
            btnCarnet.UseVisualStyleBackColor = false;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            ClientSize = new Size(956, 614);
            Controls.Add(btnCarnet);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(btnListadoVencimientos);
            Controls.Add(btnPagos);
            Controls.Add(btnInscribirActividades);
            Controls.Add(btnInscribirCliente);
            Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Home";
            Text = "Ventana Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnInscribirCliente;
        private System.Windows.Forms.Button btnInscribirActividades;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnListadoVencimientos;
        private System.Windows.Forms.Button btnSalir;
        private Label lblTitulo;
        private Button btnCarnet;
    }
}
