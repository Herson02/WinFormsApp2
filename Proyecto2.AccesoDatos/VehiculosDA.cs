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
    public class VehiculosDA
    {
        private readonly string conexion =
            ConfigurationManager.ConnectionStrings["AutoMarketDB"].ConnectionString;

        public bool Insertar(Vehiculos vehiculo)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"INSERT INTO Vehiculo
                             (IdVehiculo, Marca, Modelo, Ano, Precio, IdCategoria, Estado)
                             VALUES
                             (@IdVehiculo, @Marca, @Modelo, @Ano, @Precio, @IdCategoria, @Estado)";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdVehiculo", vehiculo.IdVehiculo);
            cmd.Parameters.AddWithValue("@Marca", vehiculo.Marca);
            cmd.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
            cmd.Parameters.AddWithValue("@Ano", vehiculo.Ano);
            cmd.Parameters.AddWithValue("@Precio", vehiculo.Precio);
            cmd.Parameters.AddWithValue("@IdCategoria", vehiculo.Categoria.IdCategoria);
            cmd.Parameters.AddWithValue("@Estado", vehiculo.Estado);

            int filas = cmd.ExecuteNonQuery();
            return filas > 0;
        }

        public List<Vehiculos> Listar()
        {
            List<Vehiculos> lista = new List<Vehiculos>();

            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = @"
                SELECT  v.IdVehiculo,
                        v.Marca,
                        v.Modelo,
                        v.Ano,
                        v.Precio,
                        v.Estado,
                        c.IdCategoria,
                        c.NombreCategoria,
                        c.Descripcion
                FROM Vehiculo v
                INNER JOIN CategoriaVehiculo c ON v.IdCategoria = c.IdCategoria";

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

                lista.Add(vehiculo);
            }

            return lista;
        }

        public bool ExisteId(int idVehiculo)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

            string query = "SELECT COUNT(*) FROM Vehiculo WHERE IdVehiculo = @IdVehiculo";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);

            int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
            return cantidad > 0;
        }
    }
}
