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
        public List<Producto> productos;

        #endregion

        #region Constructor
        public Deposito() : this (3)
        {
        }

        public Deposito(int cap)
        {
          this.productos = new List<Producto>(cap);
        }
    #endregion

    #region Metodos
    public List<Producto> OrdenadoPorStock(int tam)
    {
      Producto aux;

      for (int i = 0; i < tam; i++)
      {
        for (int j = i + 1; j < tam; j++)
        {
          if (this.productos[i].stock > this.productos[j].stock)
          {
            aux = this.productos[i];
            this.productos[i] = this.productos[j];
            this.productos[j] = aux;
          }
        }
      }

      return this.productos;
    }

    public List<Producto> OrdenadoPorNombre(int tam)
    {
      Producto aux;

      for (int i = 0; i < tam; i++)
      {
        for (int j = i + 1; j < tam; j++)
        {
          if (String.Compare(this.productos[i].nombre, this.productos[j].nombre) > 0)
          {
            aux = this.productos[i];
            this.productos[i] = this.productos[j];
            this.productos[j] = aux;
          }
        }
      }

      return this.productos;
    }
    #endregion

    #region Sobrecargas
    public static List<Producto> operator +(Deposito d1,Deposito d2)
        {
            List<Producto> lista = new List<Producto>(d1.productos.Count + d2.productos.Count);

            for (int i = 0; i < d1.productos.Count; i++)
            {
              lista.Add(d1.productos[i]);
            }

            for (int i = d1.productos.Count; i < d2.productos.Count + d1.productos.Count; i++)
            {
                lista.Add(d2.productos[i - d1.productos.Count]);
            }

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i] != null && lista[j] != null)
                    {
                        if (lista[i] == lista[j])
                        {
                            lista[i].stock += lista[j].stock;
                            lista[j] = null;
                        }
                    }
                }
            }

            return lista;
        }
        #endregion
    }
}
