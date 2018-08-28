using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases1;

namespace EClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase Sello";
            Sello.mensaje = "lalala";
            Sello.color = ConsoleColor.Magenta;

            Console.WriteLine(Sello.Imprimir());
            //Sello.Borrar();
            Sello.ImprimirEnColor();
            
            Console.Read();
        }
    }
}
