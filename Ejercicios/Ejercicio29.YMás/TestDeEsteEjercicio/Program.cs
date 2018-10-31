using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestDeEsteEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Momo", 26373767);
            Persona p2 = new Persona("Jungkkok", 6124155);

            Console.WriteLine(p1.MostrarDatos() + "\n");
            Console.WriteLine(p2.MostrarDatos() + "\n");

            Jugador j1 = new Jugador(54125155, "Juan Pablo", 10, 31);
            Jugador j2 = new Jugador(32636623, "Yoooo", 33, 10);
            Jugador j3 = new Jugador(16361363, "Modric", 250, 100);
            Jugador j4 = new Jugador(74838833, "Rakitic", 500, 100);

            DateTime dateTime = new DateTime(1956, 6, 19);
            DateTime dateTime2 = new DateTime(2000, 1, 9);

            DirectorTecnico d1 = new DirectorTecnico("Maradona", dateTime);
            DirectorTecnico d2 = new DirectorTecnico("Tu vieja", dateTime2);

            Equipo equipo = new Equipo(6,"Equipo dinamita :v");


            Console.WriteLine(d1.MostrarDatos() + "\n");
            Console.WriteLine(d2.MostrarDatos() + "\n");

            if (equipo + j1)
            {
                //j1.GetPromedio();
                Console.Write(j1.MostrarDatos()+"\n");
            }

            if (equipo + j2)
            {
                //j2.GetPromedio();
                Console.Write(j2.MostrarDatos()+"\n");
            }

            if (equipo + j3)
            {
                //j3.GetPromedio();
                Console.Write(j3.MostrarDatos()+"\n");
            }

            if (equipo + j4)
            {
                //j4.GetPromedio();
                Console.Write(j4.MostrarDatos()+"\n");
            }
            else
            {
                Console.WriteLine("No se pudo agregar este jugador.");
            }

            Console.ReadKey();
        }
    }
}
