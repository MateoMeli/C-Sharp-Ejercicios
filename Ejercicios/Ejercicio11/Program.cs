using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BibliotecaEj11;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int min = int.MaxValue;
            int max = int.MinValue;
            int acumulador = 0;
            int promedio;
            for(int i = 0; i < 10; i ++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100");
                if (int.TryParse(Console.ReadLine(), out numero) && Validaciones.Validar(numero, 100, -100))
                {
                    if(numero > max)
                    {
                        max = numero;
                    }
                    if(numero < min)
                    {
                        min = numero;
                    }
                    acumulador += numero;
                }
                else
                {
                    Console.WriteLine("Error");
                    break;
                }
            }
            promedio = acumulador / 10;
            Console.WriteLine("El valor minimo es {0}, el maximo es {1} y el promedio es {2}", min, max, promedio);
            Console.ReadKey();
        }
    }
}
