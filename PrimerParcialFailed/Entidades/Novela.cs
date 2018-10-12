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
            : base (titulo, autor, precio)
        {
            this.genero = genero;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat((string)this, "\n");
            sb.AppendFormat("Genero: {0}", this.genero, "\n");

            return sb.ToString();
        }

        public static implicit operator double(Novela n)
        {
            return n._precio;
        }

        public static bool operator ==(Novela a, Novela b)
        {
            return (a == b && a.genero == b.genero);
        }

        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }
    }
}
