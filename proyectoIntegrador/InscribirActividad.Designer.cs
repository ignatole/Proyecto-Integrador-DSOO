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
            dgvActividades.Location = new Point(34, 29);
            dgvActividades.Margin = new Padding(3, 5, 3, 5);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.ReadOnly = true;
            dgvActividades.RowHeadersVisible = false;
            dgvActividades.RowHeadersWidth = 51;
            dgvActividades.RowTemplate.Height = 35;
            dgvActividades.RowTemplate.ReadOnly = true;
            dgvActividades.ScrollBars = ScrollBars.Horizontal;
            dgvActividades.Size = new Size(948, 331);
            dgvActividades.TabIndex = 6;
            dgvActividades.CellContentClick += dgvActividades_CellContentClick;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(134, 425);
            txtDNI.Margin = new Padding(3, 5, 3, 5);
            txtDNI.MaxLength = 20;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(201, 28);
            txtDNI.TabIndex = 0;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.Location = new Point(61, 430);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(43, 23);
            lblDNI.TabIndex = 4;
            lblDNI.Text = "DNI";
            // 
            // cmbActividades
            // 
            cmbActividades.FormattingEnabled = true;
            cmbActividades.Location = new Point(771, 424);
            cmbActividades.Margin = new Padding(3, 5, 3, 5);
            cmbActividades.Name = "cmbActividades";
            cmbActividades.Size = new Size(195, 29);
            cmbActividades.TabIndex = 1;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.FromArgb(233, 239, 236);
            btnInscribir.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscribir.Location = new Point(249, 534);
            btnInscribir.Margin = new Padding(3, 5, 3, 5);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(168, 63);
            btnInscribir.TabIndex = 2;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(233, 239, 236);
            btnVolver.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(621, 534);
            btnVolver.Margin = new Padding(3, 5, 3, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(168, 63);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblActividad.Location = new Point(621, 432);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(85, 23);
            lblActividad.TabIndex = 5;
            lblActividad.Text = "Actividad";
            // 
            // InscribirActividad
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            ClientSize = new Size(1028, 630);
            Controls.Add(lblActividad);
            Controls.Add(btnVolver);
            Controls.Add(btnInscribir);
            Controls.Add(cmbActividades);
            Controls.Add(lblDNI);
            Controls.Add(txtDNI);
            Controls.Add(dgvActividades);
            Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 5, 3, 5);
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