using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Entidades
{
    public class Vehiculos
    {
        public int IdVehiculo { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int Ano { get; set; }
        public decimal Precio { get; set; }
        public CategoriasVehiculos Categoria { get; set; } = new CategoriasVehiculos();
        public char Estado { get; set; }

        public Vehiculos() { }

        public Vehiculos(int idVehiculo, string marca, string modelo, int ano,
                         decimal precio, CategoriasVehiculos categoria, char estado)
        {
            IdVehiculo = idVehiculo;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Precio = precio;
            Categoria = categoria;
            Estado = estado;
        }
    }
}
