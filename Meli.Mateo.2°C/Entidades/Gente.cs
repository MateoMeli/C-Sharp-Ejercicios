using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {
        public Gente(short edad)
            :base(null, edad)
        {
        }
        public Gente(string nombre, short edad)
            :base(nombre, edad)
        {
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            if (this.Validar())
            {
                mensaje.AppendLine(base.Mostrar());
            }
            return mensaje.ToString();
        }

        public override bool Validar()
        {
            if (this.Edad >= 18)
                return true;
            else
                return false;
        }

    }
}
