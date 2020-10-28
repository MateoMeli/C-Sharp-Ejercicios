using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string dni = "   ";
                CargarDni(dni);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine($"Debe indicar dni valido");
            }
            finally
            {

            }
            Console.ReadKey();
        }

        public static void CargarDni(string dni)
        {
            Persona persona = new Persona(dni);
        }

        public static double? Dividir(int num1, int? num2)
        {
            double? resultado = 0;
            try
            {
                resultado = num1 / num2;

                throw new NullReferenceException();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                throw new Exception("Mira que mandaste null", ex);
            }
            return resultado;
        }
    }
}
