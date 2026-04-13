using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto2.AccesoDatos;
using Proyecto2.Entidades;

namespace Proyecto2.LogicaNegocio
{
    public class VehiculoLN
    {
        private readonly VehiculosDA da = new VehiculosDA();

        public bool Agregar(Vehiculos vehiculo)
        {
            if (vehiculo == null)
                throw new Exception("El vehículo es nulo.");

            if (vehiculo.IdVehiculo <= 0)
                throw new Exception("El Id del vehículo debe ser mayor que 0.");

            if (string.IsNullOrWhiteSpace(vehiculo.Marca))
                throw new Exception("La marca es obligatoria.");

            if (string.IsNullOrWhiteSpace(vehiculo.Modelo))
                throw new Exception("El modelo es obligatorio.");

            if (vehiculo.Ano < 1900 || vehiculo.Ano > DateTime.Today.Year + 1)
                throw new Exception("El año del vehículo no es válido.");

            if (vehiculo.Precio <= 0)
                throw new Exception("El precio debe ser mayor que 0.");

            if (vehiculo.Categoria == null || vehiculo.Categoria.IdCategoria <= 0)
                throw new Exception("Debe seleccionar una categoría.");

            if (vehiculo.Estado != 'N' && vehiculo.Estado != 'U')
                throw new Exception("El estado debe ser 'N' o 'U'.");

            if (da.ExisteId(vehiculo.IdVehiculo))
                throw new Exception("Ya existe un vehículo con ese Id.");

            return da.Insertar(vehiculo);
        }

        public List<Vehiculos> Listar()
        {
            return da.Listar();
        }
    }
}
