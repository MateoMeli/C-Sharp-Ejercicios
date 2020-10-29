using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "Hola como andas?";
            Console.WriteLine("{0} tiene {1} palabras", dato, dato.ContadorPalabras(' '));
            Console.ReadKey(); 
        }
    }
}
