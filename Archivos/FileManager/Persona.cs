using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNac;

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

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public DateTime FechaNac
        {
            get
            {
                return this.fechaNac;
            }
            set
            {
                this.fechaNac = value;
            }
        }

        public Persona()
        {
        }
        public Persona(string nombre, string apellido, DateTime fechaNac)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
        }
    }
}
