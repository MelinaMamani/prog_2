using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGenerica
{
    public class Deposito <T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        public static bool operator +(Deposito <T> d, T a)
        {
            bool var = false;

            if (d._capacidadMaxima < d._lista.Count)
            {
                d._lista.Add(a);
                var = true;
            }

            return var;
        }

        private int GetIndice(T a)
        {
            int indice = -1;

            for (int i = 0; i < this._lista.Count; i++)
            {
                if (Object.Equals(a, this._lista[i]))
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            bool var = false;

            if (d.GetIndice(a) > -1)
            {
                d._lista.Remove(a);
                var = true;
            }

            return var;
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string cadena = "Capacidad: " + this._capacidadMaxima;

            for (int i = 0; i < this._lista.Count; i++)
            {
                cadena += this._lista[i].ToString();
            }

            return cadena;
        }
    }
}
