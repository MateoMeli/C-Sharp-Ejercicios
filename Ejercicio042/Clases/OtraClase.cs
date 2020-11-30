using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {
            try
            {
                new MiClase(10);
            }
            catch(UnaExcepcion ex)
            {
                throw new MiExcepcion("MetodoInstancia", ex);
            }
        }
    }
}
