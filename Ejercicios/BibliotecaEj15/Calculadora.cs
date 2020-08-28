using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEj15
{
    public class Calculadora
    {
        static bool Validar(double numero)
        {
            if(numero != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double Calcular(double numero1, double numero2, char operacion)
        {
            double respuesta = 0;
            switch(operacion)
            {
                case '+':
                    respuesta = numero1 + numero2;
                    break;
                case '-':
                    respuesta = numero1 - numero2;
                    break;
                case '*':
                    respuesta = numero1 * numero2;
                    break;
                case '/':
                    if(Validar(numero2))
                    {
                        respuesta = numero1 / numero2;
                    }
                    break;                    
            }
            return respuesta;
        }
    }
}
