using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesP
{
  public class Vehiculo
  {
    protected string _patente;
    protected Byte _ruedas;
    protected EMarcas _marca;

    public Vehiculo(string patente, Byte num, EMarcas marca)
    {
      this._patente = patente;
      this._ruedas = num;
      this._marca = marca;
    }

    #region Propiedades

    public string Patente
    {
      get { return this._patente; }
    }

    public Byte Ruedas
    {
      get { return this._ruedas; }
      set { this._ruedas = value; }
    }

    public EMarcas Marca
    {
      get { return this._marca; }
    }

    #endregion

    public virtual string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("Patente: {0}",this._patente);
      sb.AppendFormat("Ruedas: {0}",this._ruedas.ToString());
      sb.AppendFormat("Marca: {0}",this._marca);

      return sb.ToString();
    }

    public override string ToString()
    {
      return this.Mostrar();
    }

    public static bool operator ==(Vehiculo v1, Vehiculo v2)
    {
      bool ver = false;

      if((v1._patente == v2._patente) && (v1._marca == v2._marca))
      {
        ver = true; ;
      }

      return ver;
    }

    public static bool operator !=(Vehiculo v1, Vehiculo v2)
    {
      return !(v1 == v2);
    }
  }
}
