namespace WinFormsApp2.Servidor
{
    partial class FrmServidor
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
            label1 = new Label();
            btnIniciarServidor = new Button();
            btnDetenerServidor = new Button();
            lblEstadoServidor = new Label();
            txtBitacora = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            lblIdCategoria = new Label();
            txtIdCategoria = new TextBox();
            txtNombreCategoria = new TextBox();
            lblNombreCategoria = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            btbAgregarCategoria = new Button();
            dgvCategorias = new DataGridView();
            btnMostrarCategorias = new Button();
            lblIdVehiculo = new Label();
            txtIdVehiculo = new TextBox();
            txtMarcaVehiculo = new TextBox();
            lblMarcaVehiculo = new Label();
            txtModeloVehiculo = new TextBox();
            lblModeloVehiculo = new Label();
            lblAnioVehiculo = new Label();
            txtAnioVehiculo = new TextBox();
            txtPrecioVehiculo = new TextBox();
            lblPrecioVehiculo = new Label();
            lblCategoríaVehículo = new Label();
            cmbCategoriaVehiculo = new ComboBox();
            cmbEstadoVehiculo = new ComboBox();
            lblEstadoVehiculo = new Label();
            btnAgregarVehiculo = new Button();
            dgvVehiculos = new DataGridView();
            btnMostrarVehiculos = new Button();
            lblIdVendedor = new Label();
            txtIdVendedor = new TextBox();
            txtIdentificacionVendedor = new TextBox();
            lblIdentificaciónVendedor = new Label();
            txtNombreVendedor = new TextBox();
            lblNombreVendedor = new Label();
            lblFechaNacimientoVendedor = new Label();
            lblFechaIngresoVendedor = new Label();
            txtTelefonoVendedor = new TextBox();
            lblTelefonoVendedor = new Label();
            btnAgregarVendedor = new Button();
            dtpFechaNacimientoVendedor = new DateTimePicker();
            dtpFechaIngresoVendedor = new DateTimePicker();
            dgvVendedores = new DataGridView();
            btnMostrarVendedores = new Button();
            lblIdSucursal = new Label();
            txtIdSucursal = new TextBox();
            txtNombreSucursal = new TextBox();
            lblNombreSucursal = new Label();
            txtDireccionSucursal = new TextBox();
            lblDireccionSucursal = new Label();
            txtTelefonoSucursal = new TextBox();
            lblTelefonoSucursal = new Label();
            lblVendedorEncargado = new Label();
            lblSucursalActiva = new Label();
            cmbVendedorSucursal = new ComboBox();
            chkSucursalActiva = new CheckBox();
            btnAgregarSucursal = new Button();
            btnMostrarSucursales = new Button();
            dgvSucursales = new DataGridView();
            btnMostrarClientes = new Button();
            dgvClientes = new DataGridView();
            dtpFechaRegistroCliente = new DateTimePicker();
            dtpFechaNacimientoCliente = new DateTimePicker();
            btnAgregarCliente = new Button();
            lblClienteActivo = new Label();
            lblFechaRegistro = new Label();
            lblFechaNacimientoCliente = new Label();
            txtNombreCliente = new TextBox();
            lblNombreCliente = new Label();
            txtIdentificacionCliente = new TextBox();
            lblIdentificacionCliente = new Label();
            txtIdCliente = new TextBox();
            lblIdCliente = new Label();
            chkClienteActivo = new CheckBox();
            lblSucursalVxS = new Label();
            cmbSucursalVxS = new ComboBox();
            cmbVehiculoVxS = new ComboBox();
            lblVehiculoVxS = new Label();
            lblCantidadVxS = new Label();
            txtCantidadVxS = new TextBox();
            btnAgregarVxS = new Button();
            dgvVehiculosxSucursal = new DataGridView();
            btnMostrarVxS = new Button();
            btnMostrarVentas = new Button();
            dgvVentas = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculosxSucursal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 39);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Servidor TCP";
            // 
            // btnIniciarServidor
            // 
            btnIniciarServidor.Location = new Point(258, 30);
            btnIniciarServidor.Name = "btnIniciarServidor";
            btnIniciarServidor.Size = new Size(179, 29);
            btnIniciarServidor.TabIndex = 1;
            btnIniciarServidor.Text = "Iniciar Servidor";
            btnIniciarServidor.UseVisualStyleBackColor = true;
            // 
            // btnDetenerServidor
            // 
            btnDetenerServidor.Location = new Point(514, 30);
            btnDetenerServidor.Name = "btnDetenerServidor";
            btnDetenerServidor.Size = new Size(174, 29);
            btnDetenerServidor.TabIndex = 2;
            btnDetenerServidor.Text = "Detener Servidor";
            btnDetenerServidor.UseVisualStyleBackColor = true;
            // 
            // lblEstadoServidor
            // 
            lblEstadoServidor.AutoSize = true;
            lblEstadoServidor.Location = new Point(797, 34);
            lblEstadoServidor.Name = "lblEstadoServidor";
            lblEstadoServidor.Size = new Size(123, 20);
            lblEstadoServidor.TabIndex = 3;
            lblEstadoServidor.Text = "Estado: Detenido";
            // 
            // txtBitacora
            // 
            txtBitacora.Location = new Point(69, 102);
            txtBitacora.Multiline = true;
            txtBitacora.Name = "txtBitacora";
            txtBitacora.ReadOnly = true;
            txtBitacora.ScrollBars = ScrollBars.Vertical;
            txtBitacora.Size = new Size(895, 110);
            txtBitacora.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Location = new Point(69, 238);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1208, 423);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnMostrarCategorias);
            tabPage1.Controls.Add(dgvCategorias);
            tabPage1.Controls.Add(btbAgregarCategoria);
            tabPage1.Controls.Add(txtDescripcion);
            tabPage1.Controls.Add(lblDescripcion);
            tabPage1.Controls.Add(txtNombreCategoria);
            tabPage1.Controls.Add(lblNombreCategoria);
            tabPage1.Controls.Add(txtIdCategoria);
            tabPage1.Controls.Add(lblIdCategoria);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1200, 390);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Categorías";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnMostrarVehiculos);
            tabPage2.Controls.Add(dgvVehiculos);
            tabPage2.Controls.Add(btnAgregarVehiculo);
            tabPage2.Controls.Add(cmbEstadoVehiculo);
            tabPage2.Controls.Add(lblEstadoVehiculo);
            tabPage2.Controls.Add(cmbCategoriaVehiculo);
            tabPage2.Controls.Add(lblCategoríaVehículo);
            tabPage2.Controls.Add(txtPrecioVehiculo);
            tabPage2.Controls.Add(lblPrecioVehiculo);
            tabPage2.Controls.Add(txtAnioVehiculo);
            tabPage2.Controls.Add(lblAnioVehiculo);
            tabPage2.Controls.Add(txtModeloVehiculo);
            tabPage2.Controls.Add(lblModeloVehiculo);
            tabPage2.Controls.Add(txtMarcaVehiculo);
            tabPage2.Controls.Add(lblMarcaVehiculo);
            tabPage2.Controls.Add(txtIdVehiculo);
            tabPage2.Controls.Add(lblIdVehiculo);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1200, 390);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vehículos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnMostrarVendedores);
            tabPage3.Controls.Add(dgvVendedores);
            tabPage3.Controls.Add(dtpFechaIngresoVendedor);
            tabPage3.Controls.Add(dtpFechaNacimientoVendedor);
            tabPage3.Controls.Add(btnAgregarVendedor);
            tabPage3.Controls.Add(txtTelefonoVendedor);
            tabPage3.Controls.Add(lblTelefonoVendedor);
            tabPage3.Controls.Add(lblFechaIngresoVendedor);
            tabPage3.Controls.Add(lblFechaNacimientoVendedor);
            tabPage3.Controls.Add(txtNombreVendedor);
            tabPage3.Controls.Add(lblNombreVendedor);
            tabPage3.Controls.Add(txtIdentificacionVendedor);
            tabPage3.Controls.Add(lblIdentificaciónVendedor);
            tabPage3.Controls.Add(txtIdVendedor);
            tabPage3.Controls.Add(lblIdVendedor);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1200, 390);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Vendedores";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvSucursales);
            tabPage4.Controls.Add(btnMostrarSucursales);
            tabPage4.Controls.Add(btnAgregarSucursal);
            tabPage4.Controls.Add(chkSucursalActiva);
            tabPage4.Controls.Add(cmbVendedorSucursal);
            tabPage4.Controls.Add(lblSucursalActiva);
            tabPage4.Controls.Add(lblVendedorEncargado);
            tabPage4.Controls.Add(txtTelefonoSucursal);
            tabPage4.Controls.Add(lblTelefonoSucursal);
            tabPage4.Controls.Add(txtDireccionSucursal);
            tabPage4.Controls.Add(lblDireccionSucursal);
            tabPage4.Controls.Add(txtNombreSucursal);
            tabPage4.Controls.Add(lblNombreSucursal);
            tabPage4.Controls.Add(txtIdSucursal);
            tabPage4.Controls.Add(lblIdSucursal);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1200, 390);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Sucursales";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(chkClienteActivo);
            tabPage5.Controls.Add(btnMostrarClientes);
            tabPage5.Controls.Add(dgvClientes);
            tabPage5.Controls.Add(dtpFechaRegistroCliente);
            tabPage5.Controls.Add(dtpFechaNacimientoCliente);
            tabPage5.Controls.Add(btnAgregarCliente);
            tabPage5.Controls.Add(lblClienteActivo);
            tabPage5.Controls.Add(lblFechaRegistro);
            tabPage5.Controls.Add(lblFechaNacimientoCliente);
            tabPage5.Controls.Add(txtNombreCliente);
            tabPage5.Controls.Add(lblNombreCliente);
            tabPage5.Controls.Add(txtIdentificacionCliente);
            tabPage5.Controls.Add(lblIdentificacionCliente);
            tabPage5.Controls.Add(txtIdCliente);
            tabPage5.Controls.Add(lblIdCliente);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1200, 390);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Clientes";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(btnMostrarVxS);
            tabPage6.Controls.Add(dgvVehiculosxSucursal);
            tabPage6.Controls.Add(btnAgregarVxS);
            tabPage6.Controls.Add(txtCantidadVxS);
            tabPage6.Controls.Add(lblCantidadVxS);
            tabPage6.Controls.Add(cmbVehiculoVxS);
            tabPage6.Controls.Add(lblVehiculoVxS);
            tabPage6.Controls.Add(cmbSucursalVxS);
            tabPage6.Controls.Add(lblSucursalVxS);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1200, 390);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Vehículo x Sucursal";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(dgvVentas);
            tabPage7.Controls.Add(btnMostrarVentas);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1200, 390);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Ventas";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // lblIdCategoria
            // 
            lblIdCategoria.AutoSize = true;
            lblIdCategoria.Location = new Point(24, 32);
            lblIdCategoria.Name = "lblIdCategoria";
            lblIdCategoria.Size = new Size(91, 20);
            lblIdCategoria.TabIndex = 0;
            lblIdCategoria.Text = "Id Categoría";
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(121, 25);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(125, 27);
            txtIdCategoria.TabIndex = 1;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(411, 25);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(125, 27);
            txtNombreCategoria.TabIndex = 3;
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Location = new Point(272, 32);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(133, 20);
            lblNombreCategoria.TabIndex = 2;
            lblNombreCategoria.Text = "Nombre Categoría";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(668, 25);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(198, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(565, 32);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción";
            // 
            // btbAgregarCategoria
            // 
            btbAgregarCategoria.Location = new Point(956, 28);
            btbAgregarCategoria.Name = "btbAgregarCategoria";
            btbAgregarCategoria.Size = new Size(173, 29);
            btbAgregarCategoria.TabIndex = 6;
            btbAgregarCategoria.Text = "Agregar Categoría";
            btbAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(24, 80);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(1105, 233);
            dgvCategorias.TabIndex = 7;
            // 
            // btnMostrarCategorias
            // 
            btnMostrarCategorias.Location = new Point(479, 335);
            btnMostrarCategorias.Name = "btnMostrarCategorias";
            btnMostrarCategorias.Size = new Size(173, 29);
            btnMostrarCategorias.TabIndex = 8;
            btnMostrarCategorias.Text = "Mostrar Categorias";
            btnMostrarCategorias.UseVisualStyleBackColor = true;
            // 
            // lblIdVehiculo
            // 
            lblIdVehiculo.AutoSize = true;
            lblIdVehiculo.Location = new Point(39, 13);
            lblIdVehiculo.Name = "lblIdVehiculo";
            lblIdVehiculo.Size = new Size(82, 20);
            lblIdVehiculo.TabIndex = 0;
            lblIdVehiculo.Text = "Id Vehículo";
            // 
            // txtIdVehiculo
            // 
            txtIdVehiculo.Location = new Point(155, 6);
            txtIdVehiculo.Name = "txtIdVehiculo";
            txtIdVehiculo.Size = new Size(125, 27);
            txtIdVehiculo.TabIndex = 1;
            // 
            // txtMarcaVehiculo
            // 
            txtMarcaVehiculo.Location = new Point(155, 53);
            txtMarcaVehiculo.Name = "txtMarcaVehiculo";
            txtMarcaVehiculo.Size = new Size(125, 27);
            txtMarcaVehiculo.TabIndex = 3;
            // 
            // lblMarcaVehiculo
            // 
            lblMarcaVehiculo.AutoSize = true;
            lblMarcaVehiculo.Location = new Point(39, 60);
            lblMarcaVehiculo.Name = "lblMarcaVehiculo";
            lblMarcaVehiculo.Size = new Size(50, 20);
            lblMarcaVehiculo.TabIndex = 2;
            lblMarcaVehiculo.Text = "Marca";
            // 
            // txtModeloVehiculo
            // 
            txtModeloVehiculo.Location = new Point(155, 92);
            txtModeloVehiculo.Name = "txtModeloVehiculo";
            txtModeloVehiculo.Size = new Size(125, 27);
            txtModeloVehiculo.TabIndex = 5;
            // 
            // lblModeloVehiculo
            // 
            lblModeloVehiculo.AutoSize = true;
            lblModeloVehiculo.Location = new Point(39, 99);
            lblModeloVehiculo.Name = "lblModeloVehiculo";
            lblModeloVehiculo.Size = new Size(61, 20);
            lblModeloVehiculo.TabIndex = 4;
            lblModeloVehiculo.Text = "Modelo";
            // 
            // lblAnioVehiculo
            // 
            lblAnioVehiculo.AutoSize = true;
            lblAnioVehiculo.Location = new Point(39, 142);
            lblAnioVehiculo.Name = "lblAnioVehiculo";
            lblAnioVehiculo.Size = new Size(36, 20);
            lblAnioVehiculo.TabIndex = 6;
            lblAnioVehiculo.Text = "Año";
            // 
            // txtAnioVehiculo
            // 
            txtAnioVehiculo.Location = new Point(155, 135);
            txtAnioVehiculo.Name = "txtAnioVehiculo";
            txtAnioVehiculo.Size = new Size(125, 27);
            txtAnioVehiculo.TabIndex = 7;
            // 
            // txtPrecioVehiculo
            // 
            txtPrecioVehiculo.Location = new Point(155, 175);
            txtPrecioVehiculo.Name = "txtPrecioVehiculo";
            txtPrecioVehiculo.Size = new Size(125, 27);
            txtPrecioVehiculo.TabIndex = 9;
            // 
            // lblPrecioVehiculo
            // 
            lblPrecioVehiculo.AutoSize = true;
            lblPrecioVehiculo.Location = new Point(39, 182);
            lblPrecioVehiculo.Name = "lblPrecioVehiculo";
            lblPrecioVehiculo.Size = new Size(50, 20);
            lblPrecioVehiculo.TabIndex = 8;
            lblPrecioVehiculo.Text = "Precio";
            // 
            // lblCategoríaVehículo
            // 
            lblCategoríaVehículo.AutoSize = true;
            lblCategoríaVehículo.Location = new Point(39, 227);
            lblCategoríaVehículo.Name = "lblCategoríaVehículo";
            lblCategoríaVehículo.Size = new Size(74, 20);
            lblCategoríaVehículo.TabIndex = 10;
            lblCategoríaVehículo.Text = "Categoría";
            // 
            // cmbCategoriaVehiculo
            // 
            cmbCategoriaVehiculo.FormattingEnabled = true;
            cmbCategoriaVehiculo.Location = new Point(155, 219);
            cmbCategoriaVehiculo.Name = "cmbCategoriaVehiculo";
            cmbCategoriaVehiculo.Size = new Size(151, 28);
            cmbCategoriaVehiculo.TabIndex = 11;
            // 
            // cmbEstadoVehiculo
            // 
            cmbEstadoVehiculo.FormattingEnabled = true;
            cmbEstadoVehiculo.Items.AddRange(new object[] { "* N ", "*U" });
            cmbEstadoVehiculo.Location = new Point(155, 266);
            cmbEstadoVehiculo.Name = "cmbEstadoVehiculo";
            cmbEstadoVehiculo.Size = new Size(151, 28);
            cmbEstadoVehiculo.TabIndex = 13;
            // 
            // lblEstadoVehiculo
            // 
            lblEstadoVehiculo.AutoSize = true;
            lblEstadoVehiculo.Location = new Point(39, 274);
            lblEstadoVehiculo.Name = "lblEstadoVehiculo";
            lblEstadoVehiculo.Size = new Size(54, 20);
            lblEstadoVehiculo.TabIndex = 12;
            lblEstadoVehiculo.Text = "Estado";
            // 
            // btnAgregarVehiculo
            // 
            btnAgregarVehiculo.Location = new Point(88, 319);
            btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            btnAgregarVehiculo.Size = new Size(171, 29);
            btnAgregarVehiculo.TabIndex = 14;
            btnAgregarVehiculo.Text = "Agregar Vehículo";
            btnAgregarVehiculo.UseVisualStyleBackColor = true;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(333, 60);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.RowHeadersWidth = 51;
            dgvVehiculos.Size = new Size(832, 288);
            dgvVehiculos.TabIndex = 15;
            // 
            // btnMostrarVehiculos
            // 
            btnMostrarVehiculos.Location = new Point(696, 13);
            btnMostrarVehiculos.Name = "btnMostrarVehiculos";
            btnMostrarVehiculos.Size = new Size(167, 29);
            btnMostrarVehiculos.TabIndex = 16;
            btnMostrarVehiculos.Text = "Mostrar Vehiculos";
            btnMostrarVehiculos.UseVisualStyleBackColor = true;
            // 
            // lblIdVendedor
            // 
            lblIdVendedor.AutoSize = true;
            lblIdVendedor.Location = new Point(29, 18);
            lblIdVendedor.Name = "lblIdVendedor";
            lblIdVendedor.Size = new Size(90, 20);
            lblIdVendedor.TabIndex = 0;
            lblIdVendedor.Text = "Id Vendedor";
            // 
            // txtIdVendedor
            // 
            txtIdVendedor.Location = new Point(185, 11);
            txtIdVendedor.Name = "txtIdVendedor";
            txtIdVendedor.Size = new Size(125, 27);
            txtIdVendedor.TabIndex = 1;
            // 
            // txtIdentificacionVendedor
            // 
            txtIdentificacionVendedor.Location = new Point(185, 59);
            txtIdentificacionVendedor.Name = "txtIdentificacionVendedor";
            txtIdentificacionVendedor.Size = new Size(125, 27);
            txtIdentificacionVendedor.TabIndex = 3;
            // 
            // lblIdentificaciónVendedor
            // 
            lblIdentificaciónVendedor.AutoSize = true;
            lblIdentificaciónVendedor.Location = new Point(29, 66);
            lblIdentificaciónVendedor.Name = "lblIdentificaciónVendedor";
            lblIdentificaciónVendedor.Size = new Size(99, 20);
            lblIdentificaciónVendedor.TabIndex = 2;
            lblIdentificaciónVendedor.Text = "Identificación";
            // 
            // txtNombreVendedor
            // 
            txtNombreVendedor.Location = new Point(185, 107);
            txtNombreVendedor.Name = "txtNombreVendedor";
            txtNombreVendedor.Size = new Size(125, 27);
            txtNombreVendedor.TabIndex = 5;
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.AutoSize = true;
            lblNombreVendedor.Location = new Point(29, 114);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new Size(134, 20);
            lblNombreVendedor.TabIndex = 4;
            lblNombreVendedor.Text = "Nombre Completo";
            // 
            // lblFechaNacimientoVendedor
            // 
            lblFechaNacimientoVendedor.AutoSize = true;
            lblFechaNacimientoVendedor.Location = new Point(29, 165);
            lblFechaNacimientoVendedor.Name = "lblFechaNacimientoVendedor";
            lblFechaNacimientoVendedor.Size = new Size(128, 20);
            lblFechaNacimientoVendedor.TabIndex = 6;
            lblFechaNacimientoVendedor.Text = "Fecha Nacimiento";
            // 
            // lblFechaIngresoVendedor
            // 
            lblFechaIngresoVendedor.AutoSize = true;
            lblFechaIngresoVendedor.Location = new Point(29, 219);
            lblFechaIngresoVendedor.Name = "lblFechaIngresoVendedor";
            lblFechaIngresoVendedor.Size = new Size(100, 20);
            lblFechaIngresoVendedor.TabIndex = 8;
            lblFechaIngresoVendedor.Text = "Fecha Ingreso";
            // 
            // txtTelefonoVendedor
            // 
            txtTelefonoVendedor.Location = new Point(185, 266);
            txtTelefonoVendedor.Name = "txtTelefonoVendedor";
            txtTelefonoVendedor.Size = new Size(125, 27);
            txtTelefonoVendedor.TabIndex = 11;
            // 
            // lblTelefonoVendedor
            // 
            lblTelefonoVendedor.AutoSize = true;
            lblTelefonoVendedor.Location = new Point(29, 273);
            lblTelefonoVendedor.Name = "lblTelefonoVendedor";
            lblTelefonoVendedor.Size = new Size(67, 20);
            lblTelefonoVendedor.TabIndex = 10;
            lblTelefonoVendedor.Text = "Teléfono";
            // 
            // btnAgregarVendedor
            // 
            btnAgregarVendedor.Location = new Point(86, 322);
            btnAgregarVendedor.Name = "btnAgregarVendedor";
            btnAgregarVendedor.Size = new Size(162, 29);
            btnAgregarVendedor.TabIndex = 12;
            btnAgregarVendedor.Text = "Agregar Vendedor";
            btnAgregarVendedor.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimientoVendedor
            // 
            dtpFechaNacimientoVendedor.Location = new Point(185, 158);
            dtpFechaNacimientoVendedor.Name = "dtpFechaNacimientoVendedor";
            dtpFechaNacimientoVendedor.Size = new Size(282, 27);
            dtpFechaNacimientoVendedor.TabIndex = 13;
            // 
            // dtpFechaIngresoVendedor
            // 
            dtpFechaIngresoVendedor.Location = new Point(185, 212);
            dtpFechaIngresoVendedor.Name = "dtpFechaIngresoVendedor";
            dtpFechaIngresoVendedor.Size = new Size(282, 27);
            dtpFechaIngresoVendedor.TabIndex = 14;
            // 
            // dgvVendedores
            // 
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Location = new Point(484, 59);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.RowHeadersWidth = 51;
            dgvVendedores.Size = new Size(710, 306);
            dgvVendedores.TabIndex = 15;
            // 
            // btnMostrarVendedores
            // 
            btnMostrarVendedores.Location = new Point(782, 18);
            btnMostrarVendedores.Name = "btnMostrarVendedores";
            btnMostrarVendedores.Size = new Size(168, 29);
            btnMostrarVendedores.TabIndex = 16;
            btnMostrarVendedores.Text = "Mostrar Vendedores";
            btnMostrarVendedores.UseVisualStyleBackColor = true;
            // 
            // lblIdSucursal
            // 
            lblIdSucursal.AutoSize = true;
            lblIdSucursal.Location = new Point(26, 15);
            lblIdSucursal.Name = "lblIdSucursal";
            lblIdSucursal.Size = new Size(80, 20);
            lblIdSucursal.TabIndex = 0;
            lblIdSucursal.Text = "Id Sucursal";
            // 
            // txtIdSucursal
            // 
            txtIdSucursal.Location = new Point(185, 8);
            txtIdSucursal.Name = "txtIdSucursal";
            txtIdSucursal.Size = new Size(125, 27);
            txtIdSucursal.TabIndex = 1;
            // 
            // txtNombreSucursal
            // 
            txtNombreSucursal.Location = new Point(185, 51);
            txtNombreSucursal.Name = "txtNombreSucursal";
            txtNombreSucursal.Size = new Size(125, 27);
            txtNombreSucursal.TabIndex = 3;
            txtNombreSucursal.TextChanged += textBox2_TextChanged;
            // 
            // lblNombreSucursal
            // 
            lblNombreSucursal.AutoSize = true;
            lblNombreSucursal.Location = new Point(26, 58);
            lblNombreSucursal.Name = "lblNombreSucursal";
            lblNombreSucursal.Size = new Size(68, 20);
            lblNombreSucursal.TabIndex = 2;
            lblNombreSucursal.Text = "Nombre ";
            // 
            // txtDireccionSucursal
            // 
            txtDireccionSucursal.Location = new Point(185, 97);
            txtDireccionSucursal.Name = "txtDireccionSucursal";
            txtDireccionSucursal.Size = new Size(125, 27);
            txtDireccionSucursal.TabIndex = 5;
            // 
            // lblDireccionSucursal
            // 
            lblDireccionSucursal.AutoSize = true;
            lblDireccionSucursal.Location = new Point(26, 104);
            lblDireccionSucursal.Name = "lblDireccionSucursal";
            lblDireccionSucursal.Size = new Size(72, 20);
            lblDireccionSucursal.TabIndex = 4;
            lblDireccionSucursal.Text = "Dirección";
            // 
            // txtTelefonoSucursal
            // 
            txtTelefonoSucursal.Location = new Point(185, 143);
            txtTelefonoSucursal.Name = "txtTelefonoSucursal";
            txtTelefonoSucursal.Size = new Size(125, 27);
            txtTelefonoSucursal.TabIndex = 7;
            // 
            // lblTelefonoSucursal
            // 
            lblTelefonoSucursal.AutoSize = true;
            lblTelefonoSucursal.Location = new Point(26, 150);
            lblTelefonoSucursal.Name = "lblTelefonoSucursal";
            lblTelefonoSucursal.Size = new Size(67, 20);
            lblTelefonoSucursal.TabIndex = 6;
            lblTelefonoSucursal.Text = "Teléfono";
            // 
            // lblVendedorEncargado
            // 
            lblVendedorEncargado.AutoSize = true;
            lblVendedorEncargado.Location = new Point(26, 198);
            lblVendedorEncargado.Name = "lblVendedorEncargado";
            lblVendedorEncargado.Size = new Size(148, 20);
            lblVendedorEncargado.TabIndex = 8;
            lblVendedorEncargado.Text = "Vendedor Encargado";
            // 
            // lblSucursalActiva
            // 
            lblSucursalActiva.AutoSize = true;
            lblSucursalActiva.Location = new Point(26, 247);
            lblSucursalActiva.Name = "lblSucursalActiva";
            lblSucursalActiva.Size = new Size(50, 20);
            lblSucursalActiva.TabIndex = 10;
            lblSucursalActiva.Text = "Activa";
            // 
            // cmbVendedorSucursal
            // 
            cmbVendedorSucursal.FormattingEnabled = true;
            cmbVendedorSucursal.Location = new Point(185, 190);
            cmbVendedorSucursal.Name = "cmbVendedorSucursal";
            cmbVendedorSucursal.Size = new Size(151, 28);
            cmbVendedorSucursal.TabIndex = 12;
            // 
            // chkSucursalActiva
            // 
            chkSucursalActiva.AutoSize = true;
            chkSucursalActiva.Location = new Point(185, 243);
            chkSucursalActiva.Name = "chkSucursalActiva";
            chkSucursalActiva.Size = new Size(18, 17);
            chkSucursalActiva.TabIndex = 13;
            chkSucursalActiva.UseVisualStyleBackColor = true;
            // 
            // btnAgregarSucursal
            // 
            btnAgregarSucursal.Location = new Point(78, 294);
            btnAgregarSucursal.Name = "btnAgregarSucursal";
            btnAgregarSucursal.Size = new Size(193, 29);
            btnAgregarSucursal.TabIndex = 14;
            btnAgregarSucursal.Text = "Agregar Sucursal";
            btnAgregarSucursal.UseVisualStyleBackColor = true;
            // 
            // btnMostrarSucursales
            // 
            btnMostrarSucursales.Location = new Point(705, 15);
            btnMostrarSucursales.Name = "btnMostrarSucursales";
            btnMostrarSucursales.Size = new Size(206, 29);
            btnMostrarSucursales.TabIndex = 15;
            btnMostrarSucursales.Text = "Mostrar Sucursales";
            btnMostrarSucursales.UseVisualStyleBackColor = true;
            // 
            // dgvSucursales
            // 
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Location = new Point(389, 58);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.RowHeadersWidth = 51;
            dgvSucursales.Size = new Size(790, 309);
            dgvSucursales.TabIndex = 16;
            // 
            // btnMostrarClientes
            // 
            btnMostrarClientes.Location = new Point(771, 25);
            btnMostrarClientes.Name = "btnMostrarClientes";
            btnMostrarClientes.Size = new Size(168, 29);
            btnMostrarClientes.TabIndex = 31;
            btnMostrarClientes.Text = "Mostrar Clientes";
            btnMostrarClientes.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(473, 66);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(710, 306);
            dgvClientes.TabIndex = 30;
            // 
            // dtpFechaRegistroCliente
            // 
            dtpFechaRegistroCliente.Location = new Point(174, 219);
            dtpFechaRegistroCliente.Name = "dtpFechaRegistroCliente";
            dtpFechaRegistroCliente.Size = new Size(282, 27);
            dtpFechaRegistroCliente.TabIndex = 29;
            // 
            // dtpFechaNacimientoCliente
            // 
            dtpFechaNacimientoCliente.Location = new Point(174, 165);
            dtpFechaNacimientoCliente.Name = "dtpFechaNacimientoCliente";
            dtpFechaNacimientoCliente.Size = new Size(282, 27);
            dtpFechaNacimientoCliente.TabIndex = 28;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(75, 329);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(162, 29);
            btnAgregarCliente.TabIndex = 27;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // lblClienteActivo
            // 
            lblClienteActivo.AutoSize = true;
            lblClienteActivo.Location = new Point(18, 280);
            lblClienteActivo.Name = "lblClienteActivo";
            lblClienteActivo.Size = new Size(67, 20);
            lblClienteActivo.TabIndex = 25;
            lblClienteActivo.Text = "Teléfono";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Location = new Point(18, 226);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(100, 20);
            lblFechaRegistro.TabIndex = 24;
            lblFechaRegistro.Text = "Fecha Ingreso";
            // 
            // lblFechaNacimientoCliente
            // 
            lblFechaNacimientoCliente.AutoSize = true;
            lblFechaNacimientoCliente.Location = new Point(18, 172);
            lblFechaNacimientoCliente.Name = "lblFechaNacimientoCliente";
            lblFechaNacimientoCliente.Size = new Size(128, 20);
            lblFechaNacimientoCliente.TabIndex = 23;
            lblFechaNacimientoCliente.Text = "Fecha Nacimiento";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(174, 114);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(125, 27);
            txtNombreCliente.TabIndex = 22;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(18, 121);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(134, 20);
            lblNombreCliente.TabIndex = 21;
            lblNombreCliente.Text = "Nombre Completo";
            // 
            // txtIdentificacionCliente
            // 
            txtIdentificacionCliente.Location = new Point(174, 66);
            txtIdentificacionCliente.Name = "txtIdentificacionCliente";
            txtIdentificacionCliente.Size = new Size(125, 27);
            txtIdentificacionCliente.TabIndex = 20;
            // 
            // lblIdentificacionCliente
            // 
            lblIdentificacionCliente.AutoSize = true;
            lblIdentificacionCliente.Location = new Point(18, 73);
            lblIdentificacionCliente.Name = "lblIdentificacionCliente";
            lblIdentificacionCliente.Size = new Size(99, 20);
            lblIdentificacionCliente.TabIndex = 19;
            lblIdentificacionCliente.Text = "Identificación";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(174, 18);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(125, 27);
            txtIdCliente.TabIndex = 18;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(18, 25);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(72, 20);
            lblIdCliente.TabIndex = 17;
            lblIdCliente.Text = "Id Cliente";
            // 
            // chkClienteActivo
            // 
            chkClienteActivo.AutoSize = true;
            chkClienteActivo.Location = new Point(174, 276);
            chkClienteActivo.Name = "chkClienteActivo";
            chkClienteActivo.Size = new Size(18, 17);
            chkClienteActivo.TabIndex = 32;
            chkClienteActivo.UseVisualStyleBackColor = true;
            // 
            // lblSucursalVxS
            // 
            lblSucursalVxS.AutoSize = true;
            lblSucursalVxS.Location = new Point(38, 31);
            lblSucursalVxS.Name = "lblSucursalVxS";
            lblSucursalVxS.Size = new Size(63, 20);
            lblSucursalVxS.TabIndex = 0;
            lblSucursalVxS.Text = "Sucursal";
            // 
            // cmbSucursalVxS
            // 
            cmbSucursalVxS.FormattingEnabled = true;
            cmbSucursalVxS.Location = new Point(185, 23);
            cmbSucursalVxS.Name = "cmbSucursalVxS";
            cmbSucursalVxS.Size = new Size(151, 28);
            cmbSucursalVxS.TabIndex = 1;
            // 
            // cmbVehiculoVxS
            // 
            cmbVehiculoVxS.FormattingEnabled = true;
            cmbVehiculoVxS.Location = new Point(185, 77);
            cmbVehiculoVxS.Name = "cmbVehiculoVxS";
            cmbVehiculoVxS.Size = new Size(151, 28);
            cmbVehiculoVxS.TabIndex = 3;
            // 
            // lblVehiculoVxS
            // 
            lblVehiculoVxS.AutoSize = true;
            lblVehiculoVxS.Location = new Point(38, 85);
            lblVehiculoVxS.Name = "lblVehiculoVxS";
            lblVehiculoVxS.Size = new Size(65, 20);
            lblVehiculoVxS.TabIndex = 2;
            lblVehiculoVxS.Text = "Vehículo";
            // 
            // lblCantidadVxS
            // 
            lblCantidadVxS.AutoSize = true;
            lblCantidadVxS.Location = new Point(44, 145);
            lblCantidadVxS.Name = "lblCantidadVxS";
            lblCantidadVxS.Size = new Size(69, 20);
            lblCantidadVxS.TabIndex = 4;
            lblCantidadVxS.Text = "Cantidad";
            // 
            // txtCantidadVxS
            // 
            txtCantidadVxS.Location = new Point(185, 138);
            txtCantidadVxS.Name = "txtCantidadVxS";
            txtCantidadVxS.Size = new Size(125, 27);
            txtCantidadVxS.TabIndex = 5;
            // 
            // btnAgregarVxS
            // 
            btnAgregarVxS.Location = new Point(67, 203);
            btnAgregarVxS.Name = "btnAgregarVxS";
            btnAgregarVxS.Size = new Size(231, 29);
            btnAgregarVxS.TabIndex = 6;
            btnAgregarVxS.Text = "Agregar Vehiculo a Sucursal";
            btnAgregarVxS.UseVisualStyleBackColor = true;
            // 
            // dgvVehiculosxSucursal
            // 
            dgvVehiculosxSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculosxSucursal.Location = new Point(456, 64);
            dgvVehiculosxSucursal.Name = "dgvVehiculosxSucursal";
            dgvVehiculosxSucursal.RowHeadersWidth = 51;
            dgvVehiculosxSucursal.Size = new Size(706, 292);
            dgvVehiculosxSucursal.TabIndex = 7;
            // 
            // btnMostrarVxS
            // 
            btnMostrarVxS.Location = new Point(693, 19);
            btnMostrarVxS.Name = "btnMostrarVxS";
            btnMostrarVxS.Size = new Size(282, 29);
            btnMostrarVxS.TabIndex = 8;
            btnMostrarVxS.Text = "Mostrar Vehiculos por Sucursal";
            btnMostrarVxS.UseVisualStyleBackColor = true;
            // 
            // btnMostrarVentas
            // 
            btnMostrarVentas.Location = new Point(28, 25);
            btnMostrarVentas.Name = "btnMostrarVentas";
            btnMostrarVentas.Size = new Size(167, 29);
            btnMostrarVentas.TabIndex = 0;
            btnMostrarVentas.Text = "Mostrar Ventas";
            btnMostrarVentas.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(28, 77);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(1141, 292);
            dgvVentas.TabIndex = 1;
            // 
            // FrmServidor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 673);
            Controls.Add(tabControl1);
            Controls.Add(txtBitacora);
            Controls.Add(lblEstadoServidor);
            Controls.Add(btnDetenerServidor);
            Controls.Add(btnIniciarServidor);
            Controls.Add(label1);
            Name = "FrmServidor";
            Text = "Servidor AutoMarket";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculosxSucursal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIniciarServidor;
        private Button btnDetenerServidor;
        private Label lblEstadoServidor;
        private TextBox txtBitacora;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtNombreCategoria;
        private Label lblNombreCategoria;
        private TextBox txtIdCategoria;
        private Label lblIdCategoria;
        private Button btnMostrarCategorias;
        private DataGridView dgvCategorias;
        private Button btbAgregarCategoria;
        private Label lblIdVehiculo;
        private TextBox txtIdVehiculo;
        private Label lblAnioVehiculo;
        private TextBox txtModeloVehiculo;
        private Label lblModeloVehiculo;
        private TextBox txtMarcaVehiculo;
        private Label lblMarcaVehiculo;
        private TextBox txtPrecioVehiculo;
        private Label lblPrecioVehiculo;
        private TextBox txtAnioVehiculo;
        private ComboBox cmbCategoriaVehiculo;
        private Label lblCategoríaVehículo;
        private ComboBox cmbEstadoVehiculo;
        private Label lblEstadoVehiculo;
        private Button btnAgregarVehiculo;
        private DataGridView dgvVehiculos;
        private Button btnMostrarVehiculos;
        private TextBox txtIdVendedor;
        private Label lblIdVendedor;
        private Button btnAgregarVendedor;
        private TextBox txtTelefonoVendedor;
        private Label lblTelefonoVendedor;
        private Label lblFechaIngresoVendedor;
        private Label lblFechaNacimientoVendedor;
        private TextBox txtNombreVendedor;
        private Label lblNombreVendedor;
        private TextBox txtIdentificacionVendedor;
        private Label lblIdentificaciónVendedor;
        private DateTimePicker dtpFechaIngresoVendedor;
        private DateTimePicker dtpFechaNacimientoVendedor;
        private Button btnMostrarVendedores;
        private DataGridView dgvVendedores;
        private Label lblSucursalActiva;
        private Label lblVendedorEncargado;
        private TextBox txtTelefonoSucursal;
        private Label lblTelefonoSucursal;
        private TextBox txtDireccionSucursal;
        private Label lblDireccionSucursal;
        private TextBox txtNombreSucursal;
        private Label lblNombreSucursal;
        private TextBox txtIdSucursal;
        private Label lblIdSucursal;
        private ComboBox cmbVendedorSucursal;
        private DataGridView dgvSucursales;
        private Button btnMostrarSucursales;
        private Button btnAgregarSucursal;
        private CheckBox chkSucursalActiva;
        private CheckBox chkClienteActivo;
        private Button btnMostrarClientes;
        private DataGridView dgvClientes;
        private DateTimePicker dtpFechaRegistroCliente;
        private DateTimePicker dtpFechaNacimientoCliente;
        private Button btnAgregarCliente;
        private Label lblClienteActivo;
        private Label lblFechaRegistro;
        private Label lblFechaNacimientoCliente;
        private TextBox txtNombreCliente;
        private Label lblNombreCliente;
        private TextBox txtIdentificacionCliente;
        private Label lblIdentificacionCliente;
        private TextBox txtIdCliente;
        private Label lblIdCliente;
        private Label lblSucursalVxS;
        private Button btnAgregarVxS;
        private TextBox txtCantidadVxS;
        private Label lblCantidadVxS;
        private ComboBox cmbVehiculoVxS;
        private Label lblVehiculoVxS;
        private ComboBox cmbSucursalVxS;
        private Button btnMostrarVxS;
        private DataGridView dgvVehiculosxSucursal;
        private Button btnMostrarVentas;
        private DataGridView dgvVentas;
    }
}
