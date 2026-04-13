using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Entidades
{
    public class CategoriasVehiculos
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public CategoriasVehiculos() { }

        public CategoriasVehiculos(int idCategoria, string nombreCategoria, string descripcion)
        {
            IdCategoria = idCategoria;
            NombreCategoria = nombreCategoria;
            Descripcion = descripcion;
        }
    }
}
