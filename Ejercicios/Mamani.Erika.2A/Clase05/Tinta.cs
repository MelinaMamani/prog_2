using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
  class Tinta
  {
    private ConsoleColor _color;
    private ETipoTinta _tipo;


    public Tinta()
    {
      this._color = ConsoleColor.Blue;
      this._tipo = ETipoTinta.ConBrillito;
    }

    public Tinta(ConsoleColor valorColor) : this()
    {
      this._color = valorColor;
    }
    public Tinta(ConsoleColor valorColor, ETipoTinta valorTipo) : this(valorColor)
    {
      this._tipo = valorTipo;
    }

    public static string Mostrar(Tinta valorTinta)
    {
      if (!Object.Equals(valorTinta, null))
        return valorTinta.Mostrar();
      return "-Sin Tinta-";
    }

    private string Mostrar()
    {
      return this._color + "--" + this._tipo;
    }

    #region Sobrecarga op

    public static bool operator ==(Tinta n1, Tinta n2)
    {
      bool var = false;

      if (!(Object.Equals(n1, null)) && !(Object.Equals(n2, null)))
      {
        if (n1._tipo == n2._tipo && n1._color == n2._color)
          var = true;
      }
      return var;
    }

    public static bool operator !=(Tinta n1, Tinta n2)
    {
      return !(n1 == n2);
    }


    #endregion

  }
}
