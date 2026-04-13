using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto2.AccesoDatos;
using Proyecto2.Entidades;

namespace Proyecto2.LogicaNegocio
{
    public class VentaLN
    {
        private readonly VentaDA ventaDA = new VentaDA();
        private readonly ClienteLN clienteLN = new ClienteLN();
        private readonly VehiculoxSucursalLN vehiculoxSucursalLN = new VehiculoxSucursalLN();

        private static readonly object lockVenta = new object();

        public bool RegistrarVenta(Cliente cliente, Sucursal sucursal, Vehiculos vehiculo)
        {
            lock (lockVenta)
            {
                if (cliente == null || cliente.IdCliente <= 0)
                    throw new Exception("Cliente inválido.");

                if (sucursal == null || sucursal.IdSucursal <= 0)
                    throw new Exception("Sucursal inválida.");

                if (vehiculo == null || vehiculo.IdVehiculo <= 0)
                    throw new Exception("Vehículo inválido.");

                Cliente? clienteBD = clienteLN.BuscarPorIdentificacion(cliente.Identificacion);

                if (clienteBD == null)
                    throw new Exception("El cliente no existe.");

                if (!clienteBD.Activo)
                    throw new Exception("El cliente está inactivo y no puede comprar.");

                var inventarioSucursal = vehiculoxSucursalLN.ListarPorSucursal(sucursal.IdSucursal);
                var item = inventarioSucursal.FirstOrDefault(x => x.Vehiculo.IdVehiculo == vehiculo.IdVehiculo);

                if (item == null)
                    throw new Exception("Ese vehículo no está disponible en la sucursal seleccionada.");

                if (item.Cantidad <= 0)
                    throw new Exception("No hay inventario disponible para ese vehículo.");

                bool descuento = vehiculoxSucursalLN.RestarInventario(sucursal.IdSucursal, vehiculo.IdVehiculo, 1);

                if (!descuento)
                    throw new Exception("No fue posible descontar inventario.");

                Venta venta = new Venta
                {
                    Cliente = clienteBD,
                    Sucursal = sucursal,
                    Vehiculo = vehiculo,
                    FechaVenta = DateTime.Now,
                    Monto = vehiculo.Precio
                };

                return ventaDA.Insertar(venta);
            }
        }

        public List<Venta> Listar()
        {
            return ventaDA.Listar();
        }

        public List<Venta> ListarPorCliente(int idCliente)
        {
            return ventaDA.ListarPorCliente(idCliente);
        }
    }
}
