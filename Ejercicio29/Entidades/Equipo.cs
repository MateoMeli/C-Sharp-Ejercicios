using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores.Capacity = 3;
        }

        public Equipo(short cantidadDeJugadores, string nombre):this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        /*public static Equipo operator +(Equipo equipo, Jugador jugador)
        {
            foreach (Jugador jug in equipo.jugadores)
            {
                if(jugador != jug)
                {
                    equipo.jugadores.Add(jugador);
                }else
                {
                    
                }
            }
        }*/
    }
}
