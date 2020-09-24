using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Alumno("Juan");
            Persona p2 = new Profesor("Maria");
            Alumno p3 = new Alumno("Pedro");
            Profesor p4 = new Profesor("Matias");

            

            Console.WriteLine(p1.QuienSoy() + " " + p1.DeciUnNumero);
            Console.WriteLine(p2.QuienSoy() + " " + p2.DeciUnNumero);
            Console.WriteLine(p3.QuienSoy() + " " + p3.DeciUnNumero);
            Console.WriteLine(p4.QuienSoy() + " " + p4.DeciUnNumero);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(p1.SoyVirtualDeQuien());
            Console.WriteLine(p2.SoyVirtualDeQuien());
            Console.WriteLine(p3.SoyVirtualDeQuien());
            Console.WriteLine(p4.SoyVirtualDeQuien());

            Console.ReadKey();
        }
    }
}
