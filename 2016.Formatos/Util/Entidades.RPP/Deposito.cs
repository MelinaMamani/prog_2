using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class Deposito
    {
    #region Atributos
    private int _maxCap;
    public Producto[] productos;

    #endregion

    #region Properties
    public int Capacidad
    {
      get { return this._maxCap; }
      set { this._maxCap = value; }
    }
    #endregion

    #region Constructor
    public Deposito()
    {
      this.Capacidad = 3;
      this.productos = new Producto[Capacidad];
    }

    public Deposito(int cap)
    {
      this.Capacidad = cap;
      this.productos = new Producto[Capacidad];
    }
    #endregion

    #region Sobrecargas
    public static Producto[] operator +(Deposito d1,Deposito d2)
    {
      int length = d1.Capacidad + d2.Capacidad;
      Producto[] lista = new Producto[length];

      for(int i=0;i<d1.Capacidad;i++)
      {
        lista[i] = d1.productos[i];
      }

      for(int i=0;i<length;i++)
      {
        for(int j=0;j<d2.Capacidad;j++)
        {
          if(lista[i].nombre == d2.productos[j].Nombre)
          {
            lista[i].stock += d2.productos[j].Stock;
          }
          else if(lista[i]==null)
          {
            lista[i] = d2.productos[j];
          }
        }
      }

      return lista;
    }
    #endregion
  }
}
