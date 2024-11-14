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
            gridVencimientos.Location = new Point(12, 78);
            gridVencimientos.Name = "gridVencimientos";
            gridVencimientos.ReadOnly = true;
            gridVencimientos.RowHeadersVisible = false;
            gridVencimientos.RowTemplate.Height = 25;
            gridVencimientos.Size = new Size(776, 316);
            gridVencimientos.TabIndex = 0;
            gridVencimientos.CellContentClick += gridVencimientos_CellContentClick;
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "Nro del socio";
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // Dni
            // 
            Dni.HeaderText = "Documento";
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.HeaderText = "Fecha de vencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.ReadOnly = true;
            // 
            // lblTituloVencimientos
            // 
            lblTituloVencimientos.AutoSize = true;
            lblTituloVencimientos.Location = new Point(303, 29);
            lblTituloVencimientos.Name = "lblTituloVencimientos";
            lblTituloVencimientos.Size = new Size(172, 15);
            lblTituloVencimientos.TabIndex = 1;
            lblTituloVencimientos.Text = "Listado de vencimientos al dia: ";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(233, 239, 236);
            btnVolver.Location = new Point(333, 401);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 44);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ListadoVencimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblTituloVencimientos);
            Controls.Add(gridVencimientos);
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