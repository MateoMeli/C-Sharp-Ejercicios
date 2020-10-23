using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(Llamada llamada, float costo) 
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) 
            :base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        protected override string Mostrar()
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
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            if(obj is Local)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
