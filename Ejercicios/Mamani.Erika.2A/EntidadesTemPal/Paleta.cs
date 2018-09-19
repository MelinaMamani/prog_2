using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTemPal
{
  public class Paleta
  {
    private Tempera[] _colores;
    private int _cantMaxElementos;

    #region Constructores
    private Paleta() : this(5) //llamada en main: Paleta p = 8; porque es privado
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
      mensaje += "\r\nColores:";
      string cadenaAux = "";
      string cadenaAux2 = "";

      foreach (Tempera temperas in this._colores)
      {
        if (!(Object.Equals(temperas, null)))
        {
           cadenaAux2 = temperas;
           cadenaAux += cadenaAux2;
        }
      }
      mensaje += cadenaAux;
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

    private int ObtenerIndice()
    {
      int indice = -1;

      for (int i = 0; i < this._cantMaxElementos; i++)
      {
        if(this._colores.GetValue(i) == null)
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
        if(this._colores[i] != null)
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
    public static bool operator ==(Paleta p, Tempera t)
    {
      //bool verif = false;

      //if(!(Object.Equals(p,null)) && !(Object.Equals(t, null)))
      //{
        foreach (Tempera item in p._colores)
        {
           if (!(Object.Equals(item, null)) && t == item)
           {
              return true;
           }
        }
        return false;
                //for (int i = 0; i < p._cantMaxElementos ; i++)
                //{
                //  //si el array no tiene muchos elementos, es null
                //  if (p._colores.GetValue(i) != null) 
                //  {
                //    if(p._colores[i] == t)
                //    {
                //      verif = true;
                //      break;
                //    }
                //  }
                //}
            //}

      //return verif;
    }

    public static bool operator !=(Paleta p, Tempera t)
    {
      return !(p == t);
    }

    public static Paleta operator +(Paleta p, Tempera t)
    {
      int indice = -1;
      if (p == t)
      {
          indice = p.ObtenerIndice(t);
          if (indice != -1)
          {
              p._colores[indice] += t;
          }
       }
       else
       {
          indice = p.ObtenerIndice();
          if (indice != -1)
          {
              p._colores[indice] = t;
          }
       }
        return p;
    }

    public static Paleta operator -(Paleta p, Tempera t)
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

    #region Indexador
        public Tempera this[int indice]
        {
            get
            {
                if (indice >= 0 && !(Object.Equals(this._colores[indice], null)) && indice < this._cantMaxElementos)
                {
                    return this._colores[indice];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (indice >= 0 && indice < this._cantMaxElementos)
                {
                    this._colores[indice] = value;
                }
            }
        }
        #endregion
    }
}
