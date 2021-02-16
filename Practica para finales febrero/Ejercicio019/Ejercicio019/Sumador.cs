using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio019
{
    public class Sumador
    {
        private int cantidadSumas;


        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0){}

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            StringBuilder sb = new StringBuilder();
            sb.Append(a);
            sb.Append(b);
            return sb.ToString();
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }
        public static long operator +(Sumador a, Sumador b)
        {
            return (int)a + (int)b;
        }

        public static bool operator |(Sumador a, Sumador b)
        {
            return ((int)a == (int)b);
        }
    }
}
