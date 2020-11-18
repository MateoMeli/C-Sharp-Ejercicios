using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> tb = new Torneo<EquipoBasquet>("Torneo Basquet");
            Torneo<EquipoFutbol> tf = new Torneo<EquipoFutbol>("Torneo Futbol");

            EquipoBasquet eb1 = new EquipoBasquet("Basquet 1", new DateTime(1999, 06, 02));
            EquipoBasquet eb2 = new EquipoBasquet("Basquet 2", new DateTime(1999, 06, 03));
            EquipoBasquet eb3 = new EquipoBasquet("Basquet 3", new DateTime(1999, 06, 04));

            EquipoFutbol ef1 = new EquipoFutbol("Futbol 1", new DateTime(1999, 06, 05));
            EquipoFutbol ef2 = new EquipoFutbol("Futbol 2", new DateTime(1999, 06, 06));
            EquipoFutbol ef3 = new EquipoFutbol("Futbol 3", new DateTime(1999, 06, 07));

            tb += eb1;
            tb += eb2;
            tb += eb3;

            tf += ef1;
            tf += ef2;
            tf += ef3;

            Console.WriteLine(tb.ToString());
            Console.WriteLine(tf.ToString());

            Console.WriteLine(tb.JugarPartido);
            Console.WriteLine(tf.JugarPartido);

            Console.ReadKey();        
        }
    }
}
