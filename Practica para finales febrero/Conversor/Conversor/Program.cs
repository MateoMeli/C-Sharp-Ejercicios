using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroDecimal numdeci = new NumeroDecimal(5);
            NumeroBinario numbin = new NumeroBinario("11");

            Console.WriteLine(numbin + numdeci);

            Console.WriteLine(numbin - numdeci);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
