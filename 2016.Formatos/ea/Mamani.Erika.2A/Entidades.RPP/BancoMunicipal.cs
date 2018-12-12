using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public class BancoMunicipal : BancoProvincial
  {
    public string municipio;

    public BancoMunicipal(BancoProvincial bp, string municipio)
        : base(new BancoNacional(bp.nombre, bp.pais), bp.provincia)
    {
        this.municipio = municipio;
    }

    public override string ToString()
    {
        return base.Mostrar(this);
    }
    
    public static implicit operator string(BancoMunicipal bm)
    {
        return bm.ToString();
    }
  }
}
