using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Proyecto2.Entidades;
using System.Configuration;

namespace Proyecto2.AccesoDatos
{
    public class VentaDA
    {
        private readonly string conexion =
            ConfigurationManager.ConnectionStrings["AutoMarketDB"].ConnectionString;

        public bool Insertar(Venta venta)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"INSERT INTO Venta
                             (IdCliente, IdSucursal, IdVehiculo, FechaVenta, Monto)
                             VALUES
                             (@IdCliente, @IdSucursal, @IdVehiculo, @FechaVenta, @Monto)";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdCliente", venta.Cliente.IdCliente);
            cmd.Parameters.AddWithValue("@IdSucursal", venta.Sucursal.IdSucursal);
            cmd.Parameters.AddWithValue("@IdVehiculo", venta.Vehiculo.IdVehiculo);
            cmd.Parameters.AddWithValue("@FechaVenta", venta.FechaVenta);
            cmd.Parameters.AddWithValue("@Monto", venta.Monto);

            int filas = cmd.ExecuteNonQuery();
            return filas > 0;
        }

        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();

            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"
                SELECT  vt.IdVenta,
                        vt.FechaVenta,
                        vt.Monto,

                        c.IdCliente,
                        c.Identificacion AS ClienteIdentificacion,
                        c.NombreCompleto AS ClienteNombre,
                        c.FechaNacimiento,
                        c.FechaRegistro,
                        c.Activo,

                        s.IdSucursal,
                        s.Nombre AS NombreSucursal,
                        s.Direccion,
                        s.Telefono AS TelefonoSucursal,

                        v.IdVehiculo,
                        v.Marca,
                        v.Modelo,
                        v.Ano,
                        v.Precio,
                        v.Estado,

                        cat.IdCategoria,
                        cat.NombreCategoria,
                        cat.Descripcion

                FROM Venta vt
                INNER JOIN Cliente c ON vt.IdCliente = c.IdCliente
                INNER JOIN Sucursal s ON vt.IdSucursal = s.IdSucursal
                INNER JOIN Vehiculo v ON vt.IdVehiculo = v.IdVehiculo
                INNER JOIN CategoriaVehiculo cat ON v.IdCategoria = cat.IdCategoria";

            using SqlCommand cmd = new SqlCommand(query, conn);
            using SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cliente cliente = new Cliente
                {
                    IdCliente = Convert.ToInt32(dr["IdCliente"]),
                    Identificacion = dr["ClienteIdentificacion"].ToString() ?? "",
                    NombreCompleto = dr["ClienteNombre"].ToString() ?? "",
                    FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                    FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                    Activo = Convert.ToBoolean(dr["Activo"])
                };

                Sucursal sucursal = new Sucursal
                {
                    IdSucursal = Convert.ToInt32(dr["IdSucursal"]),
                    Nombre = dr["NombreSucursal"].ToString() ?? "",
                    Direccion = dr["Direccion"].ToString() ?? "",
                    Telefono = dr["TelefonoSucursal"].ToString() ?? ""
                };

                CategoriasVehiculos categoria = new CategoriasVehiculos
                {
                    IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                    NombreCategoria = dr["NombreCategoria"].ToString() ?? "",
                    Descripcion = dr["Descripcion"].ToString() ?? ""
                };

                Vehiculos vehiculo = new Vehiculos
                {
                    IdVehiculo = Convert.ToInt32(dr["IdVehiculo"]),
                    Marca = dr["Marca"].ToString() ?? "",
                    Modelo = dr["Modelo"].ToString() ?? "",
                    Ano = Convert.ToInt32(dr["Ano"]),
                    Precio = Convert.ToDecimal(dr["Precio"]),
                    Estado = Convert.ToChar(dr["Estado"]),
                    Categoria = categoria
                };

                Venta venta = new Venta
                {
                    IdVenta = Convert.ToInt32(dr["IdVenta"]),
                    Cliente = cliente,
                    Sucursal = sucursal,
                    Vehiculo = vehiculo,
                    FechaVenta = Convert.ToDateTime(dr["FechaVenta"]),
                    Monto = Convert.ToDecimal(dr["Monto"])
                };

                lista.Add(venta);
            }

            return lista;
        }

        public List<Venta> ListarPorCliente(int idCliente)
        {
            return Listar().Where(v => v.Cliente.IdCliente == idCliente).ToList();
        }
    }
}
