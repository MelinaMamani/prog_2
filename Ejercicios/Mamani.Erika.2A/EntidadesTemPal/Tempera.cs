using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTemPal
{
  public class Tempera
  {
    private sbyte _cantidad;
    private ConsoleColor _color;
    private string _marca;

    #region Propiedades
        public string Marca
        {
            get
            {
                return this._marca;
            }
        }

        public sbyte Cantidad
        {
            get
            {
                return this._cantidad;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return this._color;
            }
        }
        #endregion

        public Tempera(sbyte cant)
    {
      this._cantidad = cant;
    }

    public Tempera(sbyte cant, ConsoleColor color) : this(cant)
    {
      this._color = color;
    }

    public Tempera(sbyte cant, ConsoleColor color, string marca) : this(cant, color)
    {
      this._marca = marca;
    }

    private string Mostrar()
    {
      return "\r\n" + this._marca + " - " + this._color + " - " + this._cantidad; 
    }

    public static implicit operator string(Tempera temp)
    {
      return temp.Mostrar();
    }

    public static explicit operator sbyte(Tempera temp)
    {
      return temp._cantidad;
    }

    public static Boolean operator ==(Tempera temp1, Tempera temp2)
    {
      return (temp1._color == temp2._color) && (temp1._marca == temp2._marca);
    }

    public static Boolean operator !=(Tempera temp1, Tempera temp2)
    {
      return !(temp1 == temp2);
    }

    public static Tempera operator +(Tempera temp1, sbyte cant)
    {
      temp1._cantidad += cant;
      return temp1;
    }

    public static Tempera operator +(Tempera temp1, Tempera temp2)
    {
      Tempera t3 = new Tempera(temp1._cantidad, temp1._color, temp1._marca);

      if (temp1 == temp2)
      {
          t3 += temp2._cantidad;
      }
      return t3;
    }
  }
}
