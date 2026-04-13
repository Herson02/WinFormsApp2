using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Entidades
{
    public class VehiculoxSucursal
    {
        public Sucursal Sucursal { get; set; } = new Sucursal();
        public Vehiculos Vehiculo { get; set; } = new Vehiculos();
        public int Cantidad { get; set; }

        public VehiculoxSucursal() { }

        public VehiculoxSucursal(Sucursal sucursal, Vehiculos vehiculo, int cantidad)
        {
            Sucursal = sucursal;
            Vehiculo = vehiculo;
            Cantidad = cantidad;
        }
    }
}
