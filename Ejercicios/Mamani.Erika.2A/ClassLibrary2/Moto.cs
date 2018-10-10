using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesP
{
  public class Moto : Vehiculo
  {
    protected float _cilindrada;

    public Moto(string patente, Byte num, EMarcas marca, float cil) : base(patente, num, marca)
    {
      this._cilindrada = cil;
    }

    public Moto(EMarcas marca, float cil, string pat, Byte cantR) : this(pat, cantR, marca, cil)
    {

    }

    protected override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(base.Mostrar());
      sb.AppendFormat("Cilindrada: {0}", this._cilindrada);
      sb.AppendLine("");
      
      return sb.ToString();
    }

    public override string ToString()
    {
      return this.Mostrar();
    }
  }
}
