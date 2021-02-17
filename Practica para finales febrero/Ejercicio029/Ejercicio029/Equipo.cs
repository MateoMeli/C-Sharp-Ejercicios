using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio029
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidad;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            foreach(Jugador jug in e.jugadores)
            {
                if(j == jug)
                {
                    return false;
                }
            }
            e.jugadores.Add(j);
            return true;
            
        }
    }
}
