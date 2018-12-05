using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public class DepositoIndexado : Deposito
  {

    #region Indexador
    public Producto this[int indice]
    {
      get
      {
        if (indice >= 0 && !(Object.Equals(this.productos[indice], null)) && indice < this.Capacidad)
        {
          return this.productos[indice];
        }
        else
        {
          return null;
        }
      }

      set
      {
        if (indice >= 0 && indice < this.Capacidad)
        {
          this.productos[indice] = value;
        }
      }
    }
    #endregion

    public DepositoIndexado(int cap) : base (cap)
    {

    }

    
  }
}
