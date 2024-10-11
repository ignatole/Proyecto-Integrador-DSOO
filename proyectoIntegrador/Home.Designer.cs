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
            SuspendLayout();
            // 
            // btnInscribirCliente
            // 
            btnInscribirCliente.Location = new Point(67, 108);
            btnInscribirCliente.Margin = new Padding(4, 5, 4, 5);
            btnInscribirCliente.Name = "btnInscribirCliente";
            btnInscribirCliente.Size = new Size(267, 62);
            btnInscribirCliente.TabIndex = 0;
            btnInscribirCliente.Text = "Inscribir Cliente";
            btnInscribirCliente.UseVisualStyleBackColor = true;
            btnInscribirCliente.Click += btnInscribirCliente_Click;
            // 
            // btnInscribirActividades
            // 
            btnInscribirActividades.Location = new Point(67, 200);
            btnInscribirActividades.Margin = new Padding(4, 5, 4, 5);
            btnInscribirActividades.Name = "btnInscribirActividades";
            btnInscribirActividades.Size = new Size(267, 62);
            btnInscribirActividades.TabIndex = 1;
            btnInscribirActividades.Text = "Inscribir Actividades";
            btnInscribirActividades.UseVisualStyleBackColor = true;
            btnInscribirActividades.Click += btnInscribirActividades_Click;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(67, 292);
            btnPagos.Margin = new Padding(4, 5, 4, 5);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(267, 62);
            btnPagos.TabIndex = 2;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnListadoVencimientos
            // 
            btnListadoVencimientos.Location = new Point(67, 385);
            btnListadoVencimientos.Margin = new Padding(4, 5, 4, 5);
            btnListadoVencimientos.Name = "btnListadoVencimientos";
            btnListadoVencimientos.Size = new Size(267, 62);
            btnListadoVencimientos.TabIndex = 3;
            btnListadoVencimientos.Text = "Listado de Vencimientos";
            btnListadoVencimientos.UseVisualStyleBackColor = true;
            btnListadoVencimientos.Click += btnListadoVencimientos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(67, 477);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(267, 62);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(60, 31);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(273, 29);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Bienvenido al Sistema";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 585);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(btnListadoVencimientos);
            Controls.Add(btnPagos);
            Controls.Add(btnInscribirActividades);
            Controls.Add(btnInscribirCliente);
            Margin = new Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label labelTitulo;
        private Label lblTitulo;
    }
}
