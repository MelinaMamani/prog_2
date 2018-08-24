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
            Sello.mensaje = "Meli";
            Sello.color = ConsoleColor.Magenta;

            //Console.Write(Sello.Imprimir());
            //Sello.Borrar();
            Sello.ImprimirEnColor();
            
            Console.Read();
        }
    }
}
