using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto2.AccesoDatos;
using Proyecto2.Entidades;

namespace Proyecto2.LogicaNegocio
{
    public class SucursalLN
    {
        private readonly SucursalDA da = new SucursalDA();

        public bool Agregar(Sucursal sucursal)
        {
            if (sucursal == null)
                throw new Exception("La sucursal es nula.");

            if (sucursal.IdSucursal <= 0)
                throw new Exception("El Id de la sucursal debe ser mayor que 0.");

            if (string.IsNullOrWhiteSpace(sucursal.Nombre))
                throw new Exception("El nombre de la sucursal es obligatorio.");

            if (string.IsNullOrWhiteSpace(sucursal.Direccion))
                throw new Exception("La dirección de la sucursal es obligatoria.");

            if (sucursal.VendedorEncargado == null || sucursal.VendedorEncargado.IdVendedor <= 0)
                throw new Exception("Debe seleccionar un vendedor encargado.");

            if (da.ExisteId(sucursal.IdSucursal))
                throw new Exception("Ya existe una sucursal con ese Id.");

            return da.Insertar(sucursal);
        }

        public List<Sucursal> Listar()
        {
            return da.Listar();
        }
    }
}
