using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        //int num1;
        //int num2;
        ////Crear una clase (ClaseConstructores) que al instanciarse:
        ////    *pase por un constructor est�tico
        ////    *pase por un constructor que reciba 2 par�metros (privado)
        ////    *pase por un constructor publico (default)
        ////    *pase por una propiedad de s�lo escritura
        ////    *pase por una propiedad de s�lo lectura
        ////    *pase por un m�todo de instancia
        ////    *pase por un m�todo de clase
        ////NOTA: por cada lugar que pase, mostrar con un MessageBox.Show dicho lugar
        ////NOTA: agregar la referencia a System.Windows.Form; para poder acceder a la clase MessageBox.
        ////NOTA: NO MAS DE 2 LINEAS DE CODIGO POR METODO/PROPIEDAD/CONSTRUCTOR

        //static ClaseConstructores()
        //{

        //}

        //private ClaseConstructores(int num1, int num2)
        //{
        //    this.PropEscritura = num1;
        //    this.PropLectura;
        //}

        //public ClaseConstructores() : this(2, 4)
        //{

        //}

        //public int PropEscritura
        //{
        //    set
        //    {

        //    }
        //}

        //public int PropLectura
        //{

        //    get
        //    {

        //    }
        //}

        //public void metodoInstancia()
        //{

        //}

        //public static void metodoEstatico()
        //{


        //}

    }
}
