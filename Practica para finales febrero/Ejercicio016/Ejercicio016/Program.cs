using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio016
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno mateo = new Alumno("Mateo", "Meli", 1);
            Alumno tomi = new Alumno("Tomi", "Rotta", 2);
            Alumno juancho = new Alumno("Juancho", "Aguirre", 3);

            mateo.Estudiar(4, 4);
            tomi.Estudiar(2, 9);
            juancho.Estudiar(8, 8);

            mateo.CalcularFinal();
            tomi.CalcularFinal();
            juancho.CalcularFinal();

            Console.WriteLine(mateo.Mostrar());
            Console.WriteLine(tomi.Mostrar());
            Console.WriteLine(juancho.Mostrar());
            Console.ReadKey();
        }
    }
}
