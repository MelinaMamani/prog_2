using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public class BancoNacional : Banco
  {
    public string pais;

    public override string Mostrar()
    {

      return base.Nombre;
    }

    public override string Mostrar(Banco b)
    {

      return this.Pais;
    }

    public string Pais
    {
      get { return this.pais; }
    }

    public BancoNacional(string nombre, string pais) : base(nombre)
    {
      this.pais = pais;
    }
  }
}
