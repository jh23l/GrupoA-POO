using GrupoA_POO.Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA_POO.CalculadoraBase
{
    public abstract class CalculadoraBase : IOperaciones
    {
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir entre 0.");
                return double.NaN; 
            }
            else
            {
                return a / b;
            }
        }

        public double CalcularAreaCirculo(double radio)
        {
            return radio * radio * Math.PI;
        }

        public double CalcularVolumenEsfera(double radio)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
        }

        public double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}