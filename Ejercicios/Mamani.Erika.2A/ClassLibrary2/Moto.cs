using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesP
{
  class Moto : Vehiculo
  {
    protected float _cilindrada;

    public Moto(string patente, Byte num, EMarcas marca, float cil) : base(patente, num, marca)
    {
      this._cilindrada = cil;
    }

    public Moto(EMarcas marca, float cil, string pat, Byte cantR) : this(pat, cantR, marca, cil)
    {

    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(base.ToString());
      sb.AppendLine("");
      sb.AppendFormat("Cilindrada: {0}", this._cilindrada);

      return sb.ToString();
    }

    public override string ToString()
    {
      return this.ToString();
    }
  }
}
