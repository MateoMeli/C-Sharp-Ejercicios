using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BibliotecaMascota;

namespace Clase2Mascotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota;

            mascota = new Mascota("Mateo", new DateTime(1999, 06, 02), "Humano");
            Console.WriteLine(mascota.MostrarDatos());
            Console.WriteLine("La edad es " + mascota.CalcularEdad());

            Console.ReadKey();
        }
    }
}
