using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion = 's';
            char operacion;
            int num1;
            int num2;

            do
            {
                Console.Write("Ingrese un numero: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese otro numero: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Que operacion desea hacer? +, -, *, /");
                operacion = (char)(Console.Read());

                Calculadora.Mostrar(Calculadora.Calcular(num1, num2, operacion));

                Console.ReadLine();

                Console.Write("Continuar? s/n: ");
                opcion = (char)(Console.Read());
                Console.ReadLine();

            } while (opcion.Equals('s'));
        }
    }
}
