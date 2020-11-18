using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        public float tamanioMina;

        public Lapiz(int unidades)
        {

        }
        ConsoleColor IAcciones.Color 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        float IAcciones.UnidadesDeEscritura
        {
            get;
            set;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            throw new NotImplementedException();
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}
