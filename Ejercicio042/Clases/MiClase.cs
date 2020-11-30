using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.MetodoStatic();
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }

        }

        public MiClase(int numero)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("MiClase(int numero)", ex);
            }
        }

        public static void MetodoStatic()
        {
            throw new DivideByZeroException("MetodoStatic");
        }
    }
}
