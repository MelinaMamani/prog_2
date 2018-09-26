using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase07
{
  public class PaletaColeccion
  {
    //private Tempera[] _colores;
    List<Tempera> _colores;
    private int _cantMaxElementos;

    #region Constructores
    private PaletaColeccion() : this(5) //llamada en main: Paleta p = 8; porque es privado
    {
    }

    private PaletaColeccion(int cant)
    {
      this._cantMaxElementos = cant;
      this._colores = new List<Tempera>(this._cantMaxElementos);
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

    public static explicit operator string(PaletaColeccion p)
    {
      return p.Mostrar();
    }

    public static implicit operator PaletaColeccion(int cant)
    {
      PaletaColeccion pal = new PaletaColeccion(cant);
      return pal;
    }

    private int ObtenerIndice()
    {
      int indice = -1;

      for (int i = 0; i < this._cantMaxElementos; i++)
      {
        if (this._colores[i] == null)
        {
          indice = i;
          break;
        }
      }

      return indice;
    }

    private int ObtenerIndice(Tempera t)
    {
      int indice = 0;

      for (int i = 0; i < this._cantMaxElementos; i++)
      {
        if (this._colores[i] != null)
        {
          if (this._colores[i] == t)
          {
            indice = i;
            break;
          }
        }
      }

      return indice;
    }
    #endregion

    #region Sobrecarga
    public static int operator ==(Tempera t, PaletaColeccion p)
    {
      int index = 0;

      for (int i = 0; i < p._cantMaxElementos; i++)
      {
        if(p._colores[i] != null)
        {
          if(p._colores[i] == t)
          {
            index = i;
            break;
          }
        }
      }

      return index;
    }

    public static int operator !=(Tempera t, PaletaColeccion p)
    {
      return t == p;
    }

    public static bool operator ==(PaletaColeccion p, Tempera t)
    {
      bool verif = false;

      if (!(Object.Equals(p, null)) && !(Object.Equals(t, null)))
      {
        for (int i = 0; i < p._cantMaxElementos; i++)
        {
          //si el array no tiene muchos elementos, es null
          if (p._colores[i] != null) //antes: getValue()
          {
            if (p._colores[i] == t)
            {
              verif = true;
              break;
            }
          }
        }
      }

      return verif;
    }

    public static bool operator !=(PaletaColeccion p, Tempera t)
    {
      return !(p == t);
    }

    public static PaletaColeccion operator +(PaletaColeccion p, Tempera t)
    {
      int index;

      if (p.ObtenerIndice(t) > -1)
      {
        p._colores.Add(t);
      }

      else if (p.ObtenerIndice() > -1)
      {
        index = p.ObtenerIndice();
        p._colores[index] = t;
      }

      return p;
    }

    public static PaletaColeccion operator -(PaletaColeccion p, Tempera t)
    {
      int index;
      int resta;

      if (p.ObtenerIndice(t) > -1)
      {
        index = p.ObtenerIndice(t);
        sbyte cantTem = (sbyte)t;
        sbyte cantPal = (sbyte)p._colores[index];
        resta = cantPal - cantTem;

        if (resta <= 0)
        {
          p._colores[index] = null;
        }
        else
        {
          p._colores[index] += (sbyte)(cantTem * (-1));
        }
      }

      return p;
    }
    #endregion
  }
}
