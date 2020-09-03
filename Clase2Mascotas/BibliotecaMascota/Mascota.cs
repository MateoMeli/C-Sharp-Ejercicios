using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMascota
{
    public class Mascota
    {
        private string nombre;
        private DateTime fechaNac;
        private string especie;

        public Mascota(string nombre, DateTime fechaNac, string especie)
        {
            this.nombre = nombre;
            this.fechaNac = fechaNac;
            this.especie = especie;
        }

        public string MostrarDatos()
        {
            /*
             * StringBuilder stringBuilder = new StringBuilder();
             * stringBuilder.AppendFormat("Nombre: {0}\n", this.nombre);
             * stringBuilder.AppendFormat("Fecha de nacimiento: {0}\n",this.fechaNac.ToString("dd/MM/yyyy"));
             * stringBuilder.AppendFormat("Especie: {0}\n", this.especie);
             * return stringBuilder.ToString();
             */

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            stringBuilder.AppendLine($"Fecha de Nacimiento: {this.fechaNac.ToShortDateString()}");
            stringBuilder.AppendLine($"Fecha de Nacimiento: {this.fechaNac.ToLongDateString()}");
            stringBuilder.AppendLine($"Especie: {this.especie}");

            return stringBuilder.ToString();
        }

        public int CalcularEdad()
        {
            return DateTime.Today.AddTicks(-this.fechaNac.Ticks).Year - 1;
        }

    }
}
