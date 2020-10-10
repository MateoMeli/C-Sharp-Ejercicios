using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        #region Propiedades
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        #endregion

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            :base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder(base.Mostrar());
            mensaje.AppendLine($"El jugador pesa {this.Peso}, mide {this.Altura} y juega de {this.Posicion}.");
            return mensaje.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            float imc;
            imc = this.Peso / (this.Altura * this.Altura);
            if (imc < 18 || imc > 25)
                return false;
            else
            {
                return true;
            }          
            
        }

        public override bool ValidarAptitud()
        {
            if (ValidarEstadoFisico() && this.Edad < 40)
                return true;
            else
                return false;
        }
    }
}
