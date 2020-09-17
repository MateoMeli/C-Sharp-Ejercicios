using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador mateo = new Jugador(414834789, "Mateo", 10, 5);
            mateo.GetPromedioGoles();
            Console.WriteLine(mateo.MostrarDatos());

            Console.ReadKey();
        }
    }
}
