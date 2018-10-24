using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAFIP
{
    public class Familiar : Auto
    {
        protected int _cantDeAsientos;

        public Familiar(double precio, string patente, int cantAsientos) : base (precio, patente)
        {
            this._cantDeAsientos = cantAsientos;
        }
    }
}
