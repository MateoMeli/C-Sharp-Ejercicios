using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio012
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int num;
            char respuesta;
            do
            {
                Console.WriteLine("Ingrese numero entero a sumar: ");
                if(int.TryParse(Console.ReadLine(), out num))
                {
                    acumulador += num;
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                    break;
                }
                Console.WriteLine("Desea seguir ingresando numeros? S/N");
                char.TryParse(Console.ReadLine(), out respuesta);


            } while (ValidarRespuesta.ValidarS_N(respuesta));
            Console.WriteLine(acumulador);
            Console.ReadKey();
        }
    }
}
