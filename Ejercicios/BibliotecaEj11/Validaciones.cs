using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEj11
{
    public class Validaciones
    {
        public static bool Validar(int valor, int max, int min)
        {
            if(valor > min && valor < max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
