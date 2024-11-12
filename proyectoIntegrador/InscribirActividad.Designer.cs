using MySql.Data.MySqlClient;
using proyectoIntegrador.Datos;
using System.Data;

namespace proyectoIntegrador
{
    partial class InscribirActividad
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
            dgvActividades = new DataGridView();
            txtDNI = new TextBox();
            lblDNI = new Label();
            cmbActividades = new ComboBox();
            btnInscribir = new Button();
            btnVolver = new Button();
            lblActividad = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // dgvActividades
            // 
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.AllowUserToDeleteRows = false;
            dgvActividades.AllowUserToOrderColumns = true;
            dgvActividades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActividades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Location = new Point(26, 21);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.ReadOnly = true;
            dgvActividades.RowHeadersVisible = false;
            dgvActividades.RowTemplate.Height = 35;
            dgvActividades.RowTemplate.ReadOnly = true;
            dgvActividades.ScrollBars = ScrollBars.Horizontal;
            dgvActividades.Size = new Size(738, 236);
            dgvActividades.TabIndex = 0;
            dgvActividades.CellContentClick += dgvActividades_CellContentClick;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(83, 307);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(157, 23);
            txtDNI.TabIndex = 1;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(30, 308);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // cmbActividades
            // 
            cmbActividades.FormattingEnabled = true;
            cmbActividades.Location = new Point(358, 308);
            cmbActividades.Name = "cmbActividades";
            cmbActividades.Size = new Size(153, 23);
            cmbActividades.TabIndex = 3;
            // 
            // btnInscribir
            // 
            btnInscribir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscribir.Location = new Point(207, 382);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(130, 45);
            btnInscribir.TabIndex = 4;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(427, 382);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(130, 45);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(270, 310);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(57, 15);
            lblActividad.TabIndex = 6;
            lblActividad.Text = "Actividad";
            // 
            // InscribirActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblActividad);
            Controls.Add(btnVolver);
            Controls.Add(btnInscribir);
            Controls.Add(cmbActividades);
            Controls.Add(lblDNI);
            Controls.Add(txtDNI);
            Controls.Add(dgvActividades);
            Name = "InscribirActividad";
            Text = "InscribirActividad";
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private DataGridView dgvActividades;
        private TextBox txtDNI;
        private Label lblDNI;
        private ComboBox cmbActividades;
        private Button btnInscribir;
        private Button btnVolver;
        private Label lblActividad;
    }
}