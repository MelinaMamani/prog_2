using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public class BancoMunicipal : BancoProvincial
  {
    public string municipio;
    public BancoProvincial bP;

    public BancoMunicipal(BancoProvincial bp, string mun) : base(bp.bN, bp.Provincia)
    {
      this.municipio = mun;
    }

  }
}
