using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela : Libro
    {
        public EGenero genero;

        public Novela(string titulo, float precio, Autor autor, EGenero genero)
        {
            this.genero = genero;
        }

        public string Mostrar()
        {
            return " " + this.genero;
        }

        public static implicit operator double(Novela n)
        {
            return n._precio;
        }

        public static bool operator ==(Novela a, Novela b)
        {
            bool var = false;

            if ((a == b) && a.genero == b.genero)
            {
                var = true;
            }

            return var;
        }

        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }
    }
}
