using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }

        public DirectorTecnico (string nombre, string apellido, int edad, int dni, int añosExperiencia)
            :base(nombre, apellido, edad, dni)
        {
            this.AñosExperiencia = añosExperiencia;
        }

        public override bool ValidarAptitud()
        {
            if(this.Edad < 65 && this.AñosExperiencia > 2)
                return true;            
            else
                return false;
        }

        public override string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder(base.Mostrar());
            mensaje.AppendLine($"Los años de experiencia de este dt son {this.AñosExperiencia}.");
            return mensaje.ToString();
        }
    }
}
