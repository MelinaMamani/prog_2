using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Fruta
  {
    protected string _color;
    protected double _precio;

    public abstract bool TieneCarozo { get; }

    public Fruta()
    {

    }

    public Fruta(string color, double precio)
    {
      this._color = color;
      this._precio = precio;
    }

    protected virtual string FrutaToString()
    {
      return "Color: "+this._color+ "\nPrecio: "+
        (float)this._precio+"\n";
    }
  }
}
