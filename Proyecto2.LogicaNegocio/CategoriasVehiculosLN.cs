using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto2.AccesoDatos;
using Proyecto2.Entidades;

namespace Proyecto2.LogicaNegocio
{
    public class CategoriaVehiculoLN
    {
        private readonly CategoriaVehiculoDA da = new CategoriaVehiculoDA();

        public bool Agregar(CategoriasVehiculos categoria)
        {
            if (categoria == null)
                throw new Exception("La categoría es nula.");

            if (categoria.IdCategoria <= 0)
                throw new Exception("El Id de la categoría debe ser mayor que 0.");

            if (string.IsNullOrWhiteSpace(categoria.NombreCategoria))
                throw new Exception("El nombre de la categoría es obligatorio.");

            if (da.ExisteId(categoria.IdCategoria))
                throw new Exception("Ya existe una categoría con ese Id.");

            return da.Insertar(categoria);
        }

        public List<CategoriasVehiculos> Listar()
        {
            return da.Listar();
        }
    }
}
