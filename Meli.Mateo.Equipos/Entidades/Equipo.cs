using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo

    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }          
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>(cantidadMaximaJugadores);
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo equipo)
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Equipo: {equipo.Nombre}");
            if (!(equipo.directorTecnico is null))
            {
                mensaje.AppendLine($"Dt: {equipo.directorTecnico.Nombre}" +
                    $" {equipo.directorTecnico.Apellido}");
            }
            else
            {
                mensaje.AppendLine("No hay un dt asignado");
            }
            foreach (Jugador j in equipo.jugadores)
            {
                mensaje.AppendLine(j.Mostrar());
            }

            return mensaje.ToString();
        }

        public static bool operator == (Equipo equipo, Jugador jugador)
        {
            foreach(Jugador j in equipo.jugadores)
            {
                if (jugador == j)
                    return true;
                    break;
                    
            }
            return false;
        }
        public static bool operator != (Equipo equipo, Jugador jugador)
        {
            foreach (Jugador j in equipo.jugadores)
            {
                if (jugador != j)
                    return false;
                break;
                    
            }
            return true;
        }
        public static Equipo operator +(Equipo equipo, Jugador jugador)
        {
            if(!(equipo == jugador) &&
                equipo.jugadores.Count < cantidadMaximaJugadores &&
                jugador.ValidarAptitud())
            {
                equipo.jugadores.Add(jugador);
                return equipo;
            }
            else
            {
                return equipo;
            }
        }
        public static bool ValidarEquipo(Equipo e)
        {
            int arquero = 0;
            int defensor = 0;
            int central = 0;
            int delantero = 0;

            foreach (Jugador j in e.jugadores)
            {
                switch (j.Posicion)
                {
                    case Posicion.Arquero:
                        arquero++;
                        break;
                    case Posicion.Defensor:
                        defensor++;
                        break;
                    case Posicion.Central:
                        central++;
                        break;
                    case Posicion.Delantero:
                        delantero++;
                        break;
                    default:
                        break;
                }
            }

            if (!(e.directorTecnico is null) &&
                e.jugadores.Count == cantidadMaximaJugadores)
            {

                if (arquero == 1 && defensor > 0 && central > 0 && delantero > 0)
                { 
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
