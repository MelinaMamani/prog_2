using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public class BancoNacional : Banco
  {
    private string pais;
    public string Pais { get { return this.pais; } }

    public BancoNacional(string nom, string pais) : base (nom)
    {
      this.pais = pais;
    }
  }
}
