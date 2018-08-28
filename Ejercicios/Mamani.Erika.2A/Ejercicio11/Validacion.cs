using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool val = true;

            if (valor < min || valor > max)
            {
                val = false;
            }

            return val;
        }
    }
}
