using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public class BancoProvincial : BancoNacional
  {
    public string provincia;

    public BancoProvincial(BancoNacional bn, string provincia)
        : base(bn.nombre, bn.pais)
    {
        this.provincia = provincia;
    }

    public override string ToString()
    {
        return base.Mostrar(this);
    }
    }
}
