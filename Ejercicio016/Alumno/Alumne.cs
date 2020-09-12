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

        public void Estudiar (byte nota1, byte nota2)
        {
            if( nota1 > 0 && nota1 <= 10 && nota2 > 0 && nota2 <= 10)
            {
                this.nota1 = nota1;
                this.nota2 = nota2;
            }
        }

        public void CalcularFinal()
        {
            Random rnd = new Random();
            if(this.nota1 >= 4 && this.nota2 >= 4 && this.nota1 <= 10 && this.nota2 <= 10)
            {
                this.notaFinal = rnd.Next(4, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            if(this.notaFinal == -1)
            {
                return "Alumno desaprobado";
            }
            else
            {
                return $"El alumno {this.nombre} {this.apellido} con legajo {this.legajo} tiene de nota final un {this.notaFinal}";
            }
        }

    }
}
