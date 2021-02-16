using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio019
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador();
            Console.WriteLine(sumador.Sumar("culo", "caca"));
            Console.WriteLine(sumador.Sumar(4, 4));

            Console.WriteLine(sumador2.Sumar("pito", "pis"));
            Console.WriteLine(sumador2.Sumar(8, 8));

            Console.WriteLine((int)sumador);
            Console.WriteLine((int)sumador2);
            Console.WriteLine(sumador + sumador2);
            Console.WriteLine(sumador | sumador2);

            Console.ReadKey();
        }
    }
}
