using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class Transformador
    {
        public static string DecimalBinario(int a)
        {
            String cadena = "";

            if (a > 0)
            {
                while (a > 0)
                {
                    if (a % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    a = (int)(a / 2);
                }
            }
            else
            {
                if (a == 0)
                {
                    Console.WriteLine("0");
                }


            }
            return cadena;
        }

        public static int BinarioDecimal(string a)
        {
            char[] array = a.ToCharArray();
            // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    sum += (int)Math.Pow(2, i);
                }
            }
            return sum;
        }
    }
}
