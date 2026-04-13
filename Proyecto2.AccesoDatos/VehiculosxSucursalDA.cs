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
    public class VehiculoxSucursalDA
    {
        private readonly string conexion =
            ConfigurationManager.ConnectionStrings["AutoMarketDB"].ConnectionString;

        public bool Insertar(VehiculoxSucursal item)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"INSERT INTO VehiculoxSucursal
                             (IdSucursal, IdVehiculo, Cantidad)
                             VALUES
                             (@IdSucursal, @IdVehiculo, @Cantidad)";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdSucursal", item.Sucursal.IdSucursal);
            cmd.Parameters.AddWithValue("@IdVehiculo", item.Vehiculo.IdVehiculo);
            cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);

            int filas = cmd.ExecuteNonQuery();
            return filas > 0;
        }

        public List<VehiculoxSucursal> Listar()
        {
            List<VehiculoxSucursal> lista = new List<VehiculoxSucursal>();

            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"
                SELECT  s.IdSucursal,
                        s.Nombre AS NombreSucursal,
                        s.Direccion,
                        s.Telefono AS TelefonoSucursal,
                        s.Activo,
                        vnd.IdVendedor,
                        vnd.Identificacion,
                        vnd.NombreCompleto,
                        v.IdVehiculo,
                        v.Marca,
                        v.Modelo,
                        v.Ano,
                        v.Precio,
                        v.Estado,
                        c.IdCategoria,
                        c.NombreCategoria,
                        c.Descripcion,
                        vs.Cantidad
                FROM VehiculoxSucursal vs
                INNER JOIN Sucursal s ON vs.IdSucursal = s.IdSucursal
                INNER JOIN Vendedor vnd ON s.IdVendedor = vnd.IdVendedor
                INNER JOIN Vehiculo v ON vs.IdVehiculo = v.IdVehiculo
                INNER JOIN CategoriaVehiculo c ON v.IdCategoria = c.IdCategoria";

            using SqlCommand cmd = new SqlCommand(query, conn);
            using SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Vendedor vendedor = new Vendedor
                {
                    IdVendedor = Convert.ToInt32(dr["IdVendedor"]),
                    Identificacion = dr["Identificacion"].ToString() ?? "",
                    NombreCompleto = dr["NombreCompleto"].ToString() ?? ""
                };

                Sucursal sucursal = new Sucursal
                {
                    IdSucursal = Convert.ToInt32(dr["IdSucursal"]),
                    Nombre = dr["NombreSucursal"].ToString() ?? "",
                    Direccion = dr["Direccion"].ToString() ?? "",
                    Telefono = dr["TelefonoSucursal"].ToString() ?? "",
                    Activo = Convert.ToBoolean(dr["Activo"]),
                    VendedorEncargado = vendedor
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

                VehiculoxSucursal item = new VehiculoxSucursal
                {
                    Sucursal = sucursal,
                    Vehiculo = vehiculo,
                    Cantidad = Convert.ToInt32(dr["Cantidad"])
                };

                lista.Add(item);
            }

            return lista;
        }

        public bool ExisteRelacion(int idSucursal, int idVehiculo)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"SELECT COUNT(*) 
                             FROM VehiculoxSucursal
                             WHERE IdSucursal = @IdSucursal AND IdVehiculo = @IdVehiculo";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdSucursal", idSucursal);
            cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);

            int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
            return cantidad > 0;
        }

        public List<VehiculoxSucursal> ListarPorSucursal(int idSucursal)
        {
            return Listar().Where(x => x.Sucursal.IdSucursal == idSucursal).ToList();
        }

        public bool RestarInventario(int idSucursal, int idVehiculo, int cantidad)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"
                UPDATE VehiculoxSucursal
                SET Cantidad = Cantidad - @Cantidad
                WHERE IdSucursal = @IdSucursal
                  AND IdVehiculo = @IdVehiculo
                  AND Cantidad >= @Cantidad";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Cantidad", cantidad);
            cmd.Parameters.AddWithValue("@IdSucursal", idSucursal);
            cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);

            int filas = cmd.ExecuteNonQuery();
            return filas > 0;
        }
    }
}