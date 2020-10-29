using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Persona> personas = new List<Persona>();
                Persona persona = new Persona("Fede", "Davila", new DateTime(1984, 03, 14));
                Persona persona2 = new Persona("Mauricio", "Cerizza", new DateTime(1984, 03, 14));
                Serializador<List<Persona>> serializador = new Serializador<List<Persona>>();

                personas.Add(persona);
                personas.Add(persona2);

                serializador.Serializar(personas, "Profes.xml");

                List<Persona> personas2 = new List<Persona>();
                personas2 = serializador.Deserializar("Profes.xml");
                

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocurrio un error {ex.Message}");
            }
            Console.ReadKey();
        }
    }
                   /*
                string texto = "Hola mundo!";
                string nombreArchivo = "clase_19";
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                FileManager archivo = new FileManager();
                archivo.EscribirArchivoTexto(ruta, nombreArchivo, texto, false);
                archivo.EscribirArchivoTexto(ruta, nombreArchivo, "Chau mundo!", true);

                Console.WriteLine(archivo.LeerArchivoTexto(ruta, nombreArchivo));*/
}
