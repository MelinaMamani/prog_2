using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
  class Pluma
  {
    private string _marca;
    private int _cantidad;
    private Tinta _tinta;

    #region Constructores
    public Pluma()
    {
      this._marca = "Sin Marca";
      this._cantidad = 0;
      this._tinta = null;
    }
    public Pluma(string valorMarca) : this()
    {
      this._marca = valorMarca;
    
    }
    public Pluma(string valorMarca, int valorCantidad) : this(valorMarca)
    {
      this._cantidad = valorCantidad;
    }
    public Pluma(string valorMarca, int valorCantidad, Tinta valorTinta ) : this(valorMarca, valorCantidad)
    {
      this._tinta = valorTinta;
    }
    #endregion

    #region Metodos

    private string Mostrar()
    {
      return this._marca + "--" + this._cantidad + "--" +Tinta.Mostrar(this._tinta);
    }

    public static implicit operator string (Pluma valorPluma)
    {
      return valorPluma.Mostrar();
    }

    public static bool operator ==(Pluma n1, Tinta t1)
    {
      bool var = false;
      if (n1._tinta == t1)
        var = true;
      return var;
    }

    public static bool operator !=(Pluma n1, Tinta t1)
    {
      return !(n1 == t1);
    }

    public static Pluma operator +(Pluma pluma, Tinta tinta)
    {      
      if (pluma == tinta && pluma._cantidad <= 90)
      {
        pluma._cantidad += 10;       
      }
      return pluma;
    }

    public static Pluma operator -(Pluma pluma, Tinta tinta)
    {
      if (pluma == tinta && pluma._cantidad >= 10)
      {
        pluma._cantidad -= 10;
      }
      return pluma;
    }

    #endregion

  }
}
