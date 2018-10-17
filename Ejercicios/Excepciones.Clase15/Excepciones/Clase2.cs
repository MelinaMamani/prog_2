using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Clase2
    {
        public Clase2()
        {
            try
            {
                Clase.LanzarExcepcion();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
