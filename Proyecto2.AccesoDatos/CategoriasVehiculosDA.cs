using Microsoft.Data.SqlClient;
using Proyecto2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Proyecto2.AccesoDatos
{
    public class CategoriaVehiculoDA
    {
        private readonly string conexion =
            ConfigurationManager.ConnectionStrings["AutoMarketDB"].ConnectionString;

        public bool Insertar(CategoriasVehiculos categoria)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"INSERT INTO CategoriaVehiculo (IdCategoria, NombreCategoria, Descripcion)
                             VALUES (@IdCategoria, @NombreCategoria, @Descripcion)";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
            cmd.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
            cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

            int filas = cmd.ExecuteNonQuery();
            return filas > 0;
        }

        public List<CategoriasVehiculos> Listar()
        {
            List<CategoriasVehiculos> lista = new List<CategoriasVehiculos>();

            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = "SELECT IdCategoria, NombreCategoria, Descripcion FROM CategoriaVehiculo";

            using SqlCommand cmd = new SqlCommand(query, conn);
            using SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CategoriasVehiculos categoria = new CategoriasVehiculos
                {
                    IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                    NombreCategoria = dr["NombreCategoria"].ToString() ?? "",
                    Descripcion = dr["Descripcion"].ToString() ?? ""
                };

                lista.Add(categoria);
            }

            return lista;
        }

        public bool ExisteId(int idCategoria)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = "SELECT COUNT(*) FROM CategoriaVehiculo WHERE IdCategoria = @IdCategoria";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);

            int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
            return cantidad > 0;
        }
    }
}
