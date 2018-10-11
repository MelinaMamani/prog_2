using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        public ETipo tipo;

        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo)
        {
            this.tipo = tipo;
        }

        public string Mostrar()
        {
            return " "+this.tipo;
        }

        public static implicit operator double(Manual m)
        {
            return m._precio;
        }

        public static bool operator ==(Manual a, Manual b)
        {
            bool var = false;

            if ((a.tipo == b.tipo) && (a == b))
            {
                var = true;
            }

            return var;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
    }
}
