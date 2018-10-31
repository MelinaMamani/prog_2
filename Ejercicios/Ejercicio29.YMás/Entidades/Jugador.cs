using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region Atributos

        private int partidosJugados;
        private int totalGoles;

        #endregion

        #region Propiedades

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }

            set
            {
                this.partidosJugados = value;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return this.totalGoles / this.partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }

            set
            {
                this.totalGoles = value;
            }
        }

        #endregion

        #region Constructores

        public Jugador(int dni, string nombre) : base (nombre, dni)
        {
           
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this (dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        #endregion

        #region Métodos

        public string MostrarDatos()
        {
            return base.MostrarDatos()+"\nPartidos jugados: "+this.partidosJugados+
                "\nTotal goles: "+this.totalGoles+"\nPromedio goles: "+this.PromedioGoles+"\n";
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Jugador a, Jugador b)
        {
            return a.DNI == b.DNI;
        }

        public static bool operator !=(Jugador a, Jugador b)
        {
            return !(a == b);
        }

        #endregion
    }
}
