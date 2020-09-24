using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        public Alumno(string nombre)
            : base(nombre) { }

        public override string QuienSoy()
        {
            return "Un alumno";
        }

        public override int DeciUnNumero
        {
            get
            {
                return this.nombre.Length;
            }
        }

        public new virtual string SoyVirtualDeQuien()
        {
            return "De alumno";
        }
    }
}
