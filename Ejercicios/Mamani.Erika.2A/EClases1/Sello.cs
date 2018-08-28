using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases1
{
  class Sello
  {
    public static string mensaje;
    public static ConsoleColor color;

    public static string Imprimir()
    { 
      string cadena = "";

      if (Sello.TryParse(Sello.mensaje, out cadena))
      {
        cadena = Sello.mensaje;
      }
      else
      {
        Console.WriteLine("Cadena vacía");
      }
      return Sello.mensaje;
    }

    public static void Borrar()
    {
      Sello.mensaje = "";
    }

    public static void ImprimirEnColor()
    {
      Console.ForegroundColor = Sello.color;
      //Console.Write(Sello.mensaje);
      Console.Write(ArmarFormatoMensaje());
      Console.ForegroundColor = ConsoleColor.White;
    }

    private static string ArmarFormatoMensaje()
    {
      string cadena = "";
      string cad;
      int i;
      int cant = Sello.mensaje.Length;
      cant += 2;

      if (TryParse(Sello.mensaje, out cad))
      {
        Console.WriteLine("");
        for (i = 0; i < cant; i++)
        {
          cadena += "*";
        }
        cadena += "\n*";
        cadena += Imprimir() + "*\n";
        for (i = 0; i < cant; i++)
        {
          cadena += "*";
        }
      }
      else
      {
        Console.WriteLine("No se puede armar el formato.");
      }
      return cadena;
    }

    private static bool TryParse(string msj, out string cad)
    {
      bool ver = true;
      cad = "";

      if (msj != "")
      {
        cad = msj;
      }
      else
        ver = false;

      return ver;
    }

  }
}
