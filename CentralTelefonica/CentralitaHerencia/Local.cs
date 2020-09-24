using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        private float costo;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(Llamada llamada, float costo) 
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = CostoLlamada;
        }

        public Local(string origen, float duracion, string destino, float costo) 
            :base(duracion, destino, origen)
        {
            this.costo = CostoLlamada;
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine(base.Mostrar());
            mensaje.AppendLine($"La llamada es local y su costo es {this.CostoLlamada}.");
            return mensaje.ToString();
        }

        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }
    }
}
