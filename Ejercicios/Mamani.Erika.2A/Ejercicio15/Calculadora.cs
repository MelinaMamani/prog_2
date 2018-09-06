using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio15
{
    class Calculadora
    {
        public static int Calcular(int a, int b, char c)
        {
            int r = 0;

            if(c.Equals('+'))
            {
                r = a + b;
            }
            else if (c.Equals('-'))
            {
                r = a - b;
            }
            else if (c.Equals('*'))
            {
                r = a * b;
            }
            else if (c.Equals('/'))
            {
                if(Validar(b))
                {
                    r = a / b;
                }
                else
                {
                    Console.WriteLine("No se puedo dividir por cero.");
                }
                
            }

            return r;
        }

        private static bool Validar(int b)
        {
            bool ver = false;

            if (b != 0)
                ver = true;

            return ver;
        }

        public static void Mostrar(int r)
        {
            Console.WriteLine("Resultado: {0}",r);
        }

    }
}
