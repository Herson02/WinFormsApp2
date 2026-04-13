using System.Net.Sockets;
using System.Text;

namespace WinFormsApp2.Cliente
{
    public partial class FrmCliente : Form
    {
        private TcpClient clienteTcp;
        private NetworkStream stream;

        private string identificacionCliente = "";
        private int idCliente = 0;
        private string nombreCliente = "";
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            lblEstadoConexion.Text = "Desconectado";
            lblClienteValidado.Text = "Cliente: no validado";

            btnConsultarVehiculos.Enabled = false;
            btnComprarVehiculo.Enabled = false;
            btnVerCompras.Enabled = false;
        }

        private string EnviarMensajeAlServidor(string mensaje)
        {
            clienteTcp = new TcpClient("127.0.0.1", 1500);
            stream = clienteTcp.GetStream();

            byte[] datos = Encoding.UTF8.GetBytes(mensaje);
            stream.Write(datos, 0, datos.Length);

            byte[] buffer = new byte[4096];
            int bytesLeidos = stream.Read(buffer, 0, buffer.Length);

            string respuesta = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);

            stream.Close();
            clienteTcp.Close();

            return respuesta;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdentificacionCliente.Text))
                    throw new Exception("Debe ingresar una identificación.");

                string mensaje = "VALIDAR|" + txtIdentificacionCliente.Text.Trim();
                string respuesta = EnviarMensajeAlServidor(mensaje);

                string[] partes = respuesta.Split('|');

                if (partes[0] == "OK")
                {
                    idCliente = int.Parse(partes[1]);
                    nombreCliente = partes[2];
                    identificacionCliente = txtIdentificacionCliente.Text.Trim();

                    lblEstadoConexion.Text = "Conectado";
                    lblClienteValidado.Text = "Cliente: " + nombreCliente;

                    btnConsultarVehiculos.Enabled = true;
                    btnVerCompras.Enabled = true;

                    CargarSucursales();
                    MessageBox.Show("Cliente validado correctamente.");
                }
                else
                {
                    lblEstadoConexion.Text = "Desconectado";
                    lblClienteValidado.Text = "Cliente: no validado";
                    MessageBox.Show(partes.Length > 1 ? partes[1] : "Error de validación.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void CargarSucursales()
        {
            try
            {
                string respuesta = EnviarMensajeAlServidor("LISTAR_SUCURSALES");

                string[] partes = respuesta.Split('|');

                if (partes[0] == "ERROR")
                    throw new Exception(partes[1]);

                cmbSucursales.Items.Clear();

                if (partes[0] == "SUCURSALES")
                {
                    string[] sucursales = partes[1].Split(';');

                    foreach (string s in sucursales)
                    {
                        string[] datos = s.Split(',');

                        if (datos.Length >= 2)
                        {
                            cmbSucursales.Items.Add(new ComboItem
                            {
                                Valor = int.Parse(datos[0]),
                                Texto = datos[1]
                            });
                        }
                    }

                    cmbSucursales.DisplayMember = "Texto";
                    cmbSucursales.ValueMember = "Valor";

                    if (cmbSucursales.Items.Count > 0)
                        cmbSucursales.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando sucursales: " + ex.Message);
            }
        }

        public class ComboItem
        {
            public int Valor { get; set; }
            public string Texto { get; set; } = string.Empty;

            public override string ToString()
            {
                return Texto;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            identificacionCliente = "";
            idCliente = 0;
            nombreCliente = "";

            lblEstadoConexion.Text = "Desconectado";
            lblClienteValidado.Text = "Cliente: no validado";

            cmbSucursales.DataSource = null;
            cmbSucursales.Items.Clear();

            dgvVehiculosDisponibles.DataSource = null;
            dgvComprasCliente.DataSource = null;

            btnConsultarVehiculos.Enabled = false;
            btnComprarVehiculo.Enabled = false;
            btnVerCompras.Enabled = false;

            txtIdentificacionCliente.Clear();

            MessageBox.Show("Sesión cerrada.");
        }

        private void btnConsultarVehiculos_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSucursales.SelectedItem == null)
                    throw new Exception("Debe seleccionar una sucursal.");

                ComboItem sucursalSeleccionada = (ComboItem)cmbSucursales.SelectedItem;

                string mensaje = "LISTAR_VEHICULOS|" + sucursalSeleccionada.Valor;
                string respuesta = EnviarMensajeAlServidor(mensaje);

                string[] partes = respuesta.Split('|');

                if (partes[0] == "ERROR")
                    throw new Exception(partes[1]);

                if (partes[0] == "VEHICULOS")
                {
                    var lista = new List<object>();

                    string[] vehiculos = partes[1].Split(';');

                    foreach (string v in vehiculos)
                    {
                        string[] datos = v.Split(',');

                        if (datos.Length >= 7)
                        {
                            lista.Add(new
                            {
                                IdVehiculo = int.Parse(datos[0]),
                                Marca = datos[1],
                                Modelo = datos[2],
                                Ano = int.Parse(datos[3]),
                                Precio = decimal.Parse(datos[4]),
                                Estado = datos[5],
                                Cantidad = int.Parse(datos[6])
                            });
                        }
                    }

                    dgvVehiculosDisponibles.DataSource = null;
                    dgvVehiculosDisponibles.DataSource = lista;

                    btnComprarVehiculo.Enabled = lista.Count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error consultando vehículos: " + ex.Message);
            }
        }

        private void btnComprarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSucursales.SelectedItem == null)
                    throw new Exception("Debe seleccionar una sucursal.");

                if (dgvVehiculosDisponibles.CurrentRow == null)
                    throw new Exception("Debe seleccionar un vehículo.");

                ComboItem sucursalSeleccionada = (ComboItem)cmbSucursales.SelectedItem;
                int idSucursal = sucursalSeleccionada.Valor;

                int idVehiculo = Convert.ToInt32(dgvVehiculosDisponibles.CurrentRow.Cells["IdVehiculo"].Value);

                string mensaje = $"COMPRAR|{identificacionCliente}|{idSucursal}|{idVehiculo}";
                string respuesta = EnviarMensajeAlServidor(mensaje);

                string[] partes = respuesta.Split('|');

                if (partes[0] == "OK")
                {
                    MessageBox.Show("Compra realizada correctamente.\nMonto: " + partes[2]);
                    btnConsultarVehiculos_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(partes.Length > 1 ? partes[1] : "No se pudo realizar la compra.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprar: " + ex.Message);
            }
        }

        private void btnVerCompras_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "MIS_COMPRAS|" + identificacionCliente;
                string respuesta = EnviarMensajeAlServidor(mensaje);

                string[] partes = respuesta.Split('|');

                if (partes[0] == "ERROR")
                    throw new Exception(partes[1]);

                if (partes[0] == "COMPRAS")
                {
                    var lista = new List<object>();

                    string[] compras = partes[1].Split(';');

                    foreach (string c in compras)
                    {
                        string[] datos = c.Split(',');

                        if (datos.Length >= 6)
                        {
                            lista.Add(new
                            {
                                IdVenta = int.Parse(datos[0]),
                                Sucursal = datos[1],
                                Marca = datos[2],
                                Modelo = datos[3],
                                FechaVenta = datos[4],
                                Monto = decimal.Parse(datos[5])
                            });
                        }
                    }

                    dgvComprasCliente.DataSource = null;
                    dgvComprasCliente.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error consultando compras: " + ex.Message);
            }
        }
    }
}
