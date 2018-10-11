using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        public double PrecioDeManuales { get;}

        public double PrecioDeNovelas { get; }

        public double PrecioTotal { get; }

        private Biblioteca(int capacidad)
        {
            this._libros = new List<Libro>(capacidad);
        }

        private Biblioteca() : this(5)
        {

        }

        public string Mostrar(Biblioteca e)
        {
            string retorno = "Capacidad de biblioteca: "+this._capacidad+"\n";

            for (int i = 0; i < e._libros.Count; i++)
            {
                retorno += (string)e._libros[i];
            }

            return retorno;
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca b = new Biblioteca(capacidad);
            return b;
        }

        public static bool operator ==(Biblioteca e, Libro l)
        {
            bool var = false;

            for (int i = 0; i < e._libros.Count; i++)
            {
                if(e._libros[i] == l)
                {
                    var = true;
                    break;
                }
            }

            return var;
        }

        public static bool operator !=(Biblioteca e, Libro l)
        {
            return !(e == l);
        }

        public static Biblioteca operator +(Biblioteca e, Libro l)
        {
            if (e._capacidad > e._libros.Count)
            {
                if (e != l)
                {
                    e._libros.Add(l);
                }
            }

            return e;
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double total = 0;
            
            return total;
        }
    }
}
