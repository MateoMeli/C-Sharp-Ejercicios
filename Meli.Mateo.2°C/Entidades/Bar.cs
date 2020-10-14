using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton;

        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
        }
        public List<Gente> Gente
        {
            get
            {
                return this.gente;
            }
        }

        private Bar()
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
        }
        public static Bar GetBar()
        {
            if (singleton == null)
            {
                singleton = new Bar();
            }
            return singleton;
        }

        public static bool operator +(Bar bar, Empleado empleado)
        {
            int repetido = 0;
            foreach(Empleado e in bar.Empleados)
            {
                if(empleado == e)
                {
                    repetido = 1;
                }
            }
            if(repetido == 0)
            {
                bar.Empleados.Add(empleado);
                return true;
            }
            return false;
        }
        public static bool operator -(Bar bar, Empleado empleado)
        {
            foreach(Empleado e in bar.Empleados)
            {
                if(e == empleado)
                {
                    bar.Empleados.Remove(empleado);
                    return true;
                }
            }
            return false;
        }
        public static bool operator -(Bar bar, Gente gente)
        {
            foreach (Gente e in bar.Gente)
            {
                if (e == gente)
                {
                    bar.Gente.Remove(gente);
                    return true;
                }
            }
            return false;
        }

        public static bool operator +(Bar bar, Gente gente)
        {
            if (bar.Gente.Count / 10 < bar.Empleados.Count)
            {
                bar.Gente.Add(gente);
                return true;
            }
            else
                return false;
        }

        public static explicit operator string(Bar bar)
        {
            StringBuilder mensaje = new StringBuilder();
            if (!(bar is null))
            {
                mensaje.AppendLine("BAR");
                foreach(Empleado e in bar.Empleados)
                {
                    mensaje.AppendLine(e.ToString());
                }
                foreach(Gente g in bar.Gente)
                {
                    mensaje.AppendLine(g.ToString());
                }
            }
            return mensaje.ToString();
        }
    }
}
