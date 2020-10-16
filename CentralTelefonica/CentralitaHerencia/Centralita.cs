using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Propiedades
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        #endregion


        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipoLlamada)
        {
            float total = 0;

            switch (tipoLlamada)
            {
                case Llamada.TipoLlamada.Local:
                    foreach(Llamada l in this.Llamadas)
                    {
                        Local p = (Local)l;
                        total += p.CostoLlamada;
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada l in this.Llamadas)
                    {
                        Provincial p = (Provincial)l;
                        total += p.CostoLlamada;
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada l in this.Llamadas)
                    {
                        Local p = (Local)l;
                        total += p.CostoLlamada;
                    }
                    foreach (Llamada l in this.Llamadas)
                    {
                        Provincial p = (Provincial)l;
                        total += p.CostoLlamada;
                    }
                    break;

            }
            return total;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Empresa: {this.razonSocial}");
            sb.AppendLine($"Ganancias Totales: {this.GananciaPorTotal}");
            sb.AppendLine($"Ganancias Provinciales: {this.GananciaPorProvincial}");
            sb.AppendLine($"Ganancias Locales: {this.GananciaPorLocal}");
            foreach (Llamada l in this.listaDeLlamadas)
            {
                sb.AppendLine(l.Mostrar());
            }
            return sb.ToString();
        }
        
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
