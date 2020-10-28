using System;

namespace Excepciones
{
    internal class Persona
    {
        private string dni;

        public Persona(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                throw new DniInvalidoException("Dni invalido");
            }
            this.dni = dni;
        }
    }
}