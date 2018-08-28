using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int suma = 0;
            float prom;
            int max;
            int min;
            int i;

            for ( i = 0;  i < 10;  i++)
            {
                Console.Write("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                while(Validacion.Validar(num,-100,100) == false)
                {
                    Console.Write("Reingrese un numero: ");
                    num = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Numero ingresado: {0}", num);
                suma += num;
                
            }
            prom = (float)(suma / 10.00);
            Console.WriteLine("Promedio: {0.:00}", prom);
        }
    }
}
