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
            int i;
            string numeroP;
            int numero;

            Console.WriteLine("Inserte un numero: ");
            numeroP = Console.ReadLine();
            int.TryParse(numeroP, out numero);

            for(i = 1; i <= numero; i ++)
            {
                if(numero%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
