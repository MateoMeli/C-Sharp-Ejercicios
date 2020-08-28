using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BibliotecaEj14;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double cuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double circulo;
            Console.WriteLine("Ingrese la base del cuadrado: ");
            if(double.TryParse(Console.ReadLine(), out cuadrado))
            {
                Console.WriteLine("El area del cuadrado es {0}", CalculoDeArea.CalcularCuadrado(cuadrado));
            }else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Ingrese la base del triangulo: ");
            if(double.TryParse(Console.ReadLine(), out baseTriangulo))
            {
                Console.WriteLine("Ingrese la altura del triangulo: ");
                if(double.TryParse(Console.ReadLine(), out alturaTriangulo))
                {
                    Console.WriteLine("El area del triangulo es {0}", CalculoDeArea.Calculartriangulo(baseTriangulo, alturaTriangulo));
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Ingrese el radio del circulo: ");
            if (double.TryParse(Console.ReadLine(), out circulo))
            {
                Console.WriteLine("El area del circulo es {0}", CalculoDeArea.CalcularCirculo(circulo));
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}
