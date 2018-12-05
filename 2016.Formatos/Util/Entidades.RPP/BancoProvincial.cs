using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public class BancoProvincial : BancoNacional
  {
    string provincia;

    public string Provincia
    {
      get{ return this.provincia; }
    }

    public BancoProvincial(BancoNacional bn, string provincia):base(bn.Nombre,bn.Pais)
    {
      this.provincia = provincia;
    }
  }
}
