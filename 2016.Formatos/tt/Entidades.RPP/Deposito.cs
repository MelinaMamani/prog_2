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
        public Producto[] productos;

        #endregion

        #region Constructor
        public Deposito() : this (3)
        {
        }

        public Deposito(int cap)
        {
          this.productos = new Producto[cap];
        }
        #endregion

        #region Metodos
        public Producto[] OrdenadoPorStock(int tam)
        {
            Producto aux;

            for (int i = 0; i < tam; i++)
            {
                for (int j = i + 1; j < tam; j++)
                {
                    if (this.productos[i].Stock > this.productos[j].Stock)
                    {
                        aux = this.productos[i];
                        this.productos[i] = this.productos[j];
                        this.productos[j] = aux;
                    }
                }
            }

            return this.productos;
        }

        public Producto[] OrdenadoPorNombre(int tam)
        {
            Producto aux;

            for (int i = 0; i < tam; i++)
            {
                for (int j = i + 1; j < tam; j++)
                {
                    if (String.Compare(this.productos[i].Nombre, this.productos[j].Nombre) > 0)
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
        public static Producto[] operator +(Deposito d1,Deposito d2)
        {
            Producto[] array = new Producto[d1.productos.Length + d2.productos.Length];
            d1.productos.CopyTo(array, 0);
            d2.productos.CopyTo(array, d1.productos.Length);

            for (int i = 0; i < d1.productos.Length; i++)
            {
                array[i] = d1.productos[i];
            }
            for (int i = d1.productos.Length; i < d2.productos.Length + d1.productos.Length; i++)
            {
                array[i] = d2.productos[i - d1.productos.Length];
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] != null && array[j] != null)
                    {
                        if (array[i] == array[j])
                        {
                            array[i].stock += array[j].stock;
                            array[j] = null;
                        }
                    }
                }
            }

            return array;
        }
        #endregion
    }
}
