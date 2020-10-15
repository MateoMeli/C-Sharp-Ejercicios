using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Empezo el programa.");
                double resultado = Dividir(5, 0);

                Console.WriteLine("Ya dividi.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Controle la excepcion");
            }
            Console.ReadKey();
        }
        public static double Dividir(int numero, int divisor)
        {
            double resultado = 0;
            try
            {
                resultado = numero / divisor;
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return resultado;
        }
    }
}
