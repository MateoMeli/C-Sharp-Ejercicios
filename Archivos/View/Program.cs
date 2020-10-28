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

                string texto = "Hola mundo!";
                string nombreArchivo = "clase_19";
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                FileManager archivo = new FileManager();
                archivo.EscribirArchivoTexto(ruta, nombreArchivo, texto, false);
                archivo.EscribirArchivoTexto(ruta, nombreArchivo, "Chau mundo!", true);

                Console.WriteLine(archivo.LeerArchivoTexto(ruta, nombreArchivo));

                
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocurrio un error {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
