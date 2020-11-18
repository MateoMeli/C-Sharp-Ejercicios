using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if(e1.Equals(e2) && e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            if (e1 == e2)
            {
                return false;
            }
            return true;
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} fundado el {this.fechaCreacion}.");

            return sb.ToString();
        }
    }
}
