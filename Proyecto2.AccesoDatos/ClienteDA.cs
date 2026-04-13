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
    public class ClienteDA
    {
        private readonly string conexion =
            ConfigurationManager.ConnectionStrings["AutoMarketDB"].ConnectionString;

        public bool Insertar(Cliente cliente)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"INSERT INTO Cliente
                             (IdCliente, Identificacion, NombreCompleto, FechaNacimiento, FechaRegistro, Activo)
                             VALUES
                             (@IdCliente, @Identificacion, @NombreCompleto, @FechaNacimiento, @FechaRegistro, @Activo)";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
            cmd.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
            cmd.Parameters.AddWithValue("@NombreCompleto", cliente.NombreCompleto);
            cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
            cmd.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);
            cmd.Parameters.AddWithValue("@Activo", cliente.Activo);

            int filas = cmd.ExecuteNonQuery();
            return filas > 0;
        }

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"SELECT IdCliente, Identificacion, NombreCompleto,
                                    FechaNacimiento, FechaRegistro, Activo
                             FROM Cliente";

            using SqlCommand cmd = new SqlCommand(query, conn);
            using SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cliente cliente = new Cliente
                {
                    IdCliente = Convert.ToInt32(dr["IdCliente"]),
                    Identificacion = dr["Identificacion"].ToString() ?? "",
                    NombreCompleto = dr["NombreCompleto"].ToString() ?? "",
                    FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                    FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                    Activo = Convert.ToBoolean(dr["Activo"])
                };

                lista.Add(cliente);
            }

            return lista;
        }

        public bool ExisteId(int idCliente)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = "SELECT COUNT(*) FROM Cliente WHERE IdCliente = @IdCliente";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdCliente", idCliente);

            int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
            return cantidad > 0;
        }

        public bool ExisteIdentificacion(string identificacion)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = "SELECT COUNT(*) FROM Cliente WHERE Identificacion = @Identificacion";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Identificacion", identificacion);

            int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
            return cantidad > 0;
        }

        public Cliente? BuscarPorIdentificacion(string identificacion)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"SELECT IdCliente, Identificacion, NombreCompleto,
                                    FechaNacimiento, FechaRegistro, Activo
                             FROM Cliente
                             WHERE Identificacion = @Identificacion";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Identificacion", identificacion);

            using SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                return new Cliente
                {
                    IdCliente = Convert.ToInt32(dr["IdCliente"]),
                    Identificacion = dr["Identificacion"].ToString() ?? "",
                    NombreCompleto = dr["NombreCompleto"].ToString() ?? "",
                    FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                    FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                    Activo = Convert.ToBoolean(dr["Activo"])
                };
            }

            return null;
        }
    }
}
