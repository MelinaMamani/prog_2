using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Banana : Fruta
  {
    protected string _paisOrigen;

    public override bool TieneCarozo
    {
      get
      {
        return false;
      }
    }

    public string Nombre { get { return "Banana"; } }

    public Banana()
    {

    }

    public Banana(string color, double precio, string pais) : base(color, precio)
    {
      this._paisOrigen = pais;
    }

    protected override string FrutaToString()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(base.FrutaToString());
      sb.AppendLine("Pais: " + this._paisOrigen);
      sb.AppendLine("Nombre: " + this.Nombre);

      return sb.ToString();
    }

    public override string ToString()
    {
      return this.FrutaToString();
    }
  }
}
