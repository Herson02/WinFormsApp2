using Proyecto2.AccesoDatos;
using Proyecto2.Entidades;

namespace Proyecto2.LogicaNegocio
{
    public class VendedorLN
    {
        private readonly VendedorDA da = new VendedorDA();

        public bool Agregar(Vendedor vendedor)
        {
            if (vendedor == null)
                throw new Exception("El vendedor es nulo.");

            if (vendedor.IdVendedor <= 0)
                throw new Exception("El Id del vendedor debe ser mayor que 0.");

            if (string.IsNullOrWhiteSpace(vendedor.Identificacion))
                throw new Exception("La identificación es obligatoria.");

            if (string.IsNullOrWhiteSpace(vendedor.NombreCompleto))
                throw new Exception("El nombre completo es obligatorio.");

            if (vendedor.FechaNacimiento > DateTime.Today)
                throw new Exception("La fecha de nacimiento no puede ser futura.");

            if (vendedor.FechaIngreso > DateTime.Today)
                throw new Exception("La fecha de ingreso no puede ser futura.");

            if (vendedor.FechaIngreso <= vendedor.FechaNacimiento)
                throw new Exception("La fecha de ingreso debe ser posterior a la fecha de nacimiento.");

            if (da.ExisteId(vendedor.IdVendedor))
                throw new Exception("Ya existe un vendedor con ese Id.");

            if (da.ExisteIdentificacion(vendedor.Identificacion))
                throw new Exception("Ya existe un vendedor con esa identificación.");

            return da.Insertar(vendedor);
        }

        public List<Vendedor> Listar()
        {
            return da.Listar();
        }
    }
}
