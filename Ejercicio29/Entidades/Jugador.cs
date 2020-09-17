using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public class Jugador
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }

        public string MostrarDatos()
        {
            return $"El jugador {this.nombre} de Dni: {this.dni} jugo {this.partidosJugados} partidos" +
                $" e hizo {this.totalGoles} goles y su promedio de goles es {this.promedioGoles}";
        }

        public float GetPromedioGoles()
        {
            this.promedioGoles = this.totalGoles / this.partidosJugados;
            return this.promedioGoles;
        }

        public static bool operator ==(Jugador jug1, Jugador jug2)
        {
            return (jug1.dni == jug2.dni);
        }
        public static bool operator !=(Jugador jug1, Jugador jug2)
        {
            return (jug1.dni != jug2.dni);            
        }

    }
}
