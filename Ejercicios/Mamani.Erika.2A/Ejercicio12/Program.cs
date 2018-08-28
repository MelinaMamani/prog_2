using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            char op = 'S';

            while(ValidarRta.ValidarS_N(op))
            {
                Console.WriteLine("Continuar? S/N ");
                op = (char)(Console.Read());
                Console.ReadLine();
            }

        }
    }
}
