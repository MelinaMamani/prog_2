using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace TestPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Erika", "Mamaní", 19, ESexo.Femenino);
            Persona p2 = new Persona("Luciana", "Mamaní", 14, ESexo.Femenino);
            Persona p3 = new Persona("Ernesto", "Lopez", 44, ESexo.Indefinido);

            Console.Write(p1.ObtenerDatos() + "\n");

            OtraPersona pE = new OtraPersona("Leandro", "Simeone", 60, Entidades.Externa.ESexo.Masculino);
            Console.WriteLine(pE.ObtenerDatos());

            PersonaExternaSellada pEX = new PersonaExternaSellada("Susana", "Gimenez", 70, Entidades.Externa.Sellada.ESexo.Femenino);
            Console.WriteLine(Extensora.ObtenerDatos(pEX));

            if (!(Extensora.EsNulo(p1)))
            {
                Console.WriteLine("Ya ves? no esta vacio");
            }

            Int32 numero = 10;

            Console.WriteLine("Numero " + numero + " tiene " + Extensora.CantidadDigitos(numero) + " digitos");

            if (!(Extensora.TieneLaMismaCantidad(numero, 5)))
            {
                Console.WriteLine("No tienen la misma cantidad de digitos");
            }

            List<Persona> lista = Extensora.TraerBD(p1);

            Console.WriteLine("Mostrando lista");

            foreach (Persona p in lista)
            {
                Console.WriteLine(p.ObtenerDatos());
            }

            //if (Extensora.AgregarBD(p2))
            //{
            //    Console.WriteLine("Se insertó una persona");
            //}

            //if (Extensora.QuitarBD(13))
            //{
            //    Console.WriteLine("Se quitó una persona");
            //}

            //if (Extensora.ModificarBD(p3, 16))
            //{
            //    Console.WriteLine("Se modificó una persona");
            //}

            Console.Read();
        }
    }
}
