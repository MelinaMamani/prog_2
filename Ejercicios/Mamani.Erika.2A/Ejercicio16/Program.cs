using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";

            Alumno alumno1 = new Alumno("Mamaní", "Luciana", 4583782);
            Alumno alumno2 = new Alumno("Coronel", "Rodre", 4083322);
            Alumno alumno3 = new Alumno("Mamaní", "Melina", 4132402);

            alumno1.Estudiar(10,6);
            alumno1.CalcularFinal();
            alumno1.Mostrar();

            alumno2.Estudiar(2,3);
            alumno2.CalcularFinal();
            alumno2.Mostrar();

            alumno3.Estudiar(9,8);
            alumno3.CalcularFinal();
            alumno3.Mostrar();

            Console.Read();
        }
    }
}
