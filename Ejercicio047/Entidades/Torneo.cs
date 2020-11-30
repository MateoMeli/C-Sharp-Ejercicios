using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }


        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(CalcularPartido(equipos[random.Next(0, 2)], equipos[random.Next(0, 2)]));
                return sb.ToString();
            }
        }

        public static bool operator ==(Torneo<T> t, T q)
        {
            if (t.equipos.Contains(q))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Torneo<T> t, T q)
        {
            if (t == q)
            {
                return false;
            }
            return true;
        }

        public static Torneo<T> operator +(Torneo<T> t, T q)
        {
            if(t != q)
            {
                t.equipos.Add(q);
            }
            return t;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre.ToUpper()}");
            foreach(Equipo q in this.equipos)
            {
                sb.AppendLine(q.Ficha());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private string CalcularPartido(T t1, T t2)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            sb.AppendLine($"{t1.nombre.ToUpper()} {random.Next(0, 10)} - {random.Next(0, 10)} {t2.nombre.ToUpper()}");

            return sb.ToString();
        }


    }
}
