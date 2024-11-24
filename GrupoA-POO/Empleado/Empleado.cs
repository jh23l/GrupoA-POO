using GrupoA_POO.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA_POO.Empleado
{
    public class Empleado
    {//Atributos: Nombre, dirección, correo electrónico, historial de ventas.
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public List<Venta> HistorialDeVentas { get; set; }


        // Constructor para inicializar un empleado
        public Empleado(string nombre, string direccion, string correoElectronico)
        {
            Nombre = nombre;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
            HistorialDeVentas = new List<Venta>();
        }


        //Métodos: Consultar Ventas.
        public void ConsultarVentas()
        {
            Console.WriteLine($"Ventas de {Nombre}:");
            foreach (var venta in HistorialDeVentas)
            {
                Console.WriteLine($"La venta número: {venta.NumeroVenta}, de fecha: {venta.Fecha}, tiene un monto de: {venta.Monto}");
            }
        }

        //Crear un objeto de la clase Empleado 
        static void Main(string[] args)
        {
            //Añadir información el 1er Empleado. Nombre, dirección, correo electrónico, historial de ventas.

            Empleado empleado1 = new Empleado("Ayssa Paulino", "Calle Luna, No. 2, Brisas, SDE", "apaulino@gmail.com");

            empleado1.HistorialDeVentas.Add(new Venta(1, DateTime.Now, 250.50m));
            empleado1.HistorialDeVentas.Add(new Venta(2, DateTime.Now, 300.75m));

            // Consultar ventas del empleado
            empleado1.ConsultarVentas();
        }

    }
}
