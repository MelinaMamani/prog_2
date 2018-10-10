using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesP
{
  public class Auto : Vehiculo
  {
    protected int _cantDeAsientos;

    public Auto(string patente, Byte num, EMarcas marca, int cantAsientos) : base (patente, num, marca)
    {
      this._cantDeAsientos = cantAsientos;
    }

    public Auto(string patente, EMarcas marca, int cantAsientos) : this (patente, 4, marca, cantAsientos)
    {

    }

    protected override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(base.Mostrar());
      sb.AppendFormat("Cant. asientos: {0}", this._cantDeAsientos);
      sb.AppendLine("");
      
      return sb.ToString();
    }

    public override string ToString()
    {
      return this.Mostrar();
    }
  }
}
