using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class NumeroDecimal
    {
        public int numero;

        public NumeroDecimal(int numero)
        {
            this.numero = numero;
        }
        
        public static int operator +(NumeroDecimal deci, NumeroBinario binario)
        {
            return deci.numero + Transformador.BinarioDecimal(binario.numero);
        }

        public static int operator -(NumeroDecimal deci, NumeroBinario binario)
        {
            return deci.numero - Transformador.BinarioDecimal(binario.numero);
        }

        public static bool operator ==(NumeroDecimal deci, NumeroBinario binario)
        {
            return binario == deci;
        }

        public static bool operator !=(NumeroDecimal deci, NumeroBinario binario)
        {
            return !(deci == binario);
        }

        public static implicit operator NumeroBinario(NumeroDecimal deci)
        {
            return new NumeroBinario(Transformador.DecimalBinario(deci.numero));
        }

        public static explicit operator string(NumeroDecimal deci)
        {
            return Transformador.DecimalBinario(deci.numero);
        }
    }
}
