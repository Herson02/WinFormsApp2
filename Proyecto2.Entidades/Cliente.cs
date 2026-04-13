using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Identificacion { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        public Cliente() { }

        public Cliente(int idCliente, string identificacion, string nombreCompleto,
                       DateTime fechaNacimiento, DateTime fechaRegistro, bool activo)
        {
            IdCliente = idCliente;
            Identificacion = identificacion;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }
    }
}
