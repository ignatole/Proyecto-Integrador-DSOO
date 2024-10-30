using System;
using System.Windows.Forms;

namespace proyectoIntegrador
{
    partial class Deuda
    {
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
            lblNroDocumento = new Label();
            txtboxNroDeDocumento = new TextBox();
            btnVerDeuda = new Button();
            gridDeudaCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridDeudaCliente).BeginInit();
            SuspendLayout();
            // 
            // lblNroDocumento
            // 
            lblNroDocumento.AutoSize = true;
            lblNroDocumento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroDocumento.Location = new Point(12, 20);
            lblNroDocumento.Margin = new Padding(4, 0, 4, 0);
            lblNroDocumento.Name = "lblNroDocumento";
            lblNroDocumento.Size = new Size(84, 19);
            lblNroDocumento.TabIndex = 0;
            lblNroDocumento.Text = "Documento:";
            // 
            // txtboxNroDeDocumento
            // 
            txtboxNroDeDocumento.Location = new Point(125, 20);
            txtboxNroDeDocumento.Margin = new Padding(4);
            txtboxNroDeDocumento.Name = "txtboxNroDeDocumento";
            txtboxNroDeDocumento.Size = new Size(204, 23);
            txtboxNroDeDocumento.TabIndex = 1;
            // 
            // btnVerDeuda
            // 
            btnVerDeuda.BackColor = Color.FromArgb(233, 239, 236);
            btnVerDeuda.Location = new Point(335, 20);
            btnVerDeuda.Margin = new Padding(4);
            btnVerDeuda.Name = "btnVerDeuda";
            btnVerDeuda.Size = new Size(88, 26);
            btnVerDeuda.TabIndex = 2;
            btnVerDeuda.Text = "Ver deuda";
            btnVerDeuda.UseVisualStyleBackColor = false;
            // 
            // gridDeudaCliente
            // 
            gridDeudaCliente.AllowUserToAddRows = false;
            gridDeudaCliente.AllowUserToDeleteRows = false;
            gridDeudaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDeudaCliente.Location = new Point(0, 53);
            gridDeudaCliente.Name = "gridDeudaCliente";
            gridDeudaCliente.ReadOnly = true;
            gridDeudaCliente.Size = new Size(449, 233);
            gridDeudaCliente.TabIndex = 3;
            // 
            // Deuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 286);
            Controls.Add(gridDeudaCliente);
            Controls.Add(btnVerDeuda);
            Controls.Add(txtboxNroDeDocumento);
            Controls.Add(lblNroDocumento);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Deuda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ver Deuda";
            ((System.ComponentModel.ISupportInitialize)gridDeudaCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.TextBox txtboxNroDeDocumento;
        private System.Windows.Forms.Button btnVerDeuda;
        private System.Windows.Forms.DataGridView gridDeudaCliente;
        private System.Windows.Forms.Button btnCerrar; 
    }
}
