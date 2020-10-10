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
            :base("Perro", edad)
        {
        }

        protected new virtual string Mostrar()
        {
            if (this.Validar())
            {
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine("GENTE");
                mensaje.AppendLine(base.Mostrar());
                return mensaje.ToString();
            }
            else
                return null;
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
