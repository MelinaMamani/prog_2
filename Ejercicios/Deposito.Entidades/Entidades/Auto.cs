using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color { get; }

        public string Marca { get; }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            bool var = false;

            if ((a._color == b._color) && (a._marca == b._marca))
            {
                var = true;
            }

            return var;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if(obj is Auto)
            {
                return (obj == this);
            }

            return false;
        }

        public override string ToString()
        {
            return "\nMarca: "+this._marca+"\nColor: "+this._color;
        }
    }
}
