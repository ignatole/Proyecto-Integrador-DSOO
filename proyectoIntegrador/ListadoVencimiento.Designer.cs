namespace proyectoIntegrador
{
    partial class ListadoVencimiento
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
            gridVencimientos = new DataGridView();
            IdCliente = new DataGridViewLinkColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            lblTituloVencimientos = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)gridVencimientos).BeginInit();
            SuspendLayout();
            // 
            // gridVencimientos
            // 
            gridVencimientos.AllowUserToAddRows = false;
            gridVencimientos.AllowUserToDeleteRows = false;
            gridVencimientos.AllowUserToOrderColumns = true;
            gridVencimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridVencimientos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridVencimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVencimientos.Columns.AddRange(new DataGridViewColumn[] { IdCliente, NombreCompleto, Dni, FechaVencimiento });
            gridVencimientos.Location = new Point(14, 94);
            gridVencimientos.Margin = new Padding(3, 4, 3, 4);
            gridVencimientos.Name = "gridVencimientos";
            gridVencimientos.ReadOnly = true;
            gridVencimientos.RowHeadersVisible = false;
            gridVencimientos.RowHeadersWidth = 51;
            gridVencimientos.RowTemplate.Height = 25;
            gridVencimientos.Size = new Size(887, 379);
            gridVencimientos.TabIndex = 0;
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "Nro del socio";
            IdCliente.MinimumWidth = 6;
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // Dni
            // 
            Dni.HeaderText = "Documento";
            Dni.MinimumWidth = 6;
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.HeaderText = "Fecha de vencimiento";
            FechaVencimiento.MinimumWidth = 6;
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.ReadOnly = true;
            // 
            // lblTituloVencimientos
            // 
            lblTituloVencimientos.AutoSize = true;
            lblTituloVencimientos.Location = new Point(346, 35);
            lblTituloVencimientos.Name = "lblTituloVencimientos";
            lblTituloVencimientos.Size = new Size(211, 18);
            lblTituloVencimientos.TabIndex = 1;
            lblTituloVencimientos.Text = "Listado de vencimientos al dia: ";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(233, 239, 236);
            btnVolver.Location = new Point(381, 482);
            btnVolver.Margin = new Padding(5, 4, 5, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(122, 53);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ListadoVencimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            ClientSize = new Size(914, 540);
            Controls.Add(btnVolver);
            Controls.Add(lblTituloVencimientos);
            Controls.Add(gridVencimientos);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListadoVencimiento";
            Text = "Listado de Vencimientos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridVencimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridVencimientos;
        private Label lblTituloVencimientos;
        private DataGridViewLinkColumn IdCliente;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn FechaVencimiento;
        private Button btnVolver;
    }
}