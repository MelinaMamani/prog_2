using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesP
{
  class Camion : Vehiculo
  {
    protected float _tara;

    public Camion(string patente, Byte num, EMarcas marca, float tara) : base(patente, num, marca)
    {
      this._tara = tara;
    }

    public Camion(Vehiculo v, float tara) : this(v.Patente, v.Ruedas, v.Marca, tara)
    {

    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(base.ToString());
      sb.AppendLine("");
      sb.AppendFormat("Tara: {0}", this._tara);

      return sb.ToString();
    }

    public override string ToString()
    {
      return this.ToString();
    }
  }
}
