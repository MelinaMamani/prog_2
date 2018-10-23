using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCocina
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo { get; }
        public bool EsIndustrial { get; }
        public double Precio { get; }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool var = false;

            if (a._codigo == b._codigo)
            {
                var = true;
            }

            return var;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Cocina)
            {
                return (obj == this);
            }

            return false;
        }

        public override string ToString()
        {
            return "\nCodigo: "+this._codigo.ToString()+"\nPrecio: "+this._precio.ToString()+
                "\nEs industrial? "+this._esIndustrial.ToString()+"\n";
        }
    }
}
