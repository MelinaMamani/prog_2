using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase07
{
  class Paleta
  {
    private Tempera[] _colores;
    private int _cantMaxElementos;

    #region Constructores
    private Paleta() : this(5)
    {
    }

    private Paleta(int cant)
    {
      this._cantMaxElementos = cant;
      this._colores = new Tempera[this._cantMaxElementos];
    }
    #endregion

    #region Métodos
    private string Mostrar()
    {
      string mensaje = "Cant. elem: ";
      mensaje += this._cantMaxElementos.ToString();
      mensaje += "\nColores: \n";

      foreach (Tempera elem in this._colores)
      {
        mensaje += elem + "\n";
      }

      return mensaje;
    }

    public static explicit operator string(Paleta p)
    {
      return p.Mostrar();
    }

    public static implicit operator Paleta(int cant)
    {
      Paleta pal = new Paleta(cant);
      return pal;
    }
    #endregion
  }
}
