using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Cliente Cliente { get; set; } = new Cliente();
        public Sucursal Sucursal { get; set; } = new Sucursal();
        public Vehiculos Vehiculo { get; set; } = new Vehiculos();
        public DateTime FechaVenta { get; set; }
        public decimal Monto { get; set; }

        public Venta() { }

        public Venta(int idVenta, Cliente cliente, Sucursal sucursal,
                     Vehiculos vehiculo, DateTime fechaVenta, decimal monto)
        {
            IdVenta = idVenta;
            Cliente = cliente;
            Sucursal = sucursal;
            Vehiculo = vehiculo;
            FechaVenta = fechaVenta;
            Monto = monto;
        }
    }
}
