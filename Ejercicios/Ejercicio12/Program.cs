using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BibliotecaEj12;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;
            char respuesta;
            do
            {
                Console.WriteLine("Ingrese un numero a sumar: ");
                if(int.TryParse(Console.ReadLine(), out numero))
                {
                    acumulador += numero;
                }
                else
                {
                    Console.WriteLine("Error");
                    break;
                }

                Console.WriteLine("Desea continuar ingresando numeros? S/N");
                char.TryParse(Console.ReadLine(), out respuesta);
            } while (ValidarRespuesta.ValidarS_N(respuesta));
            Console.WriteLine("La suma de los valores ingresados es {0}", acumulador);
            Console.ReadKey();
        }
        
    }
}
