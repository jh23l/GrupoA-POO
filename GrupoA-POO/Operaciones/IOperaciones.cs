using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA_POO.Operaciones
{
    public interface IOperaciones
    {
        // Suma dos números. 
        double Sumar(double a, double b);
        // Resta dos números. 
        double Restar(double a, double b);
        //Multiplica dos números. 
        double Multiplicar(double a, double b);
        //Divide dos números(manejar la división por cero). 
        double Dividir(double a, double b);
        //Calcula el área de un círculo. 
        double CalcularAreaCirculo(double radio);
        //Calcula el volumen de una esfera. 
        double CalcularVolumenEsfera(double radio);
        //Calcula la distancia entre dos puntos en un plano cartesiano.  double CalcularDistancia(double x1, double y1, double x2, double y2); } 

    }


}