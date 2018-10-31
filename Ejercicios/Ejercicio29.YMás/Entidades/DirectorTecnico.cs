using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        private DirectorTecnico(string nombre) : base (nombre) 
        {

        }

        public DirectorTecnico(string nombre, DateTime fecha) : this (nombre)
        {
            this.fechaDeNacimiento = fecha;
        }

        public string MostrarDatos()
        {
            return this.Nombre + "\nFecha de nac: " + this.fechaDeNacimiento;
        }

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            return (d1.Nombre == d2.Nombre) && (d1.fechaDeNacimiento == d2.fechaDeNacimiento);
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
    }
}
