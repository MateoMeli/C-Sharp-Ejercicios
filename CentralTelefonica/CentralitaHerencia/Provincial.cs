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

        public Provincial(Llamada llamada, Franja miFranja) 
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_01:
                    return (0.99f * this.Duracion);
                case Franja.Franja_02:
                    return (1.25f * this.Duracion);
                case Franja.Franja_03:
                    return (0.66f * this.Duracion);
            }
            return 0f;
        }

        public override string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine(base.Mostrar());
            mensaje.AppendLine($"La llamada es provincial y su costo es {this.CostoLlamada}.");
            return mensaje.ToString();
        }
    }
}
