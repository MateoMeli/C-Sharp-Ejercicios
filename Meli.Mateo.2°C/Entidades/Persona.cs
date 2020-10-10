using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        public short Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        protected Persona(string nombre, short edad)
        {
            this.Edad = edad;
            this.Nombre = nombre;
        }

        public static explicit operator string(Persona p)
        {
            StringBuilder mensaje = new StringBuilder();
            if (p.Edad >= 0 && !(p.Nombre is null))
            {
                mensaje.AppendLine($"Nombre: {p.Nombre} Edad: {p.Edad}");
                return mensaje.ToString();
            }
            else
            {
                return null;
            }
        }

        public abstract bool Validar();

        protected virtual string Mostrar()
        {
            return (string)this;
        }
    }
}
