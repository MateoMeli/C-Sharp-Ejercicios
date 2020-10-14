using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        private int dni;

        public Empleado(string nombre, short edad)
            :base(nombre, edad)
        {
            this.dni = -1;
        }
        public Empleado(string nombre, short edad, int dni)
            :base(nombre, edad)
        {
            this.dni = dni;
        }
        /// <summary>
        /// Funcion que valida la edad y el nombre de un empleado
        /// </summary>
        /// <returns> devuelve true si es valido</returns>
        public override bool Validar()
        {
            if (this.Edad >= 21 && this.Nombre.Length >= 2)
                return true;
            else
                return false;    
        }
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            if (e1.Nombre == e2.Nombre && e1.Edad == e2.Edad)
                return true;
            else
                return false;
        }
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            if (e1.Nombre != e2.Nombre || e1.Edad != e2.Edad)
                return true;
            else
                return false;
        }

        protected override string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            if (this.Validar())
            {
                mensaje.AppendLine("EMPLEADO");
                mensaje.AppendLine(base.Mostrar());
            }
            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
