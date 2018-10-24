using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAFIP
{
    public class Carreta : Vehiculo, IARBA
    {
        public Carreta(double precio) : base (precio)
        {

        }

        double IARBA.CalcularImpuesto()
        {
            return 0.18;
        }
    }
}
