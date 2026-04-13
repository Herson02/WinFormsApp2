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
    public class SucursalDA
    {
        private readonly string conexion =
            ConfigurationManager.ConnectionStrings["AutoMarketDB"].ConnectionString;

        public bool Insertar(Sucursal sucursal)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"INSERT INTO Sucursal
                             (IdSucursal, Nombre, Direccion, Telefono, IdVendedor, Activo)
                             VALUES
                             (@IdSucursal, @Nombre, @Direccion, @Telefono, @IdVendedor, @Activo)";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdSucursal", sucursal.IdSucursal);
            cmd.Parameters.AddWithValue("@Nombre", sucursal.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", sucursal.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", sucursal.Telefono);
            cmd.Parameters.AddWithValue("@IdVendedor", sucursal.VendedorEncargado.IdVendedor);
            cmd.Parameters.AddWithValue("@Activo", sucursal.Activo);

            int filas = cmd.ExecuteNonQuery();
            return filas > 0;
        }

        public List<Sucursal> Listar()
        {
            List<Sucursal> lista = new List<Sucursal>();

            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"
                SELECT  s.IdSucursal,
                        s.Nombre,
                        s.Direccion,
                        s.Telefono,
                        s.Activo,
                        v.IdVendedor,
                        v.Identificacion,
                        v.NombreCompleto,
                        v.FechaNacimiento,
                        v.FechaIngreso,
                        v.Telefono AS TelefonoVendedor
                FROM Sucursal s
                INNER JOIN Vendedor v ON s.IdVendedor = v.IdVendedor";

            using SqlCommand cmd = new SqlCommand(query, conn);
            using SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Vendedor vendedor = new Vendedor
                {
                    IdVendedor = Convert.ToInt32(dr["IdVendedor"]),
                    Identificacion = dr["Identificacion"].ToString() ?? "",
                    NombreCompleto = dr["NombreCompleto"].ToString() ?? "",
                    FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                    FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]),
                    Telefono = dr["TelefonoVendedor"].ToString() ?? ""
                };

                Sucursal sucursal = new Sucursal
                {
                    IdSucursal = Convert.ToInt32(dr["IdSucursal"]),
                    Nombre = dr["Nombre"].ToString() ?? "",
                    Direccion = dr["Direccion"].ToString() ?? "",
                    Telefono = dr["Telefono"].ToString() ?? "",
                    Activo = Convert.ToBoolean(dr["Activo"]),
                    VendedorEncargado = vendedor
                };

                lista.Add(sucursal);
            }

            return lista;
        }

        public bool ExisteId(int idSucursal)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = "SELECT COUNT(*) FROM Sucursal WHERE IdSucursal = @IdSucursal";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdSucursal", idSucursal);

            int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
            return cantidad > 0;
        }
    }
}
