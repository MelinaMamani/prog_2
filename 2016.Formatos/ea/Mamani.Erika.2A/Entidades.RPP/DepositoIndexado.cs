using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public class DepositoIndexado : Deposito
  {
    private Producto[] productos;

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

                //else if (indice == this.productos.GetLength(0))
                //{

                //    this.productos = this + indice;
                //    this[indice] = value;
                //}
                //else
                //{
                //    Console.WriteLine("No se puede asignar a este elemento");
                //    Console.ReadLine();
                //}
            }
    }
    #endregion

    public DepositoIndexado(int cap)
    {
      this.productos = new Producto[cap];
    }

        //public static Producto[] operator +(DepositoIndexado depo, int indice)
        //{
        //    int i = indice >= depo.productos.GetLength(0) ? ++indice : --indice;

        //    Producto[] aux = new Producto[i];

        //    depo.productos.CopyTo(aux, 0);

        //    return aux;

        //}

    }
}
