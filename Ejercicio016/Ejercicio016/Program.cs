using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Alumno;

namespace Ejercicio016
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumne mateo = new Alumne("Mateo", "Meli", 1);
            Alumne tomi = new Alumne("Tomas", "Rotta", 2);
            Alumne chaka = new Alumne("Juancho", "Aguirre", 3);

            mateo.Estudiar(1, 1);
            tomi.Estudiar(7, 4);
            chaka.Estudiar(4, 3);

            mateo.CalcularFinal();
            tomi.CalcularFinal();
            chaka.CalcularFinal();

            Console.WriteLine(mateo.Mostrar());
            Console.WriteLine(tomi.Mostrar());
            Console.WriteLine(chaka.Mostrar());

            Console.ReadKey();
        }
    }
}
