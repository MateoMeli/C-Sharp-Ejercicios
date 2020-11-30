using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        public float UnidadesDeEscritura 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public EscrituraWrapper Escribir(string texto)
        {
            throw new NotImplementedException();
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}
