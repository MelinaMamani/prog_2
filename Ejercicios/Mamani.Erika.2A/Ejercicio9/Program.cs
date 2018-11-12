using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "**";
            string cad = "*";

            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(cad);
                cad += cadena;
            }

            //Console.Write(cad);

            Console.ReadKey();
        }
    }
}
