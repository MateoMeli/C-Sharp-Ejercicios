using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EContagiosidad { Baja, Moderada, Alta };
    public enum ETipo { Virus, Bacteria };
    public abstract class Microorganismo
    {
        protected long contador;
        private EContagiosidad contagiosidad;
        private string nombre;
        private ETipo tipo;

        public abstract long IndiceDeContagios{ get; }

        public Microorganismo(string nombre)
        {
            this.contador = 1;
            this.nombre = nombre;
        }
        public Microorganismo(string nombre, ETipo tipo, EContagiosidad contagiosidad) : this(nombre)
        {
            this.tipo = tipo;
            this.contagiosidad = contagiosidad;
        }

        public string Informe()
        {
            return $"El {this.tipo} lleva el nombre de {this.nombre} y tiene una contagiosidad de {this.contagiosidad}. Su impacto de contagios se calcula " +
                $"en {IndiceDeContagios}.";
        }
    }
}
