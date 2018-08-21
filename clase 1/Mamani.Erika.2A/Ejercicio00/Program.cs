using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;

            Console.WriteLine("Hola mundo");

            Console.WriteLine("Ingrese su nombre: ");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su nombre: ");

            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Su nombre {0} y edad {1} ",nombre, edad);

            Console.ReadLine();
        }
    }
}
