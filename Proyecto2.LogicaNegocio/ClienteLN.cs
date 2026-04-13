using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto2.AccesoDatos;
using Proyecto2.Entidades;

namespace Proyecto2.LogicaNegocio
{
    public class ClienteLN
    {
        private readonly ClienteDA da = new ClienteDA();

        public bool Agregar(Cliente cliente)
        {
            if (cliente == null)
                throw new Exception("El cliente es nulo.");

            if (cliente.IdCliente <= 0)
                throw new Exception("El Id del cliente debe ser mayor que 0.");

            if (string.IsNullOrWhiteSpace(cliente.Identificacion))
                throw new Exception("La identificación es obligatoria.");

            if (string.IsNullOrWhiteSpace(cliente.NombreCompleto))
                throw new Exception("El nombre completo es obligatorio.");

            if (cliente.FechaNacimiento > DateTime.Today)
                throw new Exception("La fecha de nacimiento no puede ser futura.");

            if (cliente.FechaRegistro > DateTime.Today)
                throw new Exception("La fecha de registro no puede ser futura.");

            if (cliente.FechaRegistro <= cliente.FechaNacimiento)
                throw new Exception("La fecha de registro debe ser posterior a la fecha de nacimiento.");

            if (da.ExisteId(cliente.IdCliente))
                throw new Exception("Ya existe un cliente con ese Id.");

            if (da.ExisteIdentificacion(cliente.Identificacion))
                throw new Exception("Ya existe un cliente con esa identificación.");

            return da.Insertar(cliente);
        }

        public List<Cliente> Listar()
        {
            return da.Listar();
        }

        public Cliente? BuscarPorIdentificacion(string identificacion)
        {
            return da.BuscarPorIdentificacion(identificacion);
        }
    }
}
