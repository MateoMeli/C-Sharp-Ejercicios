using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class NumeroBinario
    {
        public string numero;

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static string operator +(NumeroBinario binario, NumeroDecimal deci)
        {
            int numero = deci.numero + Transformador.BinarioDecimal(binario.numero);
            
            return Transformador.DecimalBinario(numero);
        }

        public static string operator -(NumeroBinario binario, NumeroDecimal deci)
        {
            int numero = deci.numero - Transformador.BinarioDecimal(binario.numero);

            return Transformador.DecimalBinario(numero);
        }

        public static bool operator ==(NumeroBinario binario, NumeroDecimal deci)
        {
            return (Transformador.BinarioDecimal(binario.numero) == deci.numero);
        }
        public static bool operator !=(NumeroBinario binario, NumeroDecimal deci)
        {
            return !(binario == deci);
        }

        public static implicit operator NumeroDecimal(NumeroBinario bina)
        {
            return new NumeroDecimal(Transformador.BinarioDecimal(bina.numero));
        }

        public static explicit operator int(NumeroBinario bina)
        {
            return Transformador.BinarioDecimal(bina.numero);
        }
    }
}
