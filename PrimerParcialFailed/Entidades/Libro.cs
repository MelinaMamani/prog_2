using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        protected Autor _autor;
        protected int _cantDePaginas;
        protected Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        public int CantidadDePaginas {
            get
            {
                if(_cantDePaginas == 0)
                {
                    _cantDePaginas = _generadorDePaginas.Next(10,580);
                }
                return _cantDePaginas;
            }
        }

        public Libro(float precio, string titulo, string nombre, string apellido)
        {

        }

        public Libro(string titulo, Autor autor, float precio)
        {

        }

        public Libro()
        {

        }

        public static explicit operator string(Libro l)
        {
            return Mostrar(l);
        }

        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Titulo: {0}",l._titulo,"\n");
            sb.AppendFormat("Cant. de paginas: {0}", l._cantDePaginas, "\n");
            sb.AppendFormat("Autor: {0}", (string)l._autor, "\n");
            sb.AppendFormat("Precio: {0}", l._precio, "\n");

            return sb.ToString();
        }

        public static bool operator ==(Libro a, Libro b)
        {
            bool var = false;

            if (a._titulo == b._titulo)
            {
                var = true;
            }

            return var;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
    }
}
