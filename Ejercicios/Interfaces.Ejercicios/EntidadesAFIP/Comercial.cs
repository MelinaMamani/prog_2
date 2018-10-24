using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAFIP
{
    public class Comercial : Avion, IARBA
    {
        protected int _capacidadPasajeros;

        public Comercial(double precio, double velocidad, int capacidad) : base (precio, velocidad)
        {
            this._capacidadPasajeros = capacidad;
        }

        double IARBA.CalcularImpuesto()
        {
            return 0.25;
        }
    }
}
