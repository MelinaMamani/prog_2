using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesP
{
  class Auto : Vehiculo
  {
    protected int _cantDeAsientos;

    public Auto(string patente, Byte num, EMarcas marca, int cantAsientos) : base (patente, num, marca)
    {
      this._cantDeAsientos = cantAsientos;
    }

    public Auto(string patente, EMarcas marca, int cantAsientos) : this (patente, 4, marca, cantAsientos)
    {

    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(base.ToString());
      sb.AppendLine("");
      sb.AppendFormat("Cant. asientos: {0}", this._cantDeAsientos);

      return sb.ToString();
    }

    public override string ToString()
    {
      return this.ToString();
    }
  }
}
