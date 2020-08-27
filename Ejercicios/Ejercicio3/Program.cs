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
            string numeroP;
            int numero;

            Console.WriteLine("Inserte un numero: ");
            numeroP = Console.ReadLine();
            int.TryParse(numeroP, out numero);

            for (i = 1; i < numero; i ++)
            {
                for (j = 1; j < numero -1; j ++)
                {
                    
                }
            }
            Console.ReadKey();
        }
    }
}
