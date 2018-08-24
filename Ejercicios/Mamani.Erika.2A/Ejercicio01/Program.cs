using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int acum = 0;
            int i;
            int min = 0;
            int max = 0;
            float prom;

            for ( i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if(i == 0)
                {
                    min = max = num;
                }
                else if(num < min)
                {
                    min = num;
                }
                else if(num > max)
                {
                    max = num;
                }

                acum += num;
            }
            prom = (float)(acum / 5.0);
            Console.WriteLine("Numero min: {0}, numero max: {1}, Promedio: {2:.00}", min, max, prom);
            Console.ReadLine();
        }
    }
}
