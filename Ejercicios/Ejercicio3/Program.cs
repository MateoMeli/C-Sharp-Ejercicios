using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio3";
            int i, j;
            int numero;

            Console.WriteLine("Inserte un numero: ");
            int.TryParse(Console.ReadLine(), out numero);

            if(numero > 1)
            {
                for (i = 2; i <= numero; i++)
                {
                    bool esPrimo = true;
                    for (j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }
                    if (esPrimo)
                    {
                        Console.WriteLine("{0} es primo", i);
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay numeros primos");
            }
            Console.ReadKey();
        }
    }
}
