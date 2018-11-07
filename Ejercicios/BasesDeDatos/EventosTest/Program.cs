using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace EventosTest
{
  class Program
  {
    public static void PruebaEvento()
    {
      Console.WriteLine("Se insertó un resgistro en la BD.");
    }

    public void PruebaEvento2()
    {
      Console.WriteLine("Estoy dentro del segundo metodo del delegado");
    }

    public void Mostrar(Televisor televisor)
    {
      Console.WriteLine(televisor.id +" - "+televisor.marca+" - "+(float)televisor.precio+" - "+televisor.pulgadas+" - "+televisor.pais);
    }

    static void Main(string[] args)
    {
      Televisor t = new Televisor(130,"LG",90000,100,"Argentina");

      t.miEvento += new MiDelegado(Program.PruebaEvento);
      t.miEvento += new MiDelegado(new Program().PruebaEvento2);

      t.delegadoTV += new DelegadoTV(new Program().Mostrar);

      t.Insertar();

      Console.ReadKey();
    }
  }
}
