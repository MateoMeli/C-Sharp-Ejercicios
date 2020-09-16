using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNombres = new List<string>();
            listaDeNombres.Add("Mateo");
            listaDeNombres.Add("Fede");
            listaDeNombres.Add("Cande");

            foreach (string nombre in listaDeNombres)
            {
                Console.WriteLine(nombre);
            }

            listaDeNombres.Remove("Fede");

            for(int i = 0; i < listaDeNombres.Count; i ++)
            {
                Console.WriteLine(listaDeNombres[i]);
            }

            listaDeNombres.RemoveAt(0);

            Console.WriteLine(listaDeNombres[0]);


            Dictionary<int, string> agenda = new Dictionary<int, string>();
            agenda.Add(12345678, "Juan Perez");
            agenda.Add(87654321, "Roberto Sanchez");
            agenda.Add(12345677, "Eriberto Gomez");
            agenda.Add(1234678, "Juan perez");

            foreach (KeyValuePair<int, string> contacto in agenda)
            {
                Console.WriteLine($"La clave es {contacto.Key} de nombre {contacto.Value}");
            }



            Queue<string> colaDeAtencion = new Queue<string>();
            colaDeAtencion.Enqueue("Juan Perez");
            colaDeAtencion.Enqueue("Gero Aducci");
            colaDeAtencion.Enqueue("Sabrina Gomez");

            Console.WriteLine(colaDeAtencion.Dequeue());
            Console.WriteLine(colaDeAtencion.Dequeue());
            Console.WriteLine(colaDeAtencion.Dequeue());



            Stack<char> letras = new Stack<char>();
            letras.Push('p');
            letras.Push('s');
            letras.Push('d');

            foreach (char letra in letras)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine(letras.Peek());

            Console.WriteLine(letras.Pop());
            Console.WriteLine(letras.Pop());
            Console.WriteLine(letras.Pop());

            Console.ReadKey();
        }
    }
}
