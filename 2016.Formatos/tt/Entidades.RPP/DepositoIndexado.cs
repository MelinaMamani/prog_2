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
        if (indice >= this.productos.GetLength(0) || indice < 0)
            return null;
        else
            return this.productos[indice];
      }

      set
      {
        if (indice >= 0 && indice < this.productos.GetLength(0))
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
