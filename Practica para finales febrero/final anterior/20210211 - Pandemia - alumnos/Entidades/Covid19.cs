using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Covid19 : Microorganismo
    {
        public Covid19(string nombre) : base(nombre) { }

        public override long IndiceDeContagios
        {
            get
            {
                contador *= 5;
                return this.contador;
            }
        }
    }
}
