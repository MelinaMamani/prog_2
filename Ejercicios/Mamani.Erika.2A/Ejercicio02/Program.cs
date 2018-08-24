using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            while(num <= 0)
            {
                Console.Write("ERROR. ¡Reingresar numero! ");
                num = int.Parse(Console.ReadLine());
            }

            Console.Write("Cuadrado de numero : {0} , cubo del numero: {1}", Math.Pow(num,2), Math.Pow(num,3));
            Console.Read();
        }
    }
}
