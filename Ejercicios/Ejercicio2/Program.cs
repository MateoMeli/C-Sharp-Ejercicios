using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio2";
            int numero;
            string numeroP;
            Console.WriteLine("Ingrese un numero mayor que cero: ");
            numeroP = Console.ReadLine();
            int.TryParse(numeroP, out numero);
            if(numero > 0)
            {
                Console.WriteLine("El cuadrado es {0} y el cubo es {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));
            }else
            {
                Console.WriteLine("ERROR! REINGRESE");
                
                
            }
            Console.ReadKey();
        }
    }
}
