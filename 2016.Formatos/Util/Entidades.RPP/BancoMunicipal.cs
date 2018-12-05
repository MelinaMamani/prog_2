using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public class BancoMunicipal : BancoProvincial
  {
    string municipio;

    public BancoMunicipal(BancoProvincial bp,string municipio): base(new BancoNacional(bp.Nombre,bp.Pais),bp.Provincia)
    {
      this.municipio = municipio;
    }

    public static implicit operator string(BancoMunicipal bm)
    {
      return bm.ToString();
    }

    public override string ToString()
    {
      return base.ToString();
    }

  }
}
