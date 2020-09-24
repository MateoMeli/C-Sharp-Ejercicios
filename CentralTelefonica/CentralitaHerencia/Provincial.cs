using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public enum Franja {Franja_01, Franja_02, Franja_03}

        public Provincial(string origen, float duracion, string destino) 
            : base(duracion, destino, origen)
        {
            
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public float CalcularCosto()
        {
            return 1;
        }
    }
}
