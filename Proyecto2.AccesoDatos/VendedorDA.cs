using Microsoft.Data.SqlClient;
using Proyecto2.Entidades;
using System.Configuration;

namespace Proyecto2.AccesoDatos
{
    public class VendedorDA
    {
        private readonly string conexion =
            ConfigurationManager.ConnectionStrings["AutoMarketDB"].ConnectionString;

        public bool Insertar(Vendedor vendedor)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"INSERT INTO Vendedor
                             (IdVendedor, Identificacion, NombreCompleto, FechaNacimiento, FechaIngreso, Telefono)
                             VALUES
                             (@IdVendedor, @Identificacion, @NombreCompleto, @FechaNacimiento, @FechaIngreso, @Telefono)";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdVendedor", vendedor.IdVendedor);
            cmd.Parameters.AddWithValue("@Identificacion", vendedor.Identificacion);
            cmd.Parameters.AddWithValue("@NombreCompleto", vendedor.NombreCompleto);
            cmd.Parameters.AddWithValue("@FechaNacimiento", vendedor.FechaNacimiento);
            cmd.Parameters.AddWithValue("@FechaIngreso", vendedor.FechaIngreso);
            cmd.Parameters.AddWithValue("@Telefono", vendedor.Telefono);

            int filas = cmd.ExecuteNonQuery();
            return filas > 0;
        }

        public List<Vendedor> Listar()
        {
            List<Vendedor> lista = new List<Vendedor>();

            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"SELECT IdVendedor, Identificacion, NombreCompleto,
                                    FechaNacimiento, FechaIngreso, Telefono
                             FROM Vendedor";

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
                    Telefono = dr["Telefono"].ToString() ?? ""
                };

                lista.Add(vendedor);
            }

            return lista;
        }

        public bool ExisteId(int idVendedor)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = "SELECT COUNT(*) FROM Vendedor WHERE IdVendedor = @IdVendedor";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdVendedor", idVendedor);

            int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
            return cantidad > 0;
        }

        public bool ExisteIdentificacion(string identificacion)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = "SELECT COUNT(*) FROM Vendedor WHERE Identificacion = @Identificacion";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Identificacion", identificacion);

            int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
            return cantidad > 0;
        }
    }
}
