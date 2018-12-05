using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
  public class Producto
  {
    #region Atributos
    public string nombre;
    public int stock;
    #endregion

    #region Properties
    public string Nombre
    {
      get { return this.nombre; }
      set { this.nombre = value; }
    }

    public int Stock
    {
      get { return this.stock; }
      set { this.stock = value; }
    }
    #endregion

    #region Metodos

    #endregion

    #region Constructor
    public Producto(string nombre, int stock)
    {
      this.Nombre = nombre;
      this.Stock = stock;
    }
    #endregion

    #region Sobrecargas

    #endregion
  }
}
