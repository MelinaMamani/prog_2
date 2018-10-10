using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesP
{
  public class Camion : Vehiculo
  {
    protected float _tara;

    public Camion(string patente, Byte num, EMarcas marca, float tara) : base(patente, num, marca)
    {
      this._tara = tara;
    }

    public Camion(Vehiculo v, float tara) : this(v.Patente, v.Ruedas, v.Marca, tara)
    {

    }

    protected override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(base.Mostrar());
      sb.AppendFormat("Tara: {0}", this._tara);
      sb.AppendLine("");
      
      return sb.ToString();
    }

    public override string ToString()
    {
      return this.Mostrar();
    }
  }
}
