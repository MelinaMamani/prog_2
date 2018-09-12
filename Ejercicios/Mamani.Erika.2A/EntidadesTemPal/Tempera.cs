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
      return this._marca + " - " + this._color + " - " + this._cantidad; 
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
      bool verf = false;

      if (!(Object.Equals(temp1, null)) && !(Object.Equals(temp2, null)))
      {
        if(temp1._marca == temp2._marca && temp1._color == temp2._color)
        {
          verf = true;
        }
      }
      return verf;
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
      
      if(temp1 == temp2)
      {
        temp1 += temp1._cantidad; 
      }

      return temp1;
    }
  }
}
