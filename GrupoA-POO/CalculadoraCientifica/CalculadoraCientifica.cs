using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrupoA_POO.Operaciones;
using GrupoA_POO.CalculadoraBase;

namespace GrupoA_POO.CalculadoraCientifica
{
    public class CalculadoraCientifica : GrupoA_POO.CalculadoraBase.CalculadoraBase
    {
        public double CalcularSenoEnGrados(double anguloGrados)
        {
            double anguloRadianes = anguloGrados * Math.PI / 180;
            return Math.Sin(anguloRadianes);
        }

        public double CalcularCosenoEnGrados(double anguloGrados)
        {
            double anguloRadianes = anguloGrados * Math.PI / 180;
            return Math.Cos(anguloRadianes);
        }

        public double CalcularTangenteEnGrados(double anguloGrados)
        {
            double anguloRadianes = anguloGrados * Math.PI / 180;
            return Math.Tan(anguloRadianes);
        }

        public int CalcularFactorial(int num)
        {
            int calculo = 1;
            for (int i = num; i >= 1; i--)
            {
                calculo = calculo * i;
            }
           return calculo;
        }

        public int ValorAbsoluto(int a)
        {
            return Math.Abs(a);
        }

        public double RaizCuadrada(double a)
        {
            return Math.Sqrt(a);
        }

    }

}
