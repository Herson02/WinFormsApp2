using Proyecto2.Entidades;
using Proyecto2.LogicaNegocio;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace WinFormsApp2.Servidor
{
    public partial class FrmServidor : Form
    {
        private CategoriaVehiculoLN categoriaLN = new CategoriaVehiculoLN();
        private VendedorLN vendedorLN = new VendedorLN();
        private SucursalLN sucursalLN = new SucursalLN();
        private ClienteLN clienteLN = new ClienteLN();
        private VehiculoLN vehiculoLN = new VehiculoLN();
        private VehiculoxSucursalLN vehiculoxSucursalLN = new VehiculoxSucursalLN();
        private VentaLN ventaLN = new VentaLN();

        public FrmServidor()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdCategoria.Text, out int idCategoria))
                    throw new Exception("El Id de la categoría debe ser numérico.");

                CategoriasVehiculos categoria = new CategoriasVehiculos
                {
                    IdCategoria = idCategoria,
                    NombreCategoria = txtNombreCategoria.Text,
                    Descripcion = txtDescripcionCategoria.Text
                };

                categoriaLN.Agregar(categoria);

                MessageBox.Show("Categoría agregada correctamente.");
                AgregarBitacora("Se registró una categoría de vehículo.");

                txtIdCategoria.Clear();
                txtNombreCategoria.Clear();
                txtDescripcionCategoria.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al registrar categoría: " + ex.Message);
            }
        }

        private void btnMostrarCategorias_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCategorias.DataSource = null;
                dgvCategorias.DataSource = categoriaLN.Listar();
                AgregarBitacora("Se consultaron las categorías de vehículo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al consultar categorías: " + ex.Message);
            }
        }

        private TcpListener servidor;
        private bool servidorActivo = false;
        private readonly object lockVenta = new object();

        private void txtBitacora_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarBitacora(string mensaje)
        {
            if (txtBitacora.InvokeRequired)
            {
                txtBitacora.Invoke(new Action(() =>
                    txtBitacora.AppendText($"[{DateTime.Now:HH:mm:ss}] {mensaje}{Environment.NewLine}")));
            }
            else
            {
                txtBitacora.AppendText($"[{DateTime.Now:HH:mm:ss}] {mensaje}{Environment.NewLine}");
            }
        }

        private void btnIniciarServidor_Click(object sender, EventArgs e)
        {
            try
            {
                servidor = new TcpListener(IPAddress.Parse("127.0.0.1"), 1500);
                servidor.Start();
                servidorActivo = true;

                lblEstadoServidor.Text = "Estado: Activo";
                AgregarBitacora("Servidor iniciado en 127.0.0.1:1500");

                Thread hiloEscucha = new Thread(EscucharClientes);
                hiloEscucha.IsBackground = true;
                hiloEscucha.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al iniciar servidor: " + ex.Message);
            }
        }

        private void btnDetenerServidor_Click(object sender, EventArgs e)
        {
            try
            {
                servidorActivo = false;
                servidor?.Stop();
                lblEstadoServidor.Text = "Estado: Detenido";
                AgregarBitacora("Servidor detenido.");
            }
            catch (Exception ex)
            {
                AgregarBitacora("Error al detener servidor: " + ex.Message);
            }
        }

        private void EscucharClientes()
        {
            while (servidorActivo)
            {
                try
                {
                    TcpClient cliente = servidor.AcceptTcpClient();
                    AgregarBitacora("Cliente conectado.");

                    Thread hiloCliente = new Thread(() => AtenderCliente(cliente));
                    hiloCliente.IsBackground = true;
                    hiloCliente.Start();
                }
                catch
                {
                    if (servidorActivo)
                        AgregarBitacora("Error aceptando cliente.");
                }
            }
        }

        private void AtenderCliente(TcpClient cliente)
        {
            try
            {
                using NetworkStream stream = cliente.GetStream();

                byte[] buffer = new byte[4096];
                int bytesLeidos = stream.Read(buffer, 0, buffer.Length);

                string mensaje = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);
                AgregarBitacora("Mensaje recibido: " + mensaje);

                string respuesta = ProcesarSolicitud(mensaje);

                byte[] respuestaBytes = Encoding.UTF8.GetBytes(respuesta);
                stream.Write(respuestaBytes, 0, respuestaBytes.Length);

                cliente.Close();
                AgregarBitacora("Cliente desconectado.");
            }
            catch (Exception ex)
            {
                AgregarBitacora("Error atendiendo cliente: " + ex.Message);
            }
        }

        private string ProcesarSolicitud(string mensaje)
        {
            try
            {
                string[] partes = mensaje.Split('|');
                string comando = partes[0].ToUpper();

                switch (comando)
                {
                    case "VALIDAR":
                        return ProcesarValidacion(partes);

                    case "LISTAR_SUCURSALES":
                        return ProcesarSucursales();

                    case "LISTAR_VEHICULOS":
                        return ProcesarVehiculos(partes);

                    case "COMPRAR":
                        return ProcesarCompra(partes);

                    case "MIS_COMPRAS":
                        return ProcesarMisCompras(partes);

                    default:
                        return "ERROR|Comando no reconocido.";
                }
            }
            catch (Exception ex)
            {
                return "ERROR|" + ex.Message;
            }
        }

        private string ProcesarValidacion(string[] partes)
        {
            if (partes.Length < 2)
                return "ERROR|Debe enviar la identificación.";

            string identificacion = partes[1];

            Cliente? cliente = clienteLN.BuscarPorIdentificacion(identificacion);

            if (cliente == null)
                return "ERROR|Cliente no encontrado.";

            if (!cliente.Activo)
                return "ERROR|Cliente inactivo.";

            AgregarBitacora("Cliente validado: " + cliente.NombreCompleto);

            return $"OK|{cliente.IdCliente}|{cliente.NombreCompleto}";
        }

        private string ProcesarSucursales()
        {
            var sucursales = sucursalLN.Listar()
                                       .Where(s => s.Activo)
                                       .ToList();

            if (sucursales.Count == 0)
                return "ERROR|No hay sucursales activas.";

            string resultado = "SUCURSALES|";

            foreach (var s in sucursales)
            {
                resultado += $"{s.IdSucursal},{s.Nombre};";
            }

            AgregarBitacora("Se enviaron sucursales activas al cliente.");

            return resultado.TrimEnd(';');
        }

        private string ProcesarVehiculos(string[] partes)
        {
            if (partes.Length < 2)
                return "ERROR|Debe enviar el Id de la sucursal.";

            if (!int.TryParse(partes[1], out int idSucursal))
                return "ERROR|Id de sucursal inválido.";

            var lista = vehiculoxSucursalLN.ListarPorSucursal(idSucursal)
                                           .Where(x => x.Cantidad > 0)
                                           .ToList();

            if (lista.Count == 0)
                return "ERROR|No hay vehículos disponibles en esa sucursal.";

            string resultado = "VEHICULOS|";

            foreach (var item in lista)
            {
                resultado += $"{item.Vehiculo.IdVehiculo}," +
                             $"{item.Vehiculo.Marca}," +
                             $"{item.Vehiculo.Modelo}," +
                             $"{item.Vehiculo.Ano}," +
                             $"{item.Vehiculo.Precio}," +
                             $"{item.Vehiculo.Estado}," +
                             $"{item.Cantidad};";
            }

            AgregarBitacora($"Se enviaron vehículos de la sucursal {idSucursal}.");

            return resultado.TrimEnd(';');
        }

        private string ProcesarCompra(string[] partes)
        {
            if (partes.Length < 4)
                return "ERROR|Debe enviar identificación, sucursal y vehículo.";

            string identificacion = partes[1];

            if (!int.TryParse(partes[2], out int idSucursal))
                return "ERROR|Id de sucursal inválido.";

            if (!int.TryParse(partes[3], out int idVehiculo))
                return "ERROR|Id de vehículo inválido.";

            Cliente? cliente = clienteLN.BuscarPorIdentificacion(identificacion);
            if (cliente == null)
                return "ERROR|Cliente no encontrado.";

            Sucursal? sucursal = sucursalLN.Listar().FirstOrDefault(s => s.IdSucursal == idSucursal);
            if (sucursal == null)
                return "ERROR|Sucursal no encontrada.";

            VehiculoxSucursal? item = vehiculoxSucursalLN.ListarPorSucursal(idSucursal)
                                                         .FirstOrDefault(x => x.Vehiculo.IdVehiculo == idVehiculo);

            if (item == null)
                return "ERROR|Vehículo no disponible en esa sucursal.";

            bool exito = ventaLN.RegistrarVenta(cliente, sucursal, item.Vehiculo);

            if (!exito)
                return "ERROR|No fue posible registrar la venta.";

            AgregarBitacora($"Venta registrada. Cliente: {cliente.NombreCompleto}, Vehículo: {item.Vehiculo.Marca} {item.Vehiculo.Modelo}");

            return $"OK|Venta registrada correctamente|{item.Vehiculo.Precio}";
        }

        private string ProcesarMisCompras(string[] partes)
        {
            if (partes.Length < 2)
                return "ERROR|Debe enviar la identificación del cliente.";

            string identificacion = partes[1];

            Cliente? cliente = clienteLN.BuscarPorIdentificacion(identificacion);
            if (cliente == null)
                return "ERROR|Cliente no encontrado.";

            var ventas = ventaLN.ListarPorCliente(cliente.IdCliente);

            if (ventas.Count == 0)
                return "ERROR|El cliente no tiene compras registradas.";

            string resultado = "COMPRAS|";

            foreach (var venta in ventas)
            {
                resultado += $"{venta.IdVenta}," +
                             $"{venta.Sucursal.Nombre}," +
                             $"{venta.Vehiculo.Marca}," +
                             $"{venta.Vehiculo.Modelo}," +
                             $"{venta.FechaVenta:dd/MM/yyyy HH:mm}," +
                             $"{venta.Monto};";
            }

            AgregarBitacora($"Se enviaron compras del cliente {cliente.NombreCompleto}.");

            return resultado.TrimEnd(';');
        }

        private void btnAgregarVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdVendedor.Text, out int idVendedor))
                    throw new Exception("El Id del vendedor debe ser numérico.");

                Vendedor vendedor = new Vendedor
                {
                    IdVendedor = idVendedor,
                    Identificacion = txtIdentificacionVendedor.Text,
                    NombreCompleto = txtNombreVendedor.Text,
                    FechaNacimiento = dtpFechaNacimientoVendedor.Value.Date,
                    FechaIngreso = dtpFechaIngresoVendedor.Value.Date,
                    Telefono = txtTelefonoVendedor.Text
                };

                vendedorLN.Agregar(vendedor);

                MessageBox.Show("Vendedor agregado correctamente.");
                AgregarBitacora("Se registró un vendedor.");

                txtIdVendedor.Clear();
                txtIdentificacionVendedor.Clear();
                txtNombreVendedor.Clear();
                txtTelefonoVendedor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al registrar vendedor: " + ex.Message);
            }
        }

        private void btnMostrarVendedores_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVendedores.DataSource = null;
                dgvVendedores.DataSource = vendedorLN.Listar();

                AgregarBitacora("Se consultaron los vendedores.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al consultar vendedores: " + ex.Message);
            }
        }

        private void CargarVendedoresEnComboSucursal()
        {
            try
            {
                List<Vendedor> lista = vendedorLN.Listar();

                cmbVendedorSucursal.DataSource = null;
                cmbVendedorSucursal.DataSource = lista;
                cmbVendedorSucursal.DisplayMember = "NombreCompleto";
                cmbVendedorSucursal.ValueMember = "IdVendedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando vendedores: " + ex.Message);
                AgregarBitacora("Error cargando vendedores en combo de sucursal: " + ex.Message);
            }
        }

        private void FrmServidor_Load(object sender, EventArgs e)
        {
            CargarVendedoresEnComboSucursal();
            CargarVendedoresEnComboSucursal();
            CargarCategoriasEnComboVehiculo();
            CargarEstadosVehiculo();
            CargarVendedoresEnComboSucursal();
            CargarCategoriasEnComboVehiculo();
            CargarEstadosVehiculo();
            CargarSucursalesActivasEnComboVehiculoSucursal();
            CargarVehiculosEnComboVehiculoSucursal();
        }
        private void cmbVendedorSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdSucursal.Text, out int idSucursal))
                    throw new Exception("El Id de la sucursal debe ser numérico.");

                if (cmbVendedorSucursal.SelectedItem == null)
                    throw new Exception("Debe seleccionar un vendedor.");

                Vendedor vendedorSeleccionado = (Vendedor)cmbVendedorSucursal.SelectedItem;

                Sucursal sucursal = new Sucursal
                {
                    IdSucursal = idSucursal,
                    Nombre = txtNombreSucursal.Text,
                    Direccion = txtDireccionSucursal.Text,
                    Telefono = txtTelefonoSucursal.Text,
                    VendedorEncargado = vendedorSeleccionado,
                    Activo = chkSucursalActiva.Checked
                };

                sucursalLN.Agregar(sucursal);

                MessageBox.Show("Sucursal agregada correctamente.");
                AgregarBitacora("Se registró una sucursal.");

                txtIdSucursal.Clear();
                txtNombreSucursal.Clear();
                txtDireccionSucursal.Clear();
                txtTelefonoSucursal.Clear();

                CargarVendedoresEnComboSucursal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al registrar sucursal: " + ex.Message);
            }
        }

        private void btnMostrarSucursales_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = sucursalLN.Listar();

                var datos = lista.Select(s => new
                {
                    s.IdSucursal,
                    s.Nombre,
                    s.Direccion,
                    s.Telefono,
                    VendedorNombre = s.VendedorEncargado.NombreCompleto,
                    VendedorIdentificacion = s.VendedorEncargado.Identificacion,
                    Activo = s.Activo ? "Sí" : "No"
                }).ToList();

                dgvSucursales.DataSource = null;
                dgvSucursales.DataSource = datos;

                AgregarBitacora("Se consultaron las sucursales.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al consultar sucursales: " + ex.Message);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdCliente.Text, out int idCliente))
                    throw new Exception("El Id del cliente debe ser numérico.");

                Cliente cliente = new Cliente
                {
                    IdCliente = idCliente,
                    Identificacion = txtIdentificacionCliente.Text,
                    NombreCompleto = txtNombreCliente.Text,
                    FechaNacimiento = dtpFechaNacimientoCliente.Value.Date,
                    FechaRegistro = dtpFechaRegistroCliente.Value.Date,
                    Activo = chkClienteActivo.Checked
                };

                clienteLN.Agregar(cliente);

                MessageBox.Show("Cliente agregado correctamente.");
                AgregarBitacora("Se registró un cliente.");

                txtIdCliente.Clear();
                txtIdentificacionCliente.Clear();
                txtNombreCliente.Clear();
                chkClienteActivo.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al registrar cliente: " + ex.Message);
            }
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = clienteLN.Listar();

                var datos = lista.Select(c => new
                {
                    c.IdCliente,
                    c.Identificacion,
                    c.NombreCompleto,
                    FechaNacimiento = c.FechaNacimiento.ToShortDateString(),
                    FechaRegistro = c.FechaRegistro.ToShortDateString(),
                    Activo = c.Activo ? "Sí" : "No"
                }).ToList();

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = datos;

                AgregarBitacora("Se consultaron los clientes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al consultar clientes: " + ex.Message);
            }
        }

        private void CargarCategoriasEnComboVehiculo()
        {
            try
            {
                List<CategoriasVehiculos> lista = categoriaLN.Listar();

                cmbCategoriaVehiculo.DataSource = null;
                cmbCategoriaVehiculo.DataSource = lista;
                cmbCategoriaVehiculo.DisplayMember = "NombreCategoria";
                cmbCategoriaVehiculo.ValueMember = "IdCategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando categorías: " + ex.Message);
                AgregarBitacora("Error cargando categorías en combo de vehículo: " + ex.Message);
            }
        }

        private void CargarEstadosVehiculo()
        {
            cmbEstadoVehiculo.Items.Clear();
            cmbEstadoVehiculo.Items.Add("N");
            cmbEstadoVehiculo.Items.Add("U");
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdVehiculo.Text, out int idVehiculo))
                    throw new Exception("El Id del vehículo debe ser numérico.");

                if (!int.TryParse(txtAnioVehiculo.Text, out int ano))
                    throw new Exception("El año del vehículo debe ser numérico.");

                if (!decimal.TryParse(txtPrecioVehiculo.Text, out decimal precio))
                    throw new Exception("El precio del vehículo debe ser numérico.");

                if (cmbCategoriaVehiculo.SelectedItem == null)
                    throw new Exception("Debe seleccionar una categoría.");

                if (cmbEstadoVehiculo.SelectedItem == null)
                    throw new Exception("Debe seleccionar un estado.");

                CategoriasVehiculos categoriaSeleccionada = (CategoriasVehiculos)cmbCategoriaVehiculo.SelectedItem;
                char estado = Convert.ToChar(cmbEstadoVehiculo.SelectedItem.ToString());

                Vehiculos vehiculo = new Vehiculos
                {
                    IdVehiculo = idVehiculo,
                    Marca = txtMarcaVehiculo.Text,
                    Modelo = txtModeloVehiculo.Text,
                    Ano = ano,
                    Precio = precio,
                    Categoria = categoriaSeleccionada,
                    Estado = estado
                };

                vehiculoLN.Agregar(vehiculo);

                MessageBox.Show("Vehículo agregado correctamente.");
                AgregarBitacora("Se registró un vehículo.");

                txtIdVehiculo.Clear();
                txtMarcaVehiculo.Clear();
                txtModeloVehiculo.Clear();
                txtAnioVehiculo.Clear();
                txtPrecioVehiculo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al registrar vehículo: " + ex.Message);
            }
        }

        private void btnMostrarVehiculos_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = vehiculoLN.Listar();

                var datos = lista.Select(v => new
                {
                    v.IdVehiculo,
                    v.Marca,
                    v.Modelo,
                    v.Ano,
                    v.Precio,
                    v.Estado,
                    CategoriaNombre = v.Categoria.NombreCategoria,
                    CategoriaDescripcion = v.Categoria.Descripcion
                }).ToList();

                dgvVehiculos.DataSource = null;
                dgvVehiculos.DataSource = datos;

                AgregarBitacora("Se consultaron los vehículos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al consultar vehículos: " + ex.Message);
            }
        }

        private void CargarSucursalesActivasEnComboVehiculoSucursal()
        {
            try
            {
                var lista = sucursalLN.Listar()
                                      .Where(s => s.Activo)
                                      .ToList();

                cmbSucursalVxS.DataSource = null;
                cmbSucursalVxS.DataSource = lista;
                cmbSucursalVxS.DisplayMember = "Nombre";
                cmbSucursalVxS.ValueMember = "IdSucursal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando sucursales: " + ex.Message);
                AgregarBitacora("Error cargando sucursales activas en combo: " + ex.Message);
            }
        }

        private void CargarVehiculosEnComboVehiculoSucursal()
        {
            try
            {
                var lista = vehiculoLN.Listar();

                cmbVehiculoVxS.DataSource = null;
                cmbVehiculoVxS.DataSource = lista;
                cmbVehiculoVxS.DisplayMember = "Modelo";
                cmbVehiculoVxS.ValueMember = "IdVehiculo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando vehículos: " + ex.Message);
                AgregarBitacora("Error cargando vehículos en combo: " + ex.Message);
            }
        }

        private void btnAgregarVxS_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCantidadVxS.Text, out int cantidad))
                    throw new Exception("La cantidad debe ser numérica.");

                if (cmbSucursalVxS.SelectedItem == null)
                    throw new Exception("Debe seleccionar una sucursal.");

                if (cmbVehiculoVxS.SelectedItem == null)
                    throw new Exception("Debe seleccionar un vehículo.");

                Sucursal sucursalSeleccionada = (Sucursal)cmbSucursalVxS.SelectedItem;
                Vehiculos vehiculoSeleccionado = (Vehiculos)cmbVehiculoVxS.SelectedItem;

                VehiculoxSucursal item = new VehiculoxSucursal
                {
                    Sucursal = sucursalSeleccionada,
                    Vehiculo = vehiculoSeleccionado,
                    Cantidad = cantidad
                };

                vehiculoxSucursalLN.Agregar(item);

                MessageBox.Show("Vehículo asignado a sucursal correctamente.");
                AgregarBitacora("Se registró inventario de vehículo por sucursal.");

                txtCantidadVxS.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al registrar vehículo por sucursal: " + ex.Message);
            }
        }

        private void btnMostrarVxS_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = vehiculoxSucursalLN.Listar();

                var datos = lista.Select(x => new
                {
                    x.Sucursal.IdSucursal,
                    NombreSucursal = x.Sucursal.Nombre,
                    x.Vehiculo.IdVehiculo,
                    x.Vehiculo.Marca,
                    x.Vehiculo.Modelo,
                    x.Vehiculo.Estado,
                    Categoria = x.Vehiculo.Categoria.NombreCategoria,
                    x.Cantidad
                }).ToList();

                dgvVehiculosxSucursal.DataSource = null;
                dgvVehiculosxSucursal.DataSource = datos;

                AgregarBitacora("Se consultó el inventario de vehículos por sucursal.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al consultar vehículo por sucursal: " + ex.Message);
            }
        }

        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = ventaLN.Listar();

                var datos = lista.Select(v => new
                {
                    v.IdVenta,
                    ClienteNombre = v.Cliente.NombreCompleto,
                    ClienteIdentificacion = v.Cliente.Identificacion,
                    SucursalNombre = v.Sucursal.Nombre,
                    VehiculoMarca = v.Vehiculo.Marca,
                    VehiculoModelo = v.Vehiculo.Modelo,
                    FechaVenta = v.FechaVenta.ToString("dd/MM/yyyy HH:mm"),
                    v.Monto
                }).ToList();

                dgvVentas.DataSource = null;
                dgvVentas.DataSource = datos;

                AgregarBitacora("Se consultaron las ventas.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AgregarBitacora("Error al consultar ventas: " + ex.Message);
            }
        }
    }
}
