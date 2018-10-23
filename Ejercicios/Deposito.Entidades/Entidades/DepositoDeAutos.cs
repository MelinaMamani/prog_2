using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool var = false;

            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
            }

            return var;
        }

        private int GetIndice(Auto a)
        {
            int indice = -1;

            for (int i = 0; i < this._lista.Count; i++)
            {
                if (a == this._lista[i])
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool var = false;

            if (d.GetIndice(a) > -1)
            {
                d._lista.Remove(a);
                var = true;
            }

            return var;
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string cadena = "Capacidad: "+this._capacidadMaxima;

            for (int i = 0; i < this._lista.Count; i++)
            {
                cadena += this._lista[i].ToString();
            }

            return cadena;
        }
    }
}
