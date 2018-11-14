using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Durazno : Fruta
  {
    protected int _cantPelusa;

    public override bool TieneCarozo
    {
      get
      {
        return true;
      }
    }

    public string Nombre { get { return "Durazno"; } }

    public Durazno()
    {

    }

    public Durazno(string color, double precio, int cant) : base(color, precio)
    {
      this._cantPelusa = cant;
    }

    protected override string FrutaToString()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(base.FrutaToString());
      sb.AppendLine("Cant. Pelusa: " + this._cantPelusa);
      sb.AppendLine("Nombre: " + this.Nombre);

      return sb.ToString();
    }

    public override string ToString()
    {
      return this.FrutaToString();
    }
  }
}
