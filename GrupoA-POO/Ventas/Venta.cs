using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA_POO.Ventas
{
    public class Venta
    {//Atributos: Numero de venta, fecha, monto
        public int NumeroVenta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }


        // Constructor para la clase Venta
        public Venta(int numeroVenta, DateTime fecha, decimal monto)
        {
            NumeroVenta = numeroVenta;
            Fecha = fecha;
            Monto = monto;
        }
    }
}
