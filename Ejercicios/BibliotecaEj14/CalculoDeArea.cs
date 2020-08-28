using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEj14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double valor)
        {
            return valor * valor;
        }
        public static double Calculartriangulo(double bases, double altura)
        {
            return (bases * altura / 2);
        }
        public static double CalcularCirculo(double radio)
        {
            return (Math.PI * radio * radio);
        }
    }
}
