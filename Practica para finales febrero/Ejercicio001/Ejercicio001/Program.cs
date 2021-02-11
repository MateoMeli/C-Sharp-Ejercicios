using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio001
{
    class Program
    {
        //1.	Ingresar 5 números por consola, guardándolos en una variable escalar.
        //Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
        static void Main(string[] args)
        {
            Console.Title = "Enrique Gay";
            int i;
            int numero;
            int acumulador = 0;
            int promedio;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                string num = Console.ReadLine();
                int.TryParse(num, out numero);
                if (numero > max)
                {
                    max = numero;
                }
                if(numero < min)
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
