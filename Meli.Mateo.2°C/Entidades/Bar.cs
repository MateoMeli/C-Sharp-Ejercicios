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
        private Bar singleton;

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
        public Bar GetBar()
        {
            if (singleton == null)
            {
                singleton = new Bar();
            }
            return singleton;
        }

        public static Bar operator +(Bar bar, Empleado empleado)
        {
            int repitio = 0;
            foreach(Empleado e in bar.Empleados)
            {
                if(empleado == e)
                {
                    repitio = 1;
                }
            }
            if(repitio == 0)
            {
                bar.Empleados.Add(empleado);
            }
            return bar;
        }

        public static Bar operator +(Bar bar, Gente gente)
        {
            if (bar.Gente.Count / 10 > bar.Empleados.Count)
            {
                bar.Gente.Add(gente);
                return bar;
            }
            else
                return bar;
        }

        public static explicit operator string(Bar bar)
        {
            StringBuilder mensaje = new StringBuilder();
            if (!(bar is null))
            {
                mensaje.AppendLine("BAR");
                foreach(Persona e in bar.Empleados)
                {
                    mensaje.AppendLine((string)e);
                }
                return mensaje.ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
