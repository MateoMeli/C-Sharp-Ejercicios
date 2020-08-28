using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BibliotecaEj15;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            double numero1;
            double numero2;
            char operacion;
            do
            {
                Console.WriteLine("Ingrese el primer operando: ");
                double.TryParse(Console.ReadLine(), out numero1);

                Console.WriteLine("Ingrese el segundo operando: ");
                double.TryParse(Console.ReadLine(), out numero2);

                Console.WriteLine("Ingrese el tipo de operacion (+) (-) (*) (/) : ");
                char.TryParse(Console.ReadLine(), out operacion);

                Console.WriteLine("El resultado de la operacion es {0}", Calculadora.Calcular(numero1, numero2, operacion));

                Console.WriteLine("Desea continuar haciendo operaciones? s/n?");
                char.TryParse(Console.ReadLine(), out respuesta);
            } while (respuesta == 's');
            Console.ReadKey();
        }
    }
}
