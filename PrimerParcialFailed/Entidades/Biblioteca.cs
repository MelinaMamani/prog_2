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

        public double PrecioDeManuales
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Manual);
            }
        }

        public double PrecioDeNovelas
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Novela);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Ambos);
            }
        }

        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }


        public static string Mostrar(Biblioteca e)
        {
            string retorno = "Capacidad de biblioteca: "+e._capacidad+"\n";
            retorno += "Total de manuales: $" + (float)e.PrecioDeManuales + "\n";
            retorno += "Total de novelas: $" + (float)e.PrecioDeNovelas + "\n";
            retorno += "Total: $" + (float)e.PrecioTotal + "\n";

            foreach (Libro item in e._libros)
            {
                if( item is Manual)
                {
                    retorno += ((Manual)item).Mostrar()+"\n";
                }

                if (item is Novela)
                {
                    retorno += ((Novela)item).Mostrar()+"\n";
                }
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
                if(e._libros[i] is Manual && l is Manual)
                {
                    if ((Manual)e._libros[i] == (Manual)l)
                    {
                        var = true;
                        break;
                    }
                }
                else if (e._libros[i] is Novela && l is Novela)
                {
                    if ((Novela)e._libros[i] == (Novela)l)
                    {
                        var = true;
                        break;
                    }
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
                else
                {
                    Console.WriteLine("Ya hay uno igual!!");
                }
            }
            else
            {
                Console.WriteLine("No hay más lugar !!");
            }

            return e;
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double total = 0;

            foreach (Libro item in this._libros)
            {
                switch (tipoLibro)
                {
                    case ELibro.Manual:
                        if (item is Manual)
                        {
                            total += (Manual)item;
                        }
                        break;
                    case ELibro.Novela:
                        if (item is Novela)
                        {
                            total += (Novela)item;
                        }
                        break;
                    case ELibro.Ambos:
                        if( item is Novela)
                        {
                            total += (Novela)item;
                        }
                        else if( item is Manual)
                        {
                            total += (Manual)item;
                        }
                        
                        break;

                }
            }

            return total;
        }
    }
}
