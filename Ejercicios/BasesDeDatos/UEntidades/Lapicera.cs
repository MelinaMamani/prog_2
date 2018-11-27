using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEntidades
{
  public class Lapicera : Utiles
  {
    protected string _color;
    protected string _trazo;


    protected override double Precio
    {
      get
      {
        return 20;
      }
      set
      {
        base._precio = value;
      }
    }

    protected override string Marca
    {
      get
      {
        return "BIC";
      }
      set
      {
        base._marca = value;
      }
    }

    public Lapicera(string color, string trazo, string marca, double precio) : base (precio, marca)
    {
      this._color = color;
      this._trazo = trazo;
    }

    protected override string UtilesToString()
    {
      string r = "";
      r += base.UtilesToString();
      r += " - " + this._color + " - " + this._trazo;
      r += "\n";
      return r;
    }

    public override string ToString()
    {
      return this.UtilesToString();
    }
  }
}
