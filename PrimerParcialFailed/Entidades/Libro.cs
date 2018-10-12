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
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        public int CantidadDePaginas
        {
            get
            {
                if(this._cantDePaginas == 0)
                {
                    this._cantDePaginas = Libro._generadorDePaginas.Next(10, 581);
                }
                return this._cantDePaginas;
            }
        }

        public Libro(float precio, string titulo, string nombre, string apellido) : this(titulo , 
            new Autor(nombre,apellido) , precio )
        {
        }

        public Libro(string titulo, Autor autor, float precio) 
        {
            this._autor = autor;
            this._titulo = titulo;
            this._precio = precio;
            this._cantDePaginas = this.CantidadDePaginas;
        }

        static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }

        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
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
            return (a._titulo == b._titulo && b._autor == a._autor);
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
    }
}
