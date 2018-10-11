using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        private string apellido;
        private string nombre;

        public Autor(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public static bool operator ==(Autor a, Autor b)
        {
            bool var = false;
            if ((a.apellido == b.apellido) && (a.nombre == b.nombre))
            {
                var = true;
            }
            return var;
        }

        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }

        public static implicit operator string(Autor a)
        {
            return a.apellido + " " + a.nombre;
        }
    }
}
