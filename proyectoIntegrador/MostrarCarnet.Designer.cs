namespace proyectoIntegrador
{
    partial class MostrarCarnet
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
            grpDatosPersonales = new GroupBox();
            lblId_Cliente = new Label();
            lblFNacCarnet = new Label();
            lblNombreCarnet = new Label();
            lblApellidoCarnet = new Label();
            lblDniCarnet = new Label();
            lblNroSocioCarnet = new Label();
            lblFechaNac = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblTitulo = new Label();
            txtNroCliente = new TextBox();
            btnVolver = new Button();
            btnLimpiar = new Button();
            btnImprimir = new Button();
            btnBuscar = new Button();
            grpDatosPersonales.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(lblId_Cliente);
            grpDatosPersonales.Controls.Add(lblFNacCarnet);
            grpDatosPersonales.Controls.Add(lblNombreCarnet);
            grpDatosPersonales.Controls.Add(lblApellidoCarnet);
            grpDatosPersonales.Controls.Add(lblDniCarnet);
            grpDatosPersonales.Controls.Add(lblNroSocioCarnet);
            grpDatosPersonales.Controls.Add(lblFechaNac);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Controls.Add(lblApellido);
            grpDatosPersonales.Controls.Add(lblDNI);
            grpDatosPersonales.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpDatosPersonales.Location = new Point(240, 133);
            grpDatosPersonales.Margin = new Padding(3, 5, 3, 5);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Padding = new Padding(3, 5, 3, 5);
            grpDatosPersonales.Size = new Size(565, 383);
            grpDatosPersonales.TabIndex = 14;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos personales";
            // 
            // lblId_Cliente
            // 
            lblId_Cliente.AutoSize = true;
            lblId_Cliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblId_Cliente.Location = new Point(332, 68);
            lblId_Cliente.Margin = new Padding(6, 0, 6, 0);
            lblId_Cliente.Name = "lblId_Cliente";
            lblId_Cliente.Size = new Size(0, 23);
            lblId_Cliente.TabIndex = 15;
            // 
            // lblFNacCarnet
            // 
            lblFNacCarnet.AutoSize = true;
            lblFNacCarnet.Location = new Point(9, 310);
            lblFNacCarnet.Name = "lblFNacCarnet";
            lblFNacCarnet.Size = new Size(163, 21);
            lblFNacCarnet.TabIndex = 14;
            lblFNacCarnet.Text = "Fecha de nacimiento";
            // 
            // lblNombreCarnet
            // 
            lblNombreCarnet.AutoSize = true;
            lblNombreCarnet.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreCarnet.Location = new Point(9, 125);
            lblNombreCarnet.Margin = new Padding(6, 0, 6, 0);
            lblNombreCarnet.Name = "lblNombreCarnet";
            lblNombreCarnet.Size = new Size(68, 21);
            lblNombreCarnet.TabIndex = 11;
            lblNombreCarnet.Text = "Nombre";
            // 
            // lblApellidoCarnet
            // 
            lblApellidoCarnet.AutoSize = true;
            lblApellidoCarnet.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellidoCarnet.Location = new Point(9, 188);
            lblApellidoCarnet.Margin = new Padding(6, 0, 6, 0);
            lblApellidoCarnet.Name = "lblApellidoCarnet";
            lblApellidoCarnet.Size = new Size(69, 21);
            lblApellidoCarnet.TabIndex = 12;
            lblApellidoCarnet.Text = "Apellido";
            // 
            // lblDniCarnet
            // 
            lblDniCarnet.AutoSize = true;
            lblDniCarnet.Location = new Point(9, 247);
            lblDniCarnet.Margin = new Padding(6, 0, 6, 0);
            lblDniCarnet.Name = "lblDniCarnet";
            lblDniCarnet.Size = new Size(39, 21);
            lblDniCarnet.TabIndex = 13;
            lblDniCarnet.Text = "DNI";
            // 
            // lblNroSocioCarnet
            // 
            lblNroSocioCarnet.AutoSize = true;
            lblNroSocioCarnet.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroSocioCarnet.Location = new Point(9, 68);
            lblNroSocioCarnet.Margin = new Padding(6, 0, 6, 0);
            lblNroSocioCarnet.Name = "lblNroSocioCarnet";
            lblNroSocioCarnet.Size = new Size(103, 21);
            lblNroSocioCarnet.TabIndex = 10;
            lblNroSocioCarnet.Text = "Nro de Socio";
            
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(333, 310);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(0, 21);
            lblFechaNac.TabIndex = 9;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(333, 125);
            lblNombre.Margin = new Padding(6, 0, 6, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 23);
            lblNombre.TabIndex = 0;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(333, 188);
            lblApellido.Margin = new Padding(6, 0, 6, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(0, 23);
            lblApellido.TabIndex = 1;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(333, 247);
            lblDNI.Margin = new Padding(6, 0, 6, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(0, 21);
            lblDNI.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(81, 56);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(307, 21);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Ingrese número de documento del socio";
            // 
            // txtNroCliente
            // 
            txtNroCliente.Location = new Point(443, 56);
            txtNroCliente.Margin = new Padding(6, 5, 6, 5);
            txtNroCliente.MaxLength = 20;
            txtNroCliente.Name = "txtNroCliente";
            txtNroCliente.Size = new Size(275, 28);
            txtNroCliente.TabIndex = 16;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(233, 239, 236);
            btnVolver.Location = new Point(762, 526);
            btnVolver.Margin = new Padding(6, 5, 6, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(174, 50);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(233, 239, 236);
            btnLimpiar.Location = new Point(117, 526);
            btnLimpiar.Margin = new Padding(6, 5, 6, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(171, 50);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(233, 239, 236);
            btnImprimir.Location = new Point(443, 526);
            btnImprimir.Margin = new Padding(6, 5, 6, 5);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(165, 50);
            btnImprimir.TabIndex = 17;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(233, 239, 236);
            btnBuscar.Location = new Point(762, 50);
            btnBuscar.Margin = new Padding(6, 5, 6, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(155, 38);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // MostrarCarnet
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            ClientSize = new Size(1028, 630);
            Controls.Add(btnBuscar);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnImprimir);
            Controls.Add(lblTitulo);
            Controls.Add(txtNroCliente);
            Controls.Add(grpDatosPersonales);
            Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 5, 3, 5);
            Name = "MostrarCarnet";
            Text = "Carnet";
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatosPersonales;
        private Label lblFechaNac;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblTitulo;
        private TextBox txtNroCliente;
        private Button btnVolver;
        private Button btnLimpiar;
        private Button btnImprimir;
        private Label lblNroSocioCarnet;
        private Label lblId_Cliente;
        private Label lblFNacCarnet;
        private Label lblNombreCarnet;
        private Label lblApellidoCarnet;
        private Label lblDniCarnet;
        private Button btnBuscar;
    }
}