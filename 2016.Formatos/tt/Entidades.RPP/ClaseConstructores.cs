using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Entidades.RPP
{
  public class ClaseConstructores
  {
    public static int var1;

    public int var2;
    public int var3;


    public int prop1;
    public int Propiedad1
    {
      set
      {
        this.prop1 = value;
      }
    }

    public int prop2;
    public int Propiedad2
    {
      get
      {
        return this.prop2;
      }
    }

    static ClaseConstructores()
    {
      ClaseConstructores.var1 = 1;
    }

    private ClaseConstructores(int num1, int num2)
    {
      this.var2 = num1;
      this.var3 = num2;
    }

    public ClaseConstructores()
    {

    }

    public string MetodoDeInstancia()
    {
      return "Metodo de instancia";
    }

    public static string MetodoDeClase()
    {
      return "Metodo de clase";
    }
  }
}
