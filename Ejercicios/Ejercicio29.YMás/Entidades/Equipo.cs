using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region Atributos

        private short cantidadDeJugadores;
        private string nombre;
        private List<Jugador> jugadores;

        #endregion

        #region Constructores

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this ()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        #endregion

        #region Sobrecarga

        public static bool operator +(Equipo e, Jugador j)
        {
            bool ver = false;

            if (e.cantidadDeJugadores > e.jugadores.Count)
            {
                ver = true;
                foreach (var j2 in e.jugadores)
                {
                    if(j2 == j)
                    {
                        ver = false;
                        break;
                    }
                }
                if( ver )
                {
                    e.jugadores.Add(j);
                }

            }
            return ver;
        }

        //public static bool operator +(Equipo e, DirectorTecnico d)
        //{
        //    bool ver = false;

        //    if (e.cantidadDeJugadores > e.jugadores.Count)
        //    {
        //        ver = true;
        //        foreach (var d2 in e.jugadores)
        //        {
        //            if (d2 == d)
        //            {
        //                ver = false;
        //                break;
        //            }
        //        }
        //        if (ver)
        //        {
        //            e.jugadores.Add(d);
        //        }

        //    }
        //    return ver;
        //}

        #endregion
    }
}
