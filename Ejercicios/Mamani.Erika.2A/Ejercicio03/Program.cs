using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int numero;

            Console.Write("Ingrese un numeero: ");
            numero = int.Parse(Console.ReadLine());

            for ( i = 2; i < numero; i++)
            {
                if (numero % i != 0)
                {
                    Console.WriteLine("Primo: {0}", i);
                }
            }
            Console.ReadLine();
        }
    }
}
