namespace WinFormsApp2.Cliente
{
    partial class FrmCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpConexion = new GroupBox();
            lblIdentificacionCliente = new Label();
            txtIdentificacionCliente = new TextBox();
            btnConectar = new Button();
            btnDesconectar = new Button();
            lblClienteValidado = new Label();
            lblEstadoConexion = new Label();
            groupBox1 = new GroupBox();
            lblSucursal = new Label();
            cmbSucursales = new ComboBox();
            btnConsultarVehiculos = new Button();
            dgvVehiculosDisponibles = new DataGridView();
            btnComprarVehiculo = new Button();
            grpConsultas = new GroupBox();
            btnVerCompras = new Button();
            dgvComprasCliente = new DataGridView();
            grpConexion.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculosDisponibles).BeginInit();
            grpConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComprasCliente).BeginInit();
            SuspendLayout();
            // 
            // grpConexion
            // 
            grpConexion.Controls.Add(lblEstadoConexion);
            grpConexion.Controls.Add(lblClienteValidado);
            grpConexion.Controls.Add(btnDesconectar);
            grpConexion.Controls.Add(btnConectar);
            grpConexion.Controls.Add(txtIdentificacionCliente);
            grpConexion.Controls.Add(lblIdentificacionCliente);
            grpConexion.Location = new Point(45, 36);
            grpConexion.Name = "grpConexion";
            grpConexion.Size = new Size(310, 222);
            grpConexion.TabIndex = 0;
            grpConexion.TabStop = false;
            grpConexion.Text = "Conexión y Validación";
            // 
            // lblIdentificacionCliente
            // 
            lblIdentificacionCliente.AutoSize = true;
            lblIdentificacionCliente.Location = new Point(27, 41);
            lblIdentificacionCliente.Name = "lblIdentificacionCliente";
            lblIdentificacionCliente.Size = new Size(99, 20);
            lblIdentificacionCliente.TabIndex = 0;
            lblIdentificacionCliente.Text = "Identificación";
            // 
            // txtIdentificacionCliente
            // 
            txtIdentificacionCliente.Location = new Point(151, 41);
            txtIdentificacionCliente.Name = "txtIdentificacionCliente";
            txtIdentificacionCliente.Size = new Size(125, 27);
            txtIdentificacionCliente.TabIndex = 1;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(32, 91);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(94, 29);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(151, 91);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(125, 29);
            btnDesconectar.TabIndex = 3;
            btnDesconectar.Text = "Desonectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // lblClienteValidado
            // 
            lblClienteValidado.AutoSize = true;
            lblClienteValidado.Location = new Point(68, 136);
            lblClienteValidado.Name = "lblClienteValidado";
            lblClienteValidado.Size = new Size(141, 20);
            lblClienteValidado.TabIndex = 4;
            lblClienteValidado.Text = "Cliente: no validado";
            // 
            // lblEstadoConexion
            // 
            lblEstadoConexion.AutoSize = true;
            lblEstadoConexion.Location = new Point(68, 173);
            lblEstadoConexion.Name = "lblEstadoConexion";
            lblEstadoConexion.Size = new Size(154, 20);
            lblEstadoConexion.TabIndex = 5;
            lblEstadoConexion.Text = "Estado: desconectado";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnComprarVehiculo);
            groupBox1.Controls.Add(dgvVehiculosDisponibles);
            groupBox1.Controls.Add(btnConsultarVehiculos);
            groupBox1.Controls.Add(cmbSucursales);
            groupBox1.Controls.Add(lblSucursal);
            groupBox1.Location = new Point(45, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(879, 372);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Compra";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(32, 39);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(63, 20);
            lblSucursal.TabIndex = 0;
            lblSucursal.Text = "Sucursal";
            // 
            // cmbSucursales
            // 
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(136, 31);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(151, 28);
            cmbSucursales.TabIndex = 1;
            // 
            // btnConsultarVehiculos
            // 
            btnConsultarVehiculos.Location = new Point(32, 82);
            btnConsultarVehiculos.Name = "btnConsultarVehiculos";
            btnConsultarVehiculos.Size = new Size(170, 29);
            btnConsultarVehiculos.TabIndex = 2;
            btnConsultarVehiculos.Text = "Consultar Vehículos";
            btnConsultarVehiculos.UseVisualStyleBackColor = true;
            // 
            // dgvVehiculosDisponibles
            // 
            dgvVehiculosDisponibles.AllowUserToAddRows = false;
            dgvVehiculosDisponibles.AllowUserToDeleteRows = false;
            dgvVehiculosDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehiculosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculosDisponibles.Location = new Point(32, 130);
            dgvVehiculosDisponibles.Name = "dgvVehiculosDisponibles";
            dgvVehiculosDisponibles.ReadOnly = true;
            dgvVehiculosDisponibles.RowHeadersWidth = 51;
            dgvVehiculosDisponibles.Size = new Size(817, 159);
            dgvVehiculosDisponibles.TabIndex = 3;
            // 
            // btnComprarVehiculo
            // 
            btnComprarVehiculo.Location = new Point(32, 313);
            btnComprarVehiculo.Name = "btnComprarVehiculo";
            btnComprarVehiculo.Size = new Size(170, 29);
            btnComprarVehiculo.TabIndex = 4;
            btnComprarVehiculo.Text = "Comprar Vehículo";
            btnComprarVehiculo.UseVisualStyleBackColor = true;
            // 
            // grpConsultas
            // 
            grpConsultas.Controls.Add(dgvComprasCliente);
            grpConsultas.Controls.Add(btnVerCompras);
            grpConsultas.Location = new Point(382, 36);
            grpConsultas.Name = "grpConsultas";
            grpConsultas.Size = new Size(542, 260);
            grpConsultas.TabIndex = 2;
            grpConsultas.TabStop = false;
            grpConsultas.Text = "Compras Realizadas";
            // 
            // btnVerCompras
            // 
            btnVerCompras.Location = new Point(17, 37);
            btnVerCompras.Name = "btnVerCompras";
            btnVerCompras.Size = new Size(138, 29);
            btnVerCompras.TabIndex = 0;
            btnVerCompras.Text = "Ver Compras";
            btnVerCompras.UseVisualStyleBackColor = true;
            // 
            // dgvComprasCliente
            // 
            dgvComprasCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComprasCliente.Location = new Point(26, 81);
            dgvComprasCliente.Name = "dgvComprasCliente";
            dgvComprasCliente.RowHeadersWidth = 51;
            dgvComprasCliente.Size = new Size(495, 155);
            dgvComprasCliente.TabIndex = 1;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 731);
            Controls.Add(grpConsultas);
            Controls.Add(groupBox1);
            Controls.Add(grpConexion);
            Name = "FrmCliente";
            Text = "Cliente AutoMarket";
            grpConexion.ResumeLayout(false);
            grpConexion.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculosDisponibles).EndInit();
            grpConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComprasCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpConexion;
        private Button btnConectar;
        private TextBox txtIdentificacionCliente;
        private Label lblIdentificacionCliente;
        private Button btnDesconectar;
        private Label lblEstadoConexion;
        private Label lblClienteValidado;
        private GroupBox groupBox1;
        private DataGridView dgvVehiculosDisponibles;
        private Button btnConsultarVehiculos;
        private ComboBox cmbSucursales;
        private Label lblSucursal;
        private Button btnComprarVehiculo;
        private GroupBox grpConsultas;
        private DataGridView dgvComprasCliente;
        private Button btnVerCompras;
    }
}
