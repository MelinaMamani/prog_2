using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public class Producto
  {
    public int stock;
    public string nombre;

    public Producto(string nom, int cant)
    {
      this.nombre = nom;
      this.stock = cant;
    }

    public static bool operator ==(Producto a, Producto b)
    {
      return a.nombre == b.nombre;
    }

    public static bool operator !=(Producto a, Producto b)
    {
      return !(a == b);
    }
  }
}
