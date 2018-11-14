using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
  public class Manzana : Fruta, IDeserializar, ISerializar
  {

    protected string _provinciaOrigen;

    public override bool TieneCarozo
    {
      get
      {
        return true;
      }
    }

    public string Nombre { get { return "Manzana"; } }

    public Manzana()
    {

    }

    public Manzana(string color, double precio, string provincia) : base(color, precio)
    {
      this._provinciaOrigen = provincia;
    }

    protected override string FrutaToString()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(base.FrutaToString());
      sb.AppendLine("Provincia: " + this._provinciaOrigen);
      sb.AppendLine("Nombre: " + this.Nombre);

      return sb.ToString();
    }

    public override string ToString()
    {
      return this.FrutaToString();
    }

    public bool Xml(string archivo)
    {
      XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
      XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
      serializer.Serialize(writer, this);
      writer.Close();
      return true;
    }

    public bool Xml(string archivo, out Fruta datos)
    {
      TextReader lectura = new StreamReader(archivo);
      XmlSerializer deserializador = new XmlSerializer(typeof(Manzana));
      datos = (Fruta)deserializador.Deserialize(lectura);
      lectura.Close();
      return true;
    }

    //public static explicit operator IDeserializar(Manzana m)
    //{
    //  return m;
    //}
  }
}
