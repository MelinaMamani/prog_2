using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public long DNI
        {
            get
            {
                return this.dni;
            }

            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(string nombre, long dni) : this (nombre)
        {
            this.dni = dni;
        }

        public string MostrarDatos()
        {
            return this.nombre + "\nDNI: " + this.dni;
        }
    }
}
