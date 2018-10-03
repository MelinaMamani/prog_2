using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTemPal
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
      string retorno = "Cantidad maxima de elementos: " + this._cantMaxElementos + "\r\nColores en la paleta: ";
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
      retorno += cadenaAux;
      return retorno;
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
      int indice = -1;
      int contador = 0;

      foreach (Tempera item in p._colores)
      {
         if (t == item)
         {
           indice = contador;
         }
         contador++;
      }
      return indice;
    }

    public static int operator !=(Tempera t, PaletaColeccion p)
    {
      return t == p;
    }

    public static bool operator ==(PaletaColeccion p, Tempera t)
    {
      foreach (Tempera item in p._colores)
      {
         if (!(Object.Equals(item, null)) && t == item)
         {
           return true;
         }
      }
      return false;
    }

    public static bool operator !=(PaletaColeccion p, Tempera t)
    {
      return !(p == t);
    }

    public static PaletaColeccion operator +(PaletaColeccion p, Tempera t)
    {
      int indice = -1;
      if ((t == p) != -1)
      {
        indice = (t == p);
        p._colores[indice] += t;
      }
      else if (p._colores.Count < p._cantMaxElementos)
      {
        p._colores.Add(t);   
      }
      return p;
    }

    public static PaletaColeccion operator -(PaletaColeccion p, Tempera t)
    {
      int index;
      int aux1, aux2;

      index = (t == p);
      if (index != -1)
      {
        aux1 = (sbyte)t;
        p._colores[index] += (sbyte)(aux1 * (-1));
        aux2 = (sbyte)p._colores[index];
            if (aux2 <= 0)
            {
                p._colores.Remove(t);
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
