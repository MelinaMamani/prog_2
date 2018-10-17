using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Clase
    {
        public static Exception LanzarExcepcion()
        {
           throw new DivideByZeroException();
        }
    }
}
