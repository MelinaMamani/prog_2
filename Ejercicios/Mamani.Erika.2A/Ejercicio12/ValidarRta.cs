using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRta
    {
        public static bool ValidarS_N(char c)
        {
            bool val = false;

            if (c.Equals('S'))
            {
                val = true;
            }

            return val;
        }
    }
}
