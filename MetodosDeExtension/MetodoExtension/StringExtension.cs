using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoExtension
{
    public static class StringExtension
    {
        public static int ContadorPalabras(this string dato, char splitter)
        {
            return dato.Split(splitter).Length;
        }
        public static int Por10(this int dato)
        {
            return dato * 10;
        }
    }
}
