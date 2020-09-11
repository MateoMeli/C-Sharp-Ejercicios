using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    public class Alumne
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumne(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        private void Estudiar (byte nota1, byte nota2)
        {
            if( nota1 > 0 && nota1 <= 10 && nota2 > 0 && nota2 <= 10)
            {
                this.nota1 = nota1;
                this.nota2 = nota2;
            }
        }


    }
}
