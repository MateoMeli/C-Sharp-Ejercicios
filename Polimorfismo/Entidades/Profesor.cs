using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Alumno
    {
        public Profesor(string nombre)
            : base(nombre) { }

        public override string QuienSoy()
        {
            return "Un profesor";
        }

        public override int DeciUnNumero
        {
            get
            {
                return this.nombre.Length;
            }
        }
    }
}
