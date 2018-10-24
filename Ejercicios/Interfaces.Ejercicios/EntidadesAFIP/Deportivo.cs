using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAFIP
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int caballos) : base (precio, patente)
        {
            this._caballosFuerza = caballos;
        }

        double IAFIP.CalcularImpuesto()
        {
            return 0.28;
        }

        double IARBA.CalcularImpuesto()
        {
            return 0.23;
        }
    }
}
