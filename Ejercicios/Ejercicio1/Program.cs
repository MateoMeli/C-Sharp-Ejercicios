using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio1";
            int i;
            int numero;
            int max = int.MinValue;
            int min = int.MaxValue;
            int acumulador = 0;
            int promedio;

            for( i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                string numeroP = Console.ReadLine();
                int.TryParse(numeroP, out numero);

                if(numero > max)
                {
                    max = numero;
                }else  if(numero < min)
                {
                    min = numero;
                }
                acumulador += numero;
            }
            promedio = acumulador / 5;
            Console.WriteLine("El minimo es {0}, el maximo es {1} y el promedio es {2}", min, max, promedio);
            Console.ReadKey();
        }
    }
}
