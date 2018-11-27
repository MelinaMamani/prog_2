using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEntidades
{
  public abstract class Utiles
  {
    protected double _precio;
    protected string _marca;

    protected abstract double Precio { get; set; }
    protected abstract string Marca { get; set; }

    public Utiles(double precio, string marca)
    {
      this._precio = precio;
      this._marca = marca;
    }

    protected virtual string UtilesToString()
    {
      return this._marca + " - " + this._precio;
    }
  }
}
