using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected int dni;
        protected int edad;
        protected string nombre;

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        #region Propiedades
        public string Apellido 
        { 
            get 
            {
                return this.apellido;
            } 
        }
        public int Dni 
        {
            get
            {
                return this.dni;
            } 
        }
        public int Edad 
        {
            get
            {
                return this.edad;
            }
        }
        public string Nombre
        {
            get 
            {
                return this.nombre;
            }
        }
        #endregion

        public virtual string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"{this.Apellido}, {this.Nombre} de {this.Edad} años" +
                $" con dni {this.Dni}");
            return mensaje.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}
