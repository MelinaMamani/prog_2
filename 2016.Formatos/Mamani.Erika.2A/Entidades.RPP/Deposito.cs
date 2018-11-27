using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public class Deposito
  {
    public int capacidad;
    public List<Producto> productos;

    public Deposito()
    {
      this.productos = new List<Producto>();
    }

    public Deposito(int cap) : this ()
    {
      this.capacidad = cap;
    }

    public static Producto[] operator +(Deposito d1, Deposito d2)
    {
      Deposito d3 = new Deposito();
      
      for (int i = 0; i < d1.productos.Count; i++)
      {
        if(d1.productos[i] == d1.productos[i])
        {
          d1.productos[i].stock++;
        }
        else
        {
          d3.productos.Add(d1.productos[i]);
        }
      }

      for (int i = 0; i < d2.productos.Count; i++)
      {
        if (d2.productos[i] == d2.productos[i])
        {
          d2.productos[i].stock++;
        }
        else
        {
          d3.productos.Add(d2.productos[i]);
        }
      }

      Producto[] aux = d3.productos.ToArray();
      return aux;
    }
  }
}
