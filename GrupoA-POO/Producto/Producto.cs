using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA_POO.Producto
{
    public class Producto
    {
        // Atributos
        // Nombre del producto
        public String Nombre { get; set; }

        // Descripción del producto
        public String Descripcion { get; set; }

        // Precio del producto
        public decimal Precio { get; set; }

        // Cantidad de unidades del producto en stock
        public int CantidadStock { get; set; }


        // Iniciar un nuevo objeto Producto con los valores proporcionados
        public Producto(string nombre, string descripcion, decimal precio, int cantidadStock)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            CantidadStock = cantidadStock;
        }

        public void AgregarAlCarrito()
        {
            Console.WriteLine("Se a agregado el producto al carrito");

        }
    }
}

