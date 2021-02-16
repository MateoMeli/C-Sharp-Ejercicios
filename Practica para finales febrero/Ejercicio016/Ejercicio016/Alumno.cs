using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio016
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void CalcularFinal()
        {
            Random random = new Random();

            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = random.Next(6, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} Apellido: {this.apellido} Legajo: {this.legajo}");

            if(this.notaFinal != -1)
            {
                sb.AppendLine($"{this.notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno Desaprobado");
            }
            return sb.ToString();
        }
    }
}
