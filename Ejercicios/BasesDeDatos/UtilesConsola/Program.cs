using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UEntidades;

namespace UtilesConsola
{
  class Program
  {
    static void Main(string[] args)
    {
      Cartuchera<Utiles> cartuchera = (Cartuchera<Utiles>)(4);
      Goma goma = new Goma(true,"K",10);
      Lapicera lapicera = new Lapicera("Azul","0.4 mm","BIC", 20);
      Goma goma2 = new Goma(false, "F", 15);
      Lapicera lapicera2 = new Lapicera("Negra", "0.6 mm", "BIC", 30);

      cartuchera.Add(goma);
      cartuchera.Add(goma2);
      cartuchera.Add(lapicera);
      cartuchera.Add(lapicera2);

      try
      {
        cartuchera.Add(goma);
      }
      catch (Exception)
      {

        throw new CartucheraLlenaException("Cartuchera llena");
      }

      Console.Write(cartuchera.ToString());
      Console.Read();
    }
  }
}
