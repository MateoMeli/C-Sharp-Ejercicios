using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio002
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero: ");
            if(int.TryParse(Console.ReadLine(), out num) && num > 0)
            {
                Console.WriteLine("Cuadrado: {0}     Cubo {1}", Math.Pow(num, 2), Math.Pow(num, 3));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("ERROR TIENE QUE SER MAYOR A CERO");
                Console.ReadKey();
            }

        }
    }
}
