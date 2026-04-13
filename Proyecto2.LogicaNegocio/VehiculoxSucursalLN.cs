using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto2.AccesoDatos;
using Proyecto2.Entidades;

namespace Proyecto2.LogicaNegocio
{
    public class VehiculoxSucursalLN
    {
        private readonly VehiculoxSucursalDA da = new VehiculoxSucursalDA();

        public bool Agregar(VehiculoxSucursal item)
        {
            if (item == null)
                throw new Exception("La relación vehículo-sucursal es nula.");

            if (item.Sucursal == null || item.Sucursal.IdSucursal <= 0)
                throw new Exception("Debe seleccionar una sucursal.");

            if (item.Vehiculo == null || item.Vehiculo.IdVehiculo <= 0)
                throw new Exception("Debe seleccionar un vehículo.");

            if (!item.Sucursal.Activo)
                throw new Exception("Solo se pueden asignar vehículos a sucursales activas.");

            if (item.Cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor que 0.");

            if (da.ExisteRelacion(item.Sucursal.IdSucursal, item.Vehiculo.IdVehiculo))
                throw new Exception("Ese vehículo ya está asociado a esa sucursal.");

            return da.Insertar(item);
        }

        public List<VehiculoxSucursal> Listar()
        {
            return da.Listar();
        }

        public List<VehiculoxSucursal> ListarPorSucursal(int idSucursal)
        {
            return da.ListarPorSucursal(idSucursal);
        }

        public bool RestarInventario(int idSucursal, int idVehiculo, int cantidad)
        {
            return da.RestarInventario(idSucursal, idVehiculo, cantidad);
        }
    }
}
