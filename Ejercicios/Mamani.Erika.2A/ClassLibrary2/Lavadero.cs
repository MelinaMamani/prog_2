using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesP
{
  class Lavadero
  {
    #region Atributos

    private List<Vehiculo> _vehiculos;
    private static float _precioAuto;
    private static float _precioCamion;
    private static float _precioMoto;
    private string _razonSocial;

    #endregion

    #region Propiedades

    public string LavaderoToString
    {
      get {

        string retorno = "asdfasdfasdf";

        foreach (Vehiculo item in this._vehiculos)
        {
          retorno += item.ToString();
        }
        retorno += this._vehiculos.ToString();

        return retorno;


      }
    }

    public List<Vehiculo> Vehiculos
    {
      get { return this._vehiculos; }
    }

    #endregion

    #region Constructores

    public Lavadero( string rSocial):this()
    {
      
      this._razonSocial = rSocial;
    }

    private Lavadero()
    {
      this._vehiculos = new List<Vehiculo>();
    }

    static Lavadero()
    {
      Random rm = new Random();
      Lavadero._precioAuto = rm.Next(150,565);
      Lavadero._precioCamion = rm.Next(150, 565);
      Lavadero._precioMoto = rm.Next(150, 565);
    }

    #endregion

    #region Métodos

    public double MostrarTotalFacturado()
    {
      return this.MostrarTotalFacturado(EVehiculos.Auto) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);
    }

    public double MostrarTotalFacturado(EVehiculos eVe)
    {
      double total = 0;
      double tot_auto = 0;
      double tot_moto = 0;
      double tot_camion = 0;

      foreach (Vehiculo v in this._vehiculos)
      {
        if (v is Auto)
          tot_auto++;

        if (v is Moto)
          tot_moto++;

        if (v is Camion)
          tot_camion++;
      }
      
      switch (eVe)
      {
        case EVehiculos.Auto:
          total = tot_auto * Lavadero._precioAuto;
          break;
        case EVehiculos.Camion:
          total = tot_camion * Lavadero._precioAuto;
          break;
        case EVehiculos.Moto:
          total = tot_moto * Lavadero._precioAuto;
          break;
        default:
          break;
      }

      return total;

      //foreach (Vehiculo v in this._vehiculos)
      //{
      //  switch (eVe)
      //  {
      //    case EVehiculos.Auto:
      //      if(v is Auto)
      //      {
      //        total += _precioAuto;
      //      }
      //      break;
      //    case EVehiculos.Camion:
      //      if(v is Camion)
      //      {
      //        total += _precioCamion;
      //      }
      //      break;
      //    case EVehiculos.Moto:
      //      if(v is Moto)
      //      {
      //        total += _precioMoto;
      //      }
      //      break;
      //    default:
      //      break;
      //  }
      //}

      //return total;
    }

    #endregion

    #region Sobrecarga de Op.

    public static bool operator ==(Lavadero l, Vehiculo v)
    {
      bool var = false;

      if ((v == l) >= 0)
      {
        var = true;
      }

      return var;
    }

    public static bool operator !=(Lavadero l, Vehiculo v)
    {
      return !(l == v);
    }

    public static int operator ==(Vehiculo v, Lavadero l)
    {
      int indice = -1;

      for (int i = 0; i < l._vehiculos.Count; i++)
      {
        if(v == l._vehiculos[i])
        {
          indice = i;
          break;
        }
      }

      return indice;
    }

    public static int operator !=(Vehiculo v, Lavadero l)
    {
      return 0;
    }

    public static Vehiculo operator +()
    {

    }

    #endregion
  }
}
