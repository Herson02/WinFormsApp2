using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Entidades
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }
        public string Identificacion { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; } = string.Empty;

        public Vendedor() { }

        public Vendedor(int idVendedor, string identificacion, string nombreCompleto,
                        DateTime fechaNacimiento, DateTime fechaIngreso, string telefono)
        {
            IdVendedor = idVendedor;
            Identificacion = identificacion;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
            FechaIngreso = fechaIngreso;
            Telefono = telefono;
        }
    }
}
