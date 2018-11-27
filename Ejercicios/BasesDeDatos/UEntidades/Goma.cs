using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEntidades
{
  public class Goma : Utiles
  {
    protected bool _soloLapiz;

    protected override double Precio
    {
      get
      {
        return 10;
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

    public Goma (bool sL, string marca, double precio) : base (precio, marca)
    {
      this._soloLapiz = sL;
    }

    protected override string UtilesToString()
    {
      string r = "";
      r += base.UtilesToString();
      r += " - " + this._soloLapiz;
      r += "\n";
      return r;
    }

    public override string ToString()
    {
      return this.UtilesToString();
    }
  }
}
