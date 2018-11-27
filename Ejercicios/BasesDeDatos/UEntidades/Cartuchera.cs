using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEntidades
{
  public class Cartuchera<T>
  {
    protected byte _capacidad;
    protected string _marca;
    protected List<T> _elementos;

    private Cartuchera(byte cap)
    {
      this._elementos = new List<T>(cap);
    }

    public static implicit operator Cartuchera<T>(byte n)
    {
      Cartuchera<T> cartuchera = new Cartuchera<T>(n);
      return cartuchera;
    }

    public void Add(T elem)
    {
      this._elementos.Add(elem);
    }

    public bool Remove(T elem)
    {
      this._elementos.Remove(elem);
      return true;
    }

    public override string ToString()
    {
      string cad = "";

      foreach (T elem in this._elementos)
      {
        if (elem is Goma || elem is Lapicera)
        {
          cad += elem.ToString();
        }
      }

      return cad;
    }
  }
}
