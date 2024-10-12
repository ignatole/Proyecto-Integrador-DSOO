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
            this.btnInscribirCliente = new System.Windows.Forms.Button();
            this.btnInscribirActividades = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnListadoVencimientos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInscribirCliente
            // 
            this.btnInscribirCliente.Location = new System.Drawing.Point(50, 70);
            this.btnInscribirCliente.Name = "btnInscribirCliente";
            this.btnInscribirCliente.Size = new System.Drawing.Size(200, 40);
            this.btnInscribirCliente.TabIndex = 0;
            this.btnInscribirCliente.Text = "Inscribir Cliente";
            this.btnInscribirCliente.UseVisualStyleBackColor = true;
            this.btnInscribirCliente.Click += new System.EventHandler(this.btnInscribirCliente_Click);
            // 
            // btnInscribirActividades
            // 
            this.btnInscribirActividades.Location = new System.Drawing.Point(50, 130);
            this.btnInscribirActividades.Name = "btnInscribirActividades";
            this.btnInscribirActividades.Size = new System.Drawing.Size(200, 40);
            this.btnInscribirActividades.TabIndex = 1;
            this.btnInscribirActividades.Text = "Inscribir Actividades";
            this.btnInscribirActividades.UseVisualStyleBackColor = true;
            this.btnInscribirActividades.Click += new System.EventHandler(this.btnInscribirActividades_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Location = new System.Drawing.Point(50, 190);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(200, 40);
            this.btnPagos.TabIndex = 2;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnListadoVencimientos
            // 
            this.btnListadoVencimientos.Location = new System.Drawing.Point(50, 250);
            this.btnListadoVencimientos.Name = "btnListadoVencimientos";
            this.btnListadoVencimientos.Size = new System.Drawing.Size(200, 40);
            this.btnListadoVencimientos.TabIndex = 3;
            this.btnListadoVencimientos.Text = "Listado de Vencimientos";
            this.btnListadoVencimientos.UseVisualStyleBackColor = true;
            this.btnListadoVencimientos.Click += new System.EventHandler(this.btnListadoVencimientos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(50, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(45, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(215, 24);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Bienvenido al Sistema";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 380);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListadoVencimientos);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnInscribirActividades);
            this.Controls.Add(this.btnInscribirCliente);
            this.Name = "VentanaPrincipal";
            this.Text = "Ventana Principal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnInscribirCliente;
        private System.Windows.Forms.Button btnInscribirActividades;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnListadoVencimientos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labelTitulo;
    }
}
