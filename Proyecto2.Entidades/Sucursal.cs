using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Entidades
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public Vendedor VendedorEncargado { get; set; } = new Vendedor();
        public bool Activo { get; set; }

        public Sucursal() { }

        public Sucursal(int idSucursal, string nombre, string direccion, string telefono,
                        Vendedor vendedorEncargado, bool activo)
        {
            IdSucursal = idSucursal;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            VendedorEncargado = vendedorEncargado;
            Activo = activo;
        }
    }
}
